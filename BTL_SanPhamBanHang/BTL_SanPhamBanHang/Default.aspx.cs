using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_SanPhamBanHang
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Gán dữ liệu cho repeater để hiển thị Loại hàng
            Repeater_LoaiHang.DataSource = Application["DanhSachLoaiHang"];
            Repeater_LoaiHang.DataBind();
            // Gán dữ liệu cho repeater để hiển thị danh sách mặt hàng   
            Repeater1.DataSource = Application["DanhSachMatHang"];
            Repeater1.DataBind();
        }
    }
}