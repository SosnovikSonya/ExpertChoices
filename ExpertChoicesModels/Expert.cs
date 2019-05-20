using ProblemSolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertChoicesModels
{
    public class Expert : BodyModel, IExpert
    {
        public int Id { get; set; }
        public string Name { get; set;  }
    }
}
