using ExpertChoicesModels;
using ExpertChoicesServer.DataBase;
using ExpertChoicesServer.Extensions;
using ExpertChoicesServer.Models;
using ProblemSolver;
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
        DataBase.User _currentUser;

        // GET: api/Problems
        [Route("api/problems")]
        [HttpGet]
        public List<ExpertChoicesModels.Problem> CheckForAssignedProblems()
        {
            _currentUser = AuthHelper.GetUserFromAuthHeader(Request);
            if (!AuthHelper.VerifyUserAuthorizedExpert(_currentUser))
            {
                return null;
            }

            return DbHelper.CheckForAssignedProblems(_currentUser.IdUser).Select(dbent =>ModelMapper.ConvertToResponseProblem(dbent)).ToList();            
        }

        [Route("api/problems/{id}/Experts")]
        [HttpGet]
        public List<ExpertChoicesModels.Expert> CheckForAssignedExpertEstimations(int id)
        {
            _currentUser = AuthHelper.GetUserFromAuthHeader(Request);
            if (!AuthHelper.VerifyUserAuthorizedExpert(_currentUser))
            {
                return null;
            }

            var assignedEstimationsOnExpert = new List<ExpertChoicesModels.Expert>();

            var assignedEstimationsOnExpertDb = DbHelper.CheckForEstimationsOnExperts(_currentUser.IdUser, id);
            foreach (var estimation in assignedEstimationsOnExpertDb)
            {
                var expert = DbHelper.GetExpertById(estimation.IdEstimatedExpert);
                assignedEstimationsOnExpert.Add(ModelMapper.ConvertToResponseExpert(expert));
            }
            return assignedEstimationsOnExpert;
        }

        [Route("api/problems/{id}/Alternatives")]
        [HttpGet]
        public List<ExpertChoicesModels.Alternative> CheckForAssignedAlternativesEstimations(int id)
        {
            _currentUser = AuthHelper.GetUserFromAuthHeader(Request);
            if (!AuthHelper.VerifyUserAuthorizedExpert(_currentUser))
            {
                return null;
            }

            var assignedEstimationsOnAlternatives = new List<ExpertChoicesModels.Alternative>();

            var assignedEstimationsOnExpertDb = DbHelper.CheckForEstimationsOnAlternative(_currentUser.IdUser, id);
            foreach (var estimation in assignedEstimationsOnExpertDb)
            {
                var alternative = DbHelper.GetAlternativeById(estimation.IdEstimatedAlternative);
                assignedEstimationsOnAlternatives.Add(ModelMapper.ConvertToResponseAlternative(alternative));
            }
            return assignedEstimationsOnAlternatives;
        }

        [Route("api/problems")]
        [HttpPost]
        public int CreateNewProblem([FromBody]ExpertChoicesModels.Problem problemModel)
        {
            _currentUser = AuthHelper.GetUserFromAuthHeader(Request);
            if (!AuthHelper.VerifyUserAuthorizedExpert(_currentUser))
            {
                return -1;
            }
            return DbHelper.CreateProblem(ModelMapper.ConvertToDBProblem(problemModel));            
        }

        [Route("api/problems/{id}/Experts")]
        [HttpPost]
        public void AssignExpertsToProblem(int id, [FromBody]int[] expertIds)
        {
            _currentUser = AuthHelper.GetUserFromAuthHeader(Request);
            if (!AuthHelper.VerifyUserAuthorizedAnalytic(_currentUser))
            {
                return;
            }

            foreach (var expertIdEstimator in expertIds)
            {
                foreach (var expertIdEstimated in expertIds)
                {
                    if (expertIdEstimator == expertIdEstimated)
                    {
                        continue;
                    }
                    var estOnExpertDB = new EstimationOnExpert()
                    {
                        IdEstimatedExpert = expertIdEstimated,
                        IdEstimator = expertIdEstimator,
                        IdProblem = id,
                        Value = null
                    };
                    DbHelper.CreateEtimationOnExpert(estOnExpertDB);
                }              
            }
        }

        [Route("api/problems/{id}/Alternatives")]
        [HttpPost]
        public List<int> AssignAlternativesToProblem(int id, [FromBody]List<ExpertChoicesModels.Alternative> alternatives)
        {
            _currentUser = AuthHelper.GetUserFromAuthHeader(Request);
            if (!AuthHelper.VerifyUserAuthorizedAnalytic(_currentUser))
            {
                return null;
            }

            var altIds = new List<int>();
            var expertIds = DbHelper.GetEstimatorsOfProblem(id);
            foreach (var alt in alternatives)
            {
                var altDb = ModelMapper.ConvertToDBAlternative(alt);
                var altId = DbHelper.CreateAlternative(altDb);
                altIds.Add(altId);
                foreach (var expertId in expertIds)
                {
                    var estOnAlternativeDB = new EstimationOnAlternative()
                    {
                        IdEstimatedAlternative = altId,
                        IdEstimator = expertId,
                        IdProblem = id,
                        Value = null
                    };
                    DbHelper.CreateEtimationOnAlternative(estOnAlternativeDB);
                }
            }
            return altIds;
        }

        [Route("api/problems/{id}")]
        [HttpPut]
        public void SolveTheProblem(int id)
        {
            _currentUser = AuthHelper.GetUserFromAuthHeader(Request);
            if (!AuthHelper.VerifyUserAuthorizedAnalytic(_currentUser))
            {
                return;
            }

            var problem = ModelMapper.ConvertToResponseProblem(DbHelper.GetProblem(id));

            var estimationsOnAlternativesDB = DbHelper.GetEstimationsOnAlternatives(id);
            var estimationsOnExpertsDB = DbHelper.GetEstimationsOnExpert(id);

            //Gather estimation on alternatives data into problem object
            foreach (var estOnAltDB in estimationsOnAlternativesDB.GroupBy(est => est.IdEstimator))
            {
                problem.AlternativesEstimations.Add(ModelMapper.ConvertToEstimationModel(estOnAltDB.ToList()));
                problem.AlternativesEstimations.Last().Estimator = new ExpertChoicesModels.Expert
                {
                    Id = estOnAltDB.Key
                };
                foreach (var est in estOnAltDB)
                {
                    var altFromDB = DbHelper.GetAlternativeById(est.IdEstimatedAlternative);
                    var estimatorFromDB = DbHelper.GetExpertById(estOnAltDB.Key);

                    problem.AlternativesEstimations
                        .Single(es => es.Estimator.Id == estOnAltDB.Key)
                        .Estimated
                        .Single(es => es.Key.Id == altFromDB.IdAlternative)
                        .Key.Name = altFromDB.Name;

                    problem.AlternativesEstimations
                             .Single(es => es.Estimator?.Id == estOnAltDB.Key)
                             .Estimated
                             .Single(es => es.Key.Id == altFromDB.IdAlternative)
                             .Key.Description = altFromDB.Description;

                    problem.AlternativesEstimations
                             .Single(es => es.Estimator.Id == estOnAltDB.Key)
                             .Estimator = ModelMapper.ConvertToResponseExpert(estimatorFromDB);
                }
            }

            //Gather estimation on experts data into problem object
            foreach (var estOnExpDB in estimationsOnExpertsDB.GroupBy(est => est.IdEstimator))
            {
                problem.ExpertsEstimations.Add(ModelMapper.ConvertToEstimationModel(estOnExpDB.ToList()));
                problem.ExpertsEstimations.Last().Estimator = new ExpertChoicesModels.Expert
                {
                    Id = estOnExpDB.Key
                };
                foreach (var est in estOnExpDB)
                {
                    var expFromDB = DbHelper.GetExpertById(est.IdEstimatedExpert);
                    var estimatorFromDB = DbHelper.GetExpertById(estOnExpDB.Key);

                    problem.ExpertsEstimations
                        .Single(es => es.Estimator.Id == estOnExpDB.Key)
                        .Estimated
                        .Single(es => es.Key.Id == expFromDB.IdExpert)
                        .Key.Name = expFromDB.Name;

                    problem.ExpertsEstimations
                             .Single(es => es.Estimator.Id == estOnExpDB.Key)
                             .Estimator = ModelMapper.ConvertToResponseExpert(estimatorFromDB);
                }
            }                                  
           
            //solve the problem
            var problemSolver = new ProblemSolver<
                ExpertChoicesModels.Problem,
                ExpertChoicesModels.Expert,
                ExpertChoicesModels.Expert,
                ExpertChoicesModels.Alternative>(problem);
            var problemSolution = problemSolver.SolveTheProblem();

            //Insert into AlternativeDispersion
            foreach (var item in problemSolution.AlternativesDispersion)
            {
                var altId = DbHelper.GetAlternativeByName(item.Key.Name).IdAlternative;
                DbHelper.CreateAlternativeDispersion(new AlternativeDispersion
                {
                    IdAlternative = altId,
                    IdProblem = problem.Id,
                    Value = (float) item.Value
                });
            }

            //Insert into AlternativePreferency
            foreach (var item in problemSolution.AlternativesPreferency)
            {
                var altId = DbHelper.GetAlternativeByName(item.Key.Name).IdAlternative;
                DbHelper.CreateAlternativePreferency(new AlternativePreferency
                {
                    IdAlternative = altId,
                    IdProblem = problem.Id,
                    Value = (float)item.Value
                });
            }

            //Insert into ExpertCompetency
            foreach (var item in problemSolution.ExpertsCompetency)
            {
                var expId = DbHelper.GetExpertByName(item.Key.Name).IdExpert;
                DbHelper.CreateExpertCompetency(new ExpertCompetency
                {
                    IdExpert = expId,
                    IdProblem = problem.Id,
                    Value = (float)item.Value
                });
            }

            //Insert into ExpertDispersion
            foreach (var item in problemSolution.ExpertsDispersion)
            {
                var expId = DbHelper.GetExpertByName(item.Key.Name).IdExpert;
                DbHelper.CreateExpertDispersion(new ExpertDispersion
                {
                    IdExpert = expId,
                    IdProblem = problem.Id,
                    Value = (float)item.Value
                });
            }
        }

        [Route("api/problems/{id}/experts/{idExpert}")]
        [HttpGet]
        public ExpertMetricsModel GetExpertMetrics(int id, int idExpert)
        {
            return new ExpertMetricsModel
            {
                Competency = DbHelper.GetExpertCompetency(id, idExpert),
                Dispersion = DbHelper.GetExpertDispersion(id, idExpert)
            };
        }

        [Route("api/problems/{id}/Alternatives/{idAlternative}")]
        [HttpGet]
        public AlternativeMetricsModel GetAlternativeMetrics(int id, int idAlternative)
        {
            return new AlternativeMetricsModel
            {
                Preferency = DbHelper.GetAlternativesPreferency(id, idAlternative),
                Dispersion = DbHelper.GetAlternativeDispersion(id, idAlternative)
            };
        }

        [HttpPost]
        [Route("api/problems/{id}/{idEstimator}/Experts")]
        public void SubmitEstimationsOnExperts(int id, int idEstimator, [FromBody]List<EstimationModel> estimations)
        {
            _currentUser = AuthHelper.GetUserFromAuthHeader(Request);
            if (!AuthHelper.VerifyUserAuthorizedExpert(_currentUser))
            {
                return;
            }

            var estimationsDB = ModelMapper.ConvertToDBEstimationExpert(estimations);
            estimationsDB.ForEach(est => est.IdProblem = id);
            estimationsDB.ForEach(est => est.IdEstimator = idEstimator);
            foreach (var estimationDB in estimationsDB)
            {
                DbHelper.UpdateEstimationOnExpert(estimationDB);
            }
        }

        [HttpPost]
        [Route("api/problems/{id}/{idEstimator}/Alternatives")]
        public void SubmitEstimationsOnAlternatives(int id, int idEstimator, [FromBody]List<EstimationModel> estimations)
        {
            _currentUser = AuthHelper.GetUserFromAuthHeader(Request);
            if (!AuthHelper.VerifyUserAuthorizedExpert(_currentUser))
            {
                return;
            }

            var estimationsDB = ModelMapper.ConvertToDBEstimationAlternative(estimations);
            estimationsDB.ForEach(est => est.IdProblem = id);
            estimationsDB.ForEach(est => est.IdEstimator = idEstimator);
            foreach (var estimationDB in estimationsDB)
            {
                DbHelper.UpdateEstimationOnAlternative(estimationDB);
            }            
        }        
    }
}
