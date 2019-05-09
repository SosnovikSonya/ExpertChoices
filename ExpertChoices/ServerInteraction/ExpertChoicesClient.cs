using ExpertChoices.Models;
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
        private User _currentUser;
        private string _authToken;

        public ExpertChoicesClient(User user)
        {
            _httpClient = new HttpClient();
            _currentUser = user;
            _authToken = Convert.ToBase64String(
                Encoding.ASCII.GetBytes(
               $"{_currentUser.Email}:{_currentUser.Password}"));
        }
        
        //Post
        public void Register(string email, string password)
        {
            //encode password and email

            //send http request

        }

        //Post
        public bool Authorize(string email, string password)
        {
            //encode password and email

            //send http request

            //process result

            return true;
        }

        #region Expert

        //Get
        public Problem CheckForProblems()
        {
            return null;
        }

        //Post
        public void SendEstimationsOnExperts(ExpertEstimation<IExpert> expertEstimations)
        {

        }

        //Post
        public void SendEstimationsOnAlternatives(ExpertEstimation<IAlternative> alternativesEstimations)
        {

        }
        #endregion

        #region Analytic

        //Post returns problem id
        public void CreateProblem(Problem problem)
        {
            
        }

        //Post
        public ProblemSolution<Problem> GetProblemStatus(string id)
        {
            return null;
        }

        #endregion

        #region Admin

        //Get
        public List<User> GetPendingUsers()
        {
            var message = GetRequestMessageGet(new Uri(""),  null);
            var result = _httpClient.SendAsync(message).Result;
            var response = JsonConvert.DeserializeObject<GetPendingUsersModel>(result.Content.ReadAsStringAsync().Result);

            return response.Users;
        }

        //Post
        public void ApproveUsers(List<User> approvedUsers, List<User> rejectedUsers)
        {
            var requestBody = new ProcessUserRegistrationPostRequestModel
            {
                ApprovedUsers = approvedUsers,
                RejectedUsers = rejectedUsers
            };
            var message = GetRequestMessagePost(new Uri(""), null, requestBody.ToString());
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
    }
}
