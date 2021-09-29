using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_SanPhamBanHang
{
    public partial class XuLyGioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int idxoa = Convert.ToInt32(Request.QueryString["idxoa"]);
            // Xóa sản phẩm khỏi giỏ hàng
            List<SanPhamGioHang> dsGioHang = (List<SanPhamGioHang>)Session["GioHang"];
            SanPhamGioHang itemXoa = null; // Sản phẩm sẽ xóa khỏi giỏ hàng
            foreach (var item in dsGioHang)
            {
                if (item.MatHang.ID == idxoa)
                {
                    itemXoa = item;
                }
            }
            if (itemXoa != null)
            {
                dsGioHang.Remove(itemXoa);
            }

            // Quay lại trang đặt hàng
            Response.Redirect("DatHang.aspx");
        }
    }
}