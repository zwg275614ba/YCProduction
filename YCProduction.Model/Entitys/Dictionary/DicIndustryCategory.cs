using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace YCProduction.Model.Entitys.Dictionary
{
    public class DicIndustryCategory : PrimaryKey<int>
    {
        [DisplayName("行业类别ID")]
        public string IndustryCategoryId { get; set; }
        [DisplayName("行业类别")]
        public string IndustryCategory { get; set; }
        [DisplayName("备注")]
        public string Remarks { get; set; }
    }
}
