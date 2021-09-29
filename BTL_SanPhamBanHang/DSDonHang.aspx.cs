using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_SanPhamBanHang
{
    public partial class DSDonHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = Application["DanhSachDonHang"];
            Repeater1.DataBind();

            Repeater2.DataSource = Session["GioHang"];
            Repeater2.DataBind();

            Session["GioHang"] = new List<SanPhamGioHang>();
        }
    }
}