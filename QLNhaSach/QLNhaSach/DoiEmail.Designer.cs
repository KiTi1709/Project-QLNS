namespace QLNhaSach
{
    partial class DoiEmail
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
            this.Email1 = new System.Windows.Forms.TextBox();
            this.Email2 = new System.Windows.Forms.TextBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // NutXacNhan
            // 
            this.NutXacNhan.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 12F);
            this.NutXacNhan.Location = new System.Drawing.Point(140, 90);
            this.NutXacNhan.Name = "NutXacNhan";
            this.NutXacNhan.Size = new System.Drawing.Size(119, 37);
            this.NutXacNhan.TabIndex = 0;
            this.NutXacNhan.Text = "Xác nhận";
            this.NutXacNhan.UseVisualStyleBackColor = true;
            this.NutXacNhan.Click += new System.EventHandler(this.NutXacNhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Địa chỉ email mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập lại địa chỉ email mới:";
            // 
            // Email1
            // 
            this.Email1.Location = new System.Drawing.Point(157, 17);
            this.Email1.MaxLength = 50;
            this.Email1.Name = "Email1";
            this.Email1.Size = new System.Drawing.Size(248, 20);
            this.Email1.TabIndex = 3;
            // 
            // Email2
            // 
            this.Email2.Location = new System.Drawing.Point(157, 54);
            this.Email2.MaxLength = 50;
            this.Email2.Name = "Email2";
            this.Email2.Size = new System.Drawing.Size(248, 20);
            this.Email2.TabIndex = 4;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // DoiEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 139);
            this.Controls.Add(this.Email2);
            this.Controls.Add(this.Email1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NutXacNhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DoiEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi địa chỉ email";
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NutXacNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email1;
        private System.Windows.Forms.TextBox Email2;
        private System.Windows.Forms.ErrorProvider Error;
    }
}