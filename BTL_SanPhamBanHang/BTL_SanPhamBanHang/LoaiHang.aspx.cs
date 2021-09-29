using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_SanPhamBanHang
{
    public partial class LoaiHang1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Lấy lên danh sách mặt hàng theo loại hàng
            int loaiHang = Convert.ToInt32( Request.QueryString["loai"]);
            List<MatHang> dsLoaiHang = new List<MatHang>();
            foreach (MatHang item in (List<MatHang>) Application["DanhSachMatHang"])
            {
                if (item.IDLoaiHang == loaiHang)
                {
                    dsLoaiHang.Add(item);
                }
            }
            RepeaterMatHang.DataSource = dsLoaiHang;
            RepeaterMatHang.DataBind();

        }
    }
}