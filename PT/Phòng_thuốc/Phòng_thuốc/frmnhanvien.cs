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
    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
        }

        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            uC_Dashboard_21.Visible = false;
            uC_Nhapthuoc1.Visible = false;
            uC_Kiemtrahansudung1.Visible = false;
            uC_Banthuoc1.Visible =false;
            uC_Themnhacungcap1.Visible = false;
            btndashboard.PerformClick();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            frmlogin fm = new frmlogin();
            fm.Show();
            this.Hide();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            uC_Dashboard_21.Visible = true;
            uC_Dashboard_21.BringToFront();
        }

        private void btnnhapthuoc_Click(object sender, EventArgs e)
        {
            uC_Nhapthuoc1.Visible = true;
            uC_Nhapthuoc1.BringToFront();
        }

        private void btnkiemtrahansudung_Click(object sender, EventArgs e)
        {
            uC_Kiemtrahansudung1.Visible=true;
            uC_Kiemtrahansudung1.BringToFront();
        }

        private void btnbanthuoc_Click(object sender, EventArgs e)
        {
            uC_Banthuoc1.Visible = true;
            uC_Banthuoc1.BringToFront();
        }

        private void uC_Banthuoc1_Load(object sender, EventArgs e)
        {
   
        }

        private void btnthemnhacungcap_Click(object sender, EventArgs e)
        {
            uC_Themnhacungcap1.Visible=true;
            uC_Themnhacungcap1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_KhachHang1.Visible = true;
            uC_KhachHang1.BringToFront();
        }

        private void frmnhanvien_Load_1(object sender, EventArgs e)
        {
            
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btnLoaiThuoc_Click(object sender, EventArgs e)
        {
            loaiThuoc1.Visible = true;
            loaiThuoc1.BringToFront();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            uC_HoaDon1.Visible = true;
            uC_HoaDon1.BringToFront();
        }
    }
}
