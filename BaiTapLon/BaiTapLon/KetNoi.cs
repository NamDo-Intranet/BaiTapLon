using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BaiTapLon
{
    static class KetNoi
    {
        static public SqlConnection conn;
        static SqlDataAdapter da;
        static public SqlCommand cmd;
        static public SqlDataReader dtreader;
        static public void moketnoi()
        {
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["kn"].ConnectionString.ToString();
            conn.Open();
        }
        static public void dongketnoi()
        {
            conn.Close();
        }

        #region
        static public int ktMaSV(string ma)
        {
            string sql = string.Format("select count(*) from SINHVIEN Where Masv = '{0}'", ma);
            cmd = new SqlCommand(sql, conn);
            int soluong = (int)cmd.ExecuteScalar();
            return soluong;
        }
        static public int ktMaLop(string ma)
        {
            string sql = string.Format("select count(*) from LOP where MaLop = '{0}'", ma);
            cmd = new SqlCommand(sql, conn);
            int soluong = (int)cmd.ExecuteScalar();
            return soluong;
        }
        static public int ktMaMH(string ma)
        {
            string sql = string.Format("select count(*) from MONHOC where MaMH = '{0}'", ma);
            cmd = new SqlCommand(sql, conn);
            int soluong = (int)cmd.ExecuteScalar();
            return soluong;
        }
        #endregion

        static public DataTable getData(string sql)
        {
            DataTable dt = new DataTable();
            cmd = new SqlCommand(sql, conn);
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        static public void updateData(string sql, object[] value, string[] name, int slthamso)
        {
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            for (int i = 0; i < slthamso; i++)
                cmd.Parameters.AddWithValue(name[i], value[i]);
            cmd.ExecuteNonQuery();
        }
    }
}
