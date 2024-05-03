namespace QLT
{
    partial class KhachHang
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
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.tb_Tim = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_TiepTuc = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.mtb_MaKH = new System.Windows.Forms.MaskedTextBox();
            this.mtb_sdt = new System.Windows.Forms.MaskedTextBox();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_Thoat);
            this.panel2.Controls.Add(this.bt_TiepTuc);
            this.panel2.Controls.Add(this.tb_Tim);
            this.panel2.Controls.Add(this.bt_Xoa);
            this.panel2.Controls.Add(this.bt_Sua);
            this.panel2.Controls.Add(this.bt_Them);
            this.panel2.Location = new System.Drawing.Point(109, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 59);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản lý khách hàng";
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Location = new System.Drawing.Point(218, 330);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.RowTemplate.Height = 24;
            this.dgv_KhachHang.Size = new System.Drawing.Size(654, 223);
            this.dgv_KhachHang.TabIndex = 7;
            this.dgv_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhachHang_CellClick);
            // 
            // mtb_MaKH
            // 
            this.mtb_MaKH.Location = new System.Drawing.Point(122, 36);
            this.mtb_MaKH.Mask = "000";
            this.mtb_MaKH.Name = "mtb_MaKH";
            this.mtb_MaKH.Size = new System.Drawing.Size(338, 22);
            this.mtb_MaKH.TabIndex = 10;
            this.mtb_MaKH.ValidatingType = typeof(int);
            // 
            // mtb_sdt
            // 
            this.mtb_sdt.Location = new System.Drawing.Point(601, 100);
            this.mtb_sdt.Mask = "9990000000";
            this.mtb_sdt.Name = "mtb_sdt";
            this.mtb_sdt.Size = new System.Drawing.Size(274, 22);
            this.mtb_sdt.TabIndex = 14;
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.Location = new System.Drawing.Point(122, 103);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(338, 22);
            this.tb_HoTen.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Họ tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(494, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Số điện thoại";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_DiaChi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_HoTen);
            this.panel1.Controls.Add(this.mtb_sdt);
            this.panel1.Controls.Add(this.mtb_MaKH);
            this.panel1.Location = new System.Drawing.Point(105, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 160);
            this.panel1.TabIndex = 9;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(588, 36);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(287, 22);
            this.tb_DiaChi.TabIndex = 24;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_KhachHang);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button tb_Tim;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_TiepTuc;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.MaskedTextBox mtb_MaKH;
        private System.Windows.Forms.MaskedTextBox mtb_sdt;
        private System.Windows.Forms.TextBox tb_HoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_DiaChi;
    }
}