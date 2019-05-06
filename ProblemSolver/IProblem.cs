using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver
{
    public interface IProblem
    {
        string Name { get; set; }
        List<ExpertsEstimation> ExpertsEstimations { get; set; }
        List<AlternativesEstimation> AlternativesEstimations { get; set; }
    }
}
