using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertChoices.ServerInteraction
{
    static class JsonHelper
    {
        public static string SerializeToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T DeserializeFromJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
