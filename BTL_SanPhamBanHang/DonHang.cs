using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_SanPhamBanHang
{
    public class DonHang
    {
        public List<SanPhamGioHang> DanhSachSanPham { get; set; }

        public string HoTen { get; set; }

        public string SoDienThoai { get; set; }

        public string DiaChi { get; set; }

        public decimal TongTien { get; set; }
    }
}