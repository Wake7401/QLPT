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
    public partial class UC_HoaDon : UserControl
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        string CauLenh;
        public UC_HoaDon()
        {
            InitializeComponent();
        }
        public void LayDanhSachHoaDon()
        {
            CauLenh = "select * from HoaDon";
            DataSet ds = kn.LayDuLieu(CauLenh);
            dgvHoaDon.DataSource = ds.Tables[0];
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHoadon.Text == ""||txtMaKhachHang.Text==""||txtNgayBan.Text==""||txtTenKhachHang.Text==""||txtTongGia.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CauLenh = "update HoaDon set MaHoaDon="+txtMaHoadon.Text+", MaKhachHang="+txtMaKhachHang.Text+",TenKhachHang=N'"+txtTenKhachHang.Text+"',NgayBan='"+txtNgayBan.Text+"',TongGia="+txtTongGia.Text+" where MaHoaDon="+txtMaHoadon.Text+"";
                kn.CaiDuLieu(CauLenh);
                MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LayDanhSachHoaDon();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHoadon.Text != "")
            {
                try
                {
                    CauLenh = "delete from HoaDon where MaHoaDon=" + txtMaHoadon.Text + "";
                    kn.CaiDuLieu(CauLenh);
                    MessageBox.Show("Xoá thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UC_HoaDon_Load(this, null);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UC_HoaDon_Load(object sender, EventArgs e)
        {
            LayDanhSachHoaDon();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CauLenh = "select * from HoaDon";
            DataSet ds = kn.LayDuLieu(CauLenh);
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaHoadon.Text = ds.Tables[0].Rows[r][0].ToString();
                txtMaKhachHang.Text = ds.Tables[0].Rows[r][2].ToString();
                txtTenKhachHang.Text = ds.Tables[0].Rows[r][3].ToString();
                txtNgayBan.Text = ds.Tables[0].Rows[r][4].ToString();
                txtTongGia.Text = ds.Tables[0].Rows[r][5].ToString();
            }
        }
    }
}
