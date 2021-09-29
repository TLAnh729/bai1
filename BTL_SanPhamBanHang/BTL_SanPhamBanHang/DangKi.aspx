<%@ Page Title="Đăng Kí" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DangKi.aspx.cs" Inherits="BTL_SanPhamBanHang.DangKi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/StyleSite/DangKi.css" rel="stylesheet" />
    <form runat="server">
        <div class="content">
            <div class="form_dangki">
                <div>
                    <h3>Đăng kí</h3>
                </div>
                <%-- Họ tên --%>
                <div class="name">
                    <label>Họ tên:</label>
                    <input type="text" name="Họ tên" />
                </div>
                <%-- Username --%>
                <div class="name">
                    <label>Username:</label>
                    <input type="text" name="Tên đăng nhập" />
                </div>
                <%-- Gmail --%>
                <div class="gmail">
                    <label>Gmail:</label>
                    <input type="text" name="Gmail" />
                </div>
                <%-- Số điện thoại --%>
                <div class="phonenumber">
                    <label>Số điện thoại:</label>
                    <input type="text" name="Số điện thoại" />
                </div>
                <%-- Mật khẩu --%>
                <div class="password">
                    <label>Mật khẩu:</label>
                    <input type="password" name="Mật khẩu" />
                </div>
                <div class="btn_DangKi">
                    <button type="submit" class="submit-button">Đăng Kí</button>
                </div>
            </div>

        </div>
    </form>
</asp:Content>

