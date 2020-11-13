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
    public partial class DoiEmail : Form
    {
        string ID;
        public DoiEmail(string Username)
        {
            ID = Username;
            InitializeComponent();
        }

        bool InputHopLe()
        {
            Error.Clear();
            bool bError = false;
            string E1 = Email1.Text;
            string E2 = Email2.Text;
            if (E1.Length == 0)
            {
                Error.SetError(Email1, "Hãy nhập email mới!");
                bError = true;
            }
            else if (E1.Contains("@") == false || E1.Contains(".") == false)
            {
                Error.SetError(Email1, "Địa chỉ email không hợp lệ!");
                bError = true;
            }
            if (E2.Length == 0)
            {
                Error.SetError(Email2, "Hãy nhập lại email mới!");
                bError = true;
            }
            else if (E1 != E2)
            {
                Error.SetError(Email2, "Email nhập lại chưa trùng khớp!");
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
                ChangeEmail();
        }
        private void ChangeEmail()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=POOHNHI;Database=QLNS;Trusted_Connection=true";
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE USERINFO SET Email=@E where TenDangNhap='" + ID + "'", con);
            cmd.Parameters.AddWithValue("@E", Email1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đổi email thành công!");
            con.Close();
            this.Close();
        }
    }
}
