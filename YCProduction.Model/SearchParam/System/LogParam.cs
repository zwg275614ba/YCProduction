using System;
using System.Collections.Generic;
using System.Text;

namespace YCProduction.Model.SearchParam.System
{
    public class LogParam : BaseParam
    {
        /// <summary>
        /// 操作人
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 操作类型
        /// </summary>
        public int LogType { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public string StateTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndTime { get; set; }
    }
}
