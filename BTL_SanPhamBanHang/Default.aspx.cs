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
            List<MatHang> ds = new List<MatHang>();
            List<MatHang> a = (List<MatHang>)Application["DanhSachMatHang"];
            for (int i = 0; i < a.Count; i++)
            {
                if (i < 12)
                {
                    ds.Add(a[i]);
                }
            }
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }
    }
}