
namespace QL_Customers_Products
{
    partial class ThongKe
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
            this.btn_tongthu = new System.Windows.Forms.Button();
            this.btn_tongchi = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel_left = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_tongthu
            // 
            this.btn_tongthu.Location = new System.Drawing.Point(3, 3);
            this.btn_tongthu.Name = "btn_tongthu";
            this.btn_tongthu.Size = new System.Drawing.Size(155, 74);
            this.btn_tongthu.TabIndex = 0;
            this.btn_tongthu.Text = "Tổng thu";
            this.btn_tongthu.UseVisualStyleBackColor = true;
            this.btn_tongthu.Click += new System.EventHandler(this.btn_tongthu_Click);
            // 
            // btn_tongchi
            // 
            this.btn_tongchi.Location = new System.Drawing.Point(3, 83);
            this.btn_tongchi.Name = "btn_tongchi";
            this.btn_tongchi.Size = new System.Drawing.Size(155, 74);
            this.btn_tongchi.TabIndex = 1;
            this.btn_tongchi.Text = "Tổng chi";
            this.btn_tongchi.UseVisualStyleBackColor = true;
            this.btn_tongchi.Click += new System.EventHandler(this.btn_tongchi_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(933, 61);
            this.panel_top.TabIndex = 14;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.panel_left.Controls.Add(this.btn_tongthu);
            this.panel_left.Controls.Add(this.btn_tongchi);
            this.panel_left.Location = new System.Drawing.Point(0, 57);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(163, 603);
            this.panel_left.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 599);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 61);
            this.panel1.TabIndex = 15;
            // 
            // panel_body
            // 
            this.panel_body.Location = new System.Drawing.Point(167, 64);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(752, 525);
            this.panel_body.TabIndex = 16;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 660);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_left);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.panel_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tongthu;
        private System.Windows.Forms.Button btn_tongchi;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.FlowLayoutPanel panel_left;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_body;
    }
}