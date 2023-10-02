using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Phòng_thuốc.NhanvienUC
{
    public partial class UC_Nhapthuoc : UserControl
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        string CauLenh;
        public UC_Nhapthuoc()
        {
            InitializeComponent();
        }

        public void LayDanhSachThuoc()
        {
            CauLenh = "select * from Thuoc";
            DataSet ds = kn.LayDuLieu(CauLenh);
            dgvNhapThuoc.DataSource = ds.Tables[0];
        }

        private void UC_Nhapthuoc_Load(object sender, EventArgs e)
        {
            LayDanhSachThuoc();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {   txtMaLoaiThuoc.Clear();
            txtNhaCungCap.Clear();
            txtMaThuoc.Clear();
            txtSoLuong.Clear();
            txtTenThuoc.Clear();
            txtGiaBan.Clear();
            dtpHSD.ResetText();
            dtpNgaySanXuat.ResetText();
        }

        private void lbtenthuoc_Click(object sender, EventArgs e)
        {

        }

        private void dgvNhapThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CauLenh = "select * from Thuoc";
            DataSet ds = kn.LayDuLieu(CauLenh);
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaThuoc.Text = ds.Tables[0].Rows[r][0].ToString();
                txtTenThuoc.Text = ds.Tables[0].Rows[r][1].ToString();
                txtNhaCungCap.Text = ds.Tables[0].Rows[r][2].ToString();
                txtMaLoaiThuoc.Text = ds.Tables[0].Rows[r][3].ToString();
                dtpNgaySanXuat.Value = DateTime.Parse(ds.Tables[0].Rows[r][4].ToString());
                dtpHSD.Value = DateTime.Parse(ds.Tables[0].Rows[r][5].ToString());
                txtSoLuong.Text = ds.Tables[0].Rows[r][6].ToString();
                txtGiaBan.Text = ds.Tables[0].Rows[r][7].ToString();
            }
        }

        private void dgvNhapThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaThuoc.Text == "" || txtTenThuoc.Text == "" || txtNhaCungCap.Text == "" || txtSoLuong.Text == null || txtGiaBan.Text == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string MaThuoc = txtMaThuoc.Text;
                string TenThuoc = txtTenThuoc.Text;
                string MaNhaCungCap = txtNhaCungCap.Text;
                string NgaySanXuat = dtpNgaySanXuat.Text;
                string HSD = dtpHSD.Text;
                Int32 SoLuong = Int32.Parse(txtSoLuong.Text);
                Int32 GiaBan = Int32.Parse(txtGiaBan.Text);

                try
                {
                        CauLenh = "insert into Thuoc (MaThuoc,TenThuoc,MaNhaCungCap,MaLoaiThuoc,NgaySX,HSD,SoLuong,GiaBan) values ('" + MaThuoc + "',N'" + TenThuoc + "','" + MaNhaCungCap + "',"+txtMaLoaiThuoc.Text+",'" + NgaySanXuat + "','" + HSD + "'," + SoLuong + "," + GiaBan + ")";
                        kn.CaiDuLieu(CauLenh);
                        MessageBox.Show("Nhập thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LayDanhSachThuoc();
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã thuốc đã tồn tại hoặc nhập sai thông tin!!!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaThuoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã thuốc để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DialogResult dr;
                    dr = MessageBox.Show("Bạn có chắc muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        CauLenh = "delete from Thuoc where MaThuoc='" + txtMaThuoc.Text + "'";
                        kn.CaiDuLieu(CauLenh);
                        MessageBox.Show("Đã xoá thuốc!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UC_Nhapthuoc_Load(this, null);
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Xoá thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaThuoc.Text == "" || txtTenThuoc.Text == "" || txtNhaCungCap.Text == "" || txtSoLuong.Text == "" || txtGiaBan.Text == ""||txtMaLoaiThuoc.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CauLenh = "update Thuoc set MaThuoc='" + txtMaThuoc.Text + "', TenThuoc=N'" + txtTenThuoc.Text + "', MaNhaCungCap='" + txtNhaCungCap.Text + "', MaLoaiThuoc='" + txtMaLoaiThuoc.Text + "', NgaySX='" + dtpNgaySanXuat.Text + "', HSD='" + dtpHSD.Text + "', SoLuong=" + txtSoLuong.Text + ", GiaBan=" + txtGiaBan.Text + " where MaThuoc='" + txtMaThuoc.Text + "'";
                kn.CaiDuLieu(CauLenh);
                MessageBox.Show("Cập nhật thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LayDanhSachThuoc();
            }
        }
    }
}
