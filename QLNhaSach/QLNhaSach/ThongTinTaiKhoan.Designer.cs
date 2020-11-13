namespace QLNhaSach
{
    partial class ThongTinTaiKhoan
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
            this.NutDoiEmail = new System.Windows.Forms.Button();
            this.BoxTTCN = new System.Windows.Forms.GroupBox();
            this.ThongTinCaNhan = new System.Windows.Forms.Label();
            this.BoxTTTK = new System.Windows.Forms.GroupBox();
            this.ThongTinAccount = new System.Windows.Forms.Label();
            this.BoxTTCN.SuspendLayout();
            this.BoxTTTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // NutDoiMatKhau
            // 
            this.NutDoiMatKhau.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutDoiMatKhau.Location = new System.Drawing.Point(13, 188);
            this.NutDoiMatKhau.Name = "NutDoiMatKhau";
            this.NutDoiMatKhau.Size = new System.Drawing.Size(129, 41);
            this.NutDoiMatKhau.TabIndex = 0;
            this.NutDoiMatKhau.Text = "Đổi mật khẩu";
            this.NutDoiMatKhau.UseVisualStyleBackColor = true;
            this.NutDoiMatKhau.Click += new System.EventHandler(this.NutDoiMatKhau_Click);
            // 
            // NutDoiEmail
            // 
            this.NutDoiEmail.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 9.75F);
            this.NutDoiEmail.Location = new System.Drawing.Point(166, 188);
            this.NutDoiEmail.Name = "NutDoiEmail";
            this.NutDoiEmail.Size = new System.Drawing.Size(129, 41);
            this.NutDoiEmail.TabIndex = 1;
            this.NutDoiEmail.Text = "Đổi địa chỉ email";
            this.NutDoiEmail.UseVisualStyleBackColor = true;
            this.NutDoiEmail.Click += new System.EventHandler(this.NutDoiEmail_Click);
            // 
            // BoxTTCN
            // 
            this.BoxTTCN.Controls.Add(this.ThongTinCaNhan);
            this.BoxTTCN.Location = new System.Drawing.Point(13, 12);
            this.BoxTTCN.Name = "BoxTTCN";
            this.BoxTTCN.Size = new System.Drawing.Size(282, 170);
            this.BoxTTCN.TabIndex = 2;
            this.BoxTTCN.TabStop = false;
            this.BoxTTCN.Text = "Thông tin cá nhân";
            // 
            // ThongTinCaNhan
            // 
            this.ThongTinCaNhan.AutoSize = true;
            this.ThongTinCaNhan.Location = new System.Drawing.Point(6, 20);
            this.ThongTinCaNhan.Name = "ThongTinCaNhan";
            this.ThongTinCaNhan.Size = new System.Drawing.Size(94, 13);
            this.ThongTinCaNhan.TabIndex = 0;
            this.ThongTinCaNhan.Text = "Thông tin cá nhân";
            // 
            // BoxTTTK
            // 
            this.BoxTTTK.Controls.Add(this.ThongTinAccount);
            this.BoxTTTK.Location = new System.Drawing.Point(311, 12);
            this.BoxTTTK.Name = "BoxTTTK";
            this.BoxTTTK.Size = new System.Drawing.Size(282, 217);
            this.BoxTTTK.TabIndex = 3;
            this.BoxTTTK.TabStop = false;
            this.BoxTTTK.Text = "Thông tin tài khoản";
            // 
            // ThongTinAccount
            // 
            this.ThongTinAccount.AutoSize = true;
            this.ThongTinAccount.Location = new System.Drawing.Point(6, 20);
            this.ThongTinAccount.Name = "ThongTinAccount";
            this.ThongTinAccount.Size = new System.Drawing.Size(99, 13);
            this.ThongTinAccount.TabIndex = 0;
            this.ThongTinAccount.Text = "Thông tin tài khoản";
            // 
            // ThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 241);
            this.Controls.Add(this.BoxTTTK);
            this.Controls.Add(this.BoxTTCN);
            this.Controls.Add(this.NutDoiEmail);
            this.Controls.Add(this.NutDoiMatKhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ThongTinTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            this.BoxTTCN.ResumeLayout(false);
            this.BoxTTCN.PerformLayout();
            this.BoxTTTK.ResumeLayout(false);
            this.BoxTTTK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NutDoiMatKhau;
        private System.Windows.Forms.Button NutDoiEmail;
        private System.Windows.Forms.GroupBox BoxTTCN;
        private System.Windows.Forms.Label ThongTinCaNhan;
        private System.Windows.Forms.GroupBox BoxTTTK;
        private System.Windows.Forms.Label ThongTinAccount;
    }
}