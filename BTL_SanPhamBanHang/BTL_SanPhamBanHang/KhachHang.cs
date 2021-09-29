using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_SanPhamBanHang
{
    public class KhachHang
    {
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public int sdt { get; set; }
        public KhachHang(string ten, string diachi, int sodienthoai)
        {
            TenKH = ten;
            DiaChi = diachi;
            sdt = sodienthoai;
        }
    }
}