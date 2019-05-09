using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver
{
    public interface IProblem
    {
        string Name { get; }
        List<ExpertEstimation<IExpert>> ExpertsEstimations { get; set; }
        List<ExpertEstimation<IAlternative>> AlternativesEstimations { get; set; }
    }
}
