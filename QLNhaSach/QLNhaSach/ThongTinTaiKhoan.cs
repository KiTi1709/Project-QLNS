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

namespace QLNhaSach
{
    public partial class ThongTinTaiKhoan : Form
    {
        string ID;
        public ThongTinTaiKhoan(string Username)
        {
            ID = Username;
            InitializeComponent();
            GetData();
        }
        public void GetData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=POOHNHI;Database=QLNS;Trusted_Connection=true";
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select HoTen, GioiTinh, DiaChi, SDT, CMND, NgaySinh, Email, DiemTichLuy from USERINFO where TenDangNhap = '" + ID + "'", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            ThongTinCaNhan.Text = "Họ và tên: " + dt.Rows[0]["HoTen"]
            + Environment.NewLine
            + Environment.NewLine
            + Environment.NewLine + "Giới tính: " + dt.Rows[0]["GioiTinh"]
            + Environment.NewLine
            + Environment.NewLine
            + Environment.NewLine + "Ngày sinh: " + ((DateTime)dt.Rows[0]["NgaySinh"]).ToString("dd/MM/yyyy")
            + Environment.NewLine
            + Environment.NewLine
            + Environment.NewLine + "Số điện thoại: " + dt.Rows[0]["SDT"];
            ThongTinAccount.Text = "Tên đăng nhập: " + ID
            + Environment.NewLine
            + Environment.NewLine
            + Environment.NewLine + "Email: " + dt.Rows[0]["Email"]
            + Environment.NewLine
            + Environment.NewLine
            + Environment.NewLine + "Số chứng minh thư: " + dt.Rows[0]["CMND"]
            + Environment.NewLine
            + Environment.NewLine
            + Environment.NewLine + "Số điểm tích lũy: " + dt.Rows[0]["DiemTichLuy"]
            + Environment.NewLine
            + Environment.NewLine
            + Environment.NewLine + "Số điểm tích luỹ đã tiêu thụ: " + 0;
            con.Close();
        }

        private void NutDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau DMK = new DoiMatKhau(ID);
            DMK.ShowDialog();
            this.Show();
        }

        private void NutDoiEmail_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiEmail DE = new DoiEmail(ID);
            DE.ShowDialog();
            GetData();
            this.Show();
        }
    }
}
