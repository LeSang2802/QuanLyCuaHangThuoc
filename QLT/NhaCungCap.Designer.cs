namespace QLT
{
    partial class NhaCungCap
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
            this.warn_lb = new System.Windows.Forms.Label();
            this.inGom_btn = new System.Windows.Forms.Button();
            this.in_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nhacc_dtgv = new System.Windows.Forms.DataGridView();
            this.quaylai_btn = new System.Windows.Forms.Button();
            this.timkiem_btn = new System.Windows.Forms.Button();
            this.lammoi_btn = new System.Windows.Forms.Button();
            this.xoa_btn = new System.Windows.Forms.Button();
            this.sua_btn = new System.Windows.Forms.Button();
            this.them_btn = new System.Windows.Forms.Button();
            this.sdt_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.diachi_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tenNhacc_tb = new System.Windows.Forms.TextBox();
            this.tenNhaCC = new System.Windows.Forms.Label();
            this.maNhaCC_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nhacc_dtgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // warn_lb
            // 
            this.warn_lb.AutoSize = true;
            this.warn_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warn_lb.ForeColor = System.Drawing.Color.Red;
            this.warn_lb.Location = new System.Drawing.Point(59, 164);
            this.warn_lb.Name = "warn_lb";
            this.warn_lb.Size = new System.Drawing.Size(0, 20);
            this.warn_lb.TabIndex = 18;
            // 
            // inGom_btn
            // 
            this.inGom_btn.Location = new System.Drawing.Point(684, 119);
            this.inGom_btn.Name = "inGom_btn";
            this.inGom_btn.Size = new System.Drawing.Size(129, 43);
            this.inGom_btn.TabIndex = 17;
            this.inGom_btn.Text = "in theo địa điểm";
            this.inGom_btn.UseVisualStyleBackColor = true;
            // 
            // in_btn
            // 
            this.in_btn.Location = new System.Drawing.Point(684, 59);
            this.in_btn.Name = "in_btn";
            this.in_btn.Size = new System.Drawing.Size(129, 42);
            this.in_btn.TabIndex = 16;
            this.in_btn.Text = "in danh sách";
            this.in_btn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Danh sách";
            // 
            // nhacc_dtgv
            // 
            this.nhacc_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhacc_dtgv.Location = new System.Drawing.Point(6, 273);
            this.nhacc_dtgv.Name = "nhacc_dtgv";
            this.nhacc_dtgv.RowHeadersWidth = 51;
            this.nhacc_dtgv.RowTemplate.Height = 24;
            this.nhacc_dtgv.Size = new System.Drawing.Size(807, 189);
            this.nhacc_dtgv.TabIndex = 14;
            this.nhacc_dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nhacc_dtgv_CellClick);
            // 
            // quaylai_btn
            // 
            this.quaylai_btn.Location = new System.Drawing.Point(589, 206);
            this.quaylai_btn.Name = "quaylai_btn";
            this.quaylai_btn.Size = new System.Drawing.Size(75, 28);
            this.quaylai_btn.TabIndex = 13;
            this.quaylai_btn.Text = "Quay lại";
            this.quaylai_btn.UseVisualStyleBackColor = true;
            this.quaylai_btn.Click += new System.EventHandler(this.quaylai_btn_Click);
            // 
            // timkiem_btn
            // 
            this.timkiem_btn.Location = new System.Drawing.Point(481, 206);
            this.timkiem_btn.Name = "timkiem_btn";
            this.timkiem_btn.Size = new System.Drawing.Size(75, 28);
            this.timkiem_btn.TabIndex = 12;
            this.timkiem_btn.Text = "Tìm kiếm";
            this.timkiem_btn.UseVisualStyleBackColor = true;
            this.timkiem_btn.Click += new System.EventHandler(this.timkiem_btn_Click);
            // 
            // lammoi_btn
            // 
            this.lammoi_btn.Location = new System.Drawing.Point(374, 206);
            this.lammoi_btn.Name = "lammoi_btn";
            this.lammoi_btn.Size = new System.Drawing.Size(75, 28);
            this.lammoi_btn.TabIndex = 11;
            this.lammoi_btn.Text = "Làm mới";
            this.lammoi_btn.UseVisualStyleBackColor = true;
            this.lammoi_btn.Click += new System.EventHandler(this.lammoi_btn_Click);
            // 
            // xoa_btn
            // 
            this.xoa_btn.Location = new System.Drawing.Point(263, 206);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(75, 28);
            this.xoa_btn.TabIndex = 10;
            this.xoa_btn.Text = "Xoá";
            this.xoa_btn.UseVisualStyleBackColor = true;
            this.xoa_btn.Click += new System.EventHandler(this.xoa_btn_Click);
            // 
            // sua_btn
            // 
            this.sua_btn.Location = new System.Drawing.Point(158, 206);
            this.sua_btn.Name = "sua_btn";
            this.sua_btn.Size = new System.Drawing.Size(75, 28);
            this.sua_btn.TabIndex = 9;
            this.sua_btn.Text = "Sửa";
            this.sua_btn.UseVisualStyleBackColor = true;
            this.sua_btn.Click += new System.EventHandler(this.sua_btn_Click);
            // 
            // them_btn
            // 
            this.them_btn.Location = new System.Drawing.Point(52, 206);
            this.them_btn.Name = "them_btn";
            this.them_btn.Size = new System.Drawing.Size(75, 28);
            this.them_btn.TabIndex = 8;
            this.them_btn.Text = "Thêm";
            this.them_btn.UseVisualStyleBackColor = true;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // sdt_tb
            // 
            this.sdt_tb.Location = new System.Drawing.Point(481, 119);
            this.sdt_tb.Name = "sdt_tb";
            this.sdt_tb.Size = new System.Drawing.Size(162, 22);
            this.sdt_tb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số điện thoại";
            // 
            // diachi_tb
            // 
            this.diachi_tb.Location = new System.Drawing.Point(173, 119);
            this.diachi_tb.Name = "diachi_tb";
            this.diachi_tb.Size = new System.Drawing.Size(124, 22);
            this.diachi_tb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Địa chỉ";
            // 
            // tenNhacc_tb
            // 
            this.tenNhacc_tb.Location = new System.Drawing.Point(481, 59);
            this.tenNhacc_tb.Name = "tenNhacc_tb";
            this.tenNhacc_tb.Size = new System.Drawing.Size(162, 22);
            this.tenNhacc_tb.TabIndex = 3;
            // 
            // tenNhaCC
            // 
            this.tenNhaCC.AutoSize = true;
            this.tenNhaCC.Location = new System.Drawing.Point(358, 59);
            this.tenNhaCC.Name = "tenNhaCC";
            this.tenNhaCC.Size = new System.Drawing.Size(114, 16);
            this.tenNhaCC.TabIndex = 2;
            this.tenNhaCC.Text = "Tên nhà cung cấp";
            // 
            // maNhaCC_tb
            // 
            this.maNhaCC_tb.Location = new System.Drawing.Point(173, 59);
            this.maNhaCC_tb.Name = "maNhaCC_tb";
            this.maNhaCC_tb.Size = new System.Drawing.Size(124, 22);
            this.maNhaCC_tb.TabIndex = 1;
            this.maNhaCC_tb.Validating += new System.ComponentModel.CancelEventHandler(this.maNhaCC_tb_Validating);
            this.maNhaCC_tb.Validated += new System.EventHandler(this.maNhaCC_tb_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.warn_lb);
            this.groupBox1.Controls.Add(this.inGom_btn);
            this.groupBox1.Controls.Add(this.in_btn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nhacc_dtgv);
            this.groupBox1.Controls.Add(this.quaylai_btn);
            this.groupBox1.Controls.Add(this.timkiem_btn);
            this.groupBox1.Controls.Add(this.lammoi_btn);
            this.groupBox1.Controls.Add(this.xoa_btn);
            this.groupBox1.Controls.Add(this.sua_btn);
            this.groupBox1.Controls.Add(this.them_btn);
            this.groupBox1.Controls.Add(this.sdt_tb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.diachi_tb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tenNhacc_tb);
            this.groupBox1.Controls.Add(this.tenNhaCC);
            this.groupBox1.Controls.Add(this.maNhaCC_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 474);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 468);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhaCungCap";
            this.Text = "NhaCungCap";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhacc_dtgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label warn_lb;
        private System.Windows.Forms.Button inGom_btn;
        private System.Windows.Forms.Button in_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView nhacc_dtgv;
        private System.Windows.Forms.Button quaylai_btn;
        private System.Windows.Forms.Button timkiem_btn;
        private System.Windows.Forms.Button lammoi_btn;
        private System.Windows.Forms.Button xoa_btn;
        private System.Windows.Forms.Button sua_btn;
        private System.Windows.Forms.Button them_btn;
        private System.Windows.Forms.TextBox sdt_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox diachi_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tenNhacc_tb;
        private System.Windows.Forms.Label tenNhaCC;
        private System.Windows.Forms.TextBox maNhaCC_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}