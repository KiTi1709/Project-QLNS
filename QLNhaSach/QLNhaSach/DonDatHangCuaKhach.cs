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
    public partial class DonDatHangCuaKhach : Form
    {
        string ID = "";
        string MaKhachHang = "";
        string MaSach = "";
        string GhiChu = "";
        public DonDatHangCuaKhach()
        {
            InitializeComponent();
        }

        private void DonDatHangCuaKhach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet3.DONDATHANG' table. You can move, or remove it, as needed.
            this.dONDATHANGTableAdapter.Fill(this.qLNSDataSet3.DONDATHANG);

        }
        private void DisplayData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=POOHNHI;Database=QLNS;Trusted_Connection=true";
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from DONDATHANG", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void NutXacNhan_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Xác nhận đã giao hàng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (rs == DialogResult.No)
            {
                return;
            }
            if (ID != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=POOHNHI;Database=QLNS;Trusted_Connection=true";
                con.Open();
                SqlCommand cmd = new SqlCommand("delete DONDATHANG where MaDonHang='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter cmd2 = new SqlDataAdapter("SELECT DiemTichLuy FROM USERINFO WHERE TenDangNhap = '" + MaKhachHang + "'", con);
                DataTable dt = new DataTable();
                cmd2.Fill(dt);
                int newDTL = Convert.ToInt32(dt.Rows[0][0]) + 100;
                SqlCommand cmd3 = new SqlCommand("UPDATE USERINFO SET DiemTichLuy=@DTL where TenDangNhap='" + MaKhachHang + "'", con);
                cmd3.Parameters.AddWithValue("@DTL", newDTL);
                cmd3.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Thành công!");
            }
            else
                MessageBox.Show("Hãy chọn đơn hàng!");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            MaKhachHang = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            MaSach = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            GhiChu = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void ClearData()
        {
            ID = "";
            MaKhachHang = "";
            MaSach = "";
            GhiChu = "";
        }
    }
}
