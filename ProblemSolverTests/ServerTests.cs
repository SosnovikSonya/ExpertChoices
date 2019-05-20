﻿using ExpertChoicesServer.Controllers;
using ExpertChoicesServer.DataBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolverTests
{
    [TestClass]
    public class ServerTests
    {
        ExpertChoicesModels.Expert expert1;
        ExpertChoicesModels.Expert expert2;
        ExpertChoicesModels.Expert expert3;
        ExpertChoicesModels.Problem problem;

        ExpertChoicesModels.Alternative alt1;
        ExpertChoicesModels.Alternative alt2;
        ExpertChoicesModels.Alternative alt3;

        Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert> expEstimations1;
        Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert> expEstimations2;
        Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert> expEstimations3;

        Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative> altEstimations1;
        Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative> altEstimations2;
        Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative> altEstimations3;

        [TestInitialize]
        public void Setup()
        {
            #region Test data
            //Admin
            expert1 = new ExpertChoicesModels.Expert
            {
                Id = 1,
                Name = "Sonya"
            };

            expert2 = new ExpertChoicesModels.Expert
            {
                Id = 2,
                Name = "Misha"
            };

            expert3 = new ExpertChoicesModels.Expert
            {
                Id = 3,
                Name = "Eva"
            };

            //Analytic
            problem = new ExpertChoicesModels.Problem
            {
                Name = "When to go to cinema"
            };

            alt1 = new ExpertChoicesModels.Alternative
            {
                Name = "Sunday"
            };

            alt2 = new ExpertChoicesModels.Alternative
            {
                Name = "Saturday"
            };

            alt3 = new ExpertChoicesModels.Alternative
            {
                Name = "Monday"
            };

            //Experts
            expEstimations1 = new Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert>
            {
                Estimator = expert1,
                Estimated = new Dictionary<ExpertChoicesModels.Expert, int?>
                {
                    { expert2, 7},
                    { expert3, 6},
                }
            };

            expEstimations2 = new Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert>
            {
                Estimator = expert2,
                Estimated = new Dictionary<ExpertChoicesModels.Expert, int?>
                {
                    { expert1, 9},
                    { expert3, 10},
                }
            };

            expEstimations3 = new Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert>
            {
                Estimator = expert3,
                Estimated = new Dictionary<ExpertChoicesModels.Expert, int?>
                {
                    { expert1, 5},
                    { expert2, 3},
                }
            };


            altEstimations1 = new Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative>
            {                
                Estimator = expert1,
                Estimated = new Dictionary<ExpertChoicesModels.Alternative, int?>
                {
                    { alt1, 7},
                    { alt2, 8},
                    { alt3, 7}
                }
            };

            altEstimations2 = new Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative>
            {
                Estimator = expert2,
                Estimated = new Dictionary<ExpertChoicesModels.Alternative, int?>
                {
                    { alt1, 8},
                    { alt2, 5},
                    { alt3, 8}
                }
            };

            altEstimations3 = new Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative>
            {
                Estimator = expert3,
                Estimated = new Dictionary<ExpertChoicesModels.Alternative, int?>
                {
                    { alt1, 7},
                    { alt2, 9},
                    { alt3, 1}
                }
            };


            //Server
            problem.AlternativesEstimations = new List<Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative>>
                {
                    altEstimations1,
                    altEstimations2,
                    altEstimations3
                };

            problem.ExpertsEstimations = new List<Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert>>
                {
                    expEstimations1,
                    expEstimations2,
                    expEstimations3
                };
            #endregion

        }

        [TestMethod]
        public void CreateUser()
        {
            var user = new User
            {
                Email = "asd2@asd.asd",
                FirstName = "asd2",
                LastName = "asd2",
                Password = "asd2",
                IsApproved = false,
                Role = 4,

            };
            DbHelper.RegisterUser(user);
        }

        [TestMethod]
        public void CreateProblem()
        {
            var problem = new Problem
            {
                Name = "asd",
                Description = "asd"
            };
            DbHelper.CreateProblem(problem);
        }

        [TestMethod]
        public void CreateProblemFromRequest()
        {
            var contr = new ProblemsController();
            contr.CreateNewProblem(problem);
        }

        [TestMethod]
        public void CheckForAssignedProblems()
        {
            var contr = new ProblemsController();
            contr.CheckForAssignedProblems();
        }


        [TestMethod]
        public void CreateEstimationOnExpert()
        {
            var est = new EstimationOnExpert
            {
                IdEstimatedExpert = 1,
                IdEstimator = 2,
                IdProblem = 1,
                Value = 5
            };
            DbHelper.CreateEtimationOnExpert(est);
        }

        [TestMethod]
        public void CreateEstimationOnAlternative()
        {
            var est = new EstimationOnAlternative
            {
                IdEstimatedAlternative = 1,
                IdEstimator = 2,
                IdProblem = 1,
                Value = null
            };
            DbHelper.CreateEtimationOnAlternative(est);
        }

        [TestMethod]
        public void CreateAlternative()
        {
            var alt = new Alternative
            {
                //IdProblem = 1,
                Description = "asdsad123",
                Name = "asd142f"
            };
            Console.WriteLine(DbHelper.CreateAlternative(alt));
        }


        [TestMethod]
        public void CreateEstOnExpertFromRequest()
        {           
            var contr = new ProblemsController();
            contr.SubmitEstimationsOnExperts(11, expEstimations1);

        }

        [TestMethod]
        public void CreateEstOnAlternativeFromRequest()
        {
            var contr = new ProblemsController();
            contr.SubmitEstimationsOnAlternatives(11, altEstimations1);

        }

        [TestMethod]
        public void UpdateEstimationOnExpertValue()
        {
            var est = new EstimationOnExpert
            {
                IdEstimatedExpert = 1,
                IdEstimator = 3,
                IdProblem = 11,
                Value = 5
            };

            DbHelper.UpdateEstimationOnExpert(est);
        }


        [TestMethod]
        public void GetSolution()
        {
            var contr = new ProblemsController();
            //contr.CreateNewProblem(problem);

            var solution = contr.GetSolution(14);
        }


        [TestMethod]
        public void SolverTest()
        {
            //var abstractedProblem = 

            var solver = new ProblemSolver<ExpertChoicesModels.Problem, ExpertChoicesModels.Expert, ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative>(problem);
                
                
                
                //<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative>);
            //var asd = new ProblemSolver<ExpertChoicesModels.Problem>(problem);
            //var solver = new ProblemSolver.ProblemSolver(problem as IProblem<IExpert, IExpert, IAlternative>);

            //Server to Analytic
            var solution = solver.SolveTheProblem();
        }
    }
}
