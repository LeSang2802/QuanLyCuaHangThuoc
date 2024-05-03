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
    public partial class HoaDonBan : Form
    {
        public HoaDonBan()
        {
            InitializeComponent();
        }

        private void HoaDonBan_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLBanThuoc"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblHoaDonBan", cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dgv_HDB.DataSource = dt;
                    }
                    dgv_HDB.Columns[0].HeaderText = "Mã hóa đơn";
                    dgv_HDB.Columns[1].HeaderText = "Mã nhân viên";
                    dgv_HDB.Columns[2].HeaderText = "Mã khách hàng";
                    dgv_HDB.Columns[3].HeaderText = "Ngày đặt";
                    dgv_HDB.Columns[4].HeaderText = "Ngày giao";
                    dgv_HDB.Columns[5].HeaderText = "Địa chỉ giao";

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
            if (mtb_MaKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtb_MaKH.Focus();
                return false;
            }
            if (dt_NgayDat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt_NgayDat.Focus();
                return false;
            }
            if (dt_NgayGiao.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày giao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt_NgayGiao.Focus();
                return false;
            }
            if (tb_DiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ giao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_DiaChi.Focus();
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
                            cmd.CommandText = "ThemHDB"; // Đảm bảo rằng đây là tên thủ tục lưu trữ đúng
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@iMaHD", mtb_MaHD.Text);
                            cmd.Parameters.AddWithValue("@MaNV", mtb_MaNV.Text);
                            cmd.Parameters.AddWithValue("@MaKH", mtb_MaKH.Text);
                            cmd.Parameters.AddWithValue("@NgayDat", dt_NgayDat.Value.Date);
                            cmd.Parameters.AddWithValue("@NgayGiao", dt_NgayGiao.Value.Date);
                            cmd.Parameters.AddWithValue("@DiaChiGiao", tb_DiaChi.Text);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            HoaDonBan_Load(sender, e);

                            MessageBox.Show("Thêm  hóa đơn bán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi thêm hóa đơn bán: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tb_Tim_Click(object sender, EventArgs e)
        {
            if (mtb_MaHD.Text != "")
            {
                string RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'",
                    "iMaHD", mtb_MaHD.Text.Trim());
                (dgv_HDB.DataSource as DataTable).DefaultView.RowFilter = RowFilter;

            }
            else
            {
                if (mtb_MaNV.Text != "")
                {
                    string RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'",
                        "iMaNV", mtb_MaNV.Text.Trim());
                    (dgv_HDB.DataSource as DataTable).DefaultView.RowFilter = RowFilter;

                }
                else
                {
                    if (mtb_MaKH.Text != "")
                    {
                        string RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'",
                            "iMaKH", mtb_MaHD.Text.Trim());
                        (dgv_HDB.DataSource as DataTable).DefaultView.RowFilter = RowFilter;

                    }
                    else
                    {
                        if (dt_NgayDat.Text != "")
                        {
                            string RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'",
                                 "dNgayDat", dt_NgayDat.Text.Trim());
                            (dgv_HDB.DataSource as DataTable).DefaultView.RowFilter = RowFilter;
                        }
                        else
                        {
                            if (dt_NgayGiao.Text != "")
                            {
                                string RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'",
                                     "dNgayDat", dt_NgayGiao.Text.Trim());
                                (dgv_HDB.DataSource as DataTable).DefaultView.RowFilter = RowFilter;
                            }
                            else
                            {
                                if (tb_DiaChi.Text != "")
                                {
                                    string RowFilter = string.Format("{0} like '{1}'", "sHoTen", "*" + tb_DiaChi.Text + "*");
                                    (dgv_HDB.DataSource as DataTable).DefaultView.RowFilter = RowFilter;
                                }
                            }
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
            mtb_MaHD.Text = "";
            mtb_MaNV.Text = "";
            mtb_MaKH.Text = "";
            dt_NgayDat.Text = "";
            dt_NgayGiao.Text = "";
            tb_DiaChi.Text = "";

            string constr = ConfigurationManager.ConnectionStrings["QLBanThuoc"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblHoaDonBan", cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dgv_HDB.DataSource = dt;
                    }
                    dgv_HDB.Columns[0].HeaderText = "Mã hóa đơn";
                    dgv_HDB.Columns[1].HeaderText = "Mã nhân viên";
                    dgv_HDB.Columns[2].HeaderText = "Mã khách hàng";
                    dgv_HDB.Columns[3].HeaderText = "Ngày đặt";
                    dgv_HDB.Columns[4].HeaderText = "Ngày giao";
                    dgv_HDB.Columns[5].HeaderText = "Địa chỉ giao";

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
                        cmd.CommandText = "XoaHDB";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHD", mtb_MaHD.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        HoaDonBan_Load(sender, e);

                        MessageBox.Show("Xóa hóa đơn bán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi xóa hóa đơn bán: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    using (SqlCommand cmd = new SqlCommand("SuaHDB", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Truyền các tham số cho thủ tục lưu trữ
                        cmd.Parameters.AddWithValue("@iMaHD", mtb_MaHD.Text);
                        cmd.Parameters.AddWithValue("@MaNV", mtb_MaNV.Text);
                        cmd.Parameters.AddWithValue("@MaKH", mtb_MaKH.Text);
                        cmd.Parameters.AddWithValue("@NgayDat", dt_NgayDat.Value.Date);
                        cmd.Parameters.AddWithValue("@NgayGiao", dt_NgayGiao.Value.Date);
                        cmd.Parameters.AddWithValue("@DiaChiGiao", tb_DiaChi.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        // Cập nhật lại dữ liệu trên DataGridView sau khi đã sửa
                        HoaDonBan_Load(sender, e);

                        MessageBox.Show("Sửa thông tin hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa thông tin hóa đơn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_HDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_HDB.CurrentRow.Index;
            mtb_MaHD.Text = dgv_HDB.Rows[i].Cells[0].Value.ToString();
            mtb_MaNV.Text = dgv_HDB.Rows[i].Cells[1].Value.ToString();
            mtb_MaKH.Text = dgv_HDB.Rows[i].Cells[2].Value.ToString();
            dt_NgayDat.Text = dgv_HDB.Rows[i].Cells[3].Value.ToString();
            dt_NgayGiao.Text = dgv_HDB.Rows[i].Cells[4].Value.ToString();
            tb_DiaChi.Text = dgv_HDB.Rows[i].Cells[5].Value.ToString();
        }
    }
}

