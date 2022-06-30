using System;
using System.Collections.Generic;
using System.Text;

namespace YCProduction.Model.SearchParam.System
{
    public class UserParam : BaseParam
    {
        /// <summary>
        /// 登录名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 登录状态
        /// </summary>
        public string Status { get; set; }
    }
}
