using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver
{
    class Matrix<TRaw, TCol>
    {
        public int?[,] Array { get; set; }
        public List<TRaw> Raws { get; set; }
        public List<TCol> Columns { get; set; }
    }
}
