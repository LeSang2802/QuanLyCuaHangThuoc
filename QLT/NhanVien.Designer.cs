namespace QLT
{
    partial class NhanVien
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
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_Nu = new System.Windows.Forms.RadioButton();
            this.radioButton_Nam = new System.Windows.Forms.RadioButton();
            this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.mtb_sdt = new System.Windows.Forms.MaskedTextBox();
            this.mtb_LuongCB = new System.Windows.Forms.MaskedTextBox();
            this.mtb_PhuCap = new System.Windows.Forms.MaskedTextBox();
            this.mtb_MaNV = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_TiepTuc = new System.Windows.Forms.Button();
            this.tb_Tim = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Location = new System.Drawing.Point(12, 317);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.RowTemplate.Height = 24;
            this.dgv_NhanVien.Size = new System.Drawing.Size(1043, 223);
            this.dgv_NhanVien.TabIndex = 0;
            this.dgv_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_Nu);
            this.panel1.Controls.Add(this.radioButton_Nam);
            this.panel1.Controls.Add(this.dt_NgaySinh);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_HoTen);
            this.panel1.Controls.Add(this.mtb_sdt);
            this.panel1.Controls.Add(this.mtb_LuongCB);
            this.panel1.Controls.Add(this.mtb_PhuCap);
            this.panel1.Controls.Add(this.mtb_MaNV);
            this.panel1.Location = new System.Drawing.Point(85, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 212);
            this.panel1.TabIndex = 2;
            // 
            // radioButton_Nu
            // 
            this.radioButton_Nu.AutoSize = true;
            this.radioButton_Nu.Location = new System.Drawing.Point(203, 174);
            this.radioButton_Nu.Name = "radioButton_Nu";
            this.radioButton_Nu.Size = new System.Drawing.Size(42, 20);
            this.radioButton_Nu.TabIndex = 27;
            this.radioButton_Nu.TabStop = true;
            this.radioButton_Nu.Text = "nữ";
            this.radioButton_Nu.UseVisualStyleBackColor = true;
            this.radioButton_Nu.CheckedChanged += new System.EventHandler(this.radioButton_Nu_CheckedChanged);
            // 
            // radioButton_Nam
            // 
            this.radioButton_Nam.AutoSize = true;
            this.radioButton_Nam.Location = new System.Drawing.Point(122, 174);
            this.radioButton_Nam.Name = "radioButton_Nam";
            this.radioButton_Nam.Size = new System.Drawing.Size(54, 20);
            this.radioButton_Nam.TabIndex = 26;
            this.radioButton_Nam.TabStop = true;
            this.radioButton_Nam.Text = "nam";
            this.radioButton_Nam.UseVisualStyleBackColor = true;
            this.radioButton_Nam.CheckedChanged += new System.EventHandler(this.radioButton_Nam_CheckedChanged);
            // 
            // dt_NgaySinh
            // 
            this.dt_NgaySinh.Location = new System.Drawing.Point(122, 132);
            this.dt_NgaySinh.Name = "dt_NgaySinh";
            this.dt_NgaySinh.Size = new System.Drawing.Size(338, 22);
            this.dt_NgaySinh.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Lương cơ bản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Phụ cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã nhân viên";
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.Location = new System.Drawing.Point(122, 76);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(338, 22);
            this.tb_HoTen.TabIndex = 15;
            // 
            // mtb_sdt
            // 
            this.mtb_sdt.Location = new System.Drawing.Point(586, 153);
            this.mtb_sdt.Mask = "9990000000";
            this.mtb_sdt.Name = "mtb_sdt";
            this.mtb_sdt.Size = new System.Drawing.Size(274, 22);
            this.mtb_sdt.TabIndex = 14;
            // 
            // mtb_LuongCB
            // 
            this.mtb_LuongCB.Location = new System.Drawing.Point(586, 89);
            this.mtb_LuongCB.Mask = "000000";
            this.mtb_LuongCB.Name = "mtb_LuongCB";
            this.mtb_LuongCB.Size = new System.Drawing.Size(274, 22);
            this.mtb_LuongCB.TabIndex = 13;
            this.mtb_LuongCB.ValidatingType = typeof(int);
            // 
            // mtb_PhuCap
            // 
            this.mtb_PhuCap.Location = new System.Drawing.Point(586, 33);
            this.mtb_PhuCap.Mask = "00000";
            this.mtb_PhuCap.Name = "mtb_PhuCap";
            this.mtb_PhuCap.Size = new System.Drawing.Size(274, 22);
            this.mtb_PhuCap.TabIndex = 12;
            this.mtb_PhuCap.ValidatingType = typeof(int);
            // 
            // mtb_MaNV
            // 
            this.mtb_MaNV.Location = new System.Drawing.Point(122, 21);
            this.mtb_MaNV.Mask = "000";
            this.mtb_MaNV.Name = "mtb_MaNV";
            this.mtb_MaNV.Size = new System.Drawing.Size(338, 22);
            this.mtb_MaNV.TabIndex = 10;
            this.mtb_MaNV.ValidatingType = typeof(int);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_Thoat);
            this.panel2.Controls.Add(this.bt_TiepTuc);
            this.panel2.Controls.Add(this.tb_Tim);
            this.panel2.Controls.Add(this.bt_Xoa);
            this.panel2.Controls.Add(this.bt_Sua);
            this.panel2.Controls.Add(this.bt_Them);
            this.panel2.Location = new System.Drawing.Point(89, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 59);
            this.panel2.TabIndex = 0;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1002, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "In danh sách NV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1002, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "In DS HDB_NV";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1011, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 59);
            this.button3.TabIndex = 5;
            this.button3.Text = "In HDN theo mã NV được chọn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 596);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_NhanVien);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mtb_sdt;
        private System.Windows.Forms.MaskedTextBox mtb_LuongCB;
        private System.Windows.Forms.MaskedTextBox mtb_PhuCap;
        private System.Windows.Forms.MaskedTextBox mtb_MaNV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_TiepTuc;
        private System.Windows.Forms.Button tb_Tim;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.TextBox tb_HoTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dt_NgaySinh;
        private System.Windows.Forms.RadioButton radioButton_Nam;
        private System.Windows.Forms.RadioButton radioButton_Nu;
    }
}