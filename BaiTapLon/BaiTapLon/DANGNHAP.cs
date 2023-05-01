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
using System.Threading;
namespace BaiTapLon
{
    public partial class DANGNHAP : Form
    {
        
        public DANGNHAP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DANGKY myform = new DANGKY();
            myform.Show();
            Hide();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            int doituong = 0;
            for(doituong=100;doituong>=5;doituong -= 10)
            {
                this.Opacity = doituong / 95.0;
                this.Refresh();
                Thread.Sleep(100);
            }
           Close();
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                KetNoi.moketnoi();
                string taikhoan = tbusers.Text;
                string matkhau = tbpass.Text;
                string sql = "select * from USERS where Masv = '" + taikhoan + "' and MatKhau = '" + matkhau + "' ";
                KetNoi.cmd = new SqlCommand(sql, KetNoi.conn);
                KetNoi.dtreader = KetNoi.cmd.ExecuteReader();
                if (KetNoi.dtreader.Read() == true)
                {
                    string sql1 = "select * from USERS where Masv = '"+taikhoan+"'";
                    DataTable dt = KetNoi.getData(sql1);
                    string loaitk = dt.Rows[0][2].ToString();
                    bool gtloaitk = Convert.ToBoolean(loaitk);
                    if (gtloaitk==false)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        Qlsinhvien mainform = new Qlsinhvien();
                        mainform.Show();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        SINHVIEN subform = new SINHVIEN(taikhoan);
                        subform.Show();
                    }
                    Hide()
;
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                KetNoi.dongketnoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void cbhienthimk_CheckedChanged(object sender, EventArgs e)
        {
            if(cbhienthimk.Checked == true)
            {
                tbpass.PasswordChar = (char)0;
            }
            else
            {
                tbpass.PasswordChar = '✱';
            }
        }

        private void DANGNHAP_Load(object sender, EventArgs e)
        {
        }
    }
}
