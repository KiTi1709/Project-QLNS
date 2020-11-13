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
    public partial class DoiMatKhau : Form
    {
        string ID;
        public DoiMatKhau(string Username)
        {
            ID = Username;
            InitializeComponent();
        }

        bool InputHopLe()
        {
            Error.Clear();
            bool bError = false;
            string PW = OldPW.Text;
            if (PW.Length == 0)
            {
                Error.SetError(OldPW, "Hãy nhập mật khẩu cũ!");
                bError = true;
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=POOHNHI;Database=QLNS;Trusted_Connection=true";
                con.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("SELECT MatKhau FROM LOGININFO WHERE TenDangNhap = '" + ID + "'", con);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                if (dt.Rows[0][0].ToString() != PW)
                {
                    Error.SetError(OldPW, "Sai mật khẩu!");
                    bError = true;
                }
                con.Close();
            }
            string PW1 = NewPW.Text;
            if (PW1.Length == 0)
            {
                Error.SetError(NewPW, "Hãy nhập mật khẩu mới!");
                bError = true;
            }
            else if(PW1.Length < 6)
            {
                Error.SetError(NewPW, "Mật khẩu mới phải có ít nhất 6 kí tự!");
                bError = true;
            }
            string PW2 = NewPW2.Text;
            if (PW2.Length == 0)
            {
                Error.SetError(NewPW2, "Hãy nhập lại mật khẩu mới!");
                bError = true;
            }
            else if(PW2 != PW1)
            {
                Error.SetError(NewPW2, "Mật khẩu nhập lại chưa trùng khớp!");
                bError = true;
            }

            if (bError == true)
                return false;
            else
                Error.Clear();
            return true;
        }

        private void NutXacNhan_Click(object sender, EventArgs e)
        {
            if (InputHopLe() == false)
                return;
            else
                ChangePassword();
        }
        private void ChangePassword()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=POOHNHI;Database=QLNS;Trusted_Connection=true";
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE LOGININFO SET MatKhau=@MK where TenDangNhap='" + ID + "'", con);
            cmd.Parameters.AddWithValue("@MK", NewPW.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đổi mật khẩu thành công!");
            con.Close();
            this.Close();
        }
    }
}
