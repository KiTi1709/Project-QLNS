namespace QLNhaSach
{
    partial class ManHinhDangNhap
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
            this.NutDangNhap = new System.Windows.Forms.Button();
            this.BoxID = new System.Windows.Forms.TextBox();
            this.BoxPassword = new System.Windows.Forms.TextBox();
            this.LabelTenDangNhap = new System.Windows.Forms.Label();
            this.LabelMatKhau = new System.Windows.Forms.Label();
            this.qLNSDataSet = new QLNhaSach.QLNSDataSet();
            this.qLNSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NutDangNhap
            // 
            this.NutDangNhap.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 13F);
            this.NutDangNhap.Location = new System.Drawing.Point(78, 88);
            this.NutDangNhap.Name = "NutDangNhap";
            this.NutDangNhap.Size = new System.Drawing.Size(134, 42);
            this.NutDangNhap.TabIndex = 0;
            this.NutDangNhap.Text = "Đăng nhập";
            this.NutDangNhap.UseVisualStyleBackColor = true;
            this.NutDangNhap.Click += new System.EventHandler(this.NutDangNhap_Click);
            // 
            // BoxID
            // 
            this.BoxID.Location = new System.Drawing.Point(101, 16);
            this.BoxID.MaxLength = 10;
            this.BoxID.Name = "BoxID";
            this.BoxID.Size = new System.Drawing.Size(157, 20);
            this.BoxID.TabIndex = 1;
            // 
            // BoxPassword
            // 
            this.BoxPassword.Location = new System.Drawing.Point(101, 52);
            this.BoxPassword.MaxLength = 32;
            this.BoxPassword.Name = "BoxPassword";
            this.BoxPassword.Size = new System.Drawing.Size(157, 20);
            this.BoxPassword.TabIndex = 2;
            this.BoxPassword.UseSystemPasswordChar = true;
            // 
            // LabelTenDangNhap
            // 
            this.LabelTenDangNhap.AutoSize = true;
            this.LabelTenDangNhap.Location = new System.Drawing.Point(14, 19);
            this.LabelTenDangNhap.Name = "LabelTenDangNhap";
            this.LabelTenDangNhap.Size = new System.Drawing.Size(81, 13);
            this.LabelTenDangNhap.TabIndex = 3;
            this.LabelTenDangNhap.Text = "Tên đăng nhập";
            // 
            // LabelMatKhau
            // 
            this.LabelMatKhau.AutoSize = true;
            this.LabelMatKhau.Location = new System.Drawing.Point(14, 55);
            this.LabelMatKhau.Name = "LabelMatKhau";
            this.LabelMatKhau.Size = new System.Drawing.Size(52, 13);
            this.LabelMatKhau.TabIndex = 4;
            this.LabelMatKhau.Text = "Mật khẩu";
            // 
            // qLNSDataSet
            // 
            this.qLNSDataSet.DataSetName = "QLNSDataSet";
            this.qLNSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNSDataSetBindingSource
            // 
            this.qLNSDataSetBindingSource.DataSource = this.qLNSDataSet;
            this.qLNSDataSetBindingSource.Position = 0;
            // 
            // ManHinhDangNhap
            // 
            this.AcceptButton = this.NutDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 145);
            this.Controls.Add(this.LabelMatKhau);
            this.Controls.Add(this.LabelTenDangNhap);
            this.Controls.Add(this.BoxPassword);
            this.Controls.Add(this.BoxID);
            this.Controls.Add(this.NutDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManHinhDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NutDangNhap;
        private System.Windows.Forms.TextBox BoxID;
        private System.Windows.Forms.TextBox BoxPassword;
        private System.Windows.Forms.Label LabelTenDangNhap;
        private System.Windows.Forms.Label LabelMatKhau;
        private QLNSDataSet qLNSDataSet;
        private System.Windows.Forms.BindingSource qLNSDataSetBindingSource;
    }
}