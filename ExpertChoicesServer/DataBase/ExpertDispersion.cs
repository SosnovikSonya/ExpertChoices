using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertChoicesServer.DataBase
{
    public class ExpertDispersion
    {
        public int IdExpert { get; set; }
        public int IdProblem { get; set; }
        public int IdExpertsDispersion { get; set; }
        public float Value { get; set; }

    }
}