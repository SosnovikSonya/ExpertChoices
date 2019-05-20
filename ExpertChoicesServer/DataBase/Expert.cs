using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertChoicesServer.DataBase
{
    public class Expert
    {
        public int IdExpert { get; set; }
        public int IdUser { get; set; }
        public string Name { get; set; }
    }
}