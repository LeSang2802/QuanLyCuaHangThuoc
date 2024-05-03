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
    public partial class Chitiethoadonban : Form
    {
        private List<string> selectedItems = new List<string>();
        private string connectionString = ConfigurationManager
                                     .ConnectionStrings["QLBanThuoc"]
                                     .ConnectionString;
        public Chitiethoadonban()
        {
            InitializeComponent();
        }

        private void thoat_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FillComboBoxMa()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT iMaHD FROM tblChiTietHoaDonBan"; // Thay đổi "Name" và "MyTable" cho phù hợp với cơ sở dữ liệu của bạn
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Đọc dữ liệu từ cột "Name" và thêm vào ComboBox
                    int maHD = reader.GetInt32(0);
                    maHD_cb.Items.Add(maHD);
                }

                connection.Close();
            }
        }

        private void FillComboBoxSp()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT sTenSP FROM tblSanPham"; // Thay đổi "Name" và "MyTable" cho phù hợp với cơ sở dữ liệu của bạn
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Đọc dữ liệu từ cột "Name" và thêm vào ComboBox
                    string name = reader.GetString(0);
                    sanpham_cb.Items.Add(name);
                }

                connection.Close();
            }
        }

        private void sanpham_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = sanpham_cb.SelectedItem.ToString();

            // Thực hiện truy vấn SQL để lấy thuộc tính tương ứng từ cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT fGiaHang FROM tblSanPham WHERE sTenSP = @Name"; // Thay đổi "OtherColumn" và "MyTable" cho phù hợp với cấu trúc của bảng của bạn
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", selectedName);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Hiển thị giá trị của cột "OtherColumn" trong TextBox
                    double gia = reader.GetDouble(0); // Sử dụng GetDouble nếu kiểu dữ liệu của cột là double
                    gia_tb.Text = gia.ToString();
                }

                connection.Close();
            }
        }

        private void Chitiethoadonban_Load(object sender, EventArgs e)
        {
            loadData();
            FillComboBoxMa();
            FillComboBoxSp();
        }

        private void lammoi_btn_Click(object sender, EventArgs e)
        {
            maHD_cb.Text = "";
            sanpham_cb.Text = "";
            gia_tb.Text = "";
            solg_tb.Text = "";
            loadData();
        }

        private void timKiem_btn_Click(object sender, EventArgs e)
        {
            string maHD = maHD_cb.SelectedItem != null ? maHD_cb.SelectedItem.ToString() : null;
            string sp = sanpham_cb.SelectedItem != null ? sanpham_cb.SelectedItem.ToString() : null;

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("search_ChiTietHDBan", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iMaHD", maHD);
                cmd.Parameters.AddWithValue("@sTenSP", sp);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Hiển thị kết quả tìm kiếm trong DataGridView
                HDBan_gv.DataSource = dt;
            }
        }
        private void loadData()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("select_ChiTietHDBan", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                HDBan_gv.DataSource = dt;


            }
        }
    }
}
