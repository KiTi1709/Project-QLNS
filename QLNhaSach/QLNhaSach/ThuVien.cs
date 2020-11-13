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
    public partial class ThuVien : Form
    {
        public ThuVien()
        {
            InitializeComponent();
        }

        private void LoadAnh(string Ma)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=POOHNHI;Database=QLNS;Trusted_Connection=true";
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select TENSACH, GIABAN, LOAI, NXB from SACH where MASACH = '" + Ma + "'", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            SqlDataAdapter cmd2 = new SqlDataAdapter("select TENLOAI from LOAISACH where MALOAI='" + dt.Rows[0][2] + "'", con);
            DataTable dt2 = new DataTable();
            cmd2.Fill(dt2);
            SqlDataAdapter cmd3 = new SqlDataAdapter("select TENNXB from NHAXUATBAN where MANXB='" + dt.Rows[0][3] + "'", con);
            DataTable dt3 = new DataTable();
            cmd3.Fill(dt3);
            NoiDung.Text = "- Tên sách: " + dt.Rows[0][0]
                + Environment.NewLine
                + Environment.NewLine + "- Giá: " + dt.Rows[0][1]
                + Environment.NewLine
                + Environment.NewLine + "- Loại: " + dt2.Rows[0][0]
                + Environment.NewLine
                + Environment.NewLine + "- Nhà xuất bản: " + dt3.Rows[0][0];
        }

        private void A001_Click(object sender, EventArgs e)
        {
            SachTo.Image = global::QLNhaSach.DataHinhAnh.A001;
            /*SachTo.Image = Image.FromFile(@"C:\Users\admin\Desktop\QLNS\Database\Pics. Ma Sach\A001.JPG");*/
            LoadAnh("A001");
        }

        private void A002_Click(object sender, EventArgs e)
        {
            SachTo.Image = global::QLNhaSach.DataHinhAnh.A002;
            LoadAnh("A002");
        }

        private void A003_Click(object sender, EventArgs e)
        {
            SachTo.Image = global::QLNhaSach.DataHinhAnh.A003;
            LoadAnh("A003");
        }

        private void B001_Click(object sender, EventArgs e)
        {
            SachTo.Image = global::QLNhaSach.DataHinhAnh.B001;
            LoadAnh("B001");
        }

        private void B002_Click(object sender, EventArgs e)
        {
            SachTo.Image = global::QLNhaSach.DataHinhAnh.B002;
            LoadAnh("B002");
        }

        private void B003_Click(object sender, EventArgs e)
        {
            SachTo.Image = global::QLNhaSach.DataHinhAnh.B003;
            LoadAnh("B003");
        }

        private void B004_Click(object sender, EventArgs e)
        {
            SachTo.Image = global::QLNhaSach.DataHinhAnh.B004;
            LoadAnh("B004");
        }

        private void B005_Click(object sender, EventArgs e)
        {
            SachTo.Image = global::QLNhaSach.DataHinhAnh.B005;
            LoadAnh("B005");
        }

        private void B006_Click(object sender, EventArgs e)
        {
            SachTo.Image = global::QLNhaSach.DataHinhAnh.B006;
            LoadAnh("B006");
        }

        private void C001_Click(object sender, EventArgs e)
        {
            SachTo.Image = global::QLNhaSach.DataHinhAnh.C001;
            LoadAnh("C001");
        }

        private void D001_Click(object sender, EventArgs e)
        {
            SachTo.Image = global::QLNhaSach.DataHinhAnh.D001;
            LoadAnh("D001");
        }

        private void D002_Click(object sender, EventArgs e)
        {
            SachTo.Image = global::QLNhaSach.DataHinhAnh.D002;
            LoadAnh("D002");
        }
        private void D003_Click(object sender, EventArgs e)
        {
            SachTo.Image = global::QLNhaSach.DataHinhAnh.D003;
            LoadAnh("D003");
        }

        private void D004_Click(object sender, EventArgs e)
        {
            SachTo.Image = global::QLNhaSach.DataHinhAnh.D004;
            LoadAnh("D004");
        }

        private void E001_Click(object sender, EventArgs e)
        {
            SachTo.Image = global::QLNhaSach.DataHinhAnh.E001;
            LoadAnh("E001");
        }

        private void E002_Click(object sender, EventArgs e)
        {
            SachTo.Image = global::QLNhaSach.DataHinhAnh.E002;
            LoadAnh("E002");
        }
    }
}
