namespace QLNhaSach
{
    partial class DonGiaoHang
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
            this.NutXoa = new System.Windows.Forms.Button();
            this.NutDatHang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LuuY = new System.Windows.Forms.Label();
            this.GhiChu = new System.Windows.Forms.Label();
            this.BoxGhiChu = new System.Windows.Forms.TextBox();
            this.ChonSach = new System.Windows.Forms.ComboBox();
            this.sACHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet2 = new QLNhaSach.QLNSDataSet2();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet1 = new QLNhaSach.QLNSDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GiaTien = new System.Windows.Forms.Label();
            this.qLNSDataSet = new QLNhaSach.QLNSDataSet();
            this.qLNSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sACHTableAdapter = new QLNhaSach.QLNSDataSet1TableAdapters.SACHTableAdapter();
            this.sACHTableAdapter1 = new QLNhaSach.QLNSDataSet2TableAdapters.SACHTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.TenSach = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // NutXoa
            // 
            this.NutXoa.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 12F);
            this.NutXoa.Location = new System.Drawing.Point(24, 245);
            this.NutXoa.Name = "NutXoa";
            this.NutXoa.Size = new System.Drawing.Size(131, 58);
            this.NutXoa.TabIndex = 0;
            this.NutXoa.Text = "Làm lại";
            this.NutXoa.UseVisualStyleBackColor = true;
            this.NutXoa.Click += new System.EventHandler(this.NutXoa_Click);
            // 
            // NutDatHang
            // 
            this.NutDatHang.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 12F);
            this.NutDatHang.Location = new System.Drawing.Point(189, 245);
            this.NutDatHang.Name = "NutDatHang";
            this.NutDatHang.Size = new System.Drawing.Size(131, 58);
            this.NutDatHang.TabIndex = 1;
            this.NutDatHang.Text = "Đặt hàng";
            this.NutDatHang.UseVisualStyleBackColor = true;
            this.NutDatHang.Click += new System.EventHandler(this.NutDatHang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LuuY);
            this.groupBox1.Location = new System.Drawing.Point(357, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 224);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Một số lưu ý khi đặt hàng";
            // 
            // LuuY
            // 
            this.LuuY.AutoSize = true;
            this.LuuY.Location = new System.Drawing.Point(12, 28);
            this.LuuY.Name = "LuuY";
            this.LuuY.Size = new System.Drawing.Size(198, 156);
            this.LuuY.TabIndex = 0;
            this.LuuY.Text = "Lưu ý:\r\n\r\nGiá tiền chưa bao gồm tiền ship.\r\n\r\nMiễn phí ship tại các khu vực nội t" +
    "hành.\r\n\r\nHàng đã mua miễn trả lại.\r\n\r\nMọi thắc mắc xin liên hệ email:\r\n\r\nnhasach" +
    "vietnam@gmail.com\r\n\r\n";
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSize = true;
            this.GhiChu.Location = new System.Drawing.Point(25, 136);
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Size = new System.Drawing.Size(44, 13);
            this.GhiChu.TabIndex = 3;
            this.GhiChu.Text = "Ghi chú";
            // 
            // BoxGhiChu
            // 
            this.BoxGhiChu.Location = new System.Drawing.Point(24, 155);
            this.BoxGhiChu.Multiline = true;
            this.BoxGhiChu.Name = "BoxGhiChu";
            this.BoxGhiChu.Size = new System.Drawing.Size(296, 82);
            this.BoxGhiChu.TabIndex = 4;
            // 
            // ChonSach
            // 
            this.ChonSach.DataSource = this.sACHBindingSource1;
            this.ChonSach.DisplayMember = "MASACH";
            this.ChonSach.FormattingEnabled = true;
            this.ChonSach.Location = new System.Drawing.Point(24, 46);
            this.ChonSach.Name = "ChonSach";
            this.ChonSach.Size = new System.Drawing.Size(67, 21);
            this.ChonSach.TabIndex = 5;
            this.ChonSach.ValueMember = "MASACH";
            this.ChonSach.SelectedIndexChanged += new System.EventHandler(this.ChonSach_SelectedIndexChanged);
            // 
            // sACHBindingSource1
            // 
            this.sACHBindingSource1.DataMember = "SACH";
            this.sACHBindingSource1.DataSource = this.qLNSDataSet2;
            // 
            // qLNSDataSet2
            // 
            this.qLNSDataSet2.DataSetName = "QLNSDataSet2";
            this.qLNSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.qLNSDataSet1;
            // 
            // qLNSDataSet1
            // 
            this.qLNSDataSet1.DataSetName = "QLNSDataSet1";
            this.qLNSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giá tiền";
            // 
            // GiaTien
            // 
            this.GiaTien.AutoSize = true;
            this.GiaTien.Font = new System.Drawing.Font("000 Comic Sans TB", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaTien.Location = new System.Drawing.Point(22, 98);
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.Size = new System.Drawing.Size(76, 32);
            this.GiaTien.TabIndex = 8;
            this.GiaTien.Text = "0 VNĐ";
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
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // sACHTableAdapter1
            // 
            this.sACHTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên sách";
            // 
            // TenSach
            // 
            this.TenSach.AutoSize = true;
            this.TenSach.Font = new System.Drawing.Font("000 Spellcaster [TeddyBear]", 16F, System.Drawing.FontStyle.Italic);
            this.TenSach.Location = new System.Drawing.Point(104, 39);
            this.TenSach.Name = "TenSach";
            this.TenSach.Size = new System.Drawing.Size(180, 34);
            this.TenSach.TabIndex = 10;
            this.TenSach.Text = "Hãy chọn mã sách";
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // DonGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 315);
            this.Controls.Add(this.TenSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GiaTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChonSach);
            this.Controls.Add(this.BoxGhiChu);
            this.Controls.Add(this.GhiChu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NutDatHang);
            this.Controls.Add(this.NutXoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DonGiaoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn giao hàng hiện tại";
            this.Load += new System.EventHandler(this.DonGiaoHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NutXoa;
        private System.Windows.Forms.Button NutDatHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LuuY;
        private System.Windows.Forms.Label GhiChu;
        private System.Windows.Forms.TextBox BoxGhiChu;
        private System.Windows.Forms.ComboBox ChonSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label GiaTien;
        private QLNSDataSet qLNSDataSet;
        private System.Windows.Forms.BindingSource qLNSDataSetBindingSource;
        private QLNSDataSet1 qLNSDataSet1;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private QLNSDataSet1TableAdapters.SACHTableAdapter sACHTableAdapter;
        private QLNSDataSet2 qLNSDataSet2;
        private System.Windows.Forms.BindingSource sACHBindingSource1;
        private QLNSDataSet2TableAdapters.SACHTableAdapter sACHTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TenSach;
        private System.Windows.Forms.ErrorProvider Error;
    }
}