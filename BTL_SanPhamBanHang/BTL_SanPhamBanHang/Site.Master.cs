using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_SanPhamBanHang
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Lấy danh sách menu
            //ConnectDB connectDB = new ConnectDB();
            //rptMenu.DataSource = connectDB.LayLoaiHang();
            //rptMenu.DataBind();
            // Lấy danh sách sản phẩm nổi bật
            //string a = "like";
            //List<MatHang> dsTimKiem = (List<MatHang>)Session["KetQuaTimKiem"];
            //foreach (var item in (List<MatHang>)Application["DanhSachMatHang"])
            //{
            //    if (item.TenHang.Contains(a))
            //    {
            //        dsTimKiem.Add(item);
            //    }
            //}
            //Response.Redirect("KetQuaTimKiem.aspx");
        }

    }
}