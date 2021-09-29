<%@ Page Title="Đăng Nhập" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="BTL_SanPhamBanHang.DangNhap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/StyleSite/DangNhap.css" rel="stylesheet" />
    <form runat="server">
        <div class="content">
            <div class="form_dangnhap">
                <div class="dangnhap">
                    <h3>Đăng nhập</h3>
                </div>

                <%-- tên đăng nhập --%>
                <div class="username">
                    <label>Số điện thoại:</label>
                    <input type="text" name="Số điện thoại" />
                </div>

                <%-- mật khẩu --%>
                <div class="password">
                    <label>Mật khẩu:</label>
                    <input type="text" name="Mật Khẩu" />
                </div>

                <%-- btn --%>
                <div class="btn_DangNhap">
                    <button type="submit" class="submit-button">Đăng nhập</button>
                </div>
            </div>

        </div>
    </form>
</asp:Content>

