using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver
{
    public class Estimation<TExpert, TEstimated> where TExpert: IExpert
    {
        public TExpert Estimator { get; set; }
        public Dictionary<TEstimated, int?> Estimated { get; set; }
    }
}
