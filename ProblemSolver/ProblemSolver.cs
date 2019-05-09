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
        public ProblemSolution<T> ProblemSolution { get; }      

        public ProblemSolver(T problemToSolve)
        {
            ProblemToSolve = problemToSolve;
            ProblemSolution = new ProblemSolution<T>(ProblemToSolve);
        }

        public T ProblemToSolve { get; set; }

        /// <summary>
        /// Returnes solution to the problem
        /// </summary>
        public ProblemSolution<T> SolveTheProblem()
        {
            _expertsEstimationsMatrix = GetFilledMatrix(ProblemToSolve.ExpertsEstimations);
            _alternativesEstimationsMatrix = GetFilledMatrix(ProblemToSolve.AlternativesEstimations);

            ProblemSolution.ExpertsCompitency = EvaluateExpertsCompitency();
            ProblemSolution.ExpertsDispersion = EvaluateExpertsDispersion();
            ProblemSolution.AlternativesDispersion = EvaluateAlternativesDispersion();
            ProblemSolution.AlternativesPreferency = EvaluateAlternativesPreferency();   

            return ProblemSolution;
        }

        private List<IExpert> GetEstimators<TKey>(List<ExpertEstimation<TKey>> expertEstimations)
        {
            return expertEstimations
                .Select(estimation => estimation.Estimator)
                .Distinct()
                .ToList();
        }

        /// <summary>
        /// 
        /// </summary>
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
            var result = new Dictionary<IAlternative, double>();

            for (int j = 0; j < _expertsEstimationsMatrix.Columns.Count; j++)
            {
                double Cj = 0;
                double numerator = 0;
                double altEstimationSum = 0;
                for (int i = 0; i < _alternativesEstimationsMatrix.Raws.Count; i++)
                {
                    if (_alternativesEstimationsMatrix.Array[i, j] != null)
                    {
                        altEstimationSum += (int)_alternativesEstimationsMatrix.Array[i, j];
                    }
                }
                Cj = (altEstimationSum / (_alternativesEstimationsMatrix.Columns.Count));
                for (int i = 0; i < _alternativesEstimationsMatrix.Raws.Count; i++)
                {
                    if (_alternativesEstimationsMatrix.Array[i, j] != null)
                    {
                        numerator += Math.Pow((int)_alternativesEstimationsMatrix.Array[i, j] - Cj, 2);
                    }
                }
                var AlternativesDispersion = (numerator / (_alternativesEstimationsMatrix.Columns.Count));
                result.Add(_alternativesEstimationsMatrix.Columns[j], AlternativesDispersion);
            }
            return result;
        }

        private Dictionary<IAlternative, double> EvaluateAlternativesPreferency()
        {
            var result = new Dictionary<IAlternative, double>();
            double totalSum = 0;
            for (int i = 0; i < _alternativesEstimationsMatrix.Raws.Count; i++)
            {
                for (int j = 0; j < _alternativesEstimationsMatrix.Columns.Count; j++)
                {
                    totalSum += (int)_alternativesEstimationsMatrix.Array[i, j] * ProblemSolution.ExpertsCompitency[_alternativesEstimationsMatrix.Raws[i]];
                }
            }
            for (int j = 0; j < _alternativesEstimationsMatrix.Columns.Count; j++)
            {
                double AltEstimationSum = 0;

                for (int i = 0; i < _alternativesEstimationsMatrix.Raws.Count; i++)
                {
                    AltEstimationSum += (int)_alternativesEstimationsMatrix.Array[i, j] * ProblemSolution.ExpertsCompitency[_alternativesEstimationsMatrix.Raws[i]];
                }

                var AlternativesDispersion = Math.Round(AltEstimationSum / totalSum, 3);
                result.Add(_alternativesEstimationsMatrix.Columns[j], AlternativesDispersion);
            }
            return result;
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

            for (int j = 0; j < _expertsEstimationsMatrix.Columns.Count; j++)
            {
                double expertEstimationSum = 0;

                for (int i = 0; i < _expertsEstimationsMatrix.Raws.Count; i++)
                {
                    if (_expertsEstimationsMatrix.Array[i, j] != null)
                    {
                        expertEstimationSum += (int)_expertsEstimationsMatrix.Array[i, j];
                    }
                }
                double expertsCompitency = expertEstimationSum / totalSum;
                result.Add(_expertsEstimationsMatrix.Columns[j], expertsCompitency);
            }
            return result;
        }

        private Dictionary<IExpert, double> EvaluateExpertsDispersion()
        {
            var result = new Dictionary<IExpert, double>();
            
            for (int j = 0; j < _expertsEstimationsMatrix.Columns.Count; j++)
            {
                double Rj = 0;
                double numerator = 0;
                double expertEstimationSum = 0;
                for (int i = 0; i < _expertsEstimationsMatrix.Raws.Count; i++)
                {
                    if (_expertsEstimationsMatrix.Array[i, j] != null)
                    {
                        expertEstimationSum += (int)_expertsEstimationsMatrix.Array[i, j];
                    }
                }
                Rj = (expertEstimationSum / (_expertsEstimationsMatrix.Columns.Count - 1));
                for (int i = 0; i < _expertsEstimationsMatrix.Raws.Count; i++)
                {
                    if (_expertsEstimationsMatrix.Array[i, j] != null)
                    {         
                        numerator += Math.Pow((int)_expertsEstimationsMatrix.Array[i, j] - Rj, 2);
                    }
                }
                var ExpertsDispersion = (numerator / (_expertsEstimationsMatrix.Columns.Count - 1));
                result.Add(_expertsEstimationsMatrix.Raws[j], ExpertsDispersion);
            }
            return result;
        }
    }
}
