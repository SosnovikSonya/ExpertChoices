using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver
{
    public class ProblemSolution
    { 
        public Dictionary<IExpert, double> ExpertsCompitency { get; set; }
        public Dictionary<IExpert, double> ExpertsDispersion { get; set; }
        public Dictionary<IAlternative, double> AlternativesPreferency { get; set; }
        public Dictionary<IAlternative, double> AlternativesDispersion { get; set; }
        public ProblemSolution()
        {
            ExpertsCompitency = new Dictionary<IExpert, double>();
            ExpertsDispersion = new Dictionary<IExpert, double>();
            AlternativesPreferency = new Dictionary<IAlternative, double>();
            AlternativesDispersion = new Dictionary<IAlternative, double>();
        }
    }
}
