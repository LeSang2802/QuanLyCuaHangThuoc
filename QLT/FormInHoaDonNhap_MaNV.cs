using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FormInHoaDonNhap_MaNV : Form
    {

        string connectionString = ConfigurationManager
            .ConnectionStrings["QLBanThuoc"]
            .ConnectionString;
        public FormInHoaDonNhap_MaNV()
        {
            InitializeComponent();
        }

        public void hienDL(string MaNV)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LayHoaDonNhapTheoMaNV", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Add parameter
                    cmd.Parameters.AddWithValue("@MaNV", MaNV);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            adapter.Fill(dt);

                            ReportDocument report = new ReportDocument();
                            string path = string.Format("{0}\\HoaDonNhap_MaNV.rpt", Application.StartupPath);
                            report.Load(path);
                            report.Database.Tables["LayHoaDonNhapTheoMaNV"].SetDataSource(dt);

                            crystalReportViewer1.ReportSource = report;
                            crystalReportViewer1.Refresh();
                        }
                    }
                }
            }
        }
    }
}
