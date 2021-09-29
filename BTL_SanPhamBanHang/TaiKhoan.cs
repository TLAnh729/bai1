using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_SanPhamBanHang
{
    public class TaiKhoan
    {
        public string Hoten { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }

        public TaiKhoan(string hoten, string sdt, string email, string matkhau)
        {
            Hoten = hoten;
            SDT = sdt;
            Email = email;
            MatKhau = matkhau;
        }
    }
}