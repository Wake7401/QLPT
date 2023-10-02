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
    public partial class LoaiThuoc : UserControl
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        string CauLenh;
        public LoaiThuoc()
        {
            InitializeComponent();
        }
        public void LayDanhSachLoaiThuoc()
        {
            CauLenh = "select * from LoaiThuoc";
            DataSet ds = kn.LayDuLieu(CauLenh);
            dgvLoaiThuoc.DataSource = ds.Tables[0];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaLoai.Text==""||txtTenLoai.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    CauLenh = "insert into LoaiThuoc values ('" + txtMaLoai.Text + "',N'" + txtTenLoai.Text + "')";
                    kn.CaiDuLieu(CauLenh);
                    MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LayDanhSachLoaiThuoc();
                    LoaiThuoc_Load(this, null);
                }
                catch(Exception)
                {
                    MessageBox.Show("Người dùng đã tồn tại!!!", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoaiThuoc_Load(object sender, EventArgs e)
        {
            LayDanhSachLoaiThuoc();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text==""||txtTenLoai.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CauLenh = "update LoaiThuoc set MaLoaiThuoc='" + txtMaLoai.Text + "', TenLoaiThuoc=N'" + txtTenLoai.Text + "' where MaLoaiThuoc='" + txtMaLoai.Text + "'";
                kn.CaiDuLieu(CauLenh);
                MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LayDanhSachLoaiThuoc();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text != "")
            {
                try
                {
                    CauLenh = "delete from LoaiThuoc where MaLoaiThuoc='" + txtMaLoai.Text + "'";
                    kn.CaiDuLieu(CauLenh);
                    MessageBox.Show("Xoá thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoaiThuoc_Load(this, null);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvLoaiThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CauLenh = "select * from LoaiThuoc";
            DataSet ds = kn.LayDuLieu(CauLenh);
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaLoai.Text = ds.Tables[0].Rows[r][0].ToString();
                txtTenLoai.Text = ds.Tables[0].Rows[r][1].ToString();
            }
        }

    }
}
