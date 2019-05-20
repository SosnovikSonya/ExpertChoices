using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertChoicesServer.DataBase
{
    public class EstimationOnAlternative
    {
        public int IdEstimationOnAlternative { get; set; }
        public int IdEstimator { get; set; }
        public int IdEstimatedAlternative { get; set; }
        public int? Value { get; set; }
        public int IdProblem { get; set; }
    }
}