using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BTL_SanPhamBanHang
{
    /// <summary>
    /// Lớp dùng để thao tác với CSDL
    /// </summary>
    public class ConnectDB
    {
        /// <summary>
        /// Chuỗi kết nối tới CSDL (dùng chung)
        /// </summary>
        public static string connection = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=BTL_SanPhamBanHang;Integrated Security=True";

        // Lấy danh sách loại hàng
        public DataTable LayLoaiHang()
        {
            DataTable result = new DataTable();
            // Lấy danh sách từ DB
            // Mở kết nối tới DB
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            // Lấy dữ liệu
            SqlCommand objSqlCommand = new SqlCommand("Select * from tblLoaiHang", con);
            objSqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(objSqlCommand);
            objSqlDataAdapter.Fill(result);
            // Đóng kết nối
            con.Close();
            return result;
        }

    }
}