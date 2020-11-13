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
    public partial class ManHinhDangKy : Form
    {
        public ManHinhDangKy()
        {
            InitializeComponent();
            BoxGender.Text = "Nam";
        }
        /*
        private void ManHinhDangKy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet.USERINFO' table. You can move, or remove it, as needed.
            this.uSERINFOTableAdapter.Fill(this.qLNSDataSet.USERINFO);
        }*/

        private void Reset_Click(object sender, EventArgs e)
        {
            BoxID.Clear();
            BoxPW.Clear();
            BoxPW2.Clear();
            BoxName.Clear();
            BoxAddress.Clear();
            BoxPhone.Clear();
            BoxCMND.Clear();
            BoxMail.Clear();
        }

        bool InputHopLe()
        {
            Error.Clear();
            bool bError = false;
            string ID = BoxID.Text;
            if (ID.Length == 0)
            {
                Error.SetError(BoxID, "Hãy nhập tên đăng nhập!");
                bError = true;
            }
            else if (ID.Length < 4)
            {
                Error.SetError(BoxID, "Tên đăng nhập phải có ít nhất 4 kí tự!");
                bError = true;
            }
            else
            { 
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=POOHNHI;Database=QLNS;Trusted_Connection=true";
                con.Open();
                //Kết nối với database
                SqlCommand check_User_Name = new SqlCommand("SELECT * FROM LOGININFO WHERE ([TenDangNhap] = @TenDangNhap)", con);
                check_User_Name.Parameters.AddWithValue("@TenDangNhap", BoxID.Text);
                SqlDataReader reader = check_User_Name.ExecuteReader();
                //Kiểm tra nếu ID đã bị đăng ký rồi
                if (reader.HasRows)
                {
                    Error.SetError(BoxID, "Tên đăng nhập đã bị trùng, hãy nhập tên khác!");
                    bError = true;
                }
                con.Close();
            }
            string PW = BoxPW.Text;
            if (PW.Length == 0)
            {
                Error.SetError(BoxPW, "Hãy nhập mật khẩu!");
                bError = true;
            }
            else if (PW.Length < 6)
            {
                Error.SetError(BoxPW, "Mật khẩu phải có ít nhất 6 kí tự!");
                bError = true;
            }
            string PW2 = BoxPW2.Text;
            if (PW2 != PW)
            {
                Error.SetError(BoxPW2, "Mật khẩu nhập lại không trùng khớp!");
                bError = true;
            }
            string name = BoxName.Text;
            if (name.Length == 0)
            {
                Error.SetError(BoxName, "Hãy nhập tên!");
                bError = true;
            }
            string gender = BoxGender.Text.ToUpper();
            if(gender != "NAM" && gender != "NỮ")
            {
                Error.SetError(BoxGender, "Hãy chọn giới tính nam hoặc nữ!");
                bError = true;
            }
            string Address = BoxAddress.Text;
            if (Address.Length == 0)
            {
                Error.SetError(BoxAddress, "Hãy nhập địa chỉ!");
                bError = true;
            }
            string Phone = BoxPhone.Text;
            if (Phone.Length < 10)
            {
                Error.SetError(BoxPhone, "Hãy nhập chính xác số điện thoại!");
                bError = true;
            }
            string CMND = BoxCMND.Text;
            if (CMND.Length == 0)
            {
                Error.SetError(BoxCMND, "Hãy nhập số CMND!");
                bError = true;
            }
            else if (CMND.Length != 9)
            {
                Error.SetError(BoxCMND, "Số CMND không hợp lệ!");
                bError = true;
            }
            DateTime currDate = DateTime.Now;
            int currYear = currDate.Year;
            DateTime DateofBirth = BoxDOB.Value;
            int birthYear = DateofBirth.Year;
            if (currYear - birthYear < 6)
            {
                Error.SetError(BoxDOB, "Tuối phải lớn hơn 5!");
                bError = true;
            }
            string Mail = BoxMail.Text;
            if (Mail.Length == 0)
            {
                Error.SetError(BoxMail, "Hãy nhập địa chỉ email!");
                bError = true;
            }
            else if (Mail.Contains("@") == false || Mail.Contains(".") == false)
            {
                Error.SetError(BoxMail, "Địa chỉ email không hợp lệ!");
                bError = true;
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=POOHNHI;Database=QLNS;Trusted_Connection=true";
                con.Open();
                //Kết nối với database
                SqlCommand checkMail = new SqlCommand("SELECT * FROM USERINFO WHERE ([Email] = @Email)", con);
                checkMail.Parameters.AddWithValue("@Email", BoxMail.Text);
                SqlDataReader reader = checkMail.ExecuteReader();
                //Kiểm tra nếu ID đã bị đăng ký rồi
                if (reader.HasRows)
                {
                    Error.SetError(BoxMail, "Email này đã được sử dụng, hãy nhập email khác!");
                    bError = true;
                }
                con.Close();
            }
            if (bError == true)
            {
                return false;
            }
            else
            {
                Error.Clear();
            }
            return true;
        }
        void addNewUser()
        {
            SqlConnection con = new SqlConnection();
            SqlConnection con2 = new SqlConnection();

            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            con.ConnectionString = "Server=POOHNHI;Database=QLNS;Trusted_Connection=true";
            con2.ConnectionString = "Server=POOHNHI;Database=QLNS;Trusted_Connection=true";
            con.Open();
            con2.Open();
            cmd.Connection = con;
            cmd2.Connection = con2;
            cmd.CommandText = @"INSERT INTO LOGININFO (TenDangNhap,MatKhau,ChucVu) VALUES(@TDN,@MK,@CV)";
            cmd.Parameters.AddWithValue("@TDN", BoxID.Text);
            cmd.Parameters.AddWithValue("@MK", BoxPW.Text);
            cmd.Parameters.AddWithValue("@CV", "User");
            cmd.ExecuteNonQuery();
            cmd2.CommandText = @"INSERT INTO USERINFO (TenDangNhap,HoTen,GioiTinh,DiaChi,SDT,CMND,NgaySinh,DiemTichLuy,Email) VALUES(@Us,@HT,@GT,@DC,@Phone,@CM,@NS,@DTL,@E)";
            cmd2.Parameters.AddWithValue("@Us", BoxID.Text);
            cmd2.Parameters.AddWithValue("@HT", BoxName.Text);
            /*cmd2.Parameters.AddWithValue("@GT", BoxGender.Text);*/
            string Gender = BoxGender.Text.ToUpper();
            if (Gender == "NAM")
                cmd2.Parameters.AddWithValue("@GT", "Nam");
            else
                cmd2.Parameters.AddWithValue("@GT", "Nữ");
            cmd2.Parameters.AddWithValue("@DC", BoxAddress.Text);
            cmd2.Parameters.AddWithValue("@Phone", BoxPhone.Text);
            cmd2.Parameters.AddWithValue("@CM", BoxCMND.Text);
            cmd2.Parameters.AddWithValue("@E", BoxMail.Text);
            cmd2.Parameters.Add("@NS", SqlDbType.Date).Value = BoxDOB.Value.Date;
            cmd2.Parameters.AddWithValue("@DTL", 0);
            cmd2.ExecuteNonQuery();
            con.Close();
            con2.Close();

        }
        private void Register_Click(object sender, EventArgs e)
        {
            if (InputHopLe() == false)
            {
                return;
            }
            addNewUser();
            MessageBox.Show("Đăng kí thành công!");
            this.Close();
        }
    }
}
