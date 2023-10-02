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
    public partial class frmlogin : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        string CauLenh;
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            CauLenh = "select * from NguoiDung";
            DataSet ds = kn.LayDuLieu(CauLenh);
            if(ds.Tables[0].Rows.Count > 0)
            {
                CauLenh = "select * from nguoiDung where TenDangNhap='"+txttendangnhap.Text+"' and MatKhau = '"+txtmatkhau.Text+"'";
                ds = kn.LayDuLieu(CauLenh);
                if(ds.Tables[0].Rows.Count > 0)
                {
                    string LoaiNguoiDung = ds.Tables[0].Rows[0][1].ToString();
                    if(LoaiNguoiDung=="Administrator")
                    {
                        frmadmin ad = new frmadmin(txttendangnhap.Text);
                        ad.Show();
                        this.Hide();
                    }
                    else if(LoaiNguoiDung == "Nhân viên")
                    {
                        frmnhanvien nv = new frmnhanvien();
                        nv.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            txttendangnhap.Focus();
        }

        private void frmlogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
