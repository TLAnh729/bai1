using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_SanPhamBanHang
{
    public class LoaiHang
    {
        // 1: NIKE, 2: VALENTINO, 3: LACOSTE
        public int ID { get; set; }

        public string TenLoaiHang { get; set; }

        public string TenAnhLoaiHang { get; set; }

        public LoaiHang(int id, string ten, string tenanh)
        {
            ID = id;
            TenLoaiHang = ten;
            TenAnhLoaiHang = tenanh;
        }
    }
}