using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertChoices.ServerInteraction
{
    class AuthorizeUserPostRequestModel : BodyModel
    {
        public string AuthToken { get; set; }
    }
}
