namespace QL_Customers_Products
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sbtn_Dashboard = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.sbtn_SanPham = new System.Windows.Forms.ToolStripButton();
            this.sbtn_KhachHang = new System.Windows.Forms.ToolStripButton();
            this.sbtn_DonHang = new System.Windows.Forms.ToolStripButton();
            this.sbtn_HoaDon = new System.Windows.Forms.ToolStripButton();
            this.sbtn_NhanVien = new System.Windows.Forms.ToolStripButton();
            this.sbtn_PhanHoi = new System.Windows.Forms.ToolStripButton();
            this.sbtn_ChiNhanh = new System.Windows.Forms.ToolStripButton();
            this.sbtn_Kho = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sbtn_Dashboard
            // 
            this.sbtn_Dashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtn_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.sbtn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbtn_Dashboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtn_Dashboard.Name = "sbtn_Dashboard";
            this.sbtn_Dashboard.Size = new System.Drawing.Size(134, 30);
            this.sbtn_Dashboard.Text = "Dashboard";
            this.sbtn_Dashboard.Click += new System.EventHandler(this.sbtn_Dashboard_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbtn_Dashboard,
            this.sbtn_SanPham,
            this.sbtn_KhachHang,
            this.sbtn_DonHang,
            this.sbtn_HoaDon,
            this.sbtn_NhanVien,
            this.sbtn_PhanHoi,
            this.sbtn_ChiNhanh,
            this.sbtn_Kho});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1920, 35);
            this.toolStrip1.TabIndex = 41;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // sbtn_SanPham
            // 
            this.sbtn_SanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtn_SanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.sbtn_SanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbtn_SanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtn_SanPham.Name = "sbtn_SanPham";
            this.sbtn_SanPham.Size = new System.Drawing.Size(125, 30);
            this.sbtn_SanPham.Text = "Sản Phẩm";
            // 
            // sbtn_KhachHang
            // 
            this.sbtn_KhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtn_KhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.sbtn_KhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbtn_KhachHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtn_KhachHang.Name = "sbtn_KhachHang";
            this.sbtn_KhachHang.Size = new System.Drawing.Size(148, 30);
            this.sbtn_KhachHang.Text = "Khách Hàng";
            // 
            // sbtn_DonHang
            // 
            this.sbtn_DonHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtn_DonHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.sbtn_DonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbtn_DonHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtn_DonHang.Name = "sbtn_DonHang";
            this.sbtn_DonHang.Size = new System.Drawing.Size(128, 30);
            this.sbtn_DonHang.Text = "Đơn Hàng";
            // 
            // sbtn_HoaDon
            // 
            this.sbtn_HoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtn_HoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.sbtn_HoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbtn_HoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtn_HoaDon.Name = "sbtn_HoaDon";
            this.sbtn_HoaDon.Size = new System.Drawing.Size(114, 30);
            this.sbtn_HoaDon.Text = "Hóa Đơn";
            // 
            // sbtn_NhanVien
            // 
            this.sbtn_NhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtn_NhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.sbtn_NhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbtn_NhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtn_NhanVien.Name = "sbtn_NhanVien";
            this.sbtn_NhanVien.Size = new System.Drawing.Size(132, 30);
            this.sbtn_NhanVien.Text = "Nhân Viên";
            // 
            // sbtn_PhanHoi
            // 
            this.sbtn_PhanHoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtn_PhanHoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.sbtn_PhanHoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbtn_PhanHoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtn_PhanHoi.Name = "sbtn_PhanHoi";
            this.sbtn_PhanHoi.Size = new System.Drawing.Size(116, 30);
            this.sbtn_PhanHoi.Text = "Phản Hồi";
            // 
            // sbtn_ChiNhanh
            // 
            this.sbtn_ChiNhanh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtn_ChiNhanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.sbtn_ChiNhanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbtn_ChiNhanh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtn_ChiNhanh.Name = "sbtn_ChiNhanh";
            this.sbtn_ChiNhanh.Size = new System.Drawing.Size(133, 30);
            this.sbtn_ChiNhanh.Text = "Chi Nhánh";
            // 
            // sbtn_Kho
            // 
            this.sbtn_Kho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtn_Kho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.sbtn_Kho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbtn_Kho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtn_Kho.Name = "sbtn_Kho";
            this.sbtn_Kho.Size = new System.Drawing.Size(61, 30);
            this.sbtn_Kho.Text = "Kho";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1920, 1050);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton sbtn_Dashboard;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton sbtn_SanPham;
        private System.Windows.Forms.ToolStripButton sbtn_KhachHang;
        private System.Windows.Forms.ToolStripButton sbtn_DonHang;
        private System.Windows.Forms.ToolStripButton sbtn_HoaDon;
        private System.Windows.Forms.ToolStripButton sbtn_NhanVien;
        private System.Windows.Forms.ToolStripButton sbtn_PhanHoi;
        private System.Windows.Forms.ToolStripButton sbtn_Kho;
        private System.Windows.Forms.ToolStripButton sbtn_ChiNhanh;
    }
}