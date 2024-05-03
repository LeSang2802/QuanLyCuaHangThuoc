using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace QLT
{
    public partial class NhanVien : Form
    {
        private string gioiTinh;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

            gioiTinh = "nam" ; // Mặc định giới tính là Nam

            string constr = ConfigurationManager.ConnectionStrings["QLBanThuoc"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblNhanVien", cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dgv_NhanVien.DataSource = dt;
                    }
                    dgv_NhanVien.Columns[0].HeaderText = "Mã nhân viên";
                    dgv_NhanVien.Columns[1].HeaderText = "Họ tên";
                    dgv_NhanVien.Columns[2].HeaderText = "Ngày sinh";
                    dgv_NhanVien.Columns[3].HeaderText = "Giới tính";
                    dgv_NhanVien.Columns[4].HeaderText = "Phụ cấp";
                    dgv_NhanVien.Columns[5].HeaderText = "Lương cơ bản";
                    dgv_NhanVien.Columns[6].HeaderText = "SĐT";

                }
            }
        }

        private bool kiemtra()
        {
            if (mtb_MaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtb_MaNV.Focus();
                return false;
            }
            if (tb_HoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_HoTen.Focus();
                return false;
            }
            if (dt_NgaySinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt_NgaySinh.Focus();
                return false;
            }
            if (mtb_PhuCap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tiền phụ cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtb_PhuCap.Focus();
                return false;
            }
            if (mtb_LuongCB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tiền lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtb_LuongCB.Focus();
                return false;
            }
            if (mtb_sdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtb_sdt.Focus();
                return false;
            }
            return true;
        }

        private bool KiemTraNgaySinhHopLe(DateTime ngaySinh)
        {
            DateTime ngayHienTai = DateTime.Today;
            int tuoi = ngayHienTai.Year - ngaySinh.Year;
            return tuoi >= 18; // Trả về true nếu tuổi lớn hơn hoặc bằng 18, ngược lại trả về false
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {

            if (!KiemTraNgaySinhHopLe(dt_NgaySinh.Value))
            {
                MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thêm nhân viên nếu ngày sinh không hợp lệ
            }


            if (kiemtra())
            {
                try
                {
                    string constr = ConfigurationManager.ConnectionStrings["QLBanThuoc"].ConnectionString;
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "ThemNhanVien"; // Đảm bảo rằng đây là tên thủ tục lưu trữ đúng
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaNV", mtb_MaNV.Text);
                            cmd.Parameters.AddWithValue("@HoTen", tb_HoTen.Text);
                            cmd.Parameters.AddWithValue("@NgaySinh", dt_NgaySinh.Value.Date);
                            cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                            cmd.Parameters.AddWithValue("@PhuCap", mtb_PhuCap.Text);
                            cmd.Parameters.AddWithValue("@LuongCB", mtb_LuongCB.Text);
                            cmd.Parameters.AddWithValue("@DienThoai", mtb_sdt.Text);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            NhanVien_Load(sender, e);

                            MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Mã Nhân viên đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tb_Tim_Click(object sender, EventArgs e)
        {
            if (mtb_MaNV.Text != "")
            {
                string RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'",
                    "iMaNV", mtb_MaNV.Text.Trim());
                (dgv_NhanVien.DataSource as DataTable).DefaultView.RowFilter = RowFilter;

            }
            else
            {
                if (tb_HoTen.Text != "")
                {
                    string RowFilter = string.Format("{0} like '{1}'", "sHoTen", "*" + tb_HoTen.Text + "*");
                    (dgv_NhanVien.DataSource as DataTable).DefaultView.RowFilter = RowFilter;
                }
                else
                {
                    if (gioiTinh != "")
                    {
                        string RowFilter = string.Format("{0} like '{1}'", "sGioiTinh", "*" + gioiTinh + "*");
                        (dgv_NhanVien.DataSource as DataTable).DefaultView.RowFilter = RowFilter;
                    }
                    else
                    {
                        if (dt_NgaySinh.Text != "")
                        {
                            string RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'",
                                 "dNgaySinh", dt_NgaySinh.Text.Trim());
                            (dgv_NhanVien.DataSource as DataTable).DefaultView.RowFilter = RowFilter;
                        }
                    }
                }
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_TiepTuc_Click(object sender, EventArgs e)
        {
            mtb_MaNV.Text = "";
            tb_HoTen.Text = "";
            mtb_LuongCB.Text = "";
            mtb_PhuCap.Text = "";
            mtb_sdt.Text = "";
            dt_NgaySinh.Text = "";

            string constr = ConfigurationManager.ConnectionStrings["QLBanThuoc"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblNhanVien", cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dgv_NhanVien.DataSource = dt;
                    }
                    dgv_NhanVien.Columns[0].HeaderText = "Mã nhân viên";
                    dgv_NhanVien.Columns[1].HeaderText = "Họ tên";
                    dgv_NhanVien.Columns[2].HeaderText = "Ngày sinh";
                    dgv_NhanVien.Columns[3].HeaderText = "Giới tính";
                    dgv_NhanVien.Columns[4].HeaderText = "Phụ cấp";
                    dgv_NhanVien.Columns[5].HeaderText = "Lương cơ bản";
                    dgv_NhanVien.Columns[6].HeaderText = "SĐT";

                }
            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (mtb_MaNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần Xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string constr = ConfigurationManager.ConnectionStrings["QLBanThuoc"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        //MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        cmd.Connection = conn;
                        cmd.CommandText = "XoaNhanVien";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNV", mtb_MaNV.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        NhanVien_Load(sender, e);

                        MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể xóa nhân viên này do có liên kết với nhiều bảng khác ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {

            if (mtb_MaNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string constr = ConfigurationManager.ConnectionStrings["QLBanThuoc"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SuaNhanVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Truyền các tham số cho thủ tục lưu trữ
                        cmd.Parameters.AddWithValue("@MaNV", mtb_MaNV.Text);
                        cmd.Parameters.AddWithValue("@HoTen", tb_HoTen.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dt_NgaySinh.Value.Date);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmd.Parameters.AddWithValue("@PhuCap", mtb_PhuCap.Text);
                        cmd.Parameters.AddWithValue("@LuongCB", mtb_LuongCB.Text);
                        cmd.Parameters.AddWithValue("@DienThoai", mtb_sdt.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        // Cập nhật lại dữ liệu trên DataGridView sau khi đã sửa
                        NhanVien_Load(sender, e);

                        MessageBox.Show("Sửa thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa thông tin nhân viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_NhanVien.CurrentRow.Index;
            mtb_MaNV.Text = dgv_NhanVien.Rows[i].Cells[0].Value.ToString();
            tb_HoTen.Text = dgv_NhanVien.Rows[i].Cells[1].Value.ToString();
            dt_NgaySinh.Text = dgv_NhanVien.Rows[i].Cells[2].Value.ToString();
            gioiTinh = dgv_NhanVien.Rows[i].Cells[3].Value.ToString();
            mtb_PhuCap.Text = dgv_NhanVien.Rows[i].Cells[4].Value.ToString();
            mtb_LuongCB.Text = dgv_NhanVien.Rows[i].Cells[5].Value.ToString();
            mtb_sdt.Text = dgv_NhanVien.Rows[i].Cells[6].Value.ToString();

            if (gioiTinh.ToLower() == "nam")
            {
                radioButton_Nam.Checked = true;
            }
            else if (gioiTinh.ToLower() == "nữ")
            {
                radioButton_Nu.Checked = true;
            }
        }
        private void radioButton_Nam_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Nam.Checked)
            {
                gioiTinh = "nam";
            }
        }

        private void radioButton_Nu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Nu.Checked)
            {
                gioiTinh = "nữ";
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            //lệnh lọc dữ liệu in báo cáo
            string reportFilter = "NOT(ISNULL({Select_All_NV.iMaNV}))";
            if (!string.IsNullOrEmpty(mtb_MaNV.Text))
            {
                reportFilter += string.Format(" AND {0} LIKE '*{1}*'", "{Select_All_NV.iMaNV}", mtb_MaNV.Text);
            }
            if (!string.IsNullOrEmpty(tb_HoTen.Text))
            {
                reportFilter += string.Format(" AND {0} LIKE '*{1}*'", "{Select_All_NV.sHoTen}", tb_HoTen.Text);
            }
            if (!string.IsNullOrEmpty(gioiTinh))
            {
                reportFilter += string.Format(" AND {0} LIKE '*{1}*'", "{Select_All_NV.sGioiTinh}", gioiTinh);
            }

            FormInDanhSachNV form = new FormInDanhSachNV();
            form.Show();
            form.ShowReport(reportFilter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInDanhSachHDB_NV form = new FormInDanhSachHDB_NV();
            form.Show();
            form.showReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            i = dgv_NhanVien.CurrentRow.Index;
            if (dgv_NhanVien.Rows[i].Cells[0].Value.ToString() != null)
            {
                string MaNV = dgv_NhanVien.Rows[i].Cells[0].Value.ToString();
                FormInHoaDonNhap_MaNV f2 = new FormInHoaDonNhap_MaNV();
                f2.Show();
                f2.hienDL(MaNV);
            }
            else
            {
                MessageBox.Show("hãy chọn nhân viên !");
            }
        }


    }
}
