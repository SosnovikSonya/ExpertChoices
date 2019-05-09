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

            var alt3 = new Alternative
            {
                Name = "Monday"
            };

            //Experts
            var expEstimations1 = new ExpertEstimation<IExpert>
            {
                Estimator = expert1,
                Estimated = new Dictionary<IExpert, int?>
                {
                    { expert2, 7},
                    { expert3, 6},
                }
            };

            var expEstimations2 = new ExpertEstimation<IExpert>
            {
                Estimator = expert2,
                Estimated = new Dictionary<IExpert, int?>
                {
                    { expert1, 9},
                    { expert3, 10},
                }
            };

            var expEstimations3 = new ExpertEstimation<IExpert>
            {
                Estimator = expert3,
                Estimated = new Dictionary<IExpert, int?>
                {
                    { expert1, 5},
                    { expert2, 3},
                }
            };


            var altEstimations1 = new ExpertEstimation<IAlternative>
            {
                Estimator = expert1,
                Estimated = new Dictionary<IAlternative, int?>
                {
                    { alt1, 7},
                    { alt2, 4},
                    { alt3, 5}
                }
            };

            var altEstimations2 = new ExpertEstimation<IAlternative>
            {
                Estimator = expert2,
                Estimated = new Dictionary<IAlternative, int?>
                {
                    { alt1, 8},
                    { alt2, 3},
                    { alt3, 10}
                }
            };

            var altEstimations3 = new ExpertEstimation<IAlternative>
            {
                Estimator = expert3,
                Estimated = new Dictionary<IAlternative, int?>
                {
                    { alt1, 3},
                    { alt2, 8},
                    { alt3, 4}
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

        [TestMethod]
        public void MyTestMethod()
        {
            var intOperator = new IntOperator();
            intOperator.OnOperation += GetStringRepresentation;

            intOperator.DoOperations(1, 2);

            Console.WriteLine(intOperator.result1);
            Console.WriteLine(intOperator.result2);

        }

        public static string GetStringRepresentation(int a, int b)
        {
            Console.WriteLine($"{a} and {b}");
            return $"{a} and {b}";
        }
    }

    
    class IntOperator
    {
        public event OperationStarted OnOperation;
        private Operation Operation;
        public int result1;
        public int result2;

        public IntOperator()
        {
            Operation += Sum;
            Operation += Multiply;
        }

        public void DoOperations(int a, int b)
        {
            Operation.Invoke(a, b);
        }

        private void Sum(int a, int b)
        {
            OnOperation.Invoke(a, b);
            result1 = a + b;
        }

        private void Multiply(int a, int b)
        {
            result2 = a * b;
        }
    }

    delegate void Operation(int a, int b);

    delegate string OperationStarted(int a, int b);

    enum KindOfMeat
    {
        Chiken = 2,
        Pork = 4,
        Fish = 8
    }

    class Kotleta
    {
        public KindOfMeat meat = KindOfMeat.Chiken | KindOfMeat.Pork;
    }
}
