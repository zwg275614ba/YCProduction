using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace YCProduction.Model.Entitys.Dictionary
{
    public class DicProjectResult : PrimaryKey<int>
    {
        [DisplayName("投标或立项结果ID")]
        public string ResultId { get; set; }
        [DisplayName("投标或立项结果")]
        public string Result { get; set; }
        [DisplayName("说明")]
        public string Explain { get; set; }
        [DisplayName("备注")]
        public string Remarks { get; set; }
    }
}
