using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
            // Style primaryStyle = new Style();
            //primaryStyle.BackColor = Color.Black;
            //Button1.ApplyStyle(primaryStyle);
    }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Lấy danh sách sản phẩm nổi bật
            string a = TextBox1.Text;
            Session["KetQuaTimKiem"] = new List<MatHang>(); // Xóa những kết quả cũ đi
            List<MatHang> dsTimKiem = (List<MatHang>)Session["KetQuaTimKiem"];
            foreach (MatHang item in (List<MatHang>)Application["DanhSachMatHang"])
            {
                if (item.TenHang.Contains(a))
                {
                    dsTimKiem.Add(item);
                }
            }
            Response.Redirect("KetQuaTimKiem.aspx");
        }
    }
}