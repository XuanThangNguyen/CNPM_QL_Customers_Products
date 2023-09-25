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
        public frmThanhToan()
        {
            InitializeComponent();
            LoadListIdSanPham();
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void cmb_IdSanPham_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cmb = sender as ComboBox;
                if (cmb.SelectedItem != null)
                {
                    sql = "SELECT TenSanPham, GiaGoc, GiaDaGiam, GiamGia FROM SanPham WHERE IdSanPham = '" + cbo_IdSanPham.Text + "'";
                    DataTable dataTable = config.ExecuteTableQuery(sql);

                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            txt_TenSanPham.Text = row["TenSanPham"].ToString();
                            txt_DonGia.Text = row["GiaGoc"].ToString();
                            nud_GiamGia.Value = int.Parse(row["GiamGia"].ToString());
                            txt_ThanhTien.Text = row["GiaDaGiam"].ToString();

                        }
                    }
                    SanPham sp = new SanPham();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void txt_SoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (txt_DonGia.Text != "")
            {
                int giaDaGiam = int.Parse(txt_DonGia.Text) - int.Parse(txt_DonGia.Text) * int.Parse(nud_GiamGia.Text) / 100;
                txt_ThanhTien.Text = ((int.Parse(nud_SoLuong.Text) + 1) * giaDaGiam).ToString();
            }
        }

        private void txt_SoLuong_VisibleChanged(object sender, EventArgs e)
        {
            if (txt_DonGia.Text != "")
            {
                int giaDaGiam = int.Parse(txt_DonGia.Text) - int.Parse(txt_DonGia.Text) * int.Parse(nud_GiamGia.Text) / 100;
                txt_ThanhTien.Text = (int.Parse(nud_SoLuong.Text) * giaDaGiam).ToString();
            }
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if(cbo_IdSanPham.Text != ""&& txt_TenSanPham.Text!="")
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
                        int soLuongHienTai = int.Parse(item.SubItems[3].Text);
                        item.SubItems[3].Text = (soLuongHienTai + 1).ToString();

                        item.SubItems[5].Text = ((soLuongHienTai + 1) * (int.Parse(item.SubItems[2].Text) - int.Parse(item.SubItems[2].Text) * int.Parse(item.SubItems[4].Text) / 100)).ToString();
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
                txt_TongTien.Text = tongTien.ToString("C");
            }    
        }

        private void txt_TienKhachDua_Leave(object sender, EventArgs e)
        {
            if (txt_TongTien.Text != "" && txt_TienKhachDua.Text != "")
            {
                string tongTienStr = txt_TongTien.Text.Replace("$", "").Replace("€", "").Replace(",", "");
                int tongTienInt = int.Parse(tongTienStr);
                txt_TienThoi.Text = (int.Parse(txt_TienKhachDua.Text) - tongTienInt).ToString("C");
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
            txt_TienThoi.Text= string.Empty;

        }

    }
}
