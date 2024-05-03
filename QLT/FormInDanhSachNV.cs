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
    public partial class FormInDanhSachNV : Form
    {

        string connectionString = ConfigurationManager
            .ConnectionStrings["QLBanThuoc"]
            .ConnectionString;
        public FormInDanhSachNV()
        {
            InitializeComponent();
        }

        public void ShowReport(string reportFilter)
        {
            try
            {
                string query = "Select_All_NV";
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
                        string path = string.Format("{0}\\DanhSachNV.rpt", Application.StartupPath);
                        report.Load(path);

                        report.Database.Tables["Select_All_NV"].SetDataSource(dt);
                        report.SetParameterValue("NguoiLapBieu", "Le Van Sang");


                        if (reportFilter != null)
                        {
                            report.RecordSelectionFormula = reportFilter;
                        }
                        


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
