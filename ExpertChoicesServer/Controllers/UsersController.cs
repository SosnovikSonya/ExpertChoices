using ExpertChoicesModels;
using ExpertChoicesServer.DataBase;
using ExpertChoicesServer.Extensions;
using ExpertChoicesServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExpertChoicesServer.Controllers
{
    public class UsersController : ApiController
    {
        DataBase.User _currentUser;

        // GET: api/Users
        [Route("api/users")]
        [HttpGet]
        public GetPendingUsersModel GetPendingUsers()
        {
            _currentUser = AuthHelper.GetUserFromAuthHeader(Request);
            if (!AuthHelper.VerifyUserAuthorizedAdmin(_currentUser))
            {
                return null;
            }

            var list = DbHelper.GetPendingUsers();
            var response = new GetPendingUsersModel()
            {
                Users = list.Select(userDB => ModelMapper.ConvertToResponseUser(userDB)).ToList()
            };
            return response;
        }

        // PUT: api/Users/5
        [Route("api/users/{id}")]
        [HttpPut]
        public void ApproveUser(int id)
        {
            _currentUser = AuthHelper.GetUserFromAuthHeader(Request);
            if (!AuthHelper.VerifyUserAuthorizedAdmin(_currentUser))
            {
                return;
            }

            DbHelper.ApproveUser(id);
        }

        // DELETE: api/Users/5
        [Route("api/users/{id}")]
        [HttpDelete]
        public void DeleteUser(int id)
        {
            _currentUser = AuthHelper.GetUserFromAuthHeader(Request);
            if (!AuthHelper.VerifyUserAuthorizedAdmin(_currentUser))
            {
                return ;
            }

            DbHelper.DeleteUser(_currentUser.Email, _currentUser.Password);
        }

        // POST: api/users/Register
        [Route("api/users/Register")]
        [HttpPost]
        public void Register([FromBody]ExpertChoicesModels.RegisterUserPostRequestModel user)
        {
            DbHelper.CreateUser(ModelMapper.ConvertToDBUser(user), user.Role.HasFlag(UserRole.Expert));
            return;
        }

        // POST: api/users/Authorize
        [Route("api/users/Authorize")]
        [HttpPost]
        public void Authorize( [FromBody]string value)
        {
        }
    }
}
