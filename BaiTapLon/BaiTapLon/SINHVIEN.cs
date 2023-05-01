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

namespace BaiTapLon
{
    public partial class SINHVIEN : Form
    {
        public SINHVIEN(string username)
        {
            InitializeComponent();
            lbusername.Text = username;
        }

        #region
        public void loadData()
        {
            string sql = @"SELECT SINHVIEN.Masv, SINHVIEN.HoTen, SINHVIEN.NgaySinh, SINHVIEN.GioiTinh, 
                                        KETQUA.TenMH, KETQUA.DiemThi, lOP.TenLop, KHOA.TenKhoa
                           FROM (KETQUA RIGHT JOIN SINHVIEN ON KETQUA.Masv = SINHVIEN.Masv) 
                                        INNER JOIN LOP ON SINHVIEN.MaLop = LOP.MaLop INNER JOIN KHOA ON LOP.MaKhoa = KHOA.MaKhoa ORDER BY DiemThi DESC";
            Datagridshow.DataSource = KetNoi.getData(sql);
        }
        #endregion

        private void SINHVIEN_Load(object sender, EventArgs e)
        {
            KetNoi.moketnoi();
            loadData();
            if (Datagridshow != null)
            {
                Datagridshow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                Datagridshow.Columns[Datagridshow.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
