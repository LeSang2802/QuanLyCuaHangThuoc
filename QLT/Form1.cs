using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.MdiParent = this;
            nhanvien.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang khachhang = new KhachHang();
            khachhang.MdiParent = this;
            khachhang.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MdiParent = this;
            sp.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCap NCC = new NhaCungCap();
            NCC.MdiParent = this;
            NCC.Show();
        }

        private void hóaĐơnBánToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HoaDonBan HDB = new HoaDonBan();
            HDB.MdiParent = this;
            HDB.Show();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonNhap HDN = new HoaDonNhap();
            HDN.MdiParent = this;
            HDN.Show();
        }

        private void chiTiếtHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chitiethoadonnhap CTHDN = new Chitiethoadonnhap();
            CTHDN.MdiParent = this;
            CTHDN.Show();
        }

        private void chiTiếtHóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chitiethoadonban CTHDB = new Chitiethoadonban();
            CTHDB.MdiParent = this;
            CTHDB.Show();
        }
    }
}
