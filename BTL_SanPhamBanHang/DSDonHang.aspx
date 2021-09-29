<%@ Page Title="Danh sách đơn hàng" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DSDonHang.aspx.cs" Inherits="BTL_SanPhamBanHang.DSDonHang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/StyleSite/DSDonHang.css" rel="stylesheet"/>
    <div class="content">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div  class="ThongTinKhachHang">
                    <label>Họ tên:</label>
                    <p><%#Eval("HoTen") %></p>
                    <label>Số điện thoại:</label>
                    <p><%#Eval("SoDienThoai") %></p>
                    <label>Địa chỉ:</label>
                    <p><%#Eval("DiaChi") %></p>
                    <label>Tổng tiền:</label>
                    <p><%#Eval("TongTien") %></p>
                </div>
            </ItemTemplate>
        </asp:Repeater>

        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
                <%-- Thông tin sản phẩm --%>
                <div class="ThongTinSanPham">
                    <label>Tên hàng:</label>
                    <p><%#Eval("MatHang.TenHang") %></p>
                    <label>Size:</label>
                    <p><%#Eval("Size") %></p>
                    <label>Thành tiền:</label>
                    <p><%#Eval("ThanhTien") %></p>
                    <label>Số lượng:</label>
                    <p><%#Eval("SoLuong") %></p>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>

