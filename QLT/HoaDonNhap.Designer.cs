namespace QLT
{
    partial class HoaDonNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_NgayNhapSP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.mtb_MaNV = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtb_MaHD = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_TiepTuc = new System.Windows.Forms.Button();
            this.tb_Tim = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_HDN = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dt_NgayNhapSP);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.mtb_MaNV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mtb_MaHD);
            this.panel1.Location = new System.Drawing.Point(95, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 145);
            this.panel1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Ngày nhập";
            // 
            // dt_NgayNhapSP
            // 
            this.dt_NgayNhapSP.Location = new System.Drawing.Point(383, 114);
            this.dt_NgayNhapSP.Name = "dt_NgayNhapSP";
            this.dt_NgayNhapSP.Size = new System.Drawing.Size(287, 22);
            this.dt_NgayNhapSP.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mã nhân viên";
            // 
            // mtb_MaNV
            // 
            this.mtb_MaNV.Location = new System.Drawing.Point(399, 64);
            this.mtb_MaNV.Mask = "000";
            this.mtb_MaNV.Name = "mtb_MaNV";
            this.mtb_MaNV.Size = new System.Drawing.Size(122, 22);
            this.mtb_MaNV.TabIndex = 25;
            this.mtb_MaNV.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã hóa đơn";
            // 
            // mtb_MaHD
            // 
            this.mtb_MaHD.Location = new System.Drawing.Point(399, 21);
            this.mtb_MaHD.Mask = "000";
            this.mtb_MaHD.Name = "mtb_MaHD";
            this.mtb_MaHD.Size = new System.Drawing.Size(122, 22);
            this.mtb_MaHD.TabIndex = 10;
            this.mtb_MaHD.ValidatingType = typeof(int);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_Thoat);
            this.panel2.Controls.Add(this.bt_TiepTuc);
            this.panel2.Controls.Add(this.tb_Tim);
            this.panel2.Controls.Add(this.bt_Xoa);
            this.panel2.Controls.Add(this.bt_Sua);
            this.panel2.Controls.Add(this.bt_Them);
            this.panel2.Location = new System.Drawing.Point(99, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 59);
            this.panel2.TabIndex = 14;
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Location = new System.Drawing.Point(760, 11);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(85, 38);
            this.bt_Thoat.TabIndex = 17;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // bt_TiepTuc
            // 
            this.bt_TiepTuc.Location = new System.Drawing.Point(597, 11);
            this.bt_TiepTuc.Name = "bt_TiepTuc";
            this.bt_TiepTuc.Size = new System.Drawing.Size(85, 38);
            this.bt_TiepTuc.TabIndex = 16;
            this.bt_TiepTuc.Text = "Tiếp tục";
            this.bt_TiepTuc.UseVisualStyleBackColor = true;
            this.bt_TiepTuc.Click += new System.EventHandler(this.bt_TiepTuc_Click);
            // 
            // tb_Tim
            // 
            this.tb_Tim.Location = new System.Drawing.Point(451, 11);
            this.tb_Tim.Name = "tb_Tim";
            this.tb_Tim.Size = new System.Drawing.Size(85, 38);
            this.tb_Tim.TabIndex = 15;
            this.tb_Tim.Text = "Tìm kiếm";
            this.tb_Tim.UseVisualStyleBackColor = true;
            this.tb_Tim.Click += new System.EventHandler(this.tb_Tim_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(297, 11);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(85, 38);
            this.bt_Xoa.TabIndex = 14;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(155, 11);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(85, 38);
            this.bt_Sua.TabIndex = 13;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.Location = new System.Drawing.Point(21, 11);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(82, 38);
            this.bt_Them.TabIndex = 12;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quản lý Hóa đơn nhập";
            // 
            // dgv_HDN
            // 
            this.dgv_HDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HDN.Location = new System.Drawing.Point(254, 297);
            this.dgv_HDN.Name = "dgv_HDN";
            this.dgv_HDN.RowHeadersWidth = 51;
            this.dgv_HDN.RowTemplate.Height = 24;
            this.dgv_HDN.Size = new System.Drawing.Size(576, 280);
            this.dgv_HDN.TabIndex = 15;
            this.dgv_HDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HDN_CellClick);
            // 
            // HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_HDN);
            this.Name = "HoaDonNhap";
            this.Text = "HoaDonNhap";
            this.Load += new System.EventHandler(this.HoaDonNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_NgayNhapSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtb_MaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtb_MaHD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_TiepTuc;
        private System.Windows.Forms.Button tb_Tim;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_HDN;
    }
}