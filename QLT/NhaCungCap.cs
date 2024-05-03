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
    public partial class NhaCungCap : Form
    {
        private string connectionString = ConfigurationManager
                                     .ConnectionStrings["QLBanThuoc"]
                                     .ConnectionString;
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            loadDataNhaCC();
            sua_btn.Enabled = false;
            xoa_btn.Enabled = false;
            //them_btn.Enabled = false;
        }
        private void loadDataNhaCC()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("select_NhaCC", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                nhacc_dtgv.DataSource = dt;


            }
        }

        private void lammoi_btn_Click(object sender, EventArgs e)
        {
            maNhaCC_tb.Text = "";
            tenNhacc_tb.Text = "";
            diachi_tb.Text = "";
            sdt_tb.Text = "";
        }

        private void quaylai_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            string maNhaCC = maNhaCC_tb.Text;
            string tenNhaCC = tenNhacc_tb.Text;
            string diaChi = diachi_tb.Text;
            string sdt = sdt_tb.Text;

            if (KiemTraTonTai(maNhaCC, tenNhaCC))
            {
                warn_lb.Text = "Mã hoặc Tên nhà cung cấp đã tồn tại!!!!!";
            }
            else
            {
                them_btn.Enabled = true;
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("insert_NhaCC", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@iMaNCC", maNhaCC);
                    cmd.Parameters.AddWithValue("@sTenNCC", tenNhaCC);
                    cmd.Parameters.AddWithValue("@sDiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@sSDT", sdt);
                    cmd.ExecuteNonQuery();
                }

                // Sau khi thêm thành công, bạn có thể thông báo cho người dùng và làm sạch các TextBox nếu cần.
                MessageBox.Show("Thêm nhà cung cấp thành công!");
                lammoi_btn.PerformClick();

                loadDataNhaCC();
            }
        }
        private bool KiemTraTonTai(string maNhaCC, string tenNhaCC)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tblNhaCC WHERE iMaNCC = @maNhaCC OR sTenNCC = @tenNhaCC", cnn);
                cmd.Parameters.AddWithValue("@maNhaCC", maNhaCC);
                cmd.Parameters.AddWithValue("@tenNhaCC", tenNhaCC);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void sua_btn_Click(object sender, EventArgs e)
        {
            string maNhaCC = maNhaCC_tb.Text;
            string tenNhaCC = tenNhacc_tb.Text;
            string diaChi = diachi_tb.Text;
            string sdt = sdt_tb.Text;

            // Lấy mã nhà cung cấp từ hàng được chọn trong DataGridView
            int selectedIndex = nhacc_dtgv.CurrentCell.RowIndex;
            string maNhaCCSelected = nhacc_dtgv.Rows[selectedIndex].Cells[0].Value.ToString();


            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("update_NhaCC", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iMaNCC", maNhaCCSelected); // Sử dụng mã nhà cung cấp được chọn
                cmd.Parameters.AddWithValue("@sTenNCC", tenNhaCC);
                cmd.Parameters.AddWithValue("@sDiaChi", diaChi);
                cmd.Parameters.AddWithValue("@sSDT", sdt);
                cmd.ExecuteNonQuery();
            }

            // Sau khi cập nhật thành công, thông báo cho người dùng và làm mới dữ liệu trong DataGridView
            MessageBox.Show("Cập nhật thông tin nhà cung cấp thành công!");
            lammoi_btn.PerformClick();
            resetTb();
            loadDataNhaCC();
        }
        private void resetTb()
        {
            maNhaCC_tb.Text = "";
            tenNhacc_tb.Text = "";
            diachi_tb.Text = "";
            sdt_tb.Text = "";
        }

        private void nhacc_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                // Lấy thông tin của hàng được chọn
                DataGridViewRow row = nhacc_dtgv.Rows[e.RowIndex];

                // Hiển thị thông tin của hàng được chọn vào các TextBox tương ứng

                maNhaCC_tb.Text = row.Cells["iMaNCC"].Value.ToString();
                tenNhacc_tb.Text = row.Cells["sTenNCC"].Value.ToString();
                diachi_tb.Text = row.Cells["sDiaChi"].Value.ToString();
                sdt_tb.Text = row.Cells["sSDT"].Value.ToString();

                sua_btn.Enabled = true;
                xoa_btn.Enabled = true;
                them_btn.Enabled = false;
            }
        }

        private void xoa_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Lấy mã nhà cung cấp từ hàng được chọn trong DataGridView
                int selectedIndex = nhacc_dtgv.CurrentCell.RowIndex;
                string maNhaCC = nhacc_dtgv.Rows[selectedIndex].Cells["iMaNCC"].Value.ToString();

                // Thực hiện xóa dữ liệu của nhà cung cấp từ cơ sở dữ liệu
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("delete_NhaCC", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@iMaNCC", maNhaCC);
                    cmd.ExecuteNonQuery();
                }

                // Sau khi xóa thành công, thông báo cho người dùng và cập nhật lại DataGridView
                MessageBox.Show("Đã xóa nhà cung cấp thành công!");
                loadDataNhaCC();
            }
        }

        private void timkiem_btn_Click(object sender, EventArgs e)
        {
            string maNhaCC = maNhaCC_tb.Text;
            string tenNhaCC = tenNhacc_tb.Text;
            string diaChi = diachi_tb.Text;
            string sdt = sdt_tb.Text;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("search_NhaCC", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iMaNCC", "%" + maNhaCC + "%");
                cmd.Parameters.AddWithValue("@sTenNCC", "%" + tenNhaCC + "%");
                cmd.Parameters.AddWithValue("@sDiaChi", "%" + diaChi + "%");
                cmd.Parameters.AddWithValue("@sSDT", "%" + sdt + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Hiển thị kết quả tìm kiếm trong DataGridView
                nhacc_dtgv.DataSource = dt;
            }
        }

        private void maNhaCC_tb_Validated(object sender, EventArgs e)
        {
            string maNhaCC = maNhaCC_tb.Text;
            string tenNhaCC = tenNhacc_tb.Text;
            if (KiemTraTonTai(maNhaCC, tenNhaCC))
            {
                warn_lb.Text = "Mã hoặc Tên nhà cung cấp đã tồn tại!!!!!";
            }
        }

        private void maNhaCC_tb_Validating(object sender, CancelEventArgs e)
        {
            string maNhaCC = maNhaCC_tb.Text;
            string tenNhaCC = tenNhacc_tb.Text;
            if (KiemTraTonTai(maNhaCC, tenNhaCC))
            {
                warn_lb.Text = "Mã hoặc Tên nhà cung cấp đã tồn tại!!!!!";
            }
        }
        private void CheckTextBoxes()
        {
            if (!string.IsNullOrEmpty(maNhaCC_tb.Text) &&
                !string.IsNullOrEmpty(tenNhacc_tb.Text) &&
                !string.IsNullOrEmpty(diachi_tb.Text) &&
                !string.IsNullOrEmpty(sdt_tb.Text))
            {
                // Hiển thị nút thêm khi tất cả các TextBox đã được điền
                them_btn.Visible = true;
            }
            else
            {
                // Ẩn nút thêm nếu có ít nhất một TextBox rỗng
                them_btn.Visible = false;
            }
        }
    }
}
