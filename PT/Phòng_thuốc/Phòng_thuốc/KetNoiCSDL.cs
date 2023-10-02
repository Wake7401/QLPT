using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Phòng_thuốc
{
    class KetNoiCSDL
    {
        protected SqlConnection KN()
        {
            SqlConnection ketnoi = new SqlConnection();
            ketnoi.ConnectionString = "Data Source=DESKTOP-VA9SP5A;Initial Catalog=QuanLyNhaThuoc;Integrated Security=True";
            return ketnoi;
        }
        public DataSet LayDuLieu(string CauLenh)
        {
            SqlConnection ketnoi = KN();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ketnoi;
            cmd.CommandText = CauLenh;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void CaiDuLieu(string CauLenh)
        {
            SqlConnection ketnoi = KN();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ketnoi;
            ketnoi.Open();
            cmd.CommandText = CauLenh;
            cmd.ExecuteNonQuery();
            ketnoi.Close();
        }
    }
}
