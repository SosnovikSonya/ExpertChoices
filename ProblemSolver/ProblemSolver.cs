using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver
{
    public class ProblemSolver<TProblem, TEstimator, TExpert, TEstimatedAlternative>
        where TEstimator : IExpert
        where TExpert : IExpert
        where TEstimatedAlternative : IAlternative
        where TProblem : IProblem<TEstimator, TExpert, TEstimatedAlternative>




        //<T> where T: IProblem<IExpert, IExpert, IAlternative>
    {
        private Matrix<TEstimator, TExpert> _expertsEstimationsMatrix;
        private Matrix<TEstimator, TEstimatedAlternative> _alternativesEstimationsMatrix;
        public ProblemSolution ProblemSolution { get; }      

        public ProblemSolver(TProblem problemToSolve)
        {
            ProblemToSolve = problemToSolve;
            ProblemSolution = new ProblemSolution();
        }

        public TProblem ProblemToSolve { get; set; }

        /// <summary>
        /// Returnes solution to the problem
        /// </summary>
        public ProblemSolution SolveTheProblem()
        {
            _expertsEstimationsMatrix = GetFilledMatrixExperts(ProblemToSolve.ExpertsEstimations);
            _alternativesEstimationsMatrix = GetFilledMatrixAlternatives(ProblemToSolve.AlternativesEstimations);

            ProblemSolution.ExpertsCompetency = EvaluateExpertsCompetency();
            ProblemSolution.ExpertsDispersion = EvaluateExpertsDispersion();
            ProblemSolution.AlternativesDispersion = EvaluateAlternativesDispersion();
            ProblemSolution.AlternativesPreferency = EvaluateAlternativesPreferency();   

            return ProblemSolution;
        }

        private List<TEstimator> GetEstimators<TKey>(List<Estimation<TEstimator, TKey>> expertEstimations)
        {
            return expertEstimations
                .Select(estimation => estimation.Estimator)
                .Distinct()
                .ToList();
        }

        private List<TExpert> GetObjectsOfEstimationsExperts(List<Estimation<TEstimator, TExpert>> expertEstimations)
        {
            return expertEstimations
                .SelectMany(estimation => estimation.Estimated)
                .Select(pair => pair.Key)                
                .GroupBy(est => est.Name)
                .Select(g => g.First())
                .ToList();
        }

        private List<TEstimatedAlternative> GetObjectsOfEstimationsAlternatives(List<Estimation<TEstimator, TEstimatedAlternative>> expertEstimations)
        {
            return expertEstimations
                .SelectMany(estimation => estimation.Estimated)
                .Select(pair => pair.Key)
                .GroupBy(est => est.Name)
                .Select(g => g.First())
                .ToList();
        }

        private Matrix<TEstimator, TExpert> GetFilledMatrixExperts(List<Estimation<TEstimator, TExpert>> estimations)
        {
            var estimators = GetEstimators(estimations);
            var estimatings = GetObjectsOfEstimationsExperts(estimations);
            var matrix = new Matrix<TEstimator, TExpert>()
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

                    var estimationOfExpert = estimations
                        .Single(estimation => estimation.Estimator.Name.Equals(estimators[i].Name))
                        .Estimated
                        .Where(estimated => estimated.Key.Name.Equals(estimatings[j].Name));
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

        private Matrix<TEstimator, TEstimatedAlternative> GetFilledMatrixAlternatives(List<Estimation<TEstimator, TEstimatedAlternative>> estimations)
        {
            var estimators = GetEstimators(estimations);
            var estimatings = GetObjectsOfEstimationsAlternatives(estimations);
            var matrix = new Matrix<TEstimator, TEstimatedAlternative>()
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

                    if (matrix.Array[i, j] != null)
                    {
                        throw new InvalidOperationException("Invalid data, duplication detected");
                    }

                    var estimationOfExpert = estimations
                        .Single(estimation => estimation.Estimator.Name.Equals(estimators[i].Name))
                        .Estimated
                        .Where(estimated => estimated.Key.Name.Equals(estimatings[j].Name));
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


        /// <summary>
        /// Returnes AlternativesDispersion coefficient
        /// </summary>
        private Dictionary<IAlternative, double> EvaluateAlternativesDispersion()
        {
            var result = new Dictionary<IAlternative, double>();

            for (int j = 0; j < _expertsEstimationsMatrix.Columns.Count; j++)
            {
                double Cj = 0;
                double numerator = 0;
                double altEstimationSum = 0;
                //calculate the estimates put on the alternative
                for (int i = 0; i < _alternativesEstimationsMatrix.Raws.Count; i++)
                {
                    altEstimationSum += (int)_alternativesEstimationsMatrix.Array[i, j];

                }
                Cj = (altEstimationSum / (_alternativesEstimationsMatrix.Columns.Count));
                for (int i = 0; i < _alternativesEstimationsMatrix.Raws.Count; i++)
                {
                    numerator += Math.Pow((int)_alternativesEstimationsMatrix.Array[i, j] - Cj, 2);
                }
                var AlternativesDispersion = (numerator / (_alternativesEstimationsMatrix.Columns.Count));
                result.Add(_alternativesEstimationsMatrix.Columns[j], AlternativesDispersion);
            }
            return result;
        }

        /// <summary>
        /// Returnes AlternativesPreferency coefficient
        /// </summary>
        private Dictionary<IAlternative, double> EvaluateAlternativesPreferency()
        {
            var result = new Dictionary<IAlternative, double>();
            double totalSum = 0;
            for (int i = 0; i < _alternativesEstimationsMatrix.Raws.Count; i++)
            {
                for (int j = 0; j < _alternativesEstimationsMatrix.Columns.Count; j++)
                {
                    var targetExpert = ProblemSolution.ExpertsCompetency.Single(pair => pair.Key.Name == _alternativesEstimationsMatrix.Raws[i].Name);
                    totalSum += (int)_alternativesEstimationsMatrix.Array[i, j] * targetExpert.Value;
                }
            }
            for (int j = 0; j < _alternativesEstimationsMatrix.Columns.Count; j++)
            {
                double AltEstimationSum = 0;

                for (int i = 0; i < _alternativesEstimationsMatrix.Raws.Count; i++)
                {
                    var targetExpert = ProblemSolution.ExpertsCompetency.Single(pair => pair.Key.Name == _alternativesEstimationsMatrix.Raws[i].Name);
                    AltEstimationSum += (int)_alternativesEstimationsMatrix.Array[i, j] * targetExpert.Value;
                }

                var AlternativesDispersion = Math.Round(AltEstimationSum / totalSum, 3);
                result.Add(_alternativesEstimationsMatrix.Columns[j], AlternativesDispersion);
            }
            return result;
        }

        /// <summary>
        /// Returnes ExpertsCompetency coefficient
        /// </summary>
        private Dictionary<IExpert, double> EvaluateExpertsCompetency()
        {
            var result = new Dictionary<IExpert, double>();
            var totalSum = 0;
            //calculate the arithmetic average of all estimates
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
            //calculate the estimates put on the expert
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
                double expertsCompetency = expertEstimationSum / totalSum;
                result.Add(_expertsEstimationsMatrix.Columns[j], expertsCompetency);
            }
            return result;
        }

        /// <summary>
        /// Returnes ExpertsDispersion coefficient
        /// </summary>
        private Dictionary<IExpert, double> EvaluateExpertsDispersion()
        {
            var result = new Dictionary<IExpert, double>();
            
            for (int j = 0; j < _expertsEstimationsMatrix.Columns.Count; j++)
            {
                double Rj = 0;
                double numerator = 0;
                double expertEstimationSum = 0;
                //calculate the estimates put on the expert
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
