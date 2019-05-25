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
    public class ExpertChoicesClient
    {
        private HttpClient _httpClient;
        private string _authToken;
        private const string _domain = "http://localhost:53146/api";
        private const string _userApi = "/users";
        private const string _problemApi = "/problems";
        private const string _expertApi = "/experts";
        private const string _registerUserMethod = "/register";
        private const string _authorizeMethod = "/authorize";
        private const string _alternativesMethod = "/alternatives";
        private const string _expertsMethod = "/experts";

        public ExpertChoicesClient()
        {
            _httpClient = new HttpClient();
        }
        #region Common
        //Post
        public void Register(User user)
        {
            //send http request
            var content = JsonHelper.SerializeToJson(
                new RegisterUserPostRequestModel
                {
                    AuthToken = GetAuthToken(user.Email, user.Password),
                    Name = $"{user.FirstName} {user.LastName}",
                    Role = user.Role
                });
            var message = GetRequestMessagePost(new Uri($"{_domain}{_userApi}{_registerUserMethod}"), null, content);
            var result = _httpClient.SendAsync(message).Result;
        }

        //Post -- verify user permissions
        public AuthorizationResultModel Authorize(string email, string password)
        {
            //encode password and email
            _authToken = GetAuthToken(email, password);           

            var message = GetRequestMessageGet(new Uri($"{_domain}{_userApi}{_authorizeMethod}"), null);
            var result = _httpClient.SendAsync(message).Result;
            return JsonHelper.DeserializeFromJson<AuthorizationResultModel>(result.Content.ReadAsStringAsync().Result);
        }
        #endregion

        #region Expert

        //Get
        public List<Problem> CheckForAssignedProblems()
        {
            var message = GetRequestMessageGet(new Uri($"{_domain}{_problemApi}"), null);
            var result = _httpClient.SendAsync(message).Result;
            return JsonHelper.DeserializeFromJson<List<Problem>>(result.Content.ReadAsStringAsync().Result);
        }

        //Get
        public List<Expert> CheckForAssignedEstimationsOnExperts(int problemId)
        {
            var message = GetRequestMessageGet(new Uri($"{_domain}{_problemApi}/{problemId}{_expertsMethod}"), null);
            var result = _httpClient.SendAsync(message).Result;
            return JsonHelper.DeserializeFromJson<List<Expert>>(result.Content.ReadAsStringAsync().Result);
        }

        //Get
        public List<Alternative> CheckForAssignedEstimationsOnAlternatives(int problemId)
        {
            var message = GetRequestMessageGet(new Uri($"{_domain}{_problemApi}/{problemId}{_alternativesMethod}"), null);
            var result = _httpClient.SendAsync(message).Result;
            return JsonHelper.DeserializeFromJson<List<Alternative>>(result.Content.ReadAsStringAsync().Result);
        }

        //Post
        public void SendEstimationsOnExperts(int problemId, Estimation<Expert, Expert> estimations)
        {
            var content = JsonHelper.SerializeToJson(
                estimations.Estimated.Select(pair => new EstimationModel
                {
                    Id = pair.Key.Id,
                    Value = pair.Value.Value
                }));
            var message = GetRequestMessagePost(new Uri($"{_domain}{_problemApi}/{problemId}/{estimations.Estimator.Id}{_expertsMethod}"), null, content);
            var result = _httpClient.SendAsync(message).Result;
        }

        //Post
        public void SendEstimationsOnAlternatives(int problemId, Estimation<Expert, Alternative> estimations)
        {
            var content = JsonHelper.SerializeToJson(
                estimations.Estimated.Select(pair => new EstimationModel
                {
                    Id = pair.Key.Id,
                    Value = pair.Value.Value
                }));
            var message = GetRequestMessagePost(new Uri($"{_domain}{_problemApi}/{problemId}/{estimations.Estimator.Id}{_alternativesMethod}"), null, content);
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
            return JsonHelper.DeserializeFromJson<int>(result.Content.ReadAsStringAsync().Result);
        }

        public List<int> AssignAlternative(int idProblem, List<Alternative> alternatives)
        {
            var content = JsonHelper.SerializeToJson(alternatives);
            var message = GetRequestMessagePost(new Uri($"{_domain}{_problemApi}/{idProblem}{_alternativesMethod}"), null, content);
            var result = _httpClient.SendAsync(message).Result;
            return JsonHelper.DeserializeFromJson<List<int>>(result.Content.ReadAsStringAsync().Result);
        }

        public void AssignExperts(int idProblem, List<int> expertIds)
        {
            var content = JsonHelper.SerializeToJson(expertIds);
            var message = GetRequestMessagePost(new Uri($"{_domain}{_problemApi}/{idProblem}{_expertsMethod}"), null, content);
            var result = _httpClient.SendAsync(message).Result;
        }

        
        public void SolveTheProblem(int id)
        {
            var message = GetRequestMessagePut(new Uri($"{_domain}{_problemApi}/{id}"), null, "");
            var result = _httpClient.SendAsync(message).Result;
        }

        public List<Expert> GetAllExperts()
        {
            var message = GetRequestMessageGet(new Uri($"{_domain}{_expertsMethod}"), null);
            var result = _httpClient.SendAsync(message).Result;
            return JsonHelper.DeserializeFromJson<List<Expert>>(result.Content.ReadAsStringAsync().Result);
        }

        public ExpertMetricsModel GetExpertMetrics(int problemId, int expertId)
        {
            var message = GetRequestMessageGet(new Uri($"{_domain}{_problemApi}/{problemId}{_expertsMethod}/{expertId}"), null);
            var result = _httpClient.SendAsync(message).Result;
            return JsonHelper.DeserializeFromJson<ExpertMetricsModel>(result.Content.ReadAsStringAsync().Result);
        }

        public AlternativeMetricsModel GetAlternativeMetrics(int problemId, int altId)
        {
            var message = GetRequestMessageGet(new Uri($"{_domain}{_problemApi}/{problemId}{_alternativesMethod}/{altId}"), null);
            var result = _httpClient.SendAsync(message).Result;
            return JsonHelper.DeserializeFromJson<AlternativeMetricsModel>(result.Content.ReadAsStringAsync().Result);
        }
        //3 methods remain


        #endregion

        #region Admin

        //Get
        public List<User> GetPendingUsers()
        {
            var message = GetRequestMessageGet(new Uri($"{_domain}{_userApi}"),  null);
            var result = _httpClient.SendAsync(message).Result;
            return JsonConvert.DeserializeObject<List<User>>(result.Content.ReadAsStringAsync().Result);
        }

        //Put
        public void ApproveUsers(int id)
        {           
            var message = GetRequestMessagePut(new Uri($"{_domain}{_userApi}/{id}"), null, "");
            var result = _httpClient.SendAsync(message).Result;
        }

        //Delete
        public void DeleteUsers(int id)
        {
            var message = GetRequestMessageDelete(new Uri($"{_domain}{_userApi}/{id}"), null, "");
            var result = _httpClient.SendAsync(message).Result;
        }

        #endregion

        #region http helper
        private HttpRequestMessage GetRequestMessageGet(Uri uri, Dictionary<string, string> headers)
        {
            var message = GetRequestMessage(headers);
            message.RequestUri = uri;
            return message;            
        }

        private HttpRequestMessage GetRequestMessagePost(Uri uri, Dictionary<string, string> headers, string content, string contentType = "application/json")
        {
            var message = GetRequestMessage(headers);
            message.RequestUri = uri;
            message.Content = new StringContent(content);
            message.Method = HttpMethod.Post;
            message.Content.Headers.ContentType.MediaType = contentType;
            return message;
        }

        private HttpRequestMessage GetRequestMessagePut(Uri uri, Dictionary<string, string> headers, string content, string contentType = "application/json")
        {
            var message = GetRequestMessage(headers);
            message.RequestUri = uri;
            message.Content = new StringContent(content);
            message.Content.Headers.ContentType.MediaType = contentType;
            message.Method = HttpMethod.Put;
            return message;
        }

        private HttpRequestMessage GetRequestMessageDelete(Uri uri, Dictionary<string, string> headers, string content, string contentType = "application/json")
        {
            var message = GetRequestMessage(headers);
            message.RequestUri = uri;
            message.Content = new StringContent(content);
            message.Content.Headers.ContentType.MediaType = contentType;
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
        #endregion
    }
}
