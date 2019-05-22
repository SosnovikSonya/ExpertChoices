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
    public class ExpertsController : ApiController
    {
        DataBase.User _currentUser;

        [Route("api/experts/")]
        [HttpGet]
        public List<ExpertChoicesModels.Expert> AssignAlternativesToProblem()
        {
            _currentUser = AuthHelper.GetUserFromAuthHeader(Request);
            if (!AuthHelper.VerifyUserAuthorizedAnalytic(_currentUser))
            {
                return null;
            }

            var experts = new List<ExpertChoicesModels.Expert>();
            var expertsDB = DbHelper.GetAllExperts();
            foreach (var expertDB in expertsDB)
            {
                experts.Add(ModelMapper.ConvertToResponseExpert(expertDB));
            }
            return experts;
        }
    }
}
