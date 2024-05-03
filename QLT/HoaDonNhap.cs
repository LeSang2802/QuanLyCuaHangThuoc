using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLT
{
    public partial class HoaDonNhap : Form
    {
        public HoaDonNhap()
        {
            InitializeComponent();
        }

        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLBanThuoc"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblHoaDonNhap", cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dgv_HDN.DataSource = dt;
                    }
                    dgv_HDN.Columns[0].HeaderText = "Mã hóa đơn";
                    dgv_HDN.Columns[1].HeaderText = "Mã nhân viên";
                    dgv_HDN.Columns[2].HeaderText = "Ngày nhập sản phẩm";

                }
            }
        }
        private bool kiemtra()
        {
            if (mtb_MaHD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtb_MaHD.Focus();
                return false;
            }
            if (mtb_MaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtb_MaNV.Focus();
                return false;
            }
            if (dt_NgayNhapSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt_NgayNhapSP.Focus();
                return false;
            }

            return true;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
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
                            cmd.CommandText = "ThemHDN"; // Đảm bảo rằng đây là tên thủ tục lưu trữ đúng
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@iMaHD", mtb_MaHD.Text);
                            cmd.Parameters.AddWithValue("@MaNV", mtb_MaNV.Text);
                            cmd.Parameters.AddWithValue("@NgayNhapSP", dt_NgayNhapSP.Value.Date);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            HoaDonNhap_Load(sender, e);

                            MessageBox.Show("Thêm  hóa đơn nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi thêm hóa đơn nhập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tb_Tim_Click(object sender, EventArgs e)
        {
            if (mtb_MaHD.Text != "")
            {
                string RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'",
                    "iMaHD", mtb_MaHD.Text.Trim());
                (dgv_HDN.DataSource as DataTable).DefaultView.RowFilter = RowFilter;

            }
            else
            {
                if (mtb_MaNV.Text != "")
                {
                    string RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'",
                        "iMaNV", mtb_MaNV.Text.Trim());
                    (dgv_HDN.DataSource as DataTable).DefaultView.RowFilter = RowFilter;

                }
                else
                {
                    if (dt_NgayNhapSP.Text != "")
                    {
                        string RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'",
                             "dNgayNhapSP", dt_NgayNhapSP.Text.Trim());
                        (dgv_HDN.DataSource as DataTable).DefaultView.RowFilter = RowFilter;
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
            mtb_MaHD.Text = "";
            mtb_MaNV.Text = "";
            dt_NgayNhapSP.Text = "";

            string constr = ConfigurationManager.ConnectionStrings["QLBanThuoc"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblHoaDonNhap", cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dgv_HDN.DataSource = dt;
                    }
                    dgv_HDN.Columns[0].HeaderText = "Mã hóa đơn";
                    dgv_HDN.Columns[1].HeaderText = "Mã nhân viên";
                    dgv_HDN.Columns[2].HeaderText = "Ngày nhập sản phẩm";

                }
            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (mtb_MaHD.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần Xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        cmd.CommandText = "XoaHDN";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHD", mtb_MaHD.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        HoaDonNhap_Load(sender, e);

                        MessageBox.Show("Xóa hóa đơn nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi xóa hóa đơn nhập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            if (mtb_MaHD.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string constr = ConfigurationManager.ConnectionStrings["QLBanThuoc"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SuaHDN", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Truyền các tham số cho thủ tục lưu trữ
                        cmd.Parameters.AddWithValue("@iMaHD", mtb_MaHD.Text);
                        cmd.Parameters.AddWithValue("@MaNV", mtb_MaNV.Text);
                        cmd.Parameters.AddWithValue("@NgayNhapSP", dt_NgayNhapSP.Value.Date);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        // Cập nhật lại dữ liệu trên DataGridView sau khi đã sửa
                        HoaDonNhap_Load(sender, e);

                        MessageBox.Show("Sửa thông tin hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa thông tin hóa đơn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_HDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_HDN.CurrentRow.Index;
            mtb_MaHD.Text = dgv_HDN.Rows[i].Cells[0].Value.ToString();
            mtb_MaNV.Text = dgv_HDN.Rows[i].Cells[1].Value.ToString();
            dt_NgayNhapSP.Text = dgv_HDN.Rows[i].Cells[2].Value.ToString();
        }
    }
}
