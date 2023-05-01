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
    public partial class Qlsinhvien : Form
    {
        DialogResult dr;
        public Qlsinhvien()
        {
            InitializeComponent();
        }

        #region
        public void loadcombobox()
        {
            //Mã Lớp
            string sql = "select MaLop from LOP order by MaLop ASC";
            cbbmalop.DataSource = KetNoi.getData(sql);
            cbbmalop.ValueMember = "MaLop";
            //Khoa
            string sql1 = "select * from KHOA";
            cbbmakhoa.DataSource = KetNoi.getData(sql1);
            cbbmakhoa.ValueMember = "MaKhoa";
            cbbtenkhoa.DataSource = KetNoi.getData(sql1);
            cbbtenkhoa.ValueMember = "TenKhoa";
            cbbmakhoa2.DataSource = KetNoi.getData(sql1);
            cbbmakhoa2.ValueMember = "MaKhoa";
            //Mã sinh viên
            string sql2 = "select Masv from SINHVIEN order by Masv ASC";
            cbbmasv.DataSource = KetNoi.getData(sql2);
            cbbmasv.ValueMember = "Masv";
            cbbtaikhoan.DataSource = KetNoi.getData(sql2);
            cbbtaikhoan.ValueMember = "Masv";
            //Môn Học
            string sql3 = "select * from MONHOC order by MaMH ASC";
            cbbmamonhoc.DataSource = KetNoi.getData(sql3);
            cbbmamonhoc.ValueMember = "MaMH";
            cbbtenmh.DataSource = KetNoi.getData(sql3);
            cbbtenmh.ValueMember = "TenMH";

            //account type
            string sql4 = "select LoaiTaiKhoan from USERS";
            cbbtypeaccount.DataSource = KetNoi.getData(sql4);
            cbbtypeaccount.ValueMember = "LoaiTaikhoan";
        }
        public void loadData()
        {
            //Sinh Viên
            string sql = "Select * from SINHVIEN";
            datashow.DataSource = KetNoi.getData(sql);
            //Khoa
            string sql1 = "select * from KHOA";
            datashow2.DataSource = KetNoi.getData(sql1);
            //Lớp
            string sql3 = "select * from LOP";
            datashow3.DataSource = KetNoi.getData(sql3);
            //Môn Học
            string sql4 = "select * from MONHOC";
            datashow4.DataSource = KetNoi.getData(sql4);
            //Kết Quả
            string sql5 = "select * from KETQUA ORDER BY DiemThi DESC";
            datashow5.DataSource = KetNoi.getData(sql5);
            //Users
            string sql6 = "select * from Users";
            datashow6.DataSource = KetNoi.getData(sql6);
        }
        #endregion

        private void Qlsinhvien_Load(object sender, EventArgs e)
        {
            KetNoi.moketnoi();
            loadcombobox();
            loadData();

            if (datashow != null || datashow2 != null || datashow3 != null || datashow4 != null || datashow5 != null || datashow6 != null)
            {
                datashow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                datashow.Columns[datashow.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                datashow2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                datashow2.Columns[datashow2.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                datashow3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                datashow3.Columns[datashow3.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                datashow4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                datashow4.Columns[datashow4.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                datashow5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                datashow5.Columns[datashow5.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                datashow6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                datashow6.Columns[datashow6.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        //Tab_1 Quản Lý Sinh Viên
        //Cell_click bảng SinhVien
        private void datashow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datashow.CurrentCell.RowIndex;
            tbmasv.Text = datashow.Rows[i].Cells[0].Value.ToString();
            tbhoten.Text = datashow.Rows[i].Cells[1].Value.ToString();
            dtpkdate.Text = datashow.Rows[i].Cells[2].Value.ToString();
            string gt = datashow.Rows[i].Cells[3].Value.ToString();
            if(gt == "True")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            tbnienkhoa.Text = datashow.Rows[i].Cells[4].Value.ToString();
            cbbmalop.SelectedValue = datashow.Rows[i].Cells[5].Value.ToString();
        }
        //Thêm thông tin SinhVien
        private void btthem_Click_1(object sender, EventArgs e)
        {
            KetNoi.moketnoi();
            if (KetNoi.ktMaSV(tbmasv.Text) == 0)
            {
                string sql = "Insert into SINHVIEN Values (@Masv, @HoTen, @NgaySinh, @GioiTinh, @NienKhoa, @MaLop)";
                string[] name = { "@Masv", "@HoTen", "@NgaySinh", "@GioiTinh", "@NienKhoa", "@MaLop" };
                bool gt = rdNam.Checked == true ? true : false;
                object[] value = { tbmasv.Text, tbhoten.Text, dtpkdate.Value, gt, tbnienkhoa.Text, cbbmalop.SelectedValue };

                KetNoi.updateData(sql, value, name, 6);
                loadData();
                loadcombobox();
                MessageBox.Show("Đã thêm thành công vào cơ sở dữ liệu");
                KetNoi.dongketnoi();
            }
            else
            {
                MessageBox.Show("Mã sinh viên đã tồn tại vui lòng nhập mã khác!");
            }
        }
        //Sửa thông tin SinhVien
        private void btsua_Click(object sender, EventArgs e)
        {
            dr = MessageBox.Show("Bạn có đồng ý sửa lại thông tin không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                string sql = String.Format(@"Update SINHVIEN set Masv = @Masv, HoTen = @HoTen, NgaySinh = @NgaySinh,
                                            GioiTinh = @GioiTinh, NienKhoa = @NienKhoa, MaLop = @MaLop where Masv = '{0}'", tbmasv.Text);
                string[] name = { "@Masv", "@HoTen", "@NgaySinh", "@GioiTinh", "@NienKhoa", "@MaLop" };
                bool gt = rdNam.Checked == true ? true : false;
                object[] value = { tbmasv.Text, tbhoten.Text, dtpkdate.Value, gt, tbnienkhoa.Text, cbbmalop.SelectedValue };
                KetNoi.moketnoi();
                KetNoi.updateData(sql, value, name, 6);
                loadData();
                KetNoi.dongketnoi();
                MessageBox.Show("Đã sửa thành công vào csdl");
            }
        }
        //load lại bảng SinhVien
        private void btlammoi_Click_1(object sender, EventArgs e)
        {
            string sql = "Select * from SINHVIEN";
            tbmasv.Text = "";
            tbhoten.Text = "";
            rdNam.Checked = false;
            rdNu.Checked = false;
            dtpkdate.Value = DateTime.Today;
            tbnienkhoa.Text = "";
            cbbmalop.SelectedValue = "";
            KetNoi.moketnoi();
            datashow.DataSource = KetNoi.getData(sql);
            loadData();
            KetNoi.dongketnoi();
        }
        //Xoá thông tin SinhVien
        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Bạn có muốn xoá không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                int i = datashow.CurrentCell.RowIndex;
                string ma = datashow.Rows[i].Cells[0].Value.ToString();
                string sql = string.Format("Delete from SINHVIEN where Masv = '{0}'", ma);
                string[] name = { };
                object[] value = { };
                KetNoi.moketnoi();
                KetNoi.updateData(sql, value, name, 0);
                loadData();
                loadcombobox();
                KetNoi.dongketnoi();
                MessageBox.Show("Bạn đã xoá thành công");
            }
            else
            {
                MessageBox.Show("Bạn đã huỷ đối tượng này");
            }
        }
        //Tìm họ tên trong bảng SinhVien
        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from SINHVIEN where HoTen like N'%{0}'", tbhoten.Text);
            KetNoi.moketnoi();
            datashow.DataSource = KetNoi.getData(sql);
            KetNoi.dongketnoi();
        }

        //Tab_2 Khoa
        //Cell_click bảng Khoa
        private void datashow2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datashow2.CurrentCell.RowIndex;
            cbbmakhoa.SelectedValue = datashow2.Rows[i].Cells[0].Value.ToString();
            cbbtenkhoa.SelectedValue = datashow2.Rows[i].Cells[1].Value.ToString();
            tbcbgv.Text = datashow2.Rows[i].Cells[2].Value.ToString();
        }
        //Cập nhật số lượng Giảng Viên dạy theo Khoa
        private void btcapnhat_Click(object sender, EventArgs e)
        {
            dr = MessageBox.Show("Bạn có đồng ý cập nhật hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                string sql = string.Format(@"Update KHOA set MaKhoa = @MaKhoa, TenKhoa = @TenKhoa, SoCBGV = @SoCBGV
                                            where MaKhoa = @MaKhoa");

                string[] name = { "@MaKhoa", "@TenKhoa", "@SoCBGV" };
                object[] value = { cbbmakhoa.SelectedValue, cbbtenkhoa.SelectedValue, tbcbgv.Text };
                KetNoi.moketnoi();
                KetNoi.updateData(sql, value, name, 3);
                loadData();
                KetNoi.dongketnoi();
                MessageBox.Show("Đã cập nhật thành công");
            }
        }
        //Load lại bảng Khoa
        private void btlammoi1_Click(object sender, EventArgs e)
        {
            string sql = "select * from KHOA";
            cbbmakhoa.SelectedValue = "";
            cbbtenkhoa.SelectedValue = "";
            tbcbgv.Text = "";
            KetNoi.moketnoi();
            KetNoi.getData(sql);
            loadData();
            KetNoi.dongketnoi();
        }

        //Tab_3 Lớp
        //Cell_click bảng Lớp
        private void datashow3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datashow3.CurrentCell.RowIndex;
            tbmalop.Text = datashow3.Rows[i].Cells[0].Value.ToString();
            tbtenlop.Text = datashow3.Rows[i].Cells[1].Value.ToString();
            cbbmakhoa2.SelectedValue = datashow3.Rows[i].Cells[2].Value.ToString();
        }
        //Thêm thông tin Lớp học
        private void btthemlop_Click(object sender, EventArgs e)
        {
            if (KetNoi.ktMaLop(tbmalop.Text) == 0)
            {
                string sql = "Insert into LOP VALUES (@MaLop, @TenLop, @MaKhoa)";
                string[] name = { "@MaLop", "@TenLop", "@MaKhoa" };
                object[] value = { tbmalop.Text, tbtenlop.Text, cbbmakhoa2.SelectedValue };
                KetNoi.moketnoi();
                KetNoi.updateData(sql, value, name, 3);
                loadData();
                KetNoi.dongketnoi();
                MessageBox.Show("Bạn đã thêm Lớp thành công");
            }
            else
            {
                MessageBox.Show("Bị trùng mã lớp!");
            }
        }
        //Load lại bảng Lớp
        private void btlammoi2_Click(object sender, EventArgs e)
        {
            string sql = "Select * from LOP";
            tbmalop.Text = "";
            tbtenlop.Text = "";
            cbbmakhoa2.SelectedValue = "";
            KetNoi.moketnoi();
            datashow3.DataSource = KetNoi.getData(sql);
            loadData();
            KetNoi.dongketnoi();
        }
        //Xoá thông tin Lớp
        private void btxoa2_Click(object sender, EventArgs e)
        {
            dr = MessageBox.Show("Bạn có chắc chắn muốn xoá hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                string sql = string.Format("Delete from LOP where MaLop = '{0}'", tbmalop.Text);
                string[] name = { };
                object[] value = { };
                KetNoi.moketnoi();
                KetNoi.updateData(sql, value, name, 0);
                loadData();
                KetNoi.dongketnoi();
                MessageBox.Show("Bạn đã xoá thành công");
            }
        }
        //Tìm mã lớp trong bảng Lớp
        private void bttimlop_Click(object sender, EventArgs e)
        {
            string sql = string.Format("Select * from LOP where MaLop = '{0}'", tbmalop.Text);
            KetNoi.moketnoi();
            datashow3.DataSource = KetNoi.getData(sql);
            KetNoi.dongketnoi();
        }

        //Tab_4 Môn Học
        //Cell_click bảng Môn Học
        private void datashow4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datashow4.CurrentCell.RowIndex;
            tbmamh.Text = datashow4.Rows[i].Cells[0].Value.ToString();
            tbtenmh.Text = datashow4.Rows[i].Cells[1].Value.ToString();
            tbtinchi.Text = datashow4.Rows[i].Cells[2].Value.ToString();
            tbsotiet.Text = datashow4.Rows[i].Cells[3].Value.ToString();
        }
        //Thêm thông tin Môn Học
        private void btthem3_Click(object sender, EventArgs e)
        {
            if (KetNoi.ktMaMH(tbmamh.Text) == 0)
            {
                string sql = "Insert into MONHOC VALUES(@MaMH, @TenMH, @TinChi, @SoTiet)";
                string[] name = { "@MaMH", "@TenMH", "@TinChi", "@SoTiet" };
                object[] value = { tbmamh.Text, tbtenmh.Text, tbtinchi.Text, tbsotiet.Text };
                KetNoi.moketnoi();
                KetNoi.updateData(sql, value, name, 4);
                loadData();
                loadcombobox();
                KetNoi.dongketnoi();
                MessageBox.Show("Đã Thêm Thành công");
            }
            else
            {
                MessageBox.Show("Mã môn học bị trùng!");
            }
        }
        //Load lại bảng Môn Học
        private void btlammoi3_Click(object sender, EventArgs e)
        {
            tbmamh.Text = "";
            tbtenmh.Text = "";
            tbtinchi.Text = "";
            tbsotiet.Text = "";
            string sql = "select * from MONHOC";
            KetNoi.moketnoi();
            datashow4.DataSource = KetNoi.getData(sql);
            loadData();
            KetNoi.dongketnoi();
        }
        //Sửa thông tin Môn Học
        private void btsua2_Click(object sender, EventArgs e)
        {
            dr = MessageBox.Show("Bạn có đồng ý sửa hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = string.Format(@"Update MONHOC set MAMH = @MaMH, TenMH = @TenMH, TinChi = @TinChi, SoTiet = @SoTiet
                                            where MaMH = @MaMH");

                string[] name = { "@MaMH", "@TenMH", "@TinChi", "@SoTiet"};
                object[] value = { tbmamh.Text, tbtenmh.Text, tbtinchi.Text, tbsotiet.Text };
                KetNoi.moketnoi();
                KetNoi.updateData(sql, value, name, 4);
                loadData();
                KetNoi.dongketnoi();
            }
            MessageBox.Show("Đã cập nhật thành công");
        }
        //Tìm mã môn học trong bảng Môn Học
        private void bttimkiem2_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from MONHOC where MaMH = '{0}'", tbmamh.Text);
            KetNoi.moketnoi();
            datashow4.DataSource = KetNoi.getData(sql);
            KetNoi.dongketnoi();
        }

        //Tab_5 Kết Quả
        //Cel_click bảng Kết Quả
        private void datashow5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datashow5.CurrentCell.RowIndex;
            cbbmamonhoc.SelectedValue = datashow5.Rows[i].Cells[0].Value.ToString();
            cbbmasv.SelectedValue = datashow5.Rows[i].Cells[1].Value.ToString();
            cbbtenmh.SelectedValue = datashow5.Rows[i].Cells[2].Value.ToString();
            tbdiemthi.Text = datashow5.Rows[i].Cells[3].Value.ToString();
        }
        //Thêm thông tin vào bảng Kết Quả
        private void btthem4_Click(object sender, EventArgs e)
        {
            string sql = "Insert into KETQUA VALUES(@MaMH, @Masv, @TenMH, @DiemThi)";
            string[] name = { "@MaMH", "@Masv", "@TenMH", "@DiemThi" };
            object[] value = { cbbmamonhoc.SelectedValue, cbbmasv.SelectedValue, cbbtenmh.SelectedValue, tbdiemthi.Text };
            KetNoi.moketnoi();
            KetNoi.updateData(sql, value, name, 4);
            loadData();
            KetNoi.dongketnoi();
            MessageBox.Show("Thêm thành công");
        }
        //Load lại bảng Kết Quả
        private void btlammoi5_Click(object sender, EventArgs e)
        {
            KetNoi.moketnoi();
            cbbmamonhoc.SelectedValue = "";
            cbbmasv.SelectedValue = "";
            cbbtenmh.SelectedValue = "";
            tbdiemthi.Text = "";
            loadData();
            KetNoi.dongketnoi();
        }

        //Tab_6 USERS
        //Cell_click bảng USERS
        private void datashow6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datashow6.CurrentCell.RowIndex;
            cbbtaikhoan.SelectedValue = datashow6.Rows[i].Cells[0].Value.ToString();
            tbmatkhau.Text = datashow6.Rows[i].Cells[1].Value.ToString();
        }
        //Load lại bảng USERS
        private void btlammoi6_Click(object sender, EventArgs e)
        {
            KetNoi.moketnoi();
            cbbtaikhoan.SelectedValue = "";
            tbmatkhau.Text = "";
            loadData();
            KetNoi.dongketnoi();
        }
        //Thêm tài khoản cho người dùng đăng nhập
        private void btthem5_Click(object sender, EventArgs e)
        {
            string sql = "Insert into USERS VALUES(@Masv, @MatKhau, @LoaiTaikhoan)";
            string[] name = { "@Masv", "@MatKhau", "@LoaiTaikhoan" };
            object[] value = { cbbtaikhoan.SelectedValue, tbmatkhau.Text, cbbtypeaccount.SelectedValue };
            KetNoi.moketnoi();
            KetNoi.updateData(sql, value, name, 3);
            MessageBox.Show("Đã thêm thành công vào csdl");
            loadData();
            KetNoi.dongketnoi();
        }
        //Đổi mật khẩu bảng USERS
        private void btdoimatkhau_Click(object sender, EventArgs e)
        {
            KetNoi.moketnoi();
            int i = datashow6.CurrentCell.RowIndex;
            string ma = datashow6.Rows[i].Cells[0].Value.ToString();
            string sql = string.Format("Update USERS set Masv = @Masv, MatKhau = @MatKhau where Masv = '{0}'", ma);
            string[] name = { "@Masv", "@MatKhau" };
            object[] value = { cbbtaikhoan.SelectedValue, tbmatkhau.Text };

            KetNoi.updateData(sql, value, name, 2);
            MessageBox.Show("Đổi mật khẩu thành công");
            loadData();
            KetNoi.dongketnoi();
        }

       
        //Khoá combobox không cho nhập
        private void cbbtaikhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbtaikhoan.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbbmamonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbmamonhoc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbbmasv_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbmasv.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbbmakhoa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbmakhoa2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbbmakhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbmakhoa.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbbtenkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbtenkhoa.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbbmalop_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbmalop.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbbtypeaccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbtypeaccount.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        





        //không dùng
        private void datashow5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {
        }
        private void tabPage5_Click(object sender, EventArgs e)
        {
        }
        private void tabPage6_Click(object sender, EventArgs e)
        {

        }
        private void datashow6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

    }
}
