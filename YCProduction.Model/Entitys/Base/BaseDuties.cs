using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace YCProduction.Model.Entitys.Base
{
    public class BaseDuties: PrimaryKey<int>
    {
        [DisplayName("职务ID")]
        public string Code { get; set; }
        [DisplayName("职务")]
        public string Name { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }
    }
    
}
