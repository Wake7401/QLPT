using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phòng_thuốc.NhanvienUC
{
    public partial class UC_KhachHang : UserControl
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        string CauLenh;
        DataSet ds;
        public void LayDanhSachKhachHang()
        {
            CauLenh = "select * from KhachHang";
            DataSet ds = kn.LayDuLieu(CauLenh);
            dgvKhachHang.DataSource = ds.Tables[0];
        }
        public UC_KhachHang()
        {
            InitializeComponent();
        }

        private void UC_KhachHang_Load(object sender, EventArgs e)
        {
            LayDanhSachKhachHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtSDT.Text==""||txtTenKhachHang.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    CauLenh = "insert into KhachHang (MaKhachHang, TenKhachHang, SoDienThoai) values ("+txtMaKhachHang.Text+",N'" + txtTenKhachHang.Text + "','" + txtSDT.Text + "')";
                    kn.CaiDuLieu(CauLenh);
                    MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LayDanhSachKhachHang();
                }
                catch(Exception)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại hoặc nhập sai thông tin!!!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text == "" || txtSDT.Text == "" || txtTenKhachHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                    CauLenh = "update KhachHang set MaKhachHang="+txtMaKhachHang.Text+", TenKhachHang=N'"+txtTenKhachHang.Text+"', SoDienThoai='"+txtSDT.Text+"' where MaKhachHang="+txtMaKhachHang.Text+"";
                    kn.CaiDuLieu(CauLenh);
                    MessageBox.Show("Cập nhật thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LayDanhSachKhachHang();
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CauLenh = "select * from KhachHang";
            DataSet ds = kn.LayDuLieu(CauLenh);
            int r = e.RowIndex;
            if(r>=0)
            {
                txtMaKhachHang.Text = ds.Tables[0].Rows[r][0].ToString();
                txtTenKhachHang.Text = ds.Tables[0].Rows[r][1].ToString();
                txtSDT.Text = ds.Tables[0].Rows[r][2].ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng để xoá!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr;
                dr = MessageBox.Show("Bạn có chắc muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    CauLenh = "delete from KhachHang where MaKhachHang=" + txtMaKhachHang.Text + "";
                    kn.CaiDuLieu(CauLenh);
                    MessageBox.Show("Đã xoá khách hàng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LayDanhSachKhachHang();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CauLenh = "select * from KhachHang where TenKhachHang like '%"+txtTimKiemTheoTen.Text+"%'";
            ds = kn.LayDuLieu(CauLenh);
            dgvKhachHang.DataSource = ds.Tables[0];
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txtTimKiemTheoTen.Clear();
            txtTenKhachHang.Clear();
            txtSDT.Clear();
            txtMaKhachHang.Clear();
            txtMaKhachHang.Focus();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LayDanhSachKhachHang();
        }
    }
}
