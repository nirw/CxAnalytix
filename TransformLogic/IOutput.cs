﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CxAnalytics.TransformLogic
{
    public interface IOutput
    {

        void write(Dictionary<String, String> record);
    }
}
