using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_SanPhamBanHang
{
    public class Size
    {
        public int ID { get; set; }

        public string TenSize { get; set; }

        public Size(int id, string ten)
        {
            ID = id;
            TenSize = ten;
        }
    }
}