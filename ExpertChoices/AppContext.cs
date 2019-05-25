using ExpertChoices.ServerInteraction;
using ExpertChoicesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertChoices
{
    public static class AppContext
    {
        public static User CurrentUser { get; set; }
        public static ExpertChoicesClient Client { get; set; } = new ExpertChoicesClient();
    }
}
