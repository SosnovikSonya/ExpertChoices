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
        public List<ExpertChoicesModels.User> GetPendingUsers()
        {
            _currentUser = AuthHelper.GetUserFromAuthHeader(Request);
            if (!AuthHelper.VerifyUserAuthorizedAdmin(_currentUser))
            {
                return null;
            }

            var list = DbHelper.GetPendingUsers();
            return list.Select(userDB => ModelMapper.ConvertToResponseUser(userDB)).ToList();
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

            DbHelper.DeleteUser(id);
        }

        [Route("api/users/Register")]
        [HttpPost]
        public void Register([FromBody]ExpertChoicesModels.RegisterUserPostRequestModel user)
        {
            DbHelper.CreateUser(ModelMapper.ConvertToDBUser(user), user.Role.HasFlag(UserRole.Expert));
            return;
        }

        [Route("api/users/Authorize")]
        [HttpGet]
        public AuthorizationResultModel Authorize()
        {
            _currentUser = AuthHelper.GetUserFromAuthToken(Request.Headers?.Authorization?.Parameter);
            if (_currentUser is null)
            {
                return null;
            }

            var model = new AuthorizationResultModel
            {
                Email = _currentUser.Email,
                IsAuthorized = false,
                Role = UserRole.Null
            };

            _currentUser = AuthHelper.GetUserFromAuthHeader(Request);
            if (_currentUser is null)
            {
                return model;
            }
            model.IsAuthorized = _currentUser.IsApproved;
            model.Role = (UserRole)_currentUser.Role;
            model.FirstName = _currentUser.FirstName;
            model.LastName = _currentUser.LastName;
            return model;
        }
    }
}
