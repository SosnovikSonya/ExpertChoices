﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertChoices.ServerInteraction
{
    class BodyModel
    {
        public override string ToString()
        {
            return JsonHelper.SerializeToJson(this);
        }
    }
}
