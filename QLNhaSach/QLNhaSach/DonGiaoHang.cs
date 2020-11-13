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
    public partial class DonGiaoHang : Form
    {
        string ID;
        public DonGiaoHang(string Username)
        {
            ID = Username;
            InitializeComponent();
        }

        private void DonGiaoHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet2.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter1.Fill(this.qLNSDataSet2.SACH);
            // TODO: This line of code loads data into the 'qLNSDataSet1.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.qLNSDataSet1.SACH);
            ChonSach.SelectedValue = "XXXX";
            BoxGhiChu.Clear();
            GiaTien.Text = "0 VNĐ";
        }
        private void ChonSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=POOHNHI;Database=QLNS;Trusted_Connection=true";
            con.Open();
            string Ten = ChonSach.Text;
            SqlDataAdapter cmd = new SqlDataAdapter("select * from SACH where MASACH ='" + Ten + "'", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                TenSach.Text = dt.Rows[0][1].ToString();
                GiaTien.Text = dt.Rows[0][3] + " VNĐ";
            }

            con.Close();
        }

        private void NutXoa_Click(object sender, EventArgs e)
        {
            ChonSach.SelectedValue = "XXXX";
            BoxGhiChu.Clear();
            GiaTien.Text = "0 VNĐ"
                + Environment.NewLine;
        }
        bool InputHopLe()
        {
            Error.Clear();
            bool bError = false;
            string Ten = ChonSach.Text;
            if (Ten == "XXXX")
            {
                Error.SetError(ChonSach, "Hãy chọn mã sách!");
                bError = true;
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
        private void NutDatHang_Click(object sender, EventArgs e)
        {
            if (InputHopLe() == false)
            {
                return;
            }
            DatHang();
            MessageBox.Show("Đặt hàng thành công!", "Thông báo");
        }
        private void DatHang()
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = "Server=POOHNHI;Database=QLNS;Trusted_Connection=true";
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = @"INSERT INTO DONDATHANG (MaDonHang,MaKhachHang,MASACH,GhiChu) VALUES(@MDH,@MKH,@MS,@GC)";
            cmd.Parameters.AddWithValue("@MKH", ID);
            cmd.Parameters.AddWithValue("@MS", ChonSach.Text);
            cmd.Parameters.AddWithValue("@GC", BoxGhiChu.Text);
            Random rnd = new Random();
            int SoLuong = rnd.Next(10000, 99999);
            cmd.Parameters.AddWithValue("@MDH", SoLuong);
            cmd.ExecuteNonQuery();
        }
    }
}
