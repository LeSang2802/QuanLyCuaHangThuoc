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
    public partial class Chitiethoadonnhap : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLBanThuoc"].ConnectionString;
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private object selectedRow;
        public Chitiethoadonnhap()
        {
            InitializeComponent();
        }

        private void Chitiethoadonnhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("cthdn_Hienthi", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dGv_ChitiethhdNhap.DataSource = dataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGv_ChitiethhdNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dGv_ChitiethhdNhap.Rows[e.RowIndex];

                tb_MaHD.Text = row.Cells["Mã hóa đơn "].Value.ToString();
                tb_MaSp.Text = row.Cells["Mã sản phẩm "].Value.ToString();
                tb_Dongia.Text = row.Cells["Giá nhập"].Value.ToString();
                tb_Solg.Text = row.Cells["Số lượng"].Value.ToString();

            }
        }
    }
}
