using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace BTL_SanPhamBanHang
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Danh sách loại hàng
            List<LoaiHang> dsLoaiHang = new List<LoaiHang>();
            LoaiHang loaihang1 = new LoaiHang(1, "NIKE", "Content/Images/NIKE/Nike_1-White.svg");
            LoaiHang loaihang2 = new LoaiHang(2, "VALENTINO", "Content/Images/Valentino/Valentino_1-White.svg");
            LoaiHang loaihang3 = new LoaiHang(3, "LACOSTE", "Content/Images/Lacoste/Lacoste_1-Black.svg");
            dsLoaiHang.Add(loaihang1);
            dsLoaiHang.Add(loaihang2);
            dsLoaiHang.Add(loaihang3);
            Application["DanhSachLoaiHang"] = dsLoaiHang;

            // Tạo ra sẵn 1 danh sách sản phẩm phục vụ cho ứng dụng
            List<MatHang> dsMatHang = new List<MatHang>();
            //Hàng Nike
            MatHang mathang1 = new MatHang(1, 1, "Nike Air Force 1 '07", 2000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/NIKE/Nike_1-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2,"38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang1);
            MatHang mathang2 = new MatHang(2, 1, "Nike Blazer Mid '77 Vintage", 2000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/NIKE/Nike_1-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang2);
            MatHang mathang3 = new MatHang(3, 1, "Nike Air Force 1 '07 LV8", 2500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/NIKE/Nike_1-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang3);
            MatHang mathang4 = new MatHang(4, 1, "Nike Air Zoom SuperRep 2", 3000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_2-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang4);
            MatHang mathang5 = new MatHang(5, 1, "Nike Air Force 1 '07", 2600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_2-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang5);
            MatHang mathang6 = new MatHang(6, 1, "Nike Air Force 1 '07", 1900000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_2-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang6);
            MatHang mathang7 = new MatHang(7, 1, "Nike Air Force 1 '07", 3600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_3-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang7);
            MatHang mathang8 = new MatHang(8, 1, "Nike Blazer Mid '77 Vintage", 600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_3-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang8);

            MatHang mathang9 = new MatHang(9, 1, "Nike Air Force 1 '07", 2600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_3-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang9);
            MatHang mathang10 = new MatHang(10, 1, "Nike Air Force 1 '07", 1900000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_4-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang10);
            MatHang mathang11 = new MatHang(11, 1, "Nike Air Force 1 '07", 3600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_18-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang11);
            MatHang mathang12 = new MatHang(12, 1, "Nike Blazer Mid '77 Vintage", 600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_4-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang12);

            MatHang mathang13 = new MatHang(13, 1, "Nike Air Force 1 '07", 2600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_5-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang13);
            MatHang mathang14 = new MatHang(14, 1, "Nike Air Force 1 '07", 1900000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_5-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang14);
            MatHang mathang15 = new MatHang(15, 1, "Nike Air Force 1 '07", 3600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_5-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang15);
            MatHang mathang16 = new MatHang(16, 1, "Nike Blazer Mid '77 Vintage", 600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_6-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang16);

            MatHang mathang17 = new MatHang(17, 1, "Nike Air Force 1 '07", 2600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_6-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang17);
            MatHang mathang18 = new MatHang(18, 1, "Nike Air Force 1 '07", 1900000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_19-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang18);
            MatHang mathang19 = new MatHang(19, 1, "Nike Air Force 1 '07", 3600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_7-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang19);
            MatHang mathang20 = new MatHang(20, 1, "Nike Blazer Mid '77 Vintage", 600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_7-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang20);

            MatHang mathang21 = new MatHang(21, 1, "Nike Air Force 1 '07", 2600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_7-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang21);
            MatHang mathang22 = new MatHang(22, 1, "Nike Air Force 1 '07", 1900000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_8-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang22);
            MatHang mathang23 = new MatHang(23, 1, "Nike Air Force 1 '07", 3600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_8-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang23);
            MatHang mathang24 = new MatHang(24, 1, "Nike Blazer Mid '77 Vintage", 600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_8-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang24);

            MatHang mathang25 = new MatHang(25, 1, "Nike Air Force 1 '07", 2600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_9-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang25);
            MatHang mathang26 = new MatHang(26, 1, "Nike Air Force 1 '07", 1900000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_9-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang26);
            MatHang mathang27 = new MatHang(27, 1, "Nike Air Force 1 '07", 3600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_9-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang27);
            MatHang mathang28 = new MatHang(28, 1, "Nike Blazer Mid '77 Vintage", 600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_10-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang28);

            MatHang mathang29 = new MatHang(29, 1, "Nike Air Force 1 '07", 2600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_10-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang29);
            MatHang mathang30 = new MatHang(30, 1, "Nike Air Force 1 '07", 1900000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_10-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang30);
            MatHang mathang31 = new MatHang(31, 1, "Nike Air Force 1 '07", 3600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_11-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang31);
            MatHang mathang32 = new MatHang(32, 1, "Nike Blazer Mid '77 Vintage", 600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_11-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang32);

            MatHang mathang33 = new MatHang(33, 1, "Nike Air Force 1 '07", 2600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_12-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang33);
            MatHang mathang34 = new MatHang(34, 1, "Nike Air Force 1 '07", 1900000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_12-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang34);
            MatHang mathang35 = new MatHang(35, 1, "Nike Air Force 1 '07", 3600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_12-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang35);
            MatHang mathang36 = new MatHang(36, 1, "Nike Blazer Mid '77 Vintage", 600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_13-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang36);

            MatHang mathang37 = new MatHang(37, 1, "Nike Air Force 1 '07", 2600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_13-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang37);
            MatHang mathang38 = new MatHang(38, 1, "Nike Air Force 1 '07", 1900000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_13-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang38);
            MatHang mathang39 = new MatHang(39, 1, "Nike Air Force 1 '07", 3600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_14-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang39);
            MatHang mathang40 = new MatHang(40, 1, "Nike Blazer Mid '77 Vintage", 600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_14-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mathang40);

            //Hàng Valentino
            MatHang mathang41 = new MatHang(41, 2, "Suede Classic+ Sneakers", 3000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_20-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38") }, "KT");
            dsMatHang.Add(mathang41);
            MatHang mathang42 = new MatHang(42, 2, "Suede Classic+ Sneakers", 2500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_20-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "39") }, "KT");
            dsMatHang.Add(mathang42);
            MatHang mathang43 = new MatHang(43, 2, "Clyde Core Foil Sneakers", 1500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_20-Black.svg", new List<Size>() { new Size(1, "39"), new Size(2, "40") }, "KT");
            dsMatHang.Add(mathang43);
            MatHang mathang44 = new MatHang(44, 2, "Speedcat LS Motorsport", 2700000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_19-White.svg", new List<Size>() { new Size(1, "38"), new Size(2, "41") }, "KT");
            dsMatHang.Add(mathang44);

            MatHang mathang45 = new MatHang(45, 2, "Suede Classic+ Sneakers", 3000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_19-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38") }, "KT");
            dsMatHang.Add(mathang45);
            MatHang mathang46 = new MatHang(46, 2, "Suede Classic+ Sneakers", 2500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_19-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "39") }, "KT");
            dsMatHang.Add(mathang46);
            MatHang mathang47 = new MatHang(47, 2, "Clyde Core Foil Sneakers", 1500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_18-White.svg", new List<Size>() { new Size(1, "39"), new Size(2, "40") }, "KT");
            dsMatHang.Add(mathang47);
            MatHang mathang48 = new MatHang(48, 2, "Speedcat LS Motorsport", 2700000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_18-Black.svg", new List<Size>() { new Size(1, "38"), new Size(2, "41") }, "KT");
            dsMatHang.Add(mathang48);

            MatHang mathang49 = new MatHang(49, 2, "Suede Classic+ Sneakers", 3000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_18-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38") }, "KT");
            dsMatHang.Add(mathang49);
            MatHang mathang50 = new MatHang(50, 2, "Suede Classic+ Sneakers", 2500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_17-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "39") }, "KT");
            dsMatHang.Add(mathang50);
            MatHang mathang51 = new MatHang(51, 2, "Clyde Core Foil Sneakers", 1500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_17-White.svg", new List<Size>() { new Size(1, "39"), new Size(2, "40") }, "KT");
            dsMatHang.Add(mathang51);
            MatHang mathang52 = new MatHang(52, 2, "Speedcat LS Motorsport", 2700000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_17-Red.svg", new List<Size>() { new Size(1, "38"), new Size(2, "41") }, "KT");
            dsMatHang.Add(mathang52);

            MatHang mathang53 = new MatHang(53, 2, "Suede Classic+ Sneakers", 3000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_18-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38") }, "KT");
            dsMatHang.Add(mathang53);
            MatHang mathang54 = new MatHang(54, 2, "Suede Classic+ Sneakers", 2500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_17-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "39") }, "KT");
            dsMatHang.Add(mathang54);
            MatHang mathang55 = new MatHang(55, 2, "Clyde Core Foil Sneakers", 1500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_17-White.svg", new List<Size>() { new Size(1, "39"), new Size(2, "40") }, "KT");
            dsMatHang.Add(mathang55);
            MatHang mathang56 = new MatHang(56, 2, "Speedcat LS Motorsport", 2700000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_17-Red.svg", new List<Size>() { new Size(1, "38"), new Size(2, "41") }, "KT");
            dsMatHang.Add(mathang56);

            MatHang mathang57 = new MatHang(57, 2, "Suede Classic+ Sneakers", 3000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_18-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38") }, "KT");
            dsMatHang.Add(mathang57);
            MatHang mathang58 = new MatHang(58, 2, "Suede Classic+ Sneakers", 2500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_17-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "39") }, "KT");
            dsMatHang.Add(mathang58);
            MatHang mathang59 = new MatHang(59, 2, "Clyde Core Foil Sneakers", 1500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_17-White.svg", new List<Size>() { new Size(1, "39"), new Size(2, "40") }, "KT");
            dsMatHang.Add(mathang59);
            MatHang mathang60 = new MatHang(60, 2, "Speedcat LS Motorsport", 2700000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_17-Red.svg", new List<Size>() { new Size(1, "38"), new Size(2, "41") }, "KT");
            dsMatHang.Add(mathang60);

            MatHang mathang61 = new MatHang(61, 2, "Suede Classic+ Sneakers", 3000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_16-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38") }, "KT");
            dsMatHang.Add(mathang61);
            MatHang mathang62 = new MatHang(62, 2, "Suede Classic+ Sneakers", 2500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_16-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "39") }, "KT");
            dsMatHang.Add(mathang62);
            MatHang mathang63 = new MatHang(63, 2, "Clyde Core Foil Sneakers", 1500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_16-White.svg", new List<Size>() { new Size(1, "39"), new Size(2, "40") }, "KT");
            dsMatHang.Add(mathang63);
            MatHang mathang64 = new MatHang(64, 2, "Speedcat LS Motorsport", 2700000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_15-Red.svg", new List<Size>() { new Size(1, "38"), new Size(2, "41") }, "KT");
            dsMatHang.Add(mathang64);

            MatHang mathang65 = new MatHang(65, 2, "Suede Classic+ Sneakers", 3000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_15-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38") }, "KT");
            dsMatHang.Add(mathang65);
            MatHang mathang66 = new MatHang(66, 2, "Suede Classic+ Sneakers", 2500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_14-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "39") }, "KT");
            dsMatHang.Add(mathang66);
            MatHang mathang72 = new MatHang(72, 2, "Clyde Core Foil Sneakers", 1500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_14-White.svg", new List<Size>() { new Size(1, "39"), new Size(2, "40") }, "KT");
            dsMatHang.Add(mathang72);
            MatHang mathang67 = new MatHang(67, 2, "Speedcat LS Motorsport", 2700000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_13-Red.svg", new List<Size>() { new Size(1, "38"), new Size(2, "41") }, "KT");
            dsMatHang.Add(mathang67);

            MatHang mathang68 = new MatHang(68, 2, "Suede Classic+ Sneakers", 3000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_13-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38") }, "KT");
            dsMatHang.Add(mathang68);
            MatHang mathang69 = new MatHang(69, 2, "Suede Classic+ Sneakers", 2500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_12-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "39") }, "KT");
            dsMatHang.Add(mathang69);
            MatHang mathang70 = new MatHang(70, 2, "Clyde Core Foil Sneakers", 1500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_12-Red.svg", new List<Size>() { new Size(1, "39"), new Size(2, "40") }, "KT");
            dsMatHang.Add(mathang70);
            MatHang mathang71 = new MatHang(71, 2, "Speedcat LS Motorsport", 2700000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_11-Red.svg", new List<Size>() { new Size(1, "38"), new Size(2, "41") }, "KT");
            dsMatHang.Add(mathang71);

            MatHang mathang73 = new MatHang(73, 2, "Suede Classic+ Sneakers", 3000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_11-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38") }, "KT");
            dsMatHang.Add(mathang73);
            MatHang mathang74 = new MatHang(74, 2, "Suede Classic+ Sneakers", 2500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_11-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "39") }, "KT");
            dsMatHang.Add(mathang74);
            MatHang mathang75 = new MatHang(75, 2, "Clyde Core Foil Sneakers", 1500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_10-White.svg", new List<Size>() { new Size(1, "39"), new Size(2, "40") }, "KT");
            dsMatHang.Add(mathang75);
            MatHang mathang76 = new MatHang(76, 2, "Speedcat LS Motorsport", 2700000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_10-Red.svg", new List<Size>() { new Size(1, "38"), new Size(2, "41") }, "KT");
            dsMatHang.Add(mathang76);

            MatHang mathang77 = new MatHang(77, 2, "Suede Classic+ Sneakers", 3000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_10-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38") }, "KT");
            dsMatHang.Add(mathang77);
            MatHang mathang78 = new MatHang(78, 2, "Suede Classic+ Sneakers", 2500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_9-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "39") }, "KT");
            dsMatHang.Add(mathang78);
            MatHang mathang79 = new MatHang(79, 2, "Clyde Core Foil Sneakers", 1500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_9-White.svg", new List<Size>() { new Size(1, "39"), new Size(2, "40") }, "KT");
            dsMatHang.Add(mathang79);
            MatHang mathang80 = new MatHang(80, 2, "Speedcat LS Motorsport", 2700000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_9-Red.svg", new List<Size>() { new Size(1, "38"), new Size(2, "41") }, "KT");
            dsMatHang.Add(mathang80);

            //Hàng Lacoste
            MatHang mathang81 = new MatHang(81, 3, "Suede Classic+ Sneakers", 2000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Lacoste gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_1-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38") }, "KT");
            dsMatHang.Add(mathang81);
            MatHang mathang82 = new MatHang(82, 3, "Suede Classic+ Sneakers", 2400000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Lacoste gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Lacoste/Lacoste_2-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "39") }, "KT");
            dsMatHang.Add(mathang82);
            MatHang mathang83 = new MatHang(83, 3, "Clyde Core Foil Sneakers", 3500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Lacoste gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Lacoste/Lacoste_3-White.svg", new List<Size>() { new Size(1, "39"), new Size(2, "40") }, "KT");
            dsMatHang.Add(mathang83);
            MatHang mathang84 = new MatHang(84, 3, "Speedcat LS Motorsport", 1100000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Lacoste/Lacoste_4-White.svg", new List<Size>() { new Size(1, "38"), new Size(2, "41") }, "KT");
            dsMatHang.Add(mathang84);
            Application["DanhSachMatHang"] = dsMatHang;

            // Danh sách đơn hàng
            Application["DanhSachDonHang"] = new List<DonHang>();

            // Danh sách tài khoản
            Application["DanhSachTaiKhoan"] = new List<TaiKhoan>();
        }

        void Session_Start(object sender, EventArgs e)
        {
            Session["GioHang"] = new List<SanPhamGioHang>();

            Session["KetQuaTimKiem"] = new List<MatHang>();


        }
    }
}