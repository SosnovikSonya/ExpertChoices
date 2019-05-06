﻿using ProblemSolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolverTests
{
    class Problem : IProblem
    {
        public string Name { get; set; }
        public List<ExpertEstimation<IExpert>> ExpertsEstimations { get; set; }
        public List<ExpertEstimation<IAlternative>> AlternativesEstimations { get; set; }
    }
}
