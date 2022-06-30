using System;
using System.Collections.Generic;
using System.Text;

namespace YCProduction.Model.ViewModel
{
    public class PagedData<T> where T : class
    {
        public PagedData(int pageIndex, int pageSize)
        {
            Current = pageIndex;
            RowCount = pageSize;
        }

        public PagedData() { }

        public int Current { get; set; }
        public int RowCount { get; set; }
        public int count { get; set; }
        public List<T> data { get; set; }
        public int code { get; set; } = 0;
    }
}
