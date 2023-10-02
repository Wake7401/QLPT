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
    public partial class UC_Dashboard : UserControl
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        string CauLenh;
        DataSet ds;
        public UC_Dashboard()
        {
            InitializeComponent();
        }
        public void SetLabel(DataSet ds, Label lbl)
        {
            if(ds.Tables[0].Rows.Count>0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }

        public void LoadBieuDo()
        {
            int dem;
            CauLenh = "select count(MaNguoiDung) from NguoiDung where LoaiNguoiDung='Administrator'";
            ds = kn.LayDuLieu(CauLenh);
            dem = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chartDashBoardAdmin.Series["Administrator"].Points.AddXY("Biểu Đồ", dem);

            CauLenh = "select count(MaNguoiDung) from NguoiDung where LoaiNguoiDung='Nhân viên'";
            ds = kn.LayDuLieu(CauLenh);
            dem = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chartDashBoardAdmin.Series["Nhân viên"].Points.AddXY("Biểu Đồ", dem);

            CauLenh = "select count(MaKhachHang) from KhachHang";
            ds = kn.LayDuLieu(CauLenh);
            dem = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chartDashBoardAdmin.Series["Khách hàng"].Points.AddXY("Biểu Đồ", dem);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            LoadBieuDo();
            CauLenh = "select count(LoaiNguoiDung) from NguoiDung where LoaiNguoiDung='Administrator'";
            ds = kn.LayDuLieu(CauLenh);
            SetLabel(ds, lblAdmin);

            CauLenh = "select count(LoaiNguoiDung) from NguoiDung where LoaiNguoiDung='Nhân viên'";
            ds = kn.LayDuLieu(CauLenh);
            SetLabel(ds, lblNhanVien);

            CauLenh = "select count(MaKhachHang) from KhachHang";
            ds = kn.LayDuLieu(CauLenh);
            SetLabel(ds, lblKhachHang);

            CauLenh = "select count(MaHoaDon) from HoaDon";
            ds = kn.LayDuLieu(CauLenh);
            SetLabel(ds, lblSoDonTHuoc);

            CauLenh = "select sum(TongGia) from HoaDon";
            ds = kn.LayDuLieu(CauLenh);
            SetLabel(ds, lbltonggia);
        }

        private void lblNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
