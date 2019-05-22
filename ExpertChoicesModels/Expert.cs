using ProblemSolver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertChoicesModels
{
    //[TypeConverter(typeof(ExpertConverter))]
    public class Expert : BodyModel, IExpert
    {
        public int Id { get; set; }
        public string Name { get; set;  }
    }
}
