using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_SanPhamBanHang
{
    public class MatHang
    {
        public int ID { get; set; }
        public int IDLoaiHang { get; set; }
        public string TenHang { get; set; }
        public float Gia { get; set; }
        public string MoTa { get; set; }
        public int SoLuong { get; set; }
        public string TenAnh { get; set; }
        public List<Size> Size { get; set; }
        public string ThuongHieu { get; set; }

        public MatHang(int id, int idloaihang, string ten, float giahang, string mt, int sl, string tenanh, List<Size> sizes, string thuonghieu)
        {
            ID = id;
            IDLoaiHang = idloaihang;
            TenHang = ten;
            Gia = giahang;
            MoTa = mt;
            SoLuong = sl;
            TenAnh = tenanh;
            Size = sizes;
            ThuongHieu = thuonghieu;
        }

    }
}