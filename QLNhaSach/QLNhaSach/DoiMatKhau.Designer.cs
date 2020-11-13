namespace QLNhaSach
{
    partial class DoiMatKhau
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
            this.components = new System.ComponentModel.Container();
            this.NutXacNhan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OldPW = new System.Windows.Forms.TextBox();
            this.NewPW = new System.Windows.Forms.TextBox();
            this.NewPW2 = new System.Windows.Forms.TextBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // NutXacNhan
            // 
            this.NutXacNhan.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 12F);
            this.NutXacNhan.Location = new System.Drawing.Point(81, 135);
            this.NutXacNhan.Name = "NutXacNhan";
            this.NutXacNhan.Size = new System.Drawing.Size(108, 38);
            this.NutXacNhan.TabIndex = 0;
            this.NutXacNhan.Text = "Xác nhận";
            this.NutXacNhan.UseVisualStyleBackColor = true;
            this.NutXacNhan.Click += new System.EventHandler(this.NutXacNhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // OldPW
            // 
            this.OldPW.Location = new System.Drawing.Point(119, 25);
            this.OldPW.MaxLength = 32;
            this.OldPW.Name = "OldPW";
            this.OldPW.Size = new System.Drawing.Size(129, 20);
            this.OldPW.TabIndex = 4;
            this.OldPW.UseSystemPasswordChar = true;
            // 
            // NewPW
            // 
            this.NewPW.Location = new System.Drawing.Point(119, 63);
            this.NewPW.MaxLength = 32;
            this.NewPW.Name = "NewPW";
            this.NewPW.Size = new System.Drawing.Size(129, 20);
            this.NewPW.TabIndex = 5;
            this.NewPW.UseSystemPasswordChar = true;
            // 
            // NewPW2
            // 
            this.NewPW2.Location = new System.Drawing.Point(119, 102);
            this.NewPW2.MaxLength = 32;
            this.NewPW2.Name = "NewPW2";
            this.NewPW2.Size = new System.Drawing.Size(129, 20);
            this.NewPW2.TabIndex = 6;
            this.NewPW2.UseSystemPasswordChar = true;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 185);
            this.Controls.Add(this.NewPW2);
            this.Controls.Add(this.NewPW);
            this.Controls.Add(this.OldPW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NutXacNhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NutXacNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OldPW;
        private System.Windows.Forms.TextBox NewPW;
        private System.Windows.Forms.TextBox NewPW2;
        private System.Windows.Forms.ErrorProvider Error;
    }
}