using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver
{
    public class ProblemSolver<T> where T: IProblem
    {
        private Matrix<IExpert, IExpert> _expertsEstimationsMatrix;
        private Matrix<IExpert, IAlternative> _alternativesEstimationsMatrix;

        public ProblemSolver(T problemToSolve)
        {
            ProblemToSolve = problemToSolve;
        }

        public T ProblemToSolve { get; set; }

        public ProblemSolution<T> SolveTheProblem()
        {
            _expertsEstimationsMatrix = GetFilledMatrix(ProblemToSolve.ExpertsEstimations);
            _alternativesEstimationsMatrix = GetFilledMatrix(ProblemToSolve.AlternativesEstimations);

            var asd = EvaluateExpertsCompitency();

            //create solution instance
            var solution = new ProblemSolution<T>(ProblemToSolve)
            {
                //fill its propertis = solve the problem
                AlternativesDispersion = EvaluateAlternativesDispersion(),
                AlternativesPreferency = EvaluateAlternativesPreferency(),
                ExpertsCompitency = EvaluateExpertsCompitency(),
                ExpertsDispersion = EvaluateExpertsDispersion()
            };

            //return filled object
            return solution;
        }

        private List<IExpert> GetEstimators<TKey>(List<ExpertEstimation<TKey>> expertEstimations)
        {
            return expertEstimations
                .Select(estimation => estimation.Estimator)
                .Distinct()
                .ToList();
        }

        private List<TKey> GetObjectsOfExpertsEstimations<TKey>(List<ExpertEstimation<TKey>> expertEstimations)
        {
            return expertEstimations
                .SelectMany(estimation => estimation.Estimated)
                .Select(pair => pair.Key)
                .Distinct()
                .ToList();
        }

        private Matrix<IExpert, TKey> GetFilledMatrix<TKey>(List<ExpertEstimation<TKey>> expertEstimations)
        {
            var estimators = GetEstimators(expertEstimations);
            var estimatings = GetObjectsOfExpertsEstimations(expertEstimations);
            var matrix = new Matrix<IExpert, TKey>()
            {
                Array = new int?[estimators.Count, estimatings.Count],
                Raws = estimators,
                Columns = estimatings
            };

            //fill array
            for (int i = 0; i < estimators.Count; i++)
            {
                for (int j = 0; j < estimatings.Count; j++)
                {
                    
                    if (matrix.Array[i,j] != null)
                    {
                        throw new InvalidOperationException("Invalid data, duplication detected");
                    }

                    var estimationOfExpert = expertEstimations
                        .Single(estimation => estimation.Estimator.Equals(estimators[i]))
                        .Estimated
                        .Where(estimated => estimated.Key.Equals(estimatings[j]));
                    if (estimationOfExpert.Any())
                    {
                        matrix.Array[i, j] = estimationOfExpert
                            .Single()
                            .Value;
                    }

                }
            }

            return matrix;
        }

        private Dictionary<IAlternative, double> EvaluateAlternativesDispersion()
        {

            return null;
        }

        private Dictionary<IAlternative, double> EvaluateAlternativesPreferency()
        {

            return null;
        }
        private Dictionary<IExpert, double> EvaluateExpertsCompitency()
        {
            var result = new Dictionary<IExpert, double>();
            var totalSum = 0;
            for (int i = 0; i < _expertsEstimationsMatrix.Raws.Count; i++)
            {
                for (int j = 0; j < _expertsEstimationsMatrix.Columns.Count; j++)
                {
                    if (_expertsEstimationsMatrix.Array[i,j] != null)
                    {
                        totalSum += (int)_expertsEstimationsMatrix.Array[i, j];
                    }
                }
            }

            for (int i = 0; i < _expertsEstimationsMatrix.Raws.Count; i++)
            {
                var expertEstimationSum = 0;

                for (int j = 0; j < _expertsEstimationsMatrix.Columns.Count; j++)
                {
                    if (_expertsEstimationsMatrix.Array[i, j] != null)
                    {
                        expertEstimationSum += (int)_expertsEstimationsMatrix.Array[i, j];
                    }
                }
                var expertsCompitency = (double) expertEstimationSum / totalSum;
                result.Add(_expertsEstimationsMatrix.Raws[i], expertsCompitency);
            }
            return result;
        }

        private Dictionary<IExpert, double> EvaluateExpertsDispersion()
        {

            return null;
        }

       
    }
}
