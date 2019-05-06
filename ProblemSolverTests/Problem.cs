using ProblemSolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolverTests
{
    class Problem : IProblem
    {
        public string Name { get; set; }
        public List<ExpertsEstimation> ExpertsEstimations { get; set; }
        public List<AlternativesEstimation> AlternativesEstimations { get; set; }
    }
}
