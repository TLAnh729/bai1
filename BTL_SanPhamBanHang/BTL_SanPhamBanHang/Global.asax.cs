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
            //Hàng 1
            MatHang mathang1 = new MatHang(1, 1, "Nike Air Force 1 '07", 2000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/NIKE/Nike_1-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2,"38") }, "KT");
            dsMatHang.Add(mathang1);
            MatHang mathang2 = new MatHang(2, 1, "Nike Blazer Mid '77 Vintage", 2000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/NIKE/Nike_2-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "39") }, "KT");
            dsMatHang.Add(mathang2);
            MatHang mathang3 = new MatHang(3, 1, "Nike Air Force 1 '07 LV8", 2500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/NIKE/Nike_3-Black.svg", new List<Size>() { new Size(1, "39"), new Size(2, "40") }, "KT");
            dsMatHang.Add(mathang3);
            MatHang mathang4 = new MatHang(4, 1, "Nike Air Zoom SuperRep 2", 3000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_1-Black.svg", new List<Size>() { new Size(1, "38"), new Size(2, "41") }, "KT");
            dsMatHang.Add(mathang4);
            MatHang mhNike1 = new MatHang(13, 1, "Nike Air Force 1 '07", 2600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_1-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mhNike1);
            MatHang mhNike2 = new MatHang(14, 1, "Nike Air Force 1 '07", 1900000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_1-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mhNike2);
            MatHang mhNike3 = new MatHang(15, 1, "Nike Air Force 1 '07", 3600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_1-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mhNike3);
            MatHang mhNike4 = new MatHang(16, 1, "Nike Blazer Mid '77 Vintage", 600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_2-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mhNike4);

            //Hàng 2
            MatHang mhNike5 = new MatHang(17, 1, "Nike Air Force 1 '07", 2600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_1-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mhNike5);
            MatHang mhNike6 = new MatHang(18, 1, "Nike Air Force 1 '07", 1900000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_1-Black.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mhNike6);
            MatHang mhNike7 = new MatHang(19, 1, "Nike Air Force 1 '07", 3600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_1-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mhNike7);
            MatHang mhNike8 = new MatHang(20, 1, "Nike Blazer Mid '77 Vintage", 600000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Nike gia công sản xuất tại Indonesia (Made in Indonesia)", 30, "Content/Images/NIKE/Nike_2-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38"), new Size(3, "39"), new Size(4, "40") }, "KT");
            dsMatHang.Add(mhNike8);

            //Hàng Valentino
            MatHang mathang5 = new MatHang(5, 2, "Suede Classic+ Sneakers", 3000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_2-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2,"38") }, "KT");
            dsMatHang.Add(mathang5);
            MatHang mathang6 = new MatHang(6, 2, "Suede Classic+ Sneakers", 2500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_2-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "39") }, "KT");
            dsMatHang.Add(mathang6);
            MatHang mathang7 = new MatHang(7, 2, "Clyde Core Foil Sneakers", 1500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_3-White.svg", new List<Size>() { new Size(1, "39"), new Size(2, "40") }, "KT");
            dsMatHang.Add(mathang7);
            MatHang mathang8 = new MatHang(8, 2, "Speedcat LS Motorsport", 2700000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_4-White.svg", new List<Size>() { new Size(1, "38"), new Size(2, "41") }, "KT");
            dsMatHang.Add(mathang8);

            //Hàng Lacoste
            MatHang mathang9 = new MatHang(9, 3, "Suede Classic+ Sneakers", 2000000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Lacoste gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Valentino/Valentino_1-Red.svg", new List<Size>() { new Size(1, "37"), new Size(2, "38") }, "KT");
            dsMatHang.Add(mathang9);
            MatHang mathang10 = new MatHang(10, 3, "Suede Classic+ Sneakers", 2400000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Lacoste gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Lacoste/Lacoste_2-White.svg", new List<Size>() { new Size(1, "37"), new Size(2, "39") }, "KT");
            dsMatHang.Add(mathang10);
            MatHang mathang11 = new MatHang(11, 3, "Clyde Core Foil Sneakers", 3500000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Lacoste gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Lacoste/Lacoste_3-White.svg", new List<Size>() { new Size(1, "39"), new Size(2, "40") }, "KT");
            dsMatHang.Add(mathang11);
            MatHang mathang12 = new MatHang(12, 3, "Speedcat LS Motorsport", 1100000, "Chất liệu : Da nhân tạo, cao su cao cấp. Nhập trực tiếp từ Hàn Quốc, hãng Valentino gia công sản xuất tại Indonesia (Made in Indonesia)", 10, "Content/Images/Lacoste/Lacoste_4-White.svg", new List<Size>() { new Size(1, "38"), new Size(2, "41") }, "KT");
            dsMatHang.Add(mathang12);
            Application["DanhSachMatHang"] = dsMatHang;

            // Danh sách đơn hàng
            Application["DanhSachDonHang"] = new List<DonHang>();
        }

        void Session_Start(object sender, EventArgs e)
        {
            Session["GioHang"] = new List<SanPhamGioHang>();

            Session["KetQuaTimKiem"] = new List<MatHang>();

        }
    }
}