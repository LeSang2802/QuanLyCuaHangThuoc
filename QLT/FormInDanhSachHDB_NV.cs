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
    public partial class FormInDanhSachHDB_NV : Form
    {

        string connectionString = ConfigurationManager
            .ConnectionStrings["QLBanThuoc"]
            .ConnectionString;
        public FormInDanhSachHDB_NV()
        {
            InitializeComponent();
        }

        public void showReport()
        {
            try
            {
                string query = "DanhsachHDB_NV";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    //conn.ConnectionString = connectionString;
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        ReportDocument report = new ReportDocument();
                        string path = string.Format("{0}\\DanhSachHDB_NV.rpt", Application.StartupPath);
                        report.Load(path);

                        report.Database.Tables["DanhsachHDB_NV"].SetDataSource(dt);


                        crystalReportViewer1.ReportSource = report;
                        crystalReportViewer1.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
