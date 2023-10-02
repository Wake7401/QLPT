using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phòng_thuốc.AdministratorUC
{
    public partial class UC_Thongtinnguoidung : UserControl
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        string CauLenh;
        public UC_Thongtinnguoidung()
        {
            InitializeComponent();
        }
        public void LayDanhSachNguoiDung()
        {
            CauLenh = "select * from NguoiDung";
            DataSet ds = kn.LayDuLieu(CauLenh);
            dgvThemNguoiDung.DataSource = ds.Tables[0];
        }
        public void ClearAll()
        {   
            txtMaNguoiDung.Clear();
            txttennguoidung.Clear();
            txttentaikhoan.Clear();
            txtmatkhau.Clear();
            txtdiachi.Clear();
            txtsodienthoai.Clear();
            txtNgaySinh.Clear();
            cbbloainguoidung.Text = "";
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btndangki_Click(object sender, EventArgs e)
        {
            if (txtsodienthoai.Text == "" || txttentaikhoan.Text == "" || txtdiachi.Text == "" || txtmatkhau.Text == "" || txttennguoidung.Text == "" || cbbloainguoidung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string LoaiNguoiDung = cbbloainguoidung.Text;
                string TenNguoiDung = txttennguoidung.Text;
                string NgaySinh = txtNgaySinh.Text;
                Int32 Sdt = Int32.Parse(txtsodienthoai.Text);
                string DiaChi = txtdiachi.Text;
                string TenDangNhap = txttentaikhoan.Text;
                string MatKhau = txtmatkhau.Text;

                try
                {
                    CauLenh = "insert into NguoiDung (LoaiNguoiDung,TenNguoiDung,NgaySinh,Sdt,DiaChi,TenDangNhap,MatKhau) values (N'" + LoaiNguoiDung + "',N'" + TenNguoiDung + "','" + NgaySinh + "'," + Sdt + ",N'" + DiaChi + "','" + TenDangNhap + "','" + MatKhau + "')";
                    kn.CaiDuLieu(CauLenh);
                    MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LayDanhSachNguoiDung();
                }
                catch (Exception)
                {
                    MessageBox.Show("Người dùng đã tồn tại!!!", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UC_Themnguoidung_Load(object sender, EventArgs e)
        {
            LayDanhSachNguoiDung();
        }

        private void dgvThemNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLoadDuLieu_Click(object sender, EventArgs e)
        {
            UC_Themnguoidung_Load(this, null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtsodienthoai.Text == "" || txttentaikhoan.Text == "" || txtdiachi.Text == "" || txtmatkhau.Text == "" || txttennguoidung.Text == "" || cbbloainguoidung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CauLenh = "update NguoiDung set LoaiNguoiDung=N'" + cbbloainguoidung.Text + "',TenNguoiDung=N'" + txttennguoidung.Text + "',NgaySinh='" + txtNgaySinh.Text + "',Sdt=" + txtsodienthoai.Text + ",DiaChi=N'" + txtdiachi.Text + "',TenDangNhap='" + txttentaikhoan.Text + "',MatKhau='" + txtmatkhau.Text + "' where MaNguoiDung=" + txtMaNguoiDung.Text + "";
                kn.CaiDuLieu(CauLenh);
                MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LayDanhSachNguoiDung();
            }
        }

        private void dgvThemNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CauLenh = "select * from NguoiDung";
            DataSet ds = kn.LayDuLieu(CauLenh);
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaNguoiDung.Text = ds.Tables[0].Rows[r][0].ToString();
                cbbloainguoidung.Text = ds.Tables[0].Rows[r][1].ToString();
                txttennguoidung.Text = ds.Tables[0].Rows[r][2].ToString();
                txtNgaySinh.Text = ds.Tables[0].Rows[r][3].ToString();
                txtsodienthoai.Text = ds.Tables[0].Rows[r][4].ToString();
                txtdiachi.Text = ds.Tables[0].Rows[r][5].ToString();
                txttentaikhoan.Text = ds.Tables[0].Rows[r][6].ToString();
                txtmatkhau.Text = ds.Tables[0].Rows[r][7].ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNguoiDung.Text != "")
            {
                try
                {
                    CauLenh = "delete from NguoiDung where MaNguoiDung=" + txtMaNguoiDung.Text + "";
                    kn.CaiDuLieu(CauLenh);
                    MessageBox.Show("Xoá thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UC_Themnguoidung_Load(this, null);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
