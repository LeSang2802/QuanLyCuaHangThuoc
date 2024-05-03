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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLBanThuoc"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblKhachHang", cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dgv_KhachHang.DataSource = dt;
                    }
                    dgv_KhachHang.Columns[0].HeaderText = "Mã khách hàng";
                    dgv_KhachHang.Columns[1].HeaderText = "Họ tên";
                    dgv_KhachHang.Columns[2].HeaderText = "SĐT";
                    dgv_KhachHang.Columns[3].HeaderText = "Địa chỉ";
                    

                }
            }
        }
        private bool kiemtra()
        {
            if (mtb_MaKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtb_MaKH.Focus();
                return false;
            }
            if (tb_HoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_HoTen.Focus();
                return false;
            }
            if (tb_DiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_DiaChi.Focus();
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
                            cmd.CommandText = "ThemKhachHang"; // Đảm bảo rằng đây là tên thủ tục lưu trữ đúng
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaKH", mtb_MaKH.Text);
                            cmd.Parameters.AddWithValue("@HoTen", tb_HoTen.Text);
                            cmd.Parameters.AddWithValue("@DienThoai", mtb_sdt.Text);
                            cmd.Parameters.AddWithValue("@DiaChi", tb_DiaChi.Text);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            KhachHang_Load(sender, e);

                            MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tb_Tim_Click(object sender, EventArgs e)
        {
            if (mtb_MaKH.Text != "")
            {
                string RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'",
                    "iMaKH", mtb_MaKH.Text.Trim());
                (dgv_KhachHang.DataSource as DataTable).DefaultView.RowFilter = RowFilter;

            }
            else
            {
                if (tb_HoTen.Text != "")
                {
                    string RowFilter = string.Format("{0} like '{1}'", "sHoTen", "*" + tb_HoTen.Text + "*");
                    (dgv_KhachHang.DataSource as DataTable).DefaultView.RowFilter = RowFilter;
                }
                //else
                //{
                //    if (tb_DiaChi.Text != "")
                //    {
                //        string RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'",
                //             "sDiaChi", tb_DiaChi.Text.Trim());
                //        (dgv_KhachHang.DataSource as DataTable).DefaultView.RowFilter = RowFilter;
                //    }
                //}
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_TiepTuc_Click(object sender, EventArgs e)
        {
            mtb_MaKH.Text = "";
            tb_HoTen.Text = "";
            tb_DiaChi.Text = "";
            mtb_sdt.Text = "";

            //string constr = ConfigurationManager.ConnectionStrings["QLBanThuoc"].ConnectionString;
            //using (SqlConnection cnn = new SqlConnection(constr))
            //{
            //    using (SqlCommand cmd = new SqlCommand("select * from tblKhachHang", cnn))
            //    {
            //        cnn.Open();
            //        using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
            //        {
            //            DataTable dt = new DataTable();
            //            adt.Fill(dt);
            //            dgv_KhachHang.DataSource = dt;
            //        }
            //        dgv_KhachHang.Columns[0].HeaderText = "Mã khách hàng";
            //        dgv_KhachHang.Columns[1].HeaderText = "Họ tên";
            //        dgv_KhachHang.Columns[2].HeaderText = "SĐT";
            //        dgv_KhachHang.Columns[3].HeaderText = "Địa chỉ";

            //    }
            //}
            KhachHang_Load(sender, e);
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (mtb_MaKH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Khách hàng cần Xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        cmd.CommandText = "XoaKhachHang";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaKH", mtb_MaKH.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        KhachHang_Load(sender, e);

                        MessageBox.Show("Xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            if (mtb_MaKH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string constr = ConfigurationManager.ConnectionStrings["QLBanThuoc"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SuaKhachHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Truyền các tham số cho thủ tục lưu trữ
                        cmd.Parameters.AddWithValue("@MaKH", mtb_MaKH.Text);
                        cmd.Parameters.AddWithValue("@HoTen", tb_HoTen.Text);
                        cmd.Parameters.AddWithValue("@DienThoai", mtb_sdt.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", tb_DiaChi.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        // Cập nhật lại dữ liệu trên DataGridView sau khi đã sửa
                        KhachHang_Load(sender, e);

                        MessageBox.Show("Sửa thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa thông tin khách hàng: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_KhachHang.CurrentRow.Index;
            mtb_MaKH.Text = dgv_KhachHang.Rows[i].Cells[0].Value.ToString();
            tb_HoTen.Text = dgv_KhachHang.Rows[i].Cells[1].Value.ToString();
            mtb_sdt.Text = dgv_KhachHang.Rows[i].Cells[2].Value.ToString();
            tb_DiaChi.Text = dgv_KhachHang.Rows[i].Cells[3].Value.ToString();
            
        }
    }
}


