using ProblemSolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertChoicesModels
{
    public class Problem : BodyModel, IProblem<Expert, Expert, Alternative>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Estimation<Expert, Expert>> ExpertsEstimations { get; set; }
        public List<Estimation<Expert, Alternative>> AlternativesEstimations { get; set; }
        public string Description { get; set; }

        public Problem()
        {
            ExpertsEstimations = new List<Estimation<Expert, Expert>>();
            AlternativesEstimations = new List<Estimation<Expert, Alternative>>();
        }
    }
}
