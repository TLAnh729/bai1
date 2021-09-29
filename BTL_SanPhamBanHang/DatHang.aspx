<%@ Page Title="Đặt hàng" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DatHang.aspx.cs" Inherits="BTL_SanPhamBanHang.DatHang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/StyleSite/DatHang.css" rel="stylesheet" />
    <%--<form runat="server" style="height:100%;">--%>
        <div class="content">
            <h3>Giỏ Hàng</h3>
            <asp:Repeater ID="RepeaterDatHang" runat="server">
                <ItemTemplate>
                    <div class="GioHang">
                        <div class="img_giay">
                            <img src="<%#Eval("MatHang.TenAnh")%>" />
                        </div>
                        <div class="thongtin_giay">
                            <h4><%#Eval("MatHang.TenHang")%></h4>
                            <p>Giày thể thao</p>
                            <a href="XuLyGioHang.aspx?idxoa=<%#Eval("MatHang.ID")%>"><i>Xóa khỏi giỏ hàng</i></a>
                            <a href="ChiTiet.aspx?id=<%#Eval("MatHang.ID")%>"><i>Chi tiết</i></a>
                        </div>
                    </div>
                    <div class="DonHang">
                        <div>
                            <p>Đơn giá:</p>
                            <p><%#Eval("MatHang.Gia")%><span>đ</span></p>
                        </div>
                        <div>
                            <p>Số lượng:</p>
                            <p><%#Eval("SoLuong")%></p>
                        </div>
                        <div>
                            <p>Size:</p>
                            <p><%#Eval("Size")%></p>
                        </div>
                        <hr />
                        <div>
                            <p>Thành tiền:</p>
                            <p><%#Eval("ThanhTien")%><span>đ</span></p>
                        </div>
                    </div>
                    <hr />
                </ItemTemplate>
            </asp:Repeater>
            <div>
                <div class="tongtien">
                    <p>Tổng tiền:</p>
                    <asp:Label ID="LabelTongTien" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="">
                    <p>Họ và tên</p>
                    <asp:TextBox ID="TextBoxTen" runat="server"></asp:TextBox>
                    <p>Số điện thoại</p>
                    <asp:TextBox ID="TextBoxSDT" runat="server"></asp:TextBox>
                    <p>Địa chỉ</p>
                    <asp:TextBox ID="TextBoxDiaChi" runat="server"></asp:TextBox>
                </div>
                
                <div class="dathang">
                    <asp:Button ID="ButtonDatHang" CssClass="btnDatHang" runat="server" Text="Đặt hàng" OnClick="ButtonDatHang_Click" />
                </div>
            </div>
        </div>
    <%--</form>--%>
</asp:Content>

