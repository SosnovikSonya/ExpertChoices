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
            var expEstimations1 = new ExpertsEstimation
            {
                EstimatingExpert = expert1,
                ExpertsRankings = new Dictionary<IExpert, int>
                {
                    { expert2, 8},
                }
            };

            var expEstimations2 = new ExpertsEstimation
            {
                EstimatingExpert = expert2,
                ExpertsRankings = new Dictionary<IExpert, int>
                {
                    { expert1, 7},
                }
            };

            var altEstimations1 = new AlternativesEstimation
            {
                EstimatingExpert = expert1,
                AlternativesEstimations = new Dictionary<IAlternative, int>
                {
                    { alt1, 8},
                    { alt2, 7}
                }
            };

            var altEstimations2 = new AlternativesEstimation
            {
                EstimatingExpert = expert2,
                AlternativesEstimations = new Dictionary<IAlternative, int>
                {
                    { alt1, 6},
                    { alt2, 7}
                }
            };

            //Server
            problem.AlternativesEstimations = new List<AlternativesEstimation>
                {
                    altEstimations1,
                    altEstimations2
                };

            problem.ExpertsEstimations = new List<ExpertsEstimation>
                {
                    expEstimations1,
                    expEstimations2
                };

            var solver = new ProblemSolver<Problem>(problem);

            //Server to Analytic
            var solution = solver.SolveTheProblem();

            Assert.IsNotNull(solution.AlternativesDispersion, "AlternativesDispersion expected to be not null");
        }
    }
}
