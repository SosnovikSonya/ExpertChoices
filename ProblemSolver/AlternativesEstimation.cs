using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver
{
    public class AlternativesEstimation : IExpertEstimation
    {
        public IExpert EstimatingExpert { get; set; }
        public Dictionary<IAlternative, int> AlternativesEstimations { get; set; }
    }
}
