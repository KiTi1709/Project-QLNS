namespace QLNhaSach
{
    partial class ManHinhDangKy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BoxPW2 = new System.Windows.Forms.TextBox();
            this.BoxPW = new System.Windows.Forms.TextBox();
            this.BoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BoxPhone = new System.Windows.Forms.TextBox();
            this.BoxDOB = new System.Windows.Forms.DateTimePicker();
            this.BoxGender = new System.Windows.Forms.ComboBox();
            this.BoxMail = new System.Windows.Forms.TextBox();
            this.BoxCMND = new System.Windows.Forms.TextBox();
            this.BoxAddress = new System.Windows.Forms.TextBox();
            this.BoxName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BoxPW2);
            this.groupBox1.Controls.Add(this.BoxPW);
            this.groupBox1.Controls.Add(this.BoxID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // BoxPW2
            // 
            this.BoxPW2.Location = new System.Drawing.Point(107, 109);
            this.BoxPW2.MaxLength = 32;
            this.BoxPW2.Name = "BoxPW2";
            this.BoxPW2.Size = new System.Drawing.Size(133, 20);
            this.BoxPW2.TabIndex = 3;
            this.BoxPW2.UseSystemPasswordChar = true;
            // 
            // BoxPW
            // 
            this.BoxPW.Location = new System.Drawing.Point(107, 70);
            this.BoxPW.MaxLength = 32;
            this.BoxPW.Name = "BoxPW";
            this.BoxPW.Size = new System.Drawing.Size(133, 20);
            this.BoxPW.TabIndex = 2;
            this.BoxPW.UseSystemPasswordChar = true;
            // 
            // BoxID
            // 
            this.BoxID.Location = new System.Drawing.Point(107, 32);
            this.BoxID.MaxLength = 10;
            this.BoxID.Name = "BoxID";
            this.BoxID.Size = new System.Drawing.Size(133, 20);
            this.BoxID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BoxPhone);
            this.groupBox2.Controls.Add(this.BoxDOB);
            this.groupBox2.Controls.Add(this.BoxGender);
            this.groupBox2.Controls.Add(this.BoxMail);
            this.groupBox2.Controls.Add(this.BoxCMND);
            this.groupBox2.Controls.Add(this.BoxAddress);
            this.groupBox2.Controls.Add(this.BoxName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(323, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cá nhân";
            // 
            // BoxPhone
            // 
            this.BoxPhone.Location = new System.Drawing.Point(91, 150);
            this.BoxPhone.MaxLength = 10;
            this.BoxPhone.Name = "BoxPhone";
            this.BoxPhone.Size = new System.Drawing.Size(133, 20);
            this.BoxPhone.TabIndex = 7;
            // 
            // BoxDOB
            // 
            this.BoxDOB.Location = new System.Drawing.Point(91, 228);
            this.BoxDOB.MaxDate = new System.DateTime(2019, 5, 13, 0, 0, 0, 0);
            this.BoxDOB.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.BoxDOB.Name = "BoxDOB";
            this.BoxDOB.Size = new System.Drawing.Size(270, 20);
            this.BoxDOB.TabIndex = 9;
            this.BoxDOB.Value = new System.DateTime(2019, 5, 13, 0, 0, 0, 0);
            // 
            // BoxGender
            // 
            this.BoxGender.FormattingEnabled = true;
            this.BoxGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.BoxGender.Location = new System.Drawing.Point(91, 71);
            this.BoxGender.Name = "BoxGender";
            this.BoxGender.Size = new System.Drawing.Size(76, 21);
            this.BoxGender.TabIndex = 5;
            // 
            // BoxMail
            // 
            this.BoxMail.Location = new System.Drawing.Point(91, 267);
            this.BoxMail.MaxLength = 30;
            this.BoxMail.Name = "BoxMail";
            this.BoxMail.Size = new System.Drawing.Size(270, 20);
            this.BoxMail.TabIndex = 10;
            // 
            // BoxCMND
            // 
            this.BoxCMND.Location = new System.Drawing.Point(91, 189);
            this.BoxCMND.MaxLength = 9;
            this.BoxCMND.Name = "BoxCMND";
            this.BoxCMND.Size = new System.Drawing.Size(133, 20);
            this.BoxCMND.TabIndex = 8;
            // 
            // BoxAddress
            // 
            this.BoxAddress.Location = new System.Drawing.Point(91, 111);
            this.BoxAddress.MaxLength = 100;
            this.BoxAddress.Name = "BoxAddress";
            this.BoxAddress.Size = new System.Drawing.Size(270, 20);
            this.BoxAddress.TabIndex = 6;
            // 
            // BoxName
            // 
            this.BoxName.Location = new System.Drawing.Point(91, 32);
            this.BoxName.MaxLength = 30;
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(270, 20);
            this.BoxName.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Địa chỉ email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ngày sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Số CMND";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ và tên";
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 15F);
            this.Reset.Location = new System.Drawing.Point(17, 213);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(120, 50);
            this.Reset.TabIndex = 11;
            this.Reset.Text = "Làm lại";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Register
            // 
            this.Register.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 15F);
            this.Register.Location = new System.Drawing.Point(173, 214);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(120, 50);
            this.Register.TabIndex = 12;
            this.Register.Text = "Đăng ký";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // ManHinhDangKy
            // 
            this.AcceptButton = this.Register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 336);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManHinhDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BoxPW2;
        private System.Windows.Forms.TextBox BoxPW;
        private System.Windows.Forms.TextBox BoxID;
        private System.Windows.Forms.TextBox BoxMail;
        private System.Windows.Forms.TextBox BoxCMND;
        private System.Windows.Forms.TextBox BoxAddress;
        private System.Windows.Forms.TextBox BoxName;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ComboBox BoxGender;
        private System.Windows.Forms.DateTimePicker BoxDOB;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.TextBox BoxPhone;
    }
}