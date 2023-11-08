using QL_Customers_Products.Models;
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
    public partial class frmThanhToan : Form
    {
        public static string idNguoiDungHienTai { get; set; } // Biến tĩnh để lưu thông tin đăng nhập

        SQLConfig config = new SQLConfig();
        string sql;

        private Timer timer = new Timer();
        public frmThanhToan()
        {
            InitializeComponent();
            LoadListIdSanPham();
            LoadChiNhanh();

            dtpNgayBan.Format = DateTimePickerFormat.Custom;
            dtpNgayBan.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            // Đặt Interval của Timer thành 1000 milliseconds (1 giây)
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            dtpNgayBan.Value = DateTime.Now;
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void LoadListIdSanPham()
        {
            try
            {
                sql = "SELECT IdSanPham FROM SanPham";
                DataTable dataTable = config.ExecuteTableQuery(sql);

                List<string> listIdSanPham = new List<string>();
                if (dataTable.Rows.Count > 0)
                {
                    //foreach (DataRow row in dataTable.Rows)
                    //{
                    //    SanPham sp = new SanPham();
                    //    sp.IdSanPham = row["IdSanPham"].ToString();
                    //    sp.TenSanPham = row["TenSanPham"].ToString();
                    //    sp.IdLoaiSP = row["IdLoaiSP"].ToString();
                    //    sp.AnhSP = row["AnhSP"].ToString();
                    //    sp.GiaGoc = long.Parse( row["GiaGoc"].ToString());
                    //    sp.GiaDaGiam = long.Parse(row["GiaDaGiam"].ToString());
                    //    sp.GiamGia = int.Parse(row["GiamGia"].ToString());
                    //    listSanPham.Add(sp);
                    //}

                    foreach (DataRow row in dataTable.Rows)
                    {
                        listIdSanPham.Add(row["IdSanPham"].ToString());
                    }
                }
                else
                    listIdSanPham.Add("Chưa có sản phẩm");
                cbo_IdSanPham.DataSource = listIdSanPham;
                cbo_IdSanPham.SelectedIndex = -1;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
        public void LoadChiNhanh()
        {
            try
            {
                sql = "SELECT * FROM ChiNhanh";
                DataTable dataTable = config.ExecuteTableQuery(sql);

                List<string> listChiNhanh = new List<string>();
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        listChiNhanh.Add(row["TenChiNhanh"].ToString());
                    }
                }
                else
                    listChiNhanh.Add("Chưa có chi nhánh");
                cboChiNhanh.DataSource = listChiNhanh;
                cboChiNhanh.SelectedIndex = -1;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
        public void FormThanhToan_Load(object sender, EventArgs e)
        {
            txt_IdHoaDon.Text = SharedMethods.TaoIdHoaDonDuyNhat();
            nud_SoLuong.Value = 1;
            txt_TenSanPham.Text = null;
            txt_DonGia.Text = null;
            nud_GiamGia.Value = 0;
            txt_ThanhTien.Text = null;
            try
            {
                sql = "SELECT * FROM NhanVien WHERE IdNguoiDung = '" + idNguoiDungHienTai + "'";
                DataTable dataTable = config.ExecuteTableQuery(sql);

                if (dataTable.Rows.Count > 0)
                {

                    foreach (DataRow row in dataTable.Rows)
                    {
                        txt_IdNhanVien.Text = row["IdNhanVien"].ToString();
                        txt_TenNhanVien.Text = row["TenNhanVien"].ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }

        public void txt_SoDienThoai_Leave(object sender, EventArgs e)
        {
            string soDienThoai = txt_SoDienThoai.Text;

            try
            {
                if (txt_SoDienThoai.Text != null)
                {
                    sql = "SELECT IdKhachHang, TenKhachHang, DiaChi FROM KhachHang WHERE SoDienThoai = '" + soDienThoai + "'";
                    DataTable dataTable = config.ExecuteTableQuery(sql);

                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            txt_IdKhachHang.Text = row["IdKhachHang"].ToString();
                            txt_TenKhachHang.Text = row["TenKhachHang"].ToString();
                            txt_DiaChi.Text = row["DiaChi"].ToString();
                        }
                    }
                    else
                    {
                        // Nếu không tìm thấy thông tin, xóa các TextBox
                        txt_TenKhachHang.Clear();
                        txt_DiaChi.Clear();
                        txt_SoDienThoai.Clear();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
        private void txt_SoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (txt_SoDienThoai.Text.Length == 0)
            {
                txt_IdKhachHang.Text = string.Empty;
                txt_TenKhachHang.Text = string.Empty;
                txt_DiaChi.Text = string.Empty;
            }
        }
        public void cmb_IdSanPham_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cmb = sender as ComboBox;
                if (cmb.SelectedItem != null)
                {
                    sql = "SELECT * FROM SanPham WHERE IdSanPham = '" + cbo_IdSanPham.Text + "'";
                    DataTable dataTable = config.ExecuteTableQuery(sql);

                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            txt_TenSanPham.Text = row[1].ToString();
                            int giaGoc = int.Parse(row[4].ToString());
                            txt_DonGia.Text = giaGoc.ToString();
                            int giamGia = int.Parse(row[5].ToString());
                            nud_GiamGia.Value = giamGia;
                            txt_ThanhTien.Text = (giaGoc*(100-giamGia)/100).ToString();

                        }
                    }
                    SanPham sp = new SanPham();

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }



        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if (cbo_IdSanPham.Text != "" && txt_TenSanPham.Text != "")
            {
                string idSanPham = cbo_IdSanPham.Text;
                string tenSanPham = txt_TenSanPham.Text;
                string donGia = txt_DonGia.Text;
                int soLuong = (int)nud_SoLuong.Value;
                int giamGia = (int)nud_GiamGia.Value;
                string thanhTien = txt_ThanhTien.Text;

                bool daTonTai = false;

                foreach (ListViewItem item in lsvSanPham.Items)
                {
                    if (item.SubItems[0].Text == idSanPham)
                    {
                        // Tăng số lượng lên 1
                        item.SubItems[3].Text = (int.Parse(item.SubItems[3].Text) + soLuong).ToString();

                        item.SubItems[5].Text = (int.Parse(item.SubItems[3].Text) * (int.Parse(item.SubItems[2].Text) - int.Parse(item.SubItems[2].Text) * int.Parse(item.SubItems[4].Text) / 100)).ToString();
                        daTonTai = true;
                        break;
                    }
                }

                if (!daTonTai)
                {
                    ListViewItem item = lsvSanPham.Items.Add(idSanPham);
                    item.SubItems.Add(tenSanPham);
                    item.SubItems.Add(donGia);
                    item.SubItems.Add(soLuong.ToString());
                    item.SubItems.Add(giamGia.ToString());
                    item.SubItems.Add(thanhTien);
                }
                int tongTien = 0;
                foreach (ListViewItem item in lsvSanPham.Items)
                {
                    tongTien += int.Parse(item.SubItems[5].Text);
                }
                txt_TongTien.Text = tongTien.ToString("#,##0đ");
            }
        }

        private void txt_TienKhachDua_Leave(object sender, EventArgs e)
        {
            if (txt_TongTien.Text != "" && txt_TienKhachDua.Text != "")
            {
                string tongTienStr = txt_TongTien.Text.Replace("đ", "").Replace(".", "");
                int tongTienInt = int.Parse(tongTienStr);
                txt_TienThoi.Text = (int.Parse(txt_TienKhachDua.Text) - tongTienInt).ToString("#,##0đ");
            }
        }

        private void resetHoaDon_Click(object sender, EventArgs e)
        {
            ResetHoaDon();
        }
        private void ResetHoaDon()
        {
            txt_SoDienThoai.Text = string.Empty;
            cbo_IdSanPham.SelectedIndex = -1;
            txt_TenSanPham.Text = string.Empty;
            txt_DonGia.Text = string.Empty;
            nud_SoLuong.Value = 1;
            nud_GiamGia.Value = 0;
            txt_ThanhTien.Text = string.Empty;
            lsvSanPham.Items.Clear();
            txt_TongTien.Text = string.Empty;
            txt_TienKhachDua.Text = string.Empty;
            txt_TienThoi.Text = string.Empty;

        }

        private void taoHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if(cboChiNhanh.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn chi nhánh!!!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(cboQuayThanhToan.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn quầy thanh toán!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tongTienStr = txt_TongTien.Text.Replace("đ", "").Replace(".", "");
                    if (lsvSanPham.Items.Count > 0)
                    {
                        if (txt_IdKhachHang.Text != string.Empty)
                        {
                            sql = "INSERT INTO HoaDon VALUES ('" + txt_IdHoaDon.Text + "','" + txt_IdKhachHang.Text + "',N'Tiền mặt','" + txt_IdNhanVien.Text + "','" + GetIdChiNhanh(cboChiNhanh.Text, cboQuayThanhToan.Text) + "','" + dtpNgayBan.Text + "');";
                            CapNhatDiem(txt_IdKhachHang.Text, long.Parse(tongTienStr) * 0.01);
                        }
                        else
                            sql = "INSERT INTO HoaDon VALUES ('" + txt_IdHoaDon.Text + "',null,N'Tiền mặt','" + txt_IdNhanVien.Text + "','" + GetIdChiNhanh(cboChiNhanh.Text, cboQuayThanhToan.Text) + "','" + dtpNgayBan.Text + "');";
                        if (config.ExecuteNonQuery(sql) == true)
                        {
                            foreach (ListViewItem item in lsvSanPham.Items)
                            {
                                string sql2 = "INSERT INTO ChiTietHoaDon VALUES ('" + txt_IdHoaDon.Text + "','" + item.SubItems[0].Text + "'," + item.SubItems[3].Text + "," + item.SubItems[5].Text + ");";
                                config.ExecuteNonQuery(sql2);
                            }
                        }

                    }
                    MessageBox.Show("Đã mua hàng thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    ResetHoaDon();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }

        private void CapNhatDiem(string idKhachHang,double diemTichLuy)
        {
            try
            {
                sql = "UPDATE TheThanhVien SET DiemTichLuy = DiemTichLuy - " + diemTichLuy + " WHERE IdKhachHang = '" + idKhachHang + "'";
                config.ExecuteNonQuery(sql);
            }
            catch
            { 

            }
        }
        private string GetIdChiNhanh(string tenChiNhanh,string tenQuay)
        {
            string idQuay = null;
            try
            {
                sql = "SELECT IdQuayThanhToan FROM ChiNhanh CN INNER JOIN QuayThanhToan QTT ON CN.IdChiNhanh = QTT.IdChiNhanh WHERE TenQuay = N'" + tenQuay + "' AND TenChiNhanh = N'" + tenChiNhanh + "'";
                DataTable dataTable = config.ExecuteTableQuery(sql);
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        idQuay = row["IdQuayThanhToan"].ToString();
                    }
                }
                return idQuay;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            return idQuay;
        }
        private void cboChiNhanh_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboChiNhanh.SelectedIndex != -1)
            {
                try
                {
                    sql = "SELECT QTT.TenQuay FROM QuayThanhToan QTT INNER JOIN ChiNhanh CN ON QTT.IdChiNhanh = CN.IdChiNhanh WHERE TenChiNhanh = N'" + cboChiNhanh.Text + "'";
                    DataTable dataTable = config.ExecuteTableQuery(sql);

                    List<string> listQuayThanhToan = new List<string>();
                    if (dataTable.Rows.Count > 0)
                    {

                        foreach (DataRow row in dataTable.Rows)
                        {
                            listQuayThanhToan.Add(row["TenQuay"].ToString());
                        }
                    }
                    else
                        listQuayThanhToan.Add("Chưa có quầy thanh toán");
                    cboQuayThanhToan.DataSource = listQuayThanhToan;
                    cboQuayThanhToan.SelectedIndex = -1;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Lỗi SQL: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }
            }    
        }

        private void nud_SoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (txt_DonGia.Text != "")
            {
                int giaDaGiam = int.Parse(txt_DonGia.Text) - int.Parse(txt_DonGia.Text) * int.Parse(nud_GiamGia.Text) / 100;
                txt_ThanhTien.Text = (nud_SoLuong.Value * giaDaGiam).ToString();
            }
        }

    }
}
