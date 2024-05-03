namespace QLT
{
    partial class HoaDonBan
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
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_TiepTuc = new System.Windows.Forms.Button();
            this.tb_Tim = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_NgayDat = new System.Windows.Forms.DateTimePicker();
            this.dt_NgayGiao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtb_MaKH = new System.Windows.Forms.MaskedTextBox();
            this.mtb_MaNV = new System.Windows.Forms.MaskedTextBox();
            this.mtb_MaHD = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_HDB = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDB)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(551, 141);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(287, 22);
            this.tb_DiaChi.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Địa chỉ giao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã hóa đơn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_Thoat);
            this.panel2.Controls.Add(this.bt_TiepTuc);
            this.panel2.Controls.Add(this.tb_Tim);
            this.panel2.Controls.Add(this.bt_Xoa);
            this.panel2.Controls.Add(this.bt_Sua);
            this.panel2.Controls.Add(this.bt_Them);
            this.panel2.Location = new System.Drawing.Point(132, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 59);
            this.panel2.TabIndex = 10;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dt_NgayDat);
            this.panel1.Controls.Add(this.dt_NgayGiao);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.mtb_MaKH);
            this.panel1.Controls.Add(this.mtb_MaNV);
            this.panel1.Controls.Add(this.tb_DiaChi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mtb_MaHD);
            this.panel1.Location = new System.Drawing.Point(128, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 210);
            this.panel1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Ngày đặt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ngày giao";
            // 
            // dt_NgayDat
            // 
            this.dt_NgayDat.Location = new System.Drawing.Point(551, 36);
            this.dt_NgayDat.Name = "dt_NgayDat";
            this.dt_NgayDat.Size = new System.Drawing.Size(287, 22);
            this.dt_NgayDat.TabIndex = 30;
            // 
            // dt_NgayGiao
            // 
            this.dt_NgayGiao.Location = new System.Drawing.Point(551, 88);
            this.dt_NgayGiao.Name = "dt_NgayGiao";
            this.dt_NgayGiao.Size = new System.Drawing.Size(287, 22);
            this.dt_NgayGiao.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mã khách hàng";
            // 
            // mtb_MaKH
            // 
            this.mtb_MaKH.Location = new System.Drawing.Point(143, 144);
            this.mtb_MaKH.Mask = "000";
            this.mtb_MaKH.Name = "mtb_MaKH";
            this.mtb_MaKH.Size = new System.Drawing.Size(122, 22);
            this.mtb_MaKH.TabIndex = 26;
            this.mtb_MaKH.ValidatingType = typeof(int);
            // 
            // mtb_MaNV
            // 
            this.mtb_MaNV.Location = new System.Drawing.Point(143, 88);
            this.mtb_MaNV.Mask = "000";
            this.mtb_MaNV.Name = "mtb_MaNV";
            this.mtb_MaNV.Size = new System.Drawing.Size(122, 22);
            this.mtb_MaNV.TabIndex = 25;
            this.mtb_MaNV.ValidatingType = typeof(int);
            // 
            // mtb_MaHD
            // 
            this.mtb_MaHD.Location = new System.Drawing.Point(143, 33);
            this.mtb_MaHD.Mask = "000";
            this.mtb_MaHD.Name = "mtb_MaHD";
            this.mtb_MaHD.Size = new System.Drawing.Size(122, 22);
            this.mtb_MaHD.TabIndex = 10;
            this.mtb_MaHD.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quản lý Hóa đơn bán";
            // 
            // dgv_HDB
            // 
            this.dgv_HDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HDB.Location = new System.Drawing.Point(100, 345);
            this.dgv_HDB.Name = "dgv_HDB";
            this.dgv_HDB.RowHeadersWidth = 51;
            this.dgv_HDB.RowTemplate.Height = 24;
            this.dgv_HDB.Size = new System.Drawing.Size(962, 223);
            this.dgv_HDB.TabIndex = 11;
            this.dgv_HDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HDB_CellClick);
            // 
            // HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_HDB);
            this.Name = "HoaDonBan";
            this.Text = "HoaDonBan";
            this.Load += new System.EventHandler(this.HoaDonBan_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_TiepTuc;
        private System.Windows.Forms.Button tb_Tim;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mtb_MaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_HDB;
        private System.Windows.Forms.MaskedTextBox mtb_MaNV;
        private System.Windows.Forms.MaskedTextBox mtb_MaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_NgayDat;
        private System.Windows.Forms.DateTimePicker dt_NgayGiao;
    }
}