using System;
using System.Collections.Generic;
using System.Text;

namespace YCProduction.Model.ViewModel
{
    /// <summary>
    /// 用户登录次数和过期时间配置
    /// </summary>
    public class SysAdminLoginConfig
    {
        /// <summary>
        /// 登录用户
        /// </summary>
        public string AccountName { get; set; }
        /// <summary>
        /// 设置允许登录次数
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 过期时间-分钟
        /// </summary>
        public int DelayMinute { get; set; }
        /// <summary>
        /// 错误次数
        /// </summary>
        public int ErrorCount { get; set; }
    }
}
