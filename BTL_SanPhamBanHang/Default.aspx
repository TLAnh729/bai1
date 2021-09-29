<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BTL_SanPhamBanHang._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/StyleSite/TrangChu.css" rel="stylesheet" />
    <!-- ===========BANNER============= -->
    <div class="banner">
    </div>
    <!-- ===========CONTENT============ -->
    <div class="content">
        <div class="title_mathang">
            <h2>MẶT HÀNG PHỔ BIẾN</h2>
        </div>
        <!-- Mặt hàng -->
        <div class="list_mathang">
            <!-- 3 Loại giày -->
            <div class="brand_shoes">
                <asp:Repeater ID="Repeater_LoaiHang" runat="server">
                    <ItemTemplate>
                        <div class="shoes">
                            <h3><%#Eval("TenLoaiHang") %></h3>
                            <a href="LoaiHang.aspx?loai=<%#Eval("ID") %>">
                                <img src="<%#Eval("TenAnhLoaiHang") %>" />
                            </a>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                              
                <%--<div class="shoes">
                    <h3>VALENTINO</h3>
                    <a href="#">
                        <img src="Content/Images/Valentino/Puma_8-White.svg" />
                    </a>
                </div>
                <div class="shoes">
                    <h3>LACOSTE</h3>
                    <a href="#">
                        <img src="Content/Images/Lacoste/Adidas_8-Black.svg" />
                    </a>
                </div>--%>
            </div>
            <hr>
            <!-- Danh sách giày nổi bật -->
            <div class="lish_brandshoes">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="sanpham_giay">
                            <img src="<%#Eval("TenAnh") %>" alt="" />
                            <h4><%#Eval("TenHang") %></h4>
                            <h5>Giá:<%#Eval("Gia") %>đ</h5>
                            <a href="ChiTiet.aspx?id=<%#Eval("ID") %>">Xem</a>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
        </div>
    </div>
</asp:Content>
