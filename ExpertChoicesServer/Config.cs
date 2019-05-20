using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ExpertChoicesServer
{
    public static class Config
    {
        public static string DbConnString = ConfigurationManager.ConnectionStrings["ConnStringDb"].ConnectionString;
    }
}