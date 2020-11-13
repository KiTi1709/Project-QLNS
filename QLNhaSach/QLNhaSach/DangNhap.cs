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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void NutGioiThieu_Click(object sender, EventArgs e)
        {
            this.Hide();
            GioiThieu GT = new GioiThieu();
            GT.ShowDialog();
            this.Show();
            //MessageBox.Show("Được thành lập vào năm 2020, nhà sách Việt Nam chú trọng vào việc cung cấp dịch vụ giao hàng sách nhanh chóng và tiện lợi nhất.");
        }

        private void NutLienHe_Click(object sender, EventArgs e)
        {
            this.Hide();
            LienHe LH = new LienHe();
            LH.ShowDialog();
            this.Show();
            //MessageBox.Show("Mọi thắc mắc xin liên hệ email: nhasachvietnam@gmail.com");
        }

        private void NutDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManHinhDangNhap MHDP = new ManHinhDangNhap();
            MHDP.ShowDialog();
            this.Show();
        }

        private void NutDangKy_Click(object sender, EventArgs e)
        {
            ManHinhDangKy MHDK = new ManHinhDangKy();
            MHDK.ShowDialog();
        }
    }

}
