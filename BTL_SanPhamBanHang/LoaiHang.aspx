<%@ Page Title="NIKE" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoaiHang.aspx.cs" Inherits="BTL_SanPhamBanHang.LoaiHang1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/StyleSite/LoaiHang.css" rel="stylesheet" />
    <%--<form runat="server">--%>
        <div class="all-products-page-content">
            <div class="all-products">
                <%--<div class="all-products-heading">
                    <h2 id="all-products-brand-name" class="all-products-brand_name">Nike</h2>
                </div>--%>
                <%-- end all-products-heading --%>
                <div class="all-products-container">

                    <asp:Repeater ID="RepeaterMatHang" runat="server">
                        <ItemTemplate>

                            <div class="products__wrapper">
                                <a href="ChiTiet.aspx?id=<%#Eval("ID") %>">
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


                    <%-- end products__wrapper --%>

                    <%--<div class="products__wrapper">
                        <a href="products_infomation.aspx">
                            <img class="products__image" src="Content/Images/NIKE/Nike_2-White.svg" alt="Alternate Text" />
                        </a>
                        <div class="products_content">
                            <h3 class="products_name">Nike Air Force 1</h3>
                            <p class="products_price">
                                Giá: 2649000
                            <span class="products__price-unit">đ</span>
                            </p>
                            <a class="products_button" href="#">Chi Tiết</a>
                        </div>
                    </div>--%>

                    <%-- end products__wrapper --%>

                    <%--<div class="products__wrapper">
                        <a href="products_infomation.aspx">
                            <img class="products__image" src="Content/Images/NIKE/Nike_2-White.svg" alt="Alternate Text" />
                        </a>
                        <div class="products_content">
                            <h3 class="products_name">Nike Air Force 1</h3>
                            <p class="products_price">
                                Giá: 2649000
                            <span class="products__price-unit">đ</span>
                            </p>
                            <a class="products_button" href="#">Chi Tiết</a>
                        </div>
                    </div>--%>

                    <%-- end products__wrapper --%>


                    <%--<div class="products__wrapper">
                        <a href="products_infomation.aspx">
                            <img class="products__image" src="Content/Images/NIKE/Nike_2-White.svg" alt="Alternate Text" />
                        </a>
                        <div class="products_content">
                            <h3 class="products_name">Nike Air Force 1</h3>
                            <p class="products_price">
                                Giá: 2649000
                            <span class="products__price-unit">đ</span>
                            </p>
                            <a class="products_button" href="#">Chi Tiết</a>
                        </div>
                    </div>--%>

                    <%-- end products__wrapper --%>

                    <%--<div class="products__wrapper">
                        <a href="products_infomation.aspx">
                            <img class="products__image" src="Content/Images/NIKE/Nike_2-White.svg" alt="Alternate Text" />
                        </a>
                        <div class="products_content">
                            <h3 class="products_name">Nike Air Force 1</h3>
                            <p class="products_price">
                                Giá: 2649000
                            <span class="products__price-unit">đ</span>
                            </p>
                            <a class="products_button" href="#">Chi Tiết</a>
                        </div>
                    </div>--%>

                    <%-- end products__wrapper --%>

                    <%-- <div class="products__wrapper">
                        <a href="products_infomation.aspx">
                            <img class="products__image" src="Content/Images/NIKE/Nike_2-White.svg" alt="Alternate Text" />
                        </a>
                        <div class="products_content">
                            <h3 class="products_name">Nike Air Force 1</h3>
                            <p class="products_price">
                                Giá: 2649000
                            <span class="products__price-unit">đ</span>
                            </p>
                            <a class="products_button" href="#">Chi Tiết</a>
                        </div>
                    </div>--%>

                    <%-- end products__wrapper --%>

                    <%--<div class="products__wrapper">
                        <a href="products_infomation.aspx">
                            <img class="products__image" src="Content/Images/NIKE/Nike_2-White.svg" alt="Alternate Text" />
                        </a>
                        <div class="products_content">
                            <h3 class="products_name">Nike Air Force 1</h3>
                            <p class="products_price">
                                Giá: 2649000
                            <span class="products__price-unit">đ</span>
                            </p>
                            <a class="products_button" href="#">Chi Tiết</a>
                        </div>
                    </div>--%>

                    <%-- end products__wrapper --%>


                    <%--<div class="products__wrapper">
                        <a href="products_infomation.aspx">
                            <img class="products__image" src="Content/Images/NIKE/Nike_2-White.svg" alt="Alternate Text" />
                        </a>
                        <div class="products_content">
                            <h3 class="products_name">Nike Air Force 1</h3>
                            <p class="products_price">
                                Giá: 2649000
                            <span class="products__price-unit">đ</span>
                            </p>
                            <a class="products_button" href="#">Chi Tiết</a>
                        </div>
                    </div>--%>


                    <%-- end products__wrapper --%>

                    <%--<div class="products__wrapper">
                        <a href="products_infomation.aspx">
                            <img class="products__image" src="Content/Images/NIKE/Nike_2-White.svg" alt="Alternate Text" />
                        </a>
                        <div class="products_content">
                            <h3 class="products_name">Nike Air Force 1</h3>
                            <p class="products_price">
                                Giá: 2649000
                            <span class="products__price-unit">đ</span>
                            </p>
                            <a class="products_button" href="#">Chi Tiết</a>
                        </div>
                    </div>--%>

                    <%-- end products__wrapper --%>

                    <%--<div class="products__wrapper">
                        <a href="products_infomation.aspx">
                            <img class="products__image" src="Content/Images/NIKE/Nike_2-White.svg" alt="Alternate Text" />
                        </a>
                        <div class="products_content">
                            <h3 class="products_name">Nike Air Force 1</h3>
                            <p class="products_price">
                                Giá: 2649000
                            <span class="products__price-unit">đ</span>
                            </p>
                            <a class="products_button" href="#">Chi Tiết</a>
                        </div>
                    </div>--%>

                    <%-- end products__wrapper --%>

                    <%-- <div class="products__wrapper">
                        <a href="products_infomation.aspx">
                            <img class="products__image" src="Content/Images/NIKE/Nike_2-White.svg" alt="Alternate Text" />
                        </a>
                        <div class="products_content">
                            <h3 class="products_name">Nike Air Force 1</h3>
                            <p class="products_price">
                                Giá: 2649000
                            <span class="products__price-unit">đ</span>
                            </p>
                            <a class="products_button" href="#">Chi Tiết</a>
                        </div>
                    </div>--%>

                    <%-- end products__wrapper --%>


                    <%--<div class="products__wrapper">
                        <a href="products_infomation.aspx">
                            <img class="products__image" src="Content/Images/NIKE/Nike_2-White.svg" alt="Alternate Text" />
                        </a>
                        <div class="products_content">
                            <h3 class="products_name">Nike Air Force 1</h3>
                            <p class="products_price">
                                Giá: 2649000
                            <span class="products__price-unit">đ</span>
                            </p>
                            <a class="products_button" href="#">Chi Tiết</a>
                        </div>
                    </div>--%>

                    <%-- end products__wrapper --%>

                    <%--<div class="products__wrapper">
                        <a href="products_infomation.aspx">
                            <img class="products__image" src="Content/Images/NIKE/Nike_2-White.svg" alt="Alternate Text" />
                        </a>
                        <div class="products_content">
                            <h3 class="products_name">Nike Air Force 1</h3>
                            <p class="products_price">
                                Giá: 2649000
                            <span class="products__price-unit">đ</span>
                            </p>
                            <a class="products_button" href="#">Chi Tiết</a>
                        </div>
                    </div>--%>

                    <%-- end products__wrapper --%>

                    <%--<div class="products__wrapper">
                        <a href="products_infomation.aspx">
                            <img class="products__image" src="Content/Images/NIKE/Nike_2-White.svg" alt="Alternate Text" />
                        </a>
                        <div class="products_content">
                            <h3 class="products_name">Nike Air Force 1</h3>
                            <p class="products_price">
                                Giá: 2649000
                            <span class="products__price-unit">đ</span>
                            </p>
                            <a class="products_button" href="#">Chi Tiết</a>
                        </div>
                    </div>--%>

                    <%-- end products__wrapper --%>

                    <%--<div class="products__wrapper">
                        <a href="products_infomation.aspx">
                            <img class="products__image" src="Content/Images/NIKE/Nike_2-White.svg" alt="Alternate Text" />
                        </a>
                        <div class="products_content">
                            <h3 class="products_name">Nike Air Force 1</h3>
                            <p class="products_price">
                                Giá: 2649000
                            <span class="products__price-unit">đ</span>
                            </p>
                            <a class="products_button" href="#">Chi Tiết</a>
                        </div>
                    </div>--%>

                    <%-- end products__wrapper --%>


                    <%--<div class="products__wrapper">
                        <a href="products_infomation.aspx">
                            <img class="products__image" src="Content/Images/NIKE/Nike_2-White.svg" alt="Alternate Text" />
                        </a>
                        <div class="products_content">
                            <h3 class="products_name">Nike Air Force 1</h3>
                            <p class="products_price">
                                Giá: 2649000
                            <span class="products__price-unit">đ</span>
                            </p>
                            <a class="products_button" href="#">Chi Tiết</a>
                        </div>
                    </div>--%>


                    <%-- end products__wrapper --%>
                </div>
                <%-- end all-products-container --%>
            </div>
            <%-- end all-products-heading --%>
        </div>
        <%-- end all-products-page-content --%>
    <%--</form>--%>
</asp:Content>
