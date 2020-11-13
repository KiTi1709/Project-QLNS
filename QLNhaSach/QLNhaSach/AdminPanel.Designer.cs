namespace QLNhaSach
{
    partial class AdminPanel
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
            this.NutDoiMatKhau = new System.Windows.Forms.Button();
            this.NutXemDon = new System.Windows.Forms.Button();
            this.NutDangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NutDoiMatKhau
            // 
            this.NutDoiMatKhau.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 12F);
            this.NutDoiMatKhau.Location = new System.Drawing.Point(51, 14);
            this.NutDoiMatKhau.Name = "NutDoiMatKhau";
            this.NutDoiMatKhau.Size = new System.Drawing.Size(143, 62);
            this.NutDoiMatKhau.TabIndex = 1;
            this.NutDoiMatKhau.Text = "Đổi mật khẩu";
            this.NutDoiMatKhau.UseVisualStyleBackColor = true;
            this.NutDoiMatKhau.Click += new System.EventHandler(this.NutDoiMatKhau_Click);
            // 
            // NutXemDon
            // 
            this.NutXemDon.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 12F);
            this.NutXemDon.Location = new System.Drawing.Point(51, 96);
            this.NutXemDon.Name = "NutXemDon";
            this.NutXemDon.Size = new System.Drawing.Size(143, 62);
            this.NutXemDon.TabIndex = 2;
            this.NutXemDon.Text = "Đơn đặt hàng hiện tại";
            this.NutXemDon.UseVisualStyleBackColor = true;
            this.NutXemDon.Click += new System.EventHandler(this.NutXemDon_Click);
            // 
            // NutDangXuat
            // 
            this.NutDangXuat.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 12F);
            this.NutDangXuat.Location = new System.Drawing.Point(51, 178);
            this.NutDangXuat.Name = "NutDangXuat";
            this.NutDangXuat.Size = new System.Drawing.Size(143, 62);
            this.NutDangXuat.TabIndex = 3;
            this.NutDangXuat.Text = "Đăng xuất";
            this.NutDangXuat.UseVisualStyleBackColor = true;
            this.NutDangXuat.Click += new System.EventHandler(this.NutDangXuat_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 258);
            this.ControlBox = false;
            this.Controls.Add(this.NutDangXuat);
            this.Controls.Add(this.NutXemDon);
            this.Controls.Add(this.NutDoiMatKhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện Admin";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NutDoiMatKhau;
        private System.Windows.Forms.Button NutXemDon;
        private System.Windows.Forms.Button NutDangXuat;
    }
}