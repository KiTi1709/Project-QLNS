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
    public partial class ManHinhDangNhap : Form
    {
        SqlConnection con = new SqlConnection();
        public ManHinhDangNhap()
        {
            InitializeComponent();
        }
        private void NutDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=POOHNHI;Database=QLNS;Trusted_Connection=true";
            con.Open();
            //Kết nối với database
            SqlDataAdapter cmd = new SqlDataAdapter("select * from LOGININFO where TenDangNhap='" + BoxID.Text + "'and MatKhau='" + BoxPassword.Text + "'", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            //Kiểm tra trùng khớp loại tài khoản, tên tài khoản và mật khẩu
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                if (dt.Rows[0][2].ToString() == "User")
                {
                    this.Hide();
                    GiaoDien MHGD = new GiaoDien(BoxID.Text);
                    MHGD.ShowDialog();
                }
                else if (dt.Rows[0][2].ToString() == "Admin")
                {
                    this.Hide();
                    AdminPanel AP = new AdminPanel(BoxID.Text);
                    AP.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoản!");
            }
            con.Close();
        }
    }
}
