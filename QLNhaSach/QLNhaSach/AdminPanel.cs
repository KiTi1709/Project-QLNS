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
    public partial class AdminPanel : Form
    {
        string ID;
        public AdminPanel(string Username)
        {
            ID = Username;
            InitializeComponent();
        }

        private void NutDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void NutDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau DMK = new DoiMatKhau(ID);
            DMK.ShowDialog();
            this.Show();
        }

        private void NutXemDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonDatHangCuaKhach DDH = new DonDatHangCuaKhach();
            DDH.ShowDialog();
            this.Show();
        }
    }
}
