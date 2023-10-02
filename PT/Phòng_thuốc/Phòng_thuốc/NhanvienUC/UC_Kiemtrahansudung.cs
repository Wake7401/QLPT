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
    public partial class UC_Kiemtrahansudung : UserControl
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        string CauLenh;
        DataSet ds;

        public UC_Kiemtrahansudung()
        {
            InitializeComponent();
        }

        private void cbxKiemTraHSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxKiemTraHSD.SelectedIndex == 0)
            {
                CauLenh = "select * from Thuoc where HSD >= GETDATE()";
                ds = kn.LayDuLieu(CauLenh);
                dgvKiemTraHSD.DataSource = ds.Tables[0];
            }
            else if(cbxKiemTraHSD.SelectedIndex == 1)
            {
                CauLenh = "select * from Thuoc where HSD <= GETDATE()";
                ds = kn.LayDuLieu(CauLenh);
                dgvKiemTraHSD.DataSource = ds.Tables[0];
            }
            else
            {
                CauLenh = "select * from Thuoc";
                ds = kn.LayDuLieu(CauLenh);
                dgvKiemTraHSD.DataSource = ds.Tables[0];
            }
        }

        private void UC_Kiemtrahansudung_Load(object sender, EventArgs e)
        {

        }

        private void lblKiemTraHSD_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
