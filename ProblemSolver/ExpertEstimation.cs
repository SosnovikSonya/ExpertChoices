using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver
{
    public class ExpertEstimation<T>
    {
        public IExpert Estimator { get; set; }
        public Dictionary<T, int> Estimated { get; set; }
    }
}
