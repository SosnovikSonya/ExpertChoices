using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver
{
    public class ProblemSolver<T> where T: IProblem
    {
        public ProblemSolver(T problemToSolve)
        {
            ProblemToSolve = problemToSolve;
        }

        public T ProblemToSolve { get; set; }

        public ProblemSolution<T> SolveTheProblem()
        {
            //create solution instance
            var solution = new ProblemSolution<T>(ProblemToSolve)
            {
                //fill its propertis = solve the problem
                AlternativesDispersion = EvaluateAlternativeDispersion(),
                AlternativesPreferency = EvaluateAlternativesPreferency(),
                ExpertsCompitency = EvaluateExpertsCompitency(),
                ExpertsDispersion = EvaluateExpertsDispersion()
            };

            //return filled object
            return solution;
        }

        private Dictionary<IAlternative, double> EvaluateAlternativeDispersion()
        {

            return null;
        }

        private Dictionary<IAlternative, double> EvaluateAlternativesPreferency()
        {

            return null;
        }
        private Dictionary<IExpert, double> EvaluateExpertsCompitency()
        {

            return null;
        }

        private Dictionary<IExpert, double> EvaluateExpertsDispersion()
        {

            return null;
        }

       
    }
}
