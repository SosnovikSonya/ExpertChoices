using ExpertChoices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertChoices.ServerInteraction
{
    class AuthorizeUserPostResponseModel : BodyModel
    {
        public bool Authorized { get; set; }
        public UserRole Role { get; set; }
    }
}
