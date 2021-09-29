using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_SanPhamBanHang
{
    public partial class DatHang : System.Web.UI.Page
    {
        decimal tongTien = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            // Load danh sách các mặt hàng đã có trong Sesion giỏ hàng
            RepeaterDatHang.DataSource = Session["GioHang"];
            RepeaterDatHang.DataBind();
            // Tính tổng tiền
            foreach (var item in (List<SanPhamGioHang>)Session["GioHang"])
            {
                tongTien = tongTien + item.ThanhTien;
            }
            LabelTongTien.Text = tongTien.ToString();
        }

        /// <summary>
        /// Nhấn nút đặt hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonDatHang_Click(object sender, EventArgs e)
        {
            // Tạo ra 1 đơn hàng và thêm vào Application DS đơn hàng
            DonHang donHang = new DonHang();
            donHang.DanhSachSanPham = (List<SanPhamGioHang>)Session["GioHang"];
            donHang.HoTen = TextBoxTen.Text;
            donHang.SoDienThoai = TextBoxSDT.Text;
            donHang.DiaChi = TextBoxDiaChi.Text;
            donHang.TongTien = tongTien;

            List<DonHang> dsDonHang = (List<DonHang>)Application["DanhSachDonHang"];
            dsDonHang.Add(donHang);
            // Xóa các sản phẩm đã đặt trong giỏ hàng đi
            //Session["GioHang"] = new List<SanPhamGioHang>();

            //Chuyển trang
            Response.Redirect("DSDonHang.aspx");

        }
    }
}