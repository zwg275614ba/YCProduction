using System;
using System.Collections.Generic;
using System.Text;

namespace YCProduction.Model.SearchParam
{
    public class BaseParam
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public int page { get; set; }
        /// <summary>
        /// 行数
        /// </summary>
        public int limit { get; set; }
        /// <summary>
        /// 排序字段 CreateOn
        /// </summary>
        public string field { get; set; } = "Id";
        /// <summary>
        /// 排序方式 asc desc
        /// </summary>
        public string order { get; set; } = "asc";
        /// <summary>
        /// 总数
        /// </summary>
        public int total { get; set; }
    }
}
