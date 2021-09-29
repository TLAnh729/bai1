<%@ Page Title="Chi Tiết Sản Phẩm" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChiTiet.aspx.cs" Inherits="BTL_SanPhamBanHang.ChiTiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/StyleSite/ChiTiet.css" rel="stylesheet" />
    <form runat="server">
        <div class="content">

            <%-- Thông tin đặt hàng --%>
            <div class="ThemHang">
                <%-- Ảnh sản phẩm --%>
                <asp:ListView ID="ListViewAnh" runat="server">
                    <ItemTemplate>
                        <div class="img_themgiay">
                            <img src="<%#Eval("TenAnh")%>" />
                        </div>
                    </ItemTemplate>
                </asp:ListView>
                <%-- Thông tin --%>
                <div class="text_themgiay">

                    <asp:ListView ID="ListViewSanPham" runat="server">
                        <ItemTemplate>
                            <h3><%#Eval("TenHang")%></h3>
                            <h2><%#Eval("Gia")%><span>đ</span></h2>
                        </ItemTemplate>
                    </asp:ListView>

                    <div class="size_giay">
                        <label>Chọn Size</label>
                        <div>
                            <%-- Danh sách size sản phẩm --%>
                            <asp:RadioButtonList ID="RadioButtonListSize" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" DataValueField="TenSize">
                            </asp:RadioButtonList>

                        </div>
                    </div>
                    <div>
                        <label>Số lượng</label>
                        <div class="soluong">
                            <asp:TextBox ID="TextBoxSoLuong" runat="server" TextMode="Number" value="1"></asp:TextBox>
                        </div>
                    </div>
                    <div class="btn_themhang">
                        <asp:Button ID="btnThemGiaHang" runat="server" Text="Thêm vào giỏ hàng" OnClick="btnThemGiaHang_Click" />
                        <asp:Button ID="btnMuaNgay" runat="server" Text="Mua ngay" OnClick="btnMuaNgay_Click" />
                    </div>
                </div>
            </div>
            <%-- Thông tin sản phẩm --%>
            <asp:ListView ID="ListViewThongTin" runat="server">
                <ItemTemplate>
                    <div class="ThongTin">
                        <h3>THÔNG TIN CHI TIẾT</h3>
                        <div>
                            <div class="ThongTin_ChiTiet">
                                <label>Thương hiệu</label>
                                <div><%#Eval("ThuongHieu")%></div>
                            </div>
                            <div class="ThongTin_ChiTiet">
                                <label>Xuất xứ</label>
                                <div>Hàn Quốc</div>
                            </div>
                            <div class="ThongTin_ChiTiet">
                                <label>Model</label>
                                <div>Jack2001</div>
                            </div>
                            <div class="ThongTin_ChiTiet">
                                <label>SUK</label>
                                <div>7496532604886</div>
                            </div>
                        </div>
                    </div>
                    <%-- Mô tả sản phẩm --%>
                    <div class="MoTa">
                        <h3>MÔ TẢ SẢN PHẨM</h3>
                        <div>
                            <%#Eval("MoTa")%>
                        </div>
                        <div>
                            Cổ vớ ôm sát cổ chân trong quá trình chuyển động<br />
                            Đế lót kháng khuẩn, mềm mại, co dãn và thoáng khí tối đa<br />
                            Mũ quai phong cách layer độc đáo và cá tính.<br />
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </form>
</asp:Content>
