using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver
{
    public interface IProblem<TEstimator, TEstimatedExpert, TEstimatedAlternative>  
        where TEstimator: IExpert 
        where TEstimatedExpert : IExpert
        where TEstimatedAlternative : IAlternative

    {
        string Name { get; }
        List<Estimation<TEstimator, TEstimatedExpert>> ExpertsEstimations { get; set; }
        List<Estimation<TEstimator, TEstimatedAlternative>> AlternativesEstimations { get; set; }
        string Description { get; set; }
    }
}
