using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Security.Cryptography;

namespace QL_Customers_Products
{
    public partial class frmMain : Form
    {
        SQLConfig config = new SQLConfig();
        static string sql;
        public frmMain()
        {
            InitializeComponent();
        }

        private void sbtn_Dashboard_Click(object sender, EventArgs e)
        {
            showFrm(new frmThanhToan());

        }

        public void closeForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

        }
        public void showFrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.Show();
        }
        

    }
}
