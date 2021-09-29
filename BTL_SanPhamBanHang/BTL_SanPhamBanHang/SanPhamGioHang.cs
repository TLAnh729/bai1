using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_SanPhamBanHang
{
    /// <summary>
    /// Thông tin 1 sản phẩm trong giỏ hàng giỏ hàng
    /// </summary>
    public class SanPhamGioHang
    {
        public MatHang MatHang { get; set; }

        public int SoLuong { get; set; }

        /// <summary>
        /// Size muốn mua
        /// </summary>
        public string Size { get; set; }

        public decimal ThanhTien { get; set; }

    }
}