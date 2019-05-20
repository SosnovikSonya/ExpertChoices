using ExpertChoicesModels;
using Newtonsoft.Json;
using ProblemSolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExpertChoices.ServerInteraction
{
    class ExpertChoicesClient
    {
        private HttpClient _httpClient;
        private string _authToken;
        private const string _domain = "http://ExpertChoices.com";
        private const string _userApi = "/users";
        private const string _problemApi = "/problems";
        private const string _createUserMethod = "/create";
        private const string _authorizeMethod = "/authorize";
        private const string _alternativesMethod = "/authorize";
        private const string _expertsMethod = "/authorize";

        public ExpertChoicesClient()
        {
            _httpClient = new HttpClient();
        }
        
        //Post
        public void Register(User user)
        {
            //send http request
            var content = JsonHelper.SerializeToJson(
                new RegisterUserPostRequestModel
                {
                    AuthToken = GetAuthToken(user.Email, user.Password),
                    Name = user.FirstName,
                    Role = user.Role
                });
            var message = GetRequestMessagePost(new Uri($"{_domain}{_userApi}{_createUserMethod}"), null, content);
            var result = _httpClient.SendAsync(message).Result;
        }

        //Post -- verify user permissions
        public bool Authorize(string email, string password, out UserRole role)
        {
            //encode password and email
            _authToken = GetAuthToken(email, password);

            var content = JsonHelper.SerializeToJson(new AuthorizeUserPostRequestModel
            {
                AuthToken = _authToken
            });

            var message = GetRequestMessagePost(new Uri($"{_domain}{_userApi}{_authorizeMethod}"), null, content);
            var result = _httpClient.SendAsync(message).Result;
            var resultContent = JsonHelper.DeserializeFromJson<AuthorizeUserPostResponseModel>(result.Content.ReadAsStringAsync().Result);

            //var resultContent = new AuthorizeUserPostResponseModel
            //{
            //    Authorized = true,
            //    Role = UserRole.Admin | UserRole.Analytic
            //};
            role = resultContent.Role;
            return resultContent.Authorized;
        }

        #region Expert

        //Get
        public ProblemListModel CheckForProblems()
        {
            var message = GetRequestMessageGet(new Uri($"{_domain}{_problemApi}"), null);
            var result = _httpClient.SendAsync(message).Result;
            return JsonHelper.DeserializeFromJson<ProblemListModel>(result.Content.ReadAsStringAsync().Result);
        }

        //Post
        public void SendEstimationsOnExperts(Estimation<Expert, Expert> estimations, int problemId)
        {
            var content = JsonHelper.SerializeToJson(estimations);
            var message = GetRequestMessagePost(new Uri($"{_domain}{_problemApi}/{problemId}{_expertsMethod}"), null, content);
            var result = _httpClient.SendAsync(message).Result;
        }

        //Post
        public void SendEstimationsOnAlternatives(Estimation<Expert, Alternative> estimations, int problemId)
        {
            var content = JsonHelper.SerializeToJson(estimations);
            var message = GetRequestMessagePost(new Uri($"{_domain}{_problemApi}/{problemId}{_alternativesMethod}"), null, content);
            var result = _httpClient.SendAsync(message).Result;
        }

        #endregion

        #region Analytic

        //Post returns problem id
        public int CreateProblem(Problem problem)
        {
            var content = JsonHelper.SerializeToJson(problem);
            var message = GetRequestMessagePost(new Uri($"{_domain}{_problemApi}"), null, content);
            var result = _httpClient.SendAsync(message).Result;
            return JsonHelper.DeserializeFromJson<CreateProblemPostResponseModel>(result.Content.ReadAsStringAsync().Result).Id;
        }

        //Get returns problem solution (complited or not)
        public ProblemSolution GetProblemSolution(int id)
        {
            var message = GetRequestMessageGet(new Uri($"{_domain}{_problemApi}/{id}"), null);
            var result = _httpClient.SendAsync(message).Result;
            return JsonConvert.DeserializeObject<ProblemSolution>(result.Content.ReadAsStringAsync().Result);
        }

        #endregion

        #region Admin

        //Get
        public List<User> GetPendingUsers()
        {
            var message = GetRequestMessageGet(new Uri($"{_domain}{_userApi}"),  null);
            var result = _httpClient.SendAsync(message).Result;
            var response = JsonConvert.DeserializeObject<GetPendingUsersModel>(result.Content.ReadAsStringAsync().Result);
            return response.Users;
        }

        //Put
        public void ApproveUsers(int id)
        {           
            var message = GetRequestMessagePut(new Uri($"{_domain}{_userApi}/id"), null, "");
            var result = _httpClient.SendAsync(message).Result;
        }

        //Delete
        public void DeleteUsers(int id)
        {
            var message = GetRequestMessageDelete(new Uri($"{_domain}{_userApi}/id"), null, "");
            var result = _httpClient.SendAsync(message).Result;
        }

        #endregion

        private HttpRequestMessage GetRequestMessageGet(Uri uri, Dictionary<string, string> headers)
        {
            return GetRequestMessage(headers);            
        }

        private HttpRequestMessage GetRequestMessagePost(Uri uri, Dictionary<string, string> headers, string content)
        {
            var message = GetRequestMessage(headers);
            message.Content = new StringContent(content);
            message.Method = HttpMethod.Post;
            return message;
        }

        private HttpRequestMessage GetRequestMessagePut(Uri uri, Dictionary<string, string> headers, string content)
        {
            var message = GetRequestMessage(headers);
            message.Content = new StringContent(content);
            message.Method = HttpMethod.Put;
            return message;
        }

        private HttpRequestMessage GetRequestMessageDelete(Uri uri, Dictionary<string, string> headers, string content)
        {
            var message = GetRequestMessage(headers);
            message.Content = new StringContent(content);
            message.Method = HttpMethod.Delete;
            return message;
        }

        private HttpRequestMessage GetRequestMessage(Dictionary<string, string> headers)
        {
            var message = new HttpRequestMessage();
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    message.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }
            }
            message.Headers.Authorization = new AuthenticationHeaderValue("Basic", _authToken);
            return message;
        }

        private string GetAuthToken(string email, string password)
        {
            return Convert.ToBase64String(
                Encoding.ASCII.GetBytes(
                    $"{email}:{password}"));
        }
    }
}
