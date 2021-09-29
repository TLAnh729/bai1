using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_SanPhamBanHang
{
    public partial class ChiTiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Chỉ load dữ liệu lần đầu khi vào trang web. Nếu là postback thì ko load lại
            if (!IsPostBack)
            {
                // Lấy ra thông tin của sản phẩm theo ID muốn xem
                int id = Convert.ToInt32(Request.QueryString["id"]);
                List<MatHang> matHang = new List<MatHang>();
                foreach (MatHang item in (List<MatHang>)Application["DanhSachMatHang"])
                {
                    if (item.ID == id)
                    {
                        matHang.Add(item);
                    }
                }
                // Thông tin ảnh
                ListViewAnh.DataSource = matHang;
                ListViewAnh.DataBind();

                // Thông tin sản phẩm (Giá, tên,...)
                ListViewSanPham.DataSource = matHang;
                ListViewSanPham.DataBind();

                // Thông tin size
                if (matHang.Count > 0)
                {
                    RadioButtonListSize.DataSource = matHang[0].Size;
                    RadioButtonListSize.DataBind();
                }

                // Gán dữ liệu cho mục thông tin sản phẩm
                ListViewThongTin.DataSource = matHang;
                ListViewThongTin.DataBind();
            }
        }

        /// <summary>
        /// Nhấn nút mua ngay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnMuaNgay_Click(object sender, EventArgs e)
        {
            DatHang();
            Response.Redirect("DatHang.aspx");
        }

        /// <summary>
        /// Nhấn nút thêm vào giỏ hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnThemGiaHang_Click(object sender, EventArgs e)
        {
            DatHang();
        }

        public void DatHang()
        {
            // Lấy ra sản phẩm muốn mua kèm số lượng, size, tính thành tiền để đưa vào giỏ hàng
            // Lấy sản phẩm
            int id = Convert.ToInt32(Request.QueryString["id"]);
            SanPhamGioHang sp = new SanPhamGioHang(); // Thông tin sẽ thêm vào gio hang

            foreach (MatHang item in (List<MatHang>)Application["DanhSachMatHang"])
            {
                if (item.ID == id)
                {
                    sp.MatHang = item;
                }
            }
            // Lấy số lượng
            sp.SoLuong = Convert.ToInt32(TextBoxSoLuong.Text);
            // Lấy size
            sp.Size = RadioButtonListSize.SelectedValue;
            sp.ThanhTien = Convert.ToDecimal(sp.SoLuong * sp.MatHang.Gia);
            // Thêm vào giỏ hàng
            List<SanPhamGioHang> sanPhamGioHangs = (List<SanPhamGioHang>)Session["GioHang"];
            sanPhamGioHangs.Add(sp);

            // Xem trong giỏ hàng có sp với size tương ứng hay chưa. Nếu có rồi thì tăng số lượng và tính lại thành tiền, chưa có thì add
            string size = RadioButtonListSize.SelectedValue;
            SanPhamGioHang spDaCo = null;
            foreach (var item in (List<SanPhamGioHang>)Session["GioHang"])
            {
                if (item.MatHang.ID == id && item.Size == size)
                {
                    spDaCo = item;
                }
            }
            // Nếu đã có rồi
            if (spDaCo != null)
            {
                //spDaCo.SoLuong += Convert.ToInt32(TextBoxSoLuong.Text);
                //spDaCo.ThanhTien = Convert.ToDecimal(spDaCo.SoLuong * spDaCo.MatHang.Gia);
            }
            else
            {
                //foreach (MatHang item in (List<MatHang>)Application["DanhSachMatHang"])
                //{
                //    if (item.ID == id)
                //    {
                //        sp.MatHang = item;
                //    }
                //}
                //// Lấy số lượng
                //sp.SoLuong = Convert.ToInt32(TextBoxSoLuong.Text);
                //// Lấy size
                //sp.Size = RadioButtonListSize.SelectedValue;
                //sp.ThanhTien = Convert.ToDecimal(sp.SoLuong * sp.MatHang.Gia);
                //// Thêm vào giỏ hàng
                //List<SanPhamGioHang> sanPhamGioHangs = (List<SanPhamGioHang>)Session["GioHang"];
                //sanPhamGioHangs.Add(sp);
            }
        }


    }
}