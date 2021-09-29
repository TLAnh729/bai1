using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_SanPhamBanHang
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Lấy thông tin gửi lên để đăng nhập
            string Email = Request.Params["Email"];
            string Password = Request.Params["Password"];
            if (Email != null && Password != null)
            {
                // Nếu danh sách TK có tài khoản trùng Email và Password thì có nghĩa là đăng nhập thành công
                bool thanhCong = false;
                foreach (var item in (List<TaiKhoan>)Application["DanhSachTaiKhoan"])
                {
                    if (Email == item.Email && Password == item.MatKhau)
                    {
                        thanhCong = true;
                    }
                }
                if (thanhCong == false)
                {
                    Response.Write(@"<script language='javascript'>alert('Tài khoản không đúng')</script>");
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
            }

        }
    }
}