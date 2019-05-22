using ExpertChoicesModels;
using ExpertChoicesServer.DataBase;
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
        // GET: api/Problems
        [Route("api/problems")]
        [HttpGet]
        public ProblemListModel CheckForAssignedProblems()
        {
            var userModel = GetUserFromHeaders();
            var userDB = DbHelper.GetUser(userModel.Email, userModel.Password);

            //if (userDB is null || (UserRole)userDB.Role != UserRole.Expert)
            //{
            //    return null;
            //}

            var assignedEstimationOnExpert = DbHelper.CheckForEstimationsOnExperts(userDB.IdUser);
            var assignedEstimationOnAlternative = DbHelper.CheckForEstimationsOnAlternative(userDB.IdUser);

            var problemsModel = new List<ExpertChoicesModels.Problem>();


            foreach (var est in assignedEstimationOnExpert)
            {
                if (!problemsModel.Any(prob => prob.Id == est.IdProblem))
                {
                    var problemDB = DbHelper.GetProblem(est.IdProblem);
                    problemsModel.Add(ModelMapper.ConvertToResponseProblem(problemDB));
                    if (problemsModel.Last().AlternativesEstimations is null)
                    {
                        problemsModel.Last().AlternativesEstimations = new List<Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative>>();
                    }
                    if (problemsModel.Last().ExpertsEstimations is null)
                    {
                        problemsModel.Last().ExpertsEstimations = new List<Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert>>();
                    }

                }
                var expEstimation = new Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert>
                {
                    Estimator = ModelMapper.ConvertToResponseExpert(DbHelper.GetExpertByUserId(userDB.IdUser)),
                    Estimated = new Dictionary<ExpertChoicesModels.Expert, int?>()
                };
                var Expert = ModelMapper.ConvertToResponseExpert(DbHelper.GetExpertById(est.IdExpert));
                expEstimation.Estimated.Add(Expert, est.Value);
                problemsModel.Last().ExpertsEstimations.Add(expEstimation);
            }

            foreach (var est in assignedEstimationOnAlternative)
            {
                if (!problemsModel.Any(prob => prob.Id == est.IdProblem))
                {
                    var problemDB = DbHelper.GetProblem(est.IdProblem);
                    problemsModel.Add(ModelMapper.ConvertToResponseProblem(problemDB));
                    if (problemsModel.Last().AlternativesEstimations is null)
                    {
                        problemsModel.Last().AlternativesEstimations = new List<Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative>>();
                    }
                    if (problemsModel.Last().ExpertsEstimations is null)
                    {
                        problemsModel.Last().ExpertsEstimations = new List<Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert>>();
                    }
                }
                var altEstimation = new Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative>
                {
                    Estimator = ModelMapper.ConvertToResponseExpert(DbHelper.GetExpertByUserId(userDB.IdUser)),
                    Estimated = new Dictionary<ExpertChoicesModels.Alternative, int?>()
                };
                var estimatedAlternative = ModelMapper.ConvertToResponseAlternative(DbHelper.GetAlternativeById(est.IdEstimatedAlternative));
                altEstimation.Estimated.Add(estimatedAlternative, est.Value);
                problemsModel.Last().AlternativesEstimations.Add(altEstimation);
            }
            var reponse = new ProblemListModel()
            {
                Problems = problemsModel
            };
            return reponse;
        }

        // POST: api/Problems
        [Route("api/problems")]
        [HttpPost]
        public int CreateNewProblem([FromBody]ExpertChoicesModels.Problem problemModel)
        {
            return DbHelper.CreateProblem(ModelMapper.ConvertToDBProblem(problemModel));
            //foreach (var altEstimationModel in problemModel.AlternativesEstimations)
            //{
            //    var idEstimator = altEstimationModel.Estimator.Id;
            //    foreach (var valuePair in altEstimationModel.Estimated)
            //    {
            //        int altId;
            //        var altDb = DbHelper.GetAlternativeByName(valuePair.Key.Name);
            //        if (altDb is null)
            //        {
            //            altDb = ModelMapper.ConvertToDBAlternative(valuePair.Key);
            //            //altDb.IdProblem = problemId;
            //            altId = DbHelper.CreateAlternative(altDb);
            //        }
            //        else
            //        {
            //            altId = altDb.IdAlternative;
            //        }

            //        var estOnAlternativeDB = new EstimationOnAlternative()
            //        {
            //            IdEstimatedAlternative = altId,
            //            IdEstimator = idEstimator,
            //            IdProblem = problemId,
            //            Value = valuePair.Value
            //        };
            //        DbHelper.CreateEtimationOnAlternative(estOnAlternativeDB);
            //    }
            //}

            //foreach (var expEstimationModel in problemModel.ExpertsEstimations)
            //{
            //    var idEstimator = expEstimationModel.Estimator.Id;
            //    foreach (var valuePair in expEstimationModel.Estimated)
            //    {
            //        int expId = valuePair.Key.Id;                    

            //        var estOnExpertDB = new EstimationOnExpert()
            //        {
            //            IdExpert = expId,
            //            IdEstimator = idEstimator,
            //            IdProblem = problemId,
            //            Value = valuePair.Value
            //        };
            //        DbHelper.CreateEtimationOnExpert(estOnExpertDB);
            //    }
            //}
        }

        [Route("api/problems/{id}/Experts")]
        [HttpPost]
        public void AssignExpertsToProblem(int id, [FromBody]int[] expertIds)
        {
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
                        IdExpert = expertIdEstimated,
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

        // GET: api/Problems/5
        [Route("api/problems/{id}")]
        [HttpGet]
        public ProblemSolution GetSolution(int id)
        {
            var problem = ModelMapper.ConvertToResponseProblem(DbHelper.GetProblem(id));

            var estimationsOnAlternativesDB = DbHelper.GetEstimationsOnAlternatives(id);
            var estimationsOnExpertsDB = DbHelper.GetEstimationsOnExpert(id);

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

            foreach (var estOnExpDB in estimationsOnExpertsDB.GroupBy(est => est.IdEstimator))
            {
                problem.ExpertsEstimations.Add(ModelMapper.ConvertToEstimationModel(estOnExpDB.ToList()));
                problem.ExpertsEstimations.Last().Estimator = new ExpertChoicesModels.Expert
                {
                    Id = estOnExpDB.Key
                };
                foreach (var est in estOnExpDB)
                {
                    var expFromDB = DbHelper.GetExpertById(est.IdExpert);
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


            //return solution
            var solution = new ProblemSolution();
            var expertsCompetencyList = DbHelper.GetExpertCompetencies(id);
            var expertsDispersionList = DbHelper.GetExpertDispersions(id);
            var alternativesDispersionList = DbHelper.GetAlternativeDispersions(id);
            var alternativesPreferencyList = DbHelper.GetAlternativesPreferencies(id);

            foreach (var item in expertsCompetencyList)
            {
                solution.ExpertsCompetency.Add(
                    new ExpertChoicesModels.Expert { Name = item.Name },
                    (double)item.Value);
            }

            foreach (var item in expertsDispersionList)
            {
                solution.ExpertsDispersion.Add(
                    new ExpertChoicesModels.Expert { Name = item.Name },
                    (double)item.Value);
            }

            foreach (var item in alternativesDispersionList)
            {
                solution.AlternativesDispersion.Add(
                    new ExpertChoicesModels.Alternative { Name = item.Name },
                    (double)item.Value);
            }

            foreach (var item in alternativesPreferencyList)
            {
                solution.AlternativesPreferency.Add(
                    new ExpertChoicesModels.Alternative { Name = item.Name },
                    (double)item.Value);
            }

            return solution;

        }

        [HttpPost]
        [Route("api/problems/{id}/{idEstimator}/Experts")]
        public void SubmitEstimationsOnExperts(int id, int idEstimator, [FromBody]List<EstimationModel> estimations)
        {
            var estimationsDB = ModelMapper.ConvertToDBEstimationExpert(estimations);
            estimationsDB.ForEach(est => est.IdProblem = id);
            estimationsDB.ForEach(est => est.IdEstimator = idEstimator);
            foreach (var estimationDB in estimationsDB)
            {
                DbHelper.CreateEtimationOnExpert(estimationDB);
            }
        }

        [HttpPost]
        [Route("api/problems/{id}/{idEstimator}/Alternatives")]
        public void SubmitEstimationsOnAlternatives(int id, int idEstimator, [FromBody]List<EstimationModel> estimations)
        {
            var estimationsDB = ModelMapper.ConvertToDBEstimationAlternative(estimations);
            estimationsDB.ForEach(est => est.IdProblem = id);
            estimationsDB.ForEach(est => est.IdEstimator = idEstimator);
            foreach (var estimationDB in estimationsDB)
            {
                DbHelper.CreateEtimationOnAlternative(estimationDB);
            }            
        }

        private ExpertChoicesModels.User GetUserFromHeaders()
        {
            //var auth = Request.Headers.Authorization.Parameter;
            return new ExpertChoicesModels.User
            {
                 Email = "asd@asd.asd",
                 Password = "asd"
            };
        }
    }
}
