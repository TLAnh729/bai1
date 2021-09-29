<%@ Page Title="Chi Tiết Sản Phẩm" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="KetQuaTimKiem.aspx.cs" Inherits="BTL_SanPhamBanHang.KetQuaTimKiem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/StyleSite/LoaiHang.css" rel="stylesheet" />

    <div class="all-products-page-content">
        <div class="all-products">
            <div class="all-products-container">

                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="products__wrapper">
                            <a href="products_infomation.aspx">
                                <img class="products__image" src="<%#Eval("TenAnh") %>" alt="Alternate Text" />
                            </a>
                            <div class="products_content">
                                <h3 class="products_name"><%#Eval("TenHang") %></h3>
                                <p class="products_price">
                                    <%#Eval("Gia") %>
                                    <span class="products__price-unit">đ</span>
                                </p>
                                <a class="products_button" href="ChiTiet.aspx?id=<%#Eval("ID") %>">Chi Tiết</a>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
        </div>
    </div>
</asp:Content>
