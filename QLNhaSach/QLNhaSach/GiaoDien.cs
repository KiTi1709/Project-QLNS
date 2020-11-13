using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaSach
{
    public partial class GiaoDien : Form
    {
        string ID;
        public GiaoDien(string TenDangNhap)
        {
            ID = TenDangNhap;
            InitializeComponent();
        }
        private void NutThuVien_Click(object sender, EventArgs e)
        {
            ThuVien TV = new ThuVien();
            TV.ShowDialog();
        }

        private void NutDatHang_Click(object sender, EventArgs e)
        {
            DonGiaoHang DGH = new DonGiaoHang(ID);
            DGH.ShowDialog();
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

        private void NutThongTinTK_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoan TTTK = new ThongTinTaiKhoan(ID);
            TTTK.ShowDialog();
        }
    }
}
