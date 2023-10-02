using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phòng_thuốc
{
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
        }
        public frmadmin(string tendangnhap)
        {
            InitializeComponent();
            lblTenDangNhap.Text = tendangnhap;
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            frmlogin fm = new frmlogin();
            fm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_Bangdieukhien1.Visible =true;
            uC_Bangdieukhien1.BringToFront();
        }

        private void frmadmin_Load(object sender, EventArgs e)
        {
            uC_Bangdieukhien1.Visible=false;
            uC_Themnguoidung1.Visible=false;
            btnDashboard.PerformClick();
        }

        private void btnthemnguoidung_Click(object sender, EventArgs e)
        {
            uC_Themnguoidung1.Visible = true;
            uC_Themnguoidung1.BringToFront();
        }

        private void uC_Hoso1_Load(object sender, EventArgs e)
        {

        }
    }
}
