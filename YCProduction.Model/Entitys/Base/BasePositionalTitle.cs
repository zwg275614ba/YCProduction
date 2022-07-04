using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace YCProduction.Model.Entitys.Base
{
    public class BasePositionalTitle : PrimaryKey<int>
    {
        [DisplayName("职称ID")]
        public string Code { get; set; }
        [DisplayName("职称")]
        public string Name { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }
    }
}

