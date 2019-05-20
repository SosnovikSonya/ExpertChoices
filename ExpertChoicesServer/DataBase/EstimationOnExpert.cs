using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertChoicesServer.DataBase
{
    public class EstimationOnExpert
    {
        public int IdEstimationOnExpert { get; set; }
        public int IdEstimator { get; set; }
        public int IdEstimatedExpert { get; set; }
        public int? Value { get; set; }
        public int IdProblem { get; set; }
    }
}