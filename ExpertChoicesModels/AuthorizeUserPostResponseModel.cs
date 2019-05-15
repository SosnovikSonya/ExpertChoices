using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertChoicesModels
{
    public class AuthorizeUserPostResponseModel : BodyModel
    {
        public bool Authorized { get; set; }
        public UserRole Role { get; set; }
    }
}
