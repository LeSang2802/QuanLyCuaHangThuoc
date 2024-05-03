namespace QLT
{
    partial class SanPham
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
            this.bt_InNCC = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dGV_danhsach = new System.Windows.Forms.DataGridView();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_Lammoi = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Timkiem = new System.Windows.Forms.Button();
            this.bt_In = new System.Windows.Forms.Button();
            this.tb_Giahang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Solg = new System.Windows.Forms.TextBox();
            this.tb_TenNCC = new System.Windows.Forms.TextBox();
            this.tb_Tensp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Masp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_danhsach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_InNCC
            // 
            this.bt_InNCC.Location = new System.Drawing.Point(754, 96);
            this.bt_InNCC.Name = "bt_InNCC";
            this.bt_InNCC.Size = new System.Drawing.Size(95, 42);
            this.bt_InNCC.TabIndex = 19;
            this.bt_InNCC.Text = "In thuốc theo NCC";
            this.bt_InNCC.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Danh sách";
            // 
            // dGV_danhsach
            // 
            this.dGV_danhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_danhsach.Location = new System.Drawing.Point(0, 217);
            this.dGV_danhsach.Name = "dGV_danhsach";
            this.dGV_danhsach.RowHeadersWidth = 51;
            this.dGV_danhsach.RowTemplate.Height = 24;
            this.dGV_danhsach.Size = new System.Drawing.Size(895, 275);
            this.dGV_danhsach.TabIndex = 17;
            this.dGV_danhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_danhsach_CellClick);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Location = new System.Drawing.Point(761, 160);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(76, 31);
            this.bt_Thoat.TabIndex = 16;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // bt_Lammoi
            // 
            this.bt_Lammoi.Location = new System.Drawing.Point(98, 160);
            this.bt_Lammoi.Name = "bt_Lammoi";
            this.bt_Lammoi.Size = new System.Drawing.Size(84, 31);
            this.bt_Lammoi.TabIndex = 15;
            this.bt_Lammoi.Text = "Làm mới";
            this.bt_Lammoi.UseVisualStyleBackColor = true;
            this.bt_Lammoi.Click += new System.EventHandler(this.bt_Lammoi_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(634, 159);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(87, 32);
            this.bt_Xoa.TabIndex = 14;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(508, 159);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(80, 32);
            this.bt_Sua.TabIndex = 13;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.Location = new System.Drawing.Point(369, 159);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(94, 32);
            this.bt_Them.TabIndex = 12;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // bt_Timkiem
            // 
            this.bt_Timkiem.Location = new System.Drawing.Point(236, 159);
            this.bt_Timkiem.Name = "bt_Timkiem";
            this.bt_Timkiem.Size = new System.Drawing.Size(78, 31);
            this.bt_Timkiem.TabIndex = 11;
            this.bt_Timkiem.Text = "Tìm kiếm";
            this.bt_Timkiem.UseVisualStyleBackColor = true;
            this.bt_Timkiem.Click += new System.EventHandler(this.bt_Timkiem_Click);
            // 
            // bt_In
            // 
            this.bt_In.Location = new System.Drawing.Point(620, 96);
            this.bt_In.Name = "bt_In";
            this.bt_In.Size = new System.Drawing.Size(101, 42);
            this.bt_In.TabIndex = 10;
            this.bt_In.Text = "In ds sản phẩm";
            this.bt_In.UseVisualStyleBackColor = true;
            // 
            // tb_Giahang
            // 
            this.tb_Giahang.Location = new System.Drawing.Point(320, 83);
            this.tb_Giahang.Name = "tb_Giahang";
            this.tb_Giahang.Size = new System.Drawing.Size(111, 22);
            this.tb_Giahang.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá hàng";
            // 
            // tb_Solg
            // 
            this.tb_Solg.Location = new System.Drawing.Point(118, 84);
            this.tb_Solg.Name = "tb_Solg";
            this.tb_Solg.Size = new System.Drawing.Size(100, 22);
            this.tb_Solg.TabIndex = 7;
            // 
            // tb_TenNCC
            // 
            this.tb_TenNCC.Location = new System.Drawing.Point(702, 29);
            this.tb_TenNCC.Name = "tb_TenNCC";
            this.tb_TenNCC.Size = new System.Drawing.Size(166, 22);
            this.tb_TenNCC.TabIndex = 6;
            // 
            // tb_Tensp
            // 
            this.tb_Tensp.Location = new System.Drawing.Point(352, 32);
            this.tb_Tensp.Name = "tb_Tensp";
            this.tb_Tensp.Size = new System.Drawing.Size(192, 22);
            this.tb_Tensp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên sản phẩm";
            // 
            // tb_Masp
            // 
            this.tb_Masp.Location = new System.Drawing.Point(118, 32);
            this.tb_Masp.Name = "tb_Masp";
            this.tb_Masp.Size = new System.Drawing.Size(100, 22);
            this.tb_Masp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(21, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sản phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_InNCC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dGV_danhsach);
            this.groupBox1.Controls.Add(this.bt_Thoat);
            this.groupBox1.Controls.Add(this.bt_Lammoi);
            this.groupBox1.Controls.Add(this.bt_Xoa);
            this.groupBox1.Controls.Add(this.bt_Sua);
            this.groupBox1.Controls.Add(this.bt_Them);
            this.groupBox1.Controls.Add(this.bt_Timkiem);
            this.groupBox1.Controls.Add(this.bt_In);
            this.groupBox1.Controls.Add(this.tb_Giahang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_Solg);
            this.groupBox1.Controls.Add(this.tb_TenNCC);
            this.groupBox1.Controls.Add(this.tb_Tensp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_Masp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 493);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 511);
            this.Controls.Add(this.groupBox1);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_danhsach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_InNCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dGV_danhsach;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_Lammoi;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_Timkiem;
        private System.Windows.Forms.Button bt_In;
        private System.Windows.Forms.TextBox tb_Giahang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Solg;
        private System.Windows.Forms.TextBox tb_TenNCC;
        private System.Windows.Forms.TextBox tb_Tensp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Masp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}