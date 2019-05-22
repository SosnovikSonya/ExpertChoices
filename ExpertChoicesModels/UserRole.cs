using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertChoicesModels
{
    [Flags]
    public enum UserRole
    {
        Null = 0,
        Admin = 2,
        Expert = 4,
        Analytic = 8
    }
}
