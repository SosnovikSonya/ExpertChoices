using ExpertChoices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertChoices.ServerInteraction
{
    class RegisterUserPostRequestModel : AuthorizeUserPostRequestModel
    {
        public string Name { get; set; }
        public UserRole Role { get; set; }
    }
}
