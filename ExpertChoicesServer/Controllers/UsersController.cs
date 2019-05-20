using ExpertChoicesModels;
using ExpertChoicesServer.DataBase;
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
        // GET: api/Users
        [Route("api/users")]
        [HttpGet]
        public GetPendingUsersModel GetPendingUsers()
        {
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
        public string ApproveUser(int id)
        {
            return "value";
        }

        // DELETE: api/Users/5
        [Route("api/users/{id}")]
        [HttpDelete]
        public string DeleteUser(int id)
        {
            return "value";
        }

        // POST: api/users/Register
        [Route("api/users/Register")]
        [HttpPost]
        public void Register([FromBody]string value)
        {
        }

        // POST: api/users/Authorize
        [Route("api/users/Authorize")]
        [HttpPost]
        public void Authorize( [FromBody]string value)
        {
        }
    }
}
