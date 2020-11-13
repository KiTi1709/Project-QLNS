namespace QLNhaSach
{
    partial class GiaoDien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NutDangXuat = new System.Windows.Forms.Button();
            this.NutDatHang = new System.Windows.Forms.Button();
            this.NutThongTinNXB = new System.Windows.Forms.Button();
            this.NutThuVien = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NutDangXuat);
            this.panel1.Controls.Add(this.NutDatHang);
            this.panel1.Controls.Add(this.NutThongTinNXB);
            this.panel1.Controls.Add(this.NutThuVien);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 375);
            this.panel1.TabIndex = 0;
            // 
            // NutDangXuat
            // 
            this.NutDangXuat.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutDangXuat.Location = new System.Drawing.Point(20, 283);
            this.NutDangXuat.Name = "NutDangXuat";
            this.NutDangXuat.Size = new System.Drawing.Size(150, 62);
            this.NutDangXuat.TabIndex = 3;
            this.NutDangXuat.Text = "Đăng xuất";
            this.NutDangXuat.UseVisualStyleBackColor = true;
            this.NutDangXuat.Click += new System.EventHandler(this.NutDangXuat_Click);
            // 
            // NutDatHang
            // 
            this.NutDatHang.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutDatHang.Location = new System.Drawing.Point(20, 197);
            this.NutDatHang.Name = "NutDatHang";
            this.NutDatHang.Size = new System.Drawing.Size(150, 62);
            this.NutDatHang.TabIndex = 2;
            this.NutDatHang.Text = "Đặt sách";
            this.NutDatHang.UseVisualStyleBackColor = true;
            this.NutDatHang.Click += new System.EventHandler(this.NutDatHang_Click);
            // 
            // NutThongTinNXB
            // 
            this.NutThongTinNXB.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutThongTinNXB.Location = new System.Drawing.Point(20, 111);
            this.NutThongTinNXB.Name = "NutThongTinNXB";
            this.NutThongTinNXB.Size = new System.Drawing.Size(150, 62);
            this.NutThongTinNXB.TabIndex = 1;
            this.NutThongTinNXB.Text = "Thông tin tài khoản";
            this.NutThongTinNXB.UseVisualStyleBackColor = true;
            this.NutThongTinNXB.Click += new System.EventHandler(this.NutThongTinTK_Click);
            // 
            // NutThuVien
            // 
            this.NutThuVien.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutThuVien.Location = new System.Drawing.Point(20, 25);
            this.NutThuVien.Name = "NutThuVien";
            this.NutThuVien.Size = new System.Drawing.Size(150, 62);
            this.NutThuVien.TabIndex = 0;
            this.NutThuVien.Text = "Thư viện";
            this.NutThuVien.UseVisualStyleBackColor = true;
            this.NutThuVien.Click += new System.EventHandler(this.NutThuVien_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 375);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GiaoDien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(789, 395);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GiaoDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà sách Việt Nam";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NutThongTinNXB;
        private System.Windows.Forms.Button NutThuVien;
        private System.Windows.Forms.Button NutDangXuat;
        private System.Windows.Forms.Button NutDatHang;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}