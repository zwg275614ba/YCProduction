using System;
using System.Collections.Generic;
using System.Text;

namespace YCProduction.Common.ClientApi
{
    public class AjaxResult
    {
        /// <summary>
        /// 返回状态
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// 返回信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 返回数据
        /// </summary>
        public object Data { get; set; }
    }
}
