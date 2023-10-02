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
    public partial class UC_Dashboard_2 : UserControl
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        string CauLenh;
        DataSet ds;
        Int32 dem;
        public UC_Dashboard_2()
        {
            InitializeComponent();
        }
        public void LoadBieuDo()
        {
            CauLenh = "select count(MaThuoc) from Thuoc where HSD <= GETDATE()";
            ds = kn.LayDuLieu(CauLenh);
            dem = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Thuốc hết hạn"].Points.AddXY("Biểu Đồ Thuốc", dem);

            CauLenh = "select count(MaThuoc) from Thuoc where HSD >= GETDATE()";
            ds = kn.LayDuLieu(CauLenh);
            dem = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Thuốc còn hạn"].Points.AddXY("Biểu Đồ Thuốc", dem);
        }

        private void UC_Dashboard_2_Load(object sender, EventArgs e)
        {           
            LoadBieuDo();
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            chart1.Series["Thuốc hết hạn"].Points.Clear();
            chart1.Series["Thuốc còn hạn"].Points.Clear();
            LoadBieuDo();
        }
    }
}
