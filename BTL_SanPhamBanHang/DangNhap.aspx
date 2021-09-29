<%@ Page Title="Đăng ký" Language="C#" AutoEventWireup="true" CodeBehind="~/DangNhap.aspx.cs" Inherits="BTL_SanPhamBanHang.DangNhap" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <%--<title><%: Page.Title %> - My ASP.NET Application</title>--%>
    <%--<asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>
    <webopt:BundleReference runat="server" Path="~/Content/css" />--%>
    <title>Đăng nhập</title>
    <script src="Scripts/modernizr-2.8.3.js"></script>
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link href="Content/StyleSite/font-awesome.min.css" rel="stylesheet" />
    <link href="Content/StyleSite/HeaderFooter.css" rel="stylesheet" />
    <link href="Content/StyleSite/DangNhap.css" rel="stylesheet" />

</head>
<body>
    <%-- Header--%>
    <div class="header">
        <div class="class_logo">
            <a href="Default.aspx">
                <img class="logo" src="Content/Images/icons/logo_2.png" />
            </a>
        </div>
        <div class="class_menu">
            <a runat="server" href="~/About">Giới thiệu</a>
            <a runat="server" href="LoaiHang.aspx?loai=1">NIKE</a>
            <a runat="server" href="LoaiHang.aspx?loai=2">VALENTINO</a>
            <a runat="server" href="LoaiHang.aspx?loai=3">LACOSTE</a>
            <%--<asp:Repeater ID="rptMenu" runat="server">
                <ItemTemplate>
                    <a href="LoaiHang.aspx?loai=<%#Eval("ID") %>"><%#Eval("TenLoaiHang") %></a>
                </ItemTemplate>
            </asp:Repeater>--%>
        </div>
        <div class="class_search">
            <%--<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Tìm kiếm" OnClick="Button1_Click" />
                <%--<input type="text" placeholder="Tìm kiếm..." name="search2" autocomplete="off">
            <button type="submit"><i class="fa fa-search"></i></button>--%>
        </div>
        <div class="class_giohang">
            <a href="DatHang.aspx" id="giohang">
                <img src="Content/Images/icons/full-shopping-cart.svg" class="img_giohang" />
            </a>
        </div>
        <div class="class_account">
            <a href="DangNhap.aspx" id="dangnhap">Đăng nhập</a>
            <a href="DangKi.aspx" id="dangky">Đăng ký</a>
        </div>
    </div>
    <form class="login-form" method="post" style="text-align:center">
        <div class="content">
            <div class="form_dangnhap">
                <div class="dangnhap">
                    <h3>Đăng nhập</h3>
                </div>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                <%-- tên đăng nhập --%>
                <div class="sign-in-username">
                    <label>Gmail *:</label>
                    <input type="text" name="Email" class="input" id="input-email" placeholder="Email"/>
                </div>

                <%-- mật khẩu --%>
                <div class="sign-in-password">
                    <label>Mật khẩu:</label>
                    <input type="password" name="Password" class="input" id="input-password" placeholder="Mật khẩu"/>
                </div>

                <%-- btn --%>
                <div class="sign-in-submit">
                    <button type="submit" class="submit-button">Đăng nhập</button>
                </div>
            </div>

        </div>
    </form>
    
    <script type="text/javascript">
        function check() {
            // Khi nhất đăng ký thì kiểm tra dữ liệu. Nếu thỏa mãn hết điều kiện thì trả về true. Ngược lại thì thông báo dữ liệu bị sai và trả về false

            var email = document.getElementById("input-email").value;
            var name = document.getElementById("input-fullname").value;
            var pass = document.getElementById("input-password").value;
            var passNhapLai = document.getElementById("input-repassword").value;
            // Gmail không được trống
            if (email == '') {
                alert('Email không được bỏ trống');
                event.preventDefault(); // Ngăn chặn sự kiện submit form để không gửi request lên
            }
            else if (name == '') {
                // Họ tên không được trống
                alert('Họ tên không được bỏ trống');
                event.preventDefault();
            } else if (pass == '') {
                // Password không được trống
                alert('Passsword không được bỏ trống, phải có ít nhất 8 ký tự, phải có chữ hoa và chữ thường');
                event.preventDefault();
            } else if (passNhapLai != pass) {
                // Mật khẩu lặp lại phải = mật khẩu
                alert('Mật khẩu lặp lại phải giống mật khẩu');
                event.preventDefault();
            }
        }
    </script>
    <%-- Footer--%>
    <div class="footer">
        <div class="information">
            <div class="logo_footer">
                <img class="logo" src="Content/Images/icons/logo_2.png" />
            </div>
            <div class="sanpham">
                <div><a href="#" id="nike_footer">NIKE</a></div>
                <div><a href="#" id="valentino_footer">VALENTINO</a></div>
                <div><a href="#" id="lacoste_footer">LACOSTE</a></div>
            </div>
            <div class="diachi">
                <p>Chi nhánh 1: 96 - Định Công - Hà Nội</p>
                <br />
                <p>Chi nhánh 2: 20 - Đống Đa - Hà Nội</p>
                <br />
                <p>Chi nhánh 3: 73 - Hoàn Kiếm - Hà Nội</p>
            </div>
            <div class="lienhe">
                <p>Số điện thoại: 0971973954</p>
                <p>Email: runningshoes@gmail.com</p>
            </div>
        </div>
        <div class="copyright">
            <p>2021 RUNNING SHOES VIET NAM.ALL RIGHTS RESERVED</p>
        </div>
    </div>
</body>
</html>
