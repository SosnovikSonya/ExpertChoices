using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver
{
    public interface IProblem<TEstimator, TExpert, TEstimatedAlternative>  
        where TEstimator: IExpert 
        where TExpert : IExpert
        where TEstimatedAlternative : IAlternative

    {
        string Name { get; }
        List<Estimation<TEstimator, TExpert>> ExpertsEstimations { get; set; }
        List<Estimation<TEstimator, TEstimatedAlternative>> AlternativesEstimations { get; set; }
        string Description { get; set; }
    }
}
