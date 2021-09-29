using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_SanPhamBanHang
{
    public partial class DangKi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ form đăng ký vào thêm vào danh sách tài khoản
            string Hoten = Request.Params["Hoten"];
            string Sdt = Request.Params["Sdt"];
            string Password = Request.Params["Password"];
            string Email = Request.Params["Email"];
            if (Hoten != null && Sdt != null && Password != null && Email != null)
            {
                List<TaiKhoan> dsTaiKhoan = (List<TaiKhoan>)Application["DanhSachTaiKhoan"];
                TaiKhoan taiKhoan = new TaiKhoan(Hoten, Sdt, Email, Password);
                dsTaiKhoan.Add(taiKhoan);
                Response.Redirect("DangNhap.aspx");
            }


            //loi.Text = "";
        }
        protected void btndangky_click(object sender, EventArgs e)
        {
            //if (Request.Form["input-fullname"] != null)
            //{
            //    string name = Request.Form["input-fullname"];
            //    string phonenumber = Request.Form["input-phonenumber"];
            //    string email = Request.Form["input-email"];
            //    string password = Request.Form["input-password"];
            //    string repassword = Request.Form["input-repassword"];
            //    User user = new User(name, phonenumber, email, password, repassword);
            //    List<User> arr = (List<User>)Application["user"];
            //    if (password != repassword)
            //    {
            //        loi.Text = "Mật khẩu và xác nhận mật khẩu không giống nhau!";
            //        return;
            //    }
            //    int tg = 0;
            //    if (arr.Count == 0)
            //    {
            //        arr = new List<User>();
            //    }
            //    else
            //    {
            //        foreach (User u in arr)
            //        {
            //            if (u.email != email)
            //            {

            //            }
            //            else
            //            {
            //                loi.Text = "Email đã tồn tại. Vui lòng nhập email khác !";
            //                tg = 1;
            //            }
            //        }
            //    }
            //    if (tg == 1)
            //    {

            //    }
            //    else
            //    {
            //        arr.Add(user);
            //        Application["user"] = arr;
            //        Session["login"] = 1;
            //        Session["name"] = name;
            //        Session["email"] = email;

            //        loi.Text = "Đăng kí thành công !";
            //        Response.Redirect("~/default.aspx");
            //    }
            //}
        }
    }
}