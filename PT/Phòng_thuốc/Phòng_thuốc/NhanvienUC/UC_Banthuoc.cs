using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Phòng_thuốc.NhanvienUC
{
    public partial class UC_Banthuoc : UserControl
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        string CauLenh;
        DataSet ds;
        public void ClearText()
        {
            txtMaThuoc.Text = "";
            txtTenThuoc.Text = "";
            txtGiaMoiDonViThuoc.Text = "";
            txtSoLuongMua.Text = "";
            txtSoLuongMua.Text = "";
            txtTongGia.Text = "";
        }
        public UC_Banthuoc()
        {
            InitializeComponent();
        }
        private void UC_Banthuoc_Load(object sender, EventArgs e)
        {
            CauLenh = "select TenThuoc,SoLuong from Thuoc where HSD >= GETDATE() and SoLuong > 0";
            ds = kn.LayDuLieu(CauLenh);
            for(int i=0;i < ds.Tables[0].Rows.Count;i++)
            {
                lbxBanThuoc.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            txtTongGia.Enabled = false;
        }

        private void txttimthuoc_TextChanged(object sender, EventArgs e)
        {
            lbxBanThuoc.Items.Clear();
            CauLenh = "select TenThuoc from Thuoc where TenThuoc like '%"+txtTimThuoc.Text+"%' and HSD >= GETDATE() and SoLuong > 0";
            ds = kn.LayDuLieu(CauLenh);
            ds = kn.LayDuLieu(CauLenh);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lbxBanThuoc.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void lbxBanThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGiaMoiDonViThuoc.Clear();

            string name = lbxBanThuoc.GetItemText(lbxBanThuoc.SelectedItem);
            txtTenThuoc.Text = name;
            CauLenh = "select MaThuoc,GiaBan,HSD from Thuoc where TenThuoc='"+name+"'";
            ds = kn.LayDuLieu(CauLenh);
            txtMaThuoc.Text = ds.Tables[0].Rows[0][0].ToString();
            txtGiaMoiDonViThuoc.Text = ds.Tables[0].Rows[0][1].ToString();
            dtpHSD.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        protected int n, TongGia = 0;
        protected Int32 SoLuong, SoLuongMoi;

        private void txtSoLuongMua_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuongMua.Text != "")
            {
                Int32 GiaThuoc = Int32.Parse(txtGiaMoiDonViThuoc.Text);
                Int32 SoLuongMua = Int32.Parse(txtSoLuongMua.Text);
                Int32 TongGia = GiaThuoc * SoLuongMua;
                txtTongGia.Text = TongGia.ToString();
            }
            else
            {
                txtSoLuongMua.Text = "";
                txtTongGia.Text = "";
            }
        }

        private void btnThemVaoDonThuoc_Click(object sender, EventArgs e)
        {

            if(txtMaThuoc.Text!="")
            {
                if (txtKhachHang.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (txtSoLuongMua.Text == "" || txtSoLuongMua.Text == "0")
                    {
                        MessageBox.Show("Vui lòng nhập số lượng thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CauLenh = "select SoLuong from Thuoc where MaThuoc='" + txtMaThuoc.Text + "'";
                        ds = kn.LayDuLieu(CauLenh);

                        SoLuong = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                        SoLuongMoi = SoLuong - Int32.Parse(txtSoLuongMua.Text);

                        if (SoLuongMoi > 0)
                        {
                            n = dgvBanThuoc.Rows.Add();
                            dgvBanThuoc.Rows[n].Cells[0].Value = txtMaThuoc.Text;
                            dgvBanThuoc.Rows[n].Cells[1].Value = txtTenThuoc.Text;
                            dgvBanThuoc.Rows[n].Cells[2].Value = dtpHSD.Text;
                            dgvBanThuoc.Rows[n].Cells[3].Value = txtGiaMoiDonViThuoc.Text;
                            dgvBanThuoc.Rows[n].Cells[4].Value = txtSoLuongMua.Text;
                            dgvBanThuoc.Rows[n].Cells[5].Value = txtTongGia.Text;

                            TongGia = TongGia + int.Parse(txtTongGia.Text);
                            lblTongGiaDonThuoc.Text = "Tổng giá đơn thuốc: " + TongGia.ToString();

                            CauLenh = "update Thuoc set SoLuong=" + SoLuongMoi + " where MaThuoc='" + txtMaThuoc.Text + "'";
                            kn.CaiDuLieu(CauLenh);

                            MessageBox.Show("Đã thêm vào đơn thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Số lượng không đủ! \n Chỉ còn " + SoLuong + " đơn vị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        lbxBanThuoc.Items.Clear();
                        ClearText();
                        UC_Banthuoc_Load(this, null);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thuốc trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int GiaTriSoLuongMua;
        string GiaTriID;
        protected Int32 SoLuongDonVi;

        private void dgvBanThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GiaTriSoLuongMua = int.Parse(dgvBanThuoc.Rows[e.RowIndex].Cells[5].Value.ToString());
                GiaTriID = dgvBanThuoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                SoLuongDonVi = Int32.Parse(dgvBanThuoc.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch
            {

            }
        }

        private void btnloaibo_Click(object sender, EventArgs e)
        {
                if (GiaTriID != "")
                {
                    try
                    {
                        dgvBanThuoc.Rows.RemoveAt(this.dgvBanThuoc.SelectedRows[0].Index);
                    }
                    catch (Exception)
                    {

                    }
                    finally
                    {
                        CauLenh = "select SoLuong from Thuoc where MaThuoc='" + GiaTriID + "'";
                        ds = kn.LayDuLieu(CauLenh);
                        SoLuong = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                        SoLuongMoi = SoLuong + SoLuongDonVi;

                        CauLenh = "update Thuoc set SoLuong=" + SoLuongMoi + " where MaThuoc='" + GiaTriID + "'";
                        kn.CaiDuLieu(CauLenh);

                        MessageBox.Show("Đã xoá khỏi đơn thuốc đơn thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TongGia = TongGia - GiaTriSoLuongMua;
                        lblTongGiaDonThuoc.Text = "Tổng giá đơn thuốc: " + TongGia.ToString();
                    }
                    lbxBanThuoc.Items.Clear();
                    UC_Banthuoc_Load(this, null);
                }
        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {
            try
            {
                CauLenh = "insert into KhachHang (MaKhachHang, TenKhachHang, SoDienThoai) values ("+txtMaKhachHang.Text+",N'"+txtKhachHang.Text+"','"+txtSdt.Text+"')";
                kn.CaiDuLieu(CauLenh);
            }
            catch (Exception)
            {
                MessageBox.Show("In thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                CauLenh = "insert into HoaDon (MaHoaDon, MaKhachHang, TenKhachHang, NgayBan, TongGia) values ("+txtMaHoaDon.Text+"," + txtMaKhachHang.Text + ", N'"+txtKhachHang.Text+"', '" + DateTime.Now + "', " + TongGia + ")";
                kn.CaiDuLieu(CauLenh);
            }
            catch (Exception)
            {
                MessageBox.Show("In thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            /*try
            {
                for (int i = 0; i > dgvBanThuoc.RowCount - 1; i++ )
                {
                    CauLenh = "insert into ChiTietHoaDon (MaHoaDon, MaThuoc, SoLuongMua, TongGia) values (" + txtMaHoaDon.Text + ", '"+GiaTriID+"','"+SoLuongDonVi+"','"+GiaTriSoLuongMua+"')";
                    kn.CaiDuLieu(CauLenh);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("In thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/

            DGVPrinter inhoadon = new DGVPrinter();
            inhoadon.Title = "Đơn thuốc";
            inhoadon.SubTitle = String.Format("Ngày bán: {0}, Họ tên người mua: {1}", DateTime.Now, txtKhachHang.Text);
            inhoadon.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            inhoadon.PageNumbers = true;
            inhoadon.PageNumberInHeader = true;
            inhoadon.PorportionalColumns = true;
            inhoadon.HeaderCellAlignment = StringAlignment.Near;
            inhoadon.Footer = lblTongGiaDonThuoc.Text;
            inhoadon.FooterSpacing = 15;
            inhoadon.PrintDataGridView(dgvBanThuoc);

            MessageBox.Show("Đã in hoá đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
