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
    public partial class SanPham : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLBanThuoc"].ConnectionString;
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private object selectedRow;

        public SanPham()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("sp_HienThiSanPham", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dGV_danhsach.DataSource = dataTable;
            }
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ThemSanPham(string maSP, string tenSP, string tenNCC, int soLuong, float giaHang)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_ThemSanPham", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@sMaSP", maSP);
                    cmd.Parameters.AddWithValue("@sTenSP", tenSP);
                    cmd.Parameters.AddWithValue("@sTenNCC", tenNCC);
                    cmd.Parameters.AddWithValue("@iSoLuong", soLuong);
                    cmd.Parameters.AddWithValue("@fGiaHang", giaHang);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sản phẩm thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            string maSP = tb_Masp.Text;
            string tenSP = tb_Tensp.Text;
            string tenNCC = tb_TenNCC.Text;
            int soLuong = int.Parse(tb_Solg.Text);
            float giaHang = float.Parse(tb_Giahang.Text);

            ThemSanPham(maSP, tenSP, tenNCC, soLuong, giaHang);
            LoadData();
        }

        private void bt_Lammoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void XoaSanPham(string maSP)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_XoaSanPham", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@sMaSP", maSP);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công");
                        LoadData(); // Làm mới danh sách sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm để xóa");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dGV_danhsach.SelectedRows.Count > 0)
            {
                // Lấy mã sản phẩm từ cột đầu tiên của dòng đang chọn
                string maSP = dGV_danhsach.SelectedRows[0].Cells[0].Value.ToString();
                XoaSanPham(maSP);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa");
            }
        }
        private void SuaSanPham(string maSP, string tenSP, string tenNCC, int? soLuong, float? giaHang)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_SuaSanPham", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@sMaSP", maSP);
                    cmd.Parameters.AddWithValue("@sTenSP", tenSP);

                    // Kiểm tra xem có nhập số lượng mới không
                    if (soLuong.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@iSoLuong", soLuong);
                    }
                    else
                    {
                        // Lấy số lượng cũ từ cột "Số lượng" của dòng đang chọn
                        int oldSoLuong = Convert.ToInt32(dGV_danhsach.SelectedRows[0].Cells["Số lượng"].Value);
                        cmd.Parameters.AddWithValue("@iSoLuong", oldSoLuong);
                    }

                    // Kiểm tra xem có nhập giá mới không
                    if (giaHang.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@fGiaHang", giaHang);
                    }
                    else
                    {
                        // Lấy giá cũ từ cột "Giá hàng" của dòng đang chọn
                        float oldGiaHang = Convert.ToSingle(dGV_danhsach.SelectedRows[0].Cells["Giá hàng"].Value);
                        cmd.Parameters.AddWithValue("@fGiaHang", oldGiaHang);
                    }

                    // Kiểm tra xem có nhập tên nhà cung cấp mới không
                    if (string.IsNullOrEmpty(tenNCC))
                    {
                        // Lấy tên nhà cung cấp cũ từ cột "Tên nhà cung cấp" của dòng đang chọn
                        tenNCC = dGV_danhsach.SelectedRows[0].Cells["Tên nhà cung cấp"].Value.ToString();
                    }
                    cmd.Parameters.AddWithValue("@sTenNCC", tenNCC); // Sử dụng tên nhà cung cấp cũ hoặc mới

                    // Nếu có nhập tên nhà cung cấp mới, sẽ thực hiện thêm mã nhà cung cấp vào tham số @iMaNCC
                    if (!string.IsNullOrEmpty(tenNCC))
                    {
                        // Lấy mã nhà cung cấp từ tên nhà cung cấp
                        int maNCC;
                        using (SqlCommand cmdMaNCC = new SqlCommand("SELECT iMaNCC FROM tblNhaCC WHERE sTenNCC = @sTenNCC", conn))
                        {
                            cmdMaNCC.Parameters.AddWithValue("@sTenNCC", tenNCC);
                            maNCC = (int)cmdMaNCC.ExecuteScalar();
                        }
                        cmd.Parameters.AddWithValue("@iMaNCC", maNCC);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sửa sản phẩm thành công");
                        LoadData(); // Làm mới danh sách sau khi sửa
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm để sửa");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dGV_danhsach.SelectedRows.Count > 0)
            {
                // Lấy mã sản phẩm từ cột đầu tiên của dòng đang chọn
                string maSP = dGV_danhsach.SelectedRows[0].Cells[0].Value.ToString();

                // Lấy thông tin nhập vào từ các ô
                string tenSP = tb_Tensp.Text;
                string tenNCC = tb_TenNCC.Text;
                int? soLuong = null;
                float? giaHang = null;

                // Nếu có nhập số lượng, kiểm tra và chuyển đổi thành số nguyên
                int.TryParse(tb_Solg.Text, out int sl);
                if (sl != 0)
                {
                    soLuong = sl;
                }

                // Nếu có nhập giá hàng, kiểm tra và chuyển đổi thành số thực
                float.TryParse(tb_Giahang.Text, out float gh);
                if (gh != 0)
                {
                    giaHang = gh;
                }

                // Gọi phương thức sửa sản phẩm
                SuaSanPham(maSP, tenSP, tenNCC, soLuong, giaHang);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa");
            }
        }
        private void TimKiemSanPham(string maSP = null, string tenSP = null, string tenNCC = null, int? soLuong = null, float? giaHang = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_TimKiemSanPham", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho stored procedure
                    cmd.Parameters.AddWithValue("@MaSP", (object)maSP ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@TenSP", (object)tenSP ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@TenNCC", (object)tenNCC ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong.HasValue ? (object)soLuong.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@GiaHang", giaHang.HasValue ? (object)giaHang.Value : DBNull.Value);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dGV_danhsach.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void bt_Timkiem_Click(object sender, EventArgs e)
        {
            string maSP = tb_Masp.Text.Trim();
            string tenSP = tb_Tensp.Text.Trim();
            string tenNCC = tb_TenNCC.Text.Trim();
            string soLuong = tb_Solg.Text.Trim();
            string giaHang = tb_Giahang.Text.Trim();

            // Gọi phương thức tìm kiếm sản phẩm với các tham số tương ứng
            TimKiemSanPham(maSP, tenSP, tenNCC, !string.IsNullOrEmpty(soLuong) ? int.Parse(soLuong) : (int?)null,
                           !string.IsNullOrEmpty(giaHang) ? float.Parse(giaHang) : (float?)null);
        }

        private void dGV_danhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dGV_danhsach.Rows[e.RowIndex];


                tb_Masp.Text = row.Cells["Mã sản phẩm"].Value.ToString();
                tb_Tensp.Text = row.Cells["Tên sán phẩm "].Value.ToString();
                tb_TenNCC.Text = row.Cells["Tên nhà cung cấp"].Value.ToString();
                tb_Solg.Text = row.Cells["Số lượng"].Value.ToString();
                tb_Giahang.Text = row.Cells["Giá hàng"].Value.ToString();

            }
        }
    }
}
