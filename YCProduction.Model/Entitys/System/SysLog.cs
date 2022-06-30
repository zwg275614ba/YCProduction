using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.Values;

namespace YCProduction.Model.Entitys.System
{
    public class SysLog : AggregateRoot
    {
        public DbLogType? LogType { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
    }
}
