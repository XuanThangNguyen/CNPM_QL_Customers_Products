using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Customers_Products
{
    public partial class ChiTietHDNH : Form
    {
        public ChiTietHDNH()
        {
            InitializeComponent();
        }
        private string idHoaDon;

        // Tạo constructor để truyền IdHoaDon từ form chính
        public ChiTietHDNH(string idHoaDon)
        {
            InitializeComponent();
            this.idHoaDon = idHoaDon;
        }
        private string connectionString = "Server=DESKTOP-MH8F2OA;Database=QLKH_SP;User=sa;Password=123;"; // Thay thế bằng chuỗi kết nối của bạn
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private void ChiTietHDNH_Load(object sender, EventArgs e)
        {
            // Lấy IdHoaDon từ constructor
            string idHoaDon = this.idHoaDon;
            label1.Text = idHoaDon;
            // Kiểm tra xem IdHoaDon có giá trị không
            if (!string.IsNullOrEmpty(idHoaDon))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Truy vấn danh sách sản phẩm dựa trên IdHoaDon
                    string query = "SELECT CTHDNH.IdNhapHang,CTHDNH.IdSanPham, SP.TenSanPham, CTHDNH.SoLuong, CTHDNH.GiaNhap,CTHDNH.IdNhaCungCap FROM ChiTietHoaDonNhapHang CTHDNH INNER JOIN SanPham SP ON CTHDNH.IdSanPham = SP.IdSanPham WHERE CTHDNH.IdNhapHang = @IdHoaDon";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdHoaDon", idHoaDon);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Đọc dữ liệu từ SqlDataReader và thêm vào ListView
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["IdNhapHang"].ToString());
                                item.SubItems.Add(reader["IdSanPham"].ToString());
                                item.SubItems.Add(reader["TenSanPham"].ToString());
                                item.SubItems.Add(reader["SoLuong"].ToString());
                                item.SubItems.Add(reader["GiaNhap"].ToString());
                                item.SubItems.Add(reader["IdNhaCungCap"].ToString());
                                listView1.Items.Add(item);
                            }
                        }
                    }
                    connection.Close();
                }
            }
        }
    }
}
