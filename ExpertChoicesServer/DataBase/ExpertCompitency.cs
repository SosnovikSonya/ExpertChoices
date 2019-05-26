using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertChoicesServer.DataBase
{
    public class ExpertCompetency
    {
        public int IdExpertCompetency { get; set; }
        public int IdProblem { get; set; }
        public int IdExpert { get; set; }
        public float Value { get; set; }
    }
}