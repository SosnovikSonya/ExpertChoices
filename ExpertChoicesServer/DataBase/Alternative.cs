using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertChoicesServer.DataBase
{
    public class Alternative
    {
        public int IdAlternative { get; set; }
        //public int IdProblem { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}