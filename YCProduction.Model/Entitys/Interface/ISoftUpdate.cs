using System;
using System.Collections.Generic;
using System.Text;

namespace YCProduction.Model.Entitys.Interface
{
    public interface ISoftUpdate
    {
        int? UpdateBy { get; set; }
        DateTime? UpdateDate { get; set; }
    }
}
