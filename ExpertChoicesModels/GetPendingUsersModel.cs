using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertChoicesModels
{
    public class GetPendingUsersModel : BodyModel
    {
        public List<User> Users { get; set; }
    }
}
