using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver
{
    public class ExpertsEstimation : IExpertEstimation
    {
        public IExpert EstimatingExpert { get; set; }
        public Dictionary<IExpert, int> ExpertsRankings { get; set; }
    }
}
