using System;
using System.Collections.Generic;
using System.Text;

namespace YCProduction.Common.Helpers
{
    internal interface ISnowWorker
    {
        Action<OverCostActionArg> GenAction { get; set; }

        long NextId();
    }
}
