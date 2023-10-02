using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phòng_thuốc.NhanvienUC
{
    public partial class UC_Danhmucnhacungcap : UserControl
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        string CauLenh;
        public void LayDanhSachNhaCungCap()
        {
            CauLenh = "select * from NhaCungCap";
            DataSet ds = kn.LayDuLieu(CauLenh);
            dgvThongTinNhaCungCap.DataSource = ds.Tables[0];
        }
        public UC_Danhmucnhacungcap()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
            txtdiachi.Clear();
            txtsdt.Clear();
            txtTenhacungcap.Clear();
            txtManhacungcap.Clear();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtManhacungcap.Text==""||txtTenhacungcap.Text==""||txtdiachi.Text==""||txtsdt.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    CauLenh = "insert into NhaCungCap values ('" + txtManhacungcap.Text + "',N'" + txtTenhacungcap.Text + "','" + txtdiachi.Text + "'," + txtsdt.Text + ")";
                    kn.CaiDuLieu(CauLenh);
                    MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LayDanhSachNhaCungCap();
                }
                catch(Exception)
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại hoặc nhập sai thông tin!!!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void UC_Themnhacungcap_Load(object sender, EventArgs e)
        {
            LayDanhSachNhaCungCap();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtManhacungcap.Text == "" || txtTenhacungcap.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CauLenh = "update NhaCungCap set TenNhaCungCap=N'" + txtTenhacungcap.Text + "',DiaChi=N'" + txtdiachi.Text + "',SoDienThoai=" + txtsdt.Text + " where MaNhaCungCap='" + txtManhacungcap.Text + "'";
                kn.CaiDuLieu(CauLenh);
                MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LayDanhSachNhaCungCap();
            }
        }

        private void dgvThongTinNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CauLenh = "select * from NhaCungCap";
            DataSet ds = kn.LayDuLieu(CauLenh);
            int r = e.RowIndex;
            if(r>=0)
            {
                txtManhacungcap.Text = ds.Tables[0].Rows[r][0].ToString();
                txtTenhacungcap.Text = ds.Tables[0].Rows[r][1].ToString();
                txtdiachi.Text = ds.Tables[0].Rows[r][2].ToString();
                txtsdt.Text = ds.Tables[0].Rows[r][3].ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtManhacungcap.Text != "")
            {
                try
                {
                    CauLenh = "delete from NhaCungCap where MaNhaCungCap='" + txtManhacungcap.Text + "'";
                    kn.CaiDuLieu(CauLenh);
                    MessageBox.Show("Xoá thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp để xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
