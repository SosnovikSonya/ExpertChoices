using ExpertChoices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertChoices.ServerInteraction
{
    class GetPendingUsersModel : BodyModel
    {
        public List<User> Users { get; set; }
    }
}
