using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolver;

namespace ProblemSolverTests
{
    [TestClass]
    public class SolverTests
    {
        [TestMethod]
        public void ProblemSolver_SomeProblem_SolutionIsNotEmpty()
        {
            //Admin
            var expert1 = new Expert
            {
                Name = "Sonya"
            };

            var expert2 = new Expert
            {
                Name = "Misha"
            };

            var expert3 = new Expert
            {
                Name = "Eva"
            };

            //Analytic
            var problem = new Problem
            {
                Name = "When to go to cinema"
            };

            var alt1 = new Alternative
            {
                Name = "Sunday"
            };

            var alt2 = new Alternative
            {
                Name = "Saturday"
            };

            //Experts
            var expEstimations1 = new ExpertEstimation<IExpert>
            {
                Estimator = expert1,
                Estimated = new Dictionary<IExpert, int>
                {
                    { expert2, 7},
                    { expert3, 6},
                }
            };

            var expEstimations2 = new ExpertEstimation<IExpert>
            {
                Estimator = expert2,
                Estimated = new Dictionary<IExpert, int>
                {
                    { expert1, 9},
                    { expert3, 10},
                }
            };

            var expEstimations3 = new ExpertEstimation<IExpert>
            {
                Estimator = expert3,
                Estimated = new Dictionary<IExpert, int>
                {
                    { expert1, 5},
                    { expert2, 3},
                }
            };


            var altEstimations1 = new ExpertEstimation<IAlternative>
            {
                Estimator = expert1,
                Estimated = new Dictionary<IAlternative, int>
                {
                    { alt1, 8},
                    { alt2, 7},
                }
            };

            var altEstimations2 = new ExpertEstimation<IAlternative>
            {
                Estimator = expert2,
                Estimated = new Dictionary<IAlternative, int>
                {
                    { alt1, 6},
                    { alt2, 7}
                }
            };

            var altEstimations3 = new ExpertEstimation<IAlternative>
            {
                Estimator = expert3,
                Estimated = new Dictionary<IAlternative, int>
                {
                    { alt1, 2},
                    { alt2, 10}
                }
            };


            //Server
            problem.AlternativesEstimations = new List<ExpertEstimation<IAlternative>>
                {
                    altEstimations1,
                    altEstimations2,
                    altEstimations3
                };

            problem.ExpertsEstimations = new List<ExpertEstimation<IExpert>>
                {
                    expEstimations1,
                    expEstimations2,
                    expEstimations3
                };

            var solver = new ProblemSolver<Problem>(problem);

            //Server to Analytic
            var solution = solver.SolveTheProblem();

            Assert.IsNotNull(solution.AlternativesDispersion, "AlternativesDispersion expected to be not null");
        }
    }
}
