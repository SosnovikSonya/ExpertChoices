﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertChoicesServer.DataBase
{
    public class AlternativePreferency
    {
        public int IdAlternativesPreferency { get; set; }
        public int IdProblem { get; set; }
        public int IdAlternative { get; set; }
        public float Value { get; set; }
    }
}