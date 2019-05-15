using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExpertChoicesServer.Controllers
{
    public class ProblemsController : ApiController
    {
        // GET: api/Problems
        [Route("api/problems")]
        [HttpGet]
        public IEnumerable<string> CheckForAssignedProblems()
        {
            return new string[] { "value1", "value2" };
        }

        // POST: api/Problems
        [Route("api/problems")]
        [HttpPost]
        public void CreateNewProblem([FromBody]string value)
        {
        }

        // GET: api/Problems/5
        [Route("api/problems/{Id}")]
        [HttpGet]
        public void GetSolution(int id)
        {
        }

        [HttpPost]
        [Route("api/problems/{id}/experts")]
        public void SubmitEstimationsOnExperts(int id)
        {
        }

        [HttpPost]
        [Route("api/problems/{id}/alternatives")]
        public void SubmitEstimationsOnAlternatives(int id)
        {

        }
    }
}
