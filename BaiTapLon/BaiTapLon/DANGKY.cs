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
    public partial class DANGKY : Form
    {
        public DANGKY()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DANGNHAP mylogin = new DANGNHAP();
            mylogin.Show();
            Hide();
        }

        private void btdangky_Click(object sender, EventArgs e)
        {
            KetNoi.moketnoi();
            string taikhoan = tbtaikhoan.Text;
            string matkhau = tbmatkhau.Text;
            string repass = tbnhaplaimk.Text;
            string querysql1 = "select * from USERS where Masv = '" + taikhoan + "'";
            string querysql2 = "select Masv from SINHVIEN where Masv = '" + taikhoan + "' ";
            KetNoi.cmd = new SqlCommand(querysql1, KetNoi.conn);
            KetNoi.dtreader = KetNoi.cmd.ExecuteReader();
            if (KetNoi.dtreader.Read() == true)
            {
                MessageBox.Show("Tài khoản đã được đăng ký", "Thông Báo");
            }
            else
            {
                KetNoi.cmd= new SqlCommand(querysql2, KetNoi.conn);
                KetNoi.dtreader = KetNoi.cmd.ExecuteReader();
                bool loaitkSV = true;
                if(KetNoi.dtreader.Read() == true)
                {
                    if (matkhau == repass)
                    {
                        string sql = "Insert into USERS VALUES('" + taikhoan + "', '" + matkhau + "', '" + loaitkSV + "')";
                        string[] name = { "@Masv", "@MatKhau", "@LoaiTaikhoan" };
                        object[] value = { taikhoan, matkhau, loaitkSV };
                        KetNoi.updateData(sql, value, name, 3);
                        MessageBox.Show("Đã đăng ký thành công", "Thông Báo");
                    }
                    else
                    {
                        MessageBox.Show("Nhập lại mật khẩu không chính xác!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại mã sinh viên này trong CSDL", "Thông Báo");
                }              
            }
            KetNoi.dongketnoi();
        }

        private void cbhienmk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhienmk.Checked == true)
            {
                tbmatkhau.PasswordChar = (char)0;
                tbnhaplaimk.PasswordChar = (char)0;
            }
            else
            {
                tbmatkhau.PasswordChar = '✱';
                tbnhaplaimk.PasswordChar = '✱';
            }
        }

        private void DANGKY_Load(object sender, EventArgs e)
        {

        }
    }
}
