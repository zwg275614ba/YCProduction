using System;
using System.Collections.Generic;
using System.Text;

namespace YCProduction.Model.SearchParam.Base
{
    public class CustomerInfoParam : BaseParam
    {
        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact { get; set; }
        /// <summary>
        /// 客户公司
        /// </summary>
        public string CustomerCompany { get; set; }
    }
}
