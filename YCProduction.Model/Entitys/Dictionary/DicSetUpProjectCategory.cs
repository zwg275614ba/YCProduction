using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace YCProduction.Model.Entitys.Dictionary
{
    public class DicSetUpProjectCategory : PrimaryKey<int>
    {
        [DisplayName("立项类别ID")]
        public string CategoryId { get; set; }
        [DisplayName("立项类别")]
        public string Category { get; set; }
        [DisplayName("备注")]
        public string Remarks { get; set; }
    }
}
