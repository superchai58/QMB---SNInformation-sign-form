using Connect.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Threading;
using CrystalDecisions.CrystalReports.Engine;
using System.Globalization;
using CrystalDecisions.Shared;
using SignFormSN_Information;
using System.Web.UI.WebControls;

namespace SignFormSN_Information
{
    public partial class frmSnInformation : Form
    {
        ConnectDB oCon = new ConnectDB();
        DataSet ds = new DataSet();
        //string fileName = "";
        string strNameFile = "";
        crReport oReport = new crReport();

        public frmSnInformation()
        {
            InitializeComponent();
        }

        private void frmSnInformation_Load(object sender, EventArgs e)
        {
            if (!bgwLoad.IsBusy)
            {
                bgwLoad.RunWorkerAsync();
                pcbLoad.Visible = true;
            }                
        }

        private void txtscan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtscan.Text.Trim() != "")
            {
                if (!bgwScan.IsBusy)
                {
                    bgwScan.RunWorkerAsync();
                    pcbLoad.Visible = true;
                }
            }
        }

        private void bgwLoad_DoWork(object sendr, System.ComponentModel.DoWorkEventArgs e)
        {
            //--Select SMT_SP and SN_Trace Top 100 DESC--            
            ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXEC GetSMT_SPAndSN_Trace @serial";
            cmd.Parameters.Add(new SqlParameter("@serial", "ALL"));
            cmd.CommandTimeout = 180;
            try
            {
                ds = oCon.QueryDataSet(cmd);

                //DataSet dsReport = CreateDynamicDataSet(ds);
                ////ds.WriteXmlSchema(@"Dataset.xml");
                //dsReport.WriteXml(@"Dataset.xml");
            }
            catch (Exception ex)
            { }            
        }

        public DataSet CreateDynamicDataSet(DataSet ds)
        {
            //--SMT_SP--
            DataSet dsTmp = new DataSet();
            //dsTmp.Namespace = "ReportNamespace";
            DataTable smt_SPTable = new DataTable("Table");
            DataColumn col1 = new DataColumn("SerialNumber");
            DataColumn col2 = new DataColumn("workOrer");
            DataColumn col3 = new DataColumn("line");
            DataColumn col4 = new DataColumn("dateTime");
            smt_SPTable.Columns.Add(col1);
            smt_SPTable.Columns.Add(col2);
            smt_SPTable.Columns.Add(col3);
            smt_SPTable.Columns.Add(col4);

            dsTmp.Tables.Add(smt_SPTable);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    smt_SPTable.Rows.Add(row["SerialNumber"].ToString().Trim(), row["WorkOrder"].ToString().Trim(), row["MFGLine"].ToString().Trim(), row["TransDateTime"].ToString().Trim());
                }
            }

            //--SN_Trace--
            DataTable snTraceTable = new DataTable("Table1");
            DataColumn col11 = new DataColumn("SN");
            DataColumn col12 = new DataColumn("Station");
            DataColumn col13 = new DataColumn("Status");
            DataColumn col14 = new DataColumn("Transdatetime");
            snTraceTable.Columns.Add(col11);
            snTraceTable.Columns.Add(col12);
            snTraceTable.Columns.Add(col13);
            snTraceTable.Columns.Add(col14);

            dsTmp.Tables.Add(snTraceTable);
            if (ds.Tables[1].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[1].Rows)
                {
                    snTraceTable.Rows.Add(row["SN"].ToString().Trim(), row["Station"].ToString().Trim(), row["Status"].ToString().Trim(), row["Trans_DateTime"].ToString().Trim());
                }
            }
            dsTmp.AcceptChanges();            
            return dsTmp;
        }

        private void bgwLoad_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            pcbLoad.Visible = false;
            if (ds.Tables[0].Rows.Count > 0)
            {
                dgvSMT_SP.Rows.Clear();
                dgvSMT_SP.DataSource = ds.Tables[0];                
            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                dgvSN_Trace.Rows.Clear();
                dgvSN_Trace.DataSource = ds.Tables[1];
            }
            //--END Select SMT_SP and SN_Trace Top 100 DESC--             
        }

        private void bgwScan_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {                    
            SqlCommand cmd = new SqlCommand();            
            cmd.CommandText = "EXEC GetSMT_SPAndSN_Trace @serial";
            cmd.Parameters.Add(new SqlParameter("@serial", txtscan.Text.Trim()));
            cmd.CommandTimeout = 180;
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                ds = new DataSet();
                ds = oCon.QueryDataSet(cmd);

                //DataSet dsReport = CreateDynamicDataSet(ds);
                ////ds.WriteXmlSchema(@"Dataset.xml");
                //dsReport.WriteXml(@"Dataset.xml");

            }
            catch (Exception ex)
            { }
        }

        private void bgwScan_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            pcbLoad.Visible = false;
            if (ds.Tables[0].Rows.Count > 0)
            {
                dgvSMT_SP.DataSource = null;
                dgvSMT_SP.DataSource = ds.Tables[0];
            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                dgvSN_Trace.DataSource = null;
                dgvSN_Trace.DataSource = ds.Tables[1];
            }

            if (ds.Tables[0].Rows.Count == 0 && ds.Tables[1].Rows.Count == 0)
            {
                MessageBox.Show("Data SMT_SP and SN_Trace not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Data SMT_SP not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else if (ds.Tables[1].Rows.Count == 0)
            {
                MessageBox.Show("Data SN_Trace not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            //txtscan.Text = "";
            txtscan.Focus();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (!bgwExcel.IsBusy)
            {
                bgwExcel.RunWorkerAsync();
                pcbLoad.Visible = true;
            }

        }

        private void bgwExcel_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //--Create Folder--
            //CreateFileOrFolder();
            ExportExcel("REPORT-");
        }

        private void bgwExcel_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            pcbLoad.Visible = false;
            MessageBox.Show("Export success : " + strNameFile, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            dgvSMT_SP.DataSource = null;
            dgvSN_Trace.DataSource = null;
        }

        public void ExportExcel(string menuType)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;             
            // see the excel sheet behind the program  
            app.Visible = false;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "SMT_SP";
            // storing header part in Excel  
            for (int i = 1; i < dgvSMT_SP.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvSMT_SP.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgvSMT_SP.Rows.Count; i++)
            {
                for (int j = 0; j < dgvSMT_SP.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvSMT_SP.Rows[i].Cells[j].Value.ToString();
                }
            }

            workbook.Sheets.Add();
            Microsoft.Office.Interop.Excel._Worksheet worksheet2 = null;
            //Thread.Sleep(3000);

            worksheet2 = workbook.Sheets["Sheet2"];
            worksheet2 = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet2.Name = "SN_Trace";
            // storing header part in Excel  
            for (int i = 1; i < dgvSN_Trace.Columns.Count + 1; i++)
            {
                worksheet2.Cells[1, i] = dgvSN_Trace.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgvSN_Trace.Rows.Count; i++)
            {
                for (int j = 0; j < dgvSN_Trace.Columns.Count; j++)
                {
                    worksheet2.Cells[i + 2, j + 1] = dgvSN_Trace.Rows[i].Cells[j].Value.ToString();
                }
            }

            // save the application  
            strNameFile = "D:\\" + menuType + DateTime.Now.ToString("yyyyMMdd").Trim() + ".xlsx";            
            workbook.SaveAs(strNameFile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            workbook.Close(true, strNameFile, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        private void btnCrytalReport_Click(object sender, EventArgs e)
        {
            if (!bgwCreateSign.IsBusy)
            {
                bgwCreateSign.RunWorkerAsync();
                pcbLoad.Visible = true;
            }
        }

        private void bgwCreateSign_DoWork(object sender, DoWorkEventArgs e)
        {
            //--Set Datagridview to crytal report--            
            DataTable Table = new DataTable();
            Table.TableName = "Table";
            Table.Columns.Add("SerialNumber", typeof(string));
            Table.Columns.Add("workOrer", typeof(string));
            Table.Columns.Add("line", typeof(string));
            Table.Columns.Add("dateTime", typeof(string));

            DataTable Table1 = new DataTable();
            Table1.TableName = "Table1";
            Table1.Columns.Add("SN", typeof(string));
            Table1.Columns.Add("Station", typeof(string));
            Table1.Columns.Add("Status", typeof(string));
            Table1.Columns.Add("Transdatetime", typeof(string));            

            //--Loop datagridview to datateble--
            if (dgvSMT_SP.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSMT_SP.Rows)
                {
                    Table.Rows.Add(row.Cells["SerialNumber"].Value.ToString().Trim(),row.Cells["WorkOrder"].Value.ToString().Trim(), row.Cells["MFGLine"].Value.ToString().Trim(), row.Cells["TransDateTime"].Value.ToString().Trim());
                }
            }
            if (dgvSN_Trace.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSN_Trace.Rows)
                {
                    Table1.Rows.Add(row.Cells["SN"].Value.ToString().Trim(), row.Cells["Station"].Value.ToString().Trim(), row.Cells["Status"].Value.ToString().Trim(), row.Cells["Trans_DateTime"].Value.ToString().Trim());
                }
            }



            //--Report Sign--
            oReport = new crReport();
            //oDocument = new ReportDocument();
            string path = Application.StartupPath;
            path = path.Remove(path.Length - 10);

            oReport.Load(path + "//crReport.rpt");
            DataSet ds = new DataSet();
            ds.Tables.Add(Table);
            ds.Tables.Add(Table1);
            oReport.SetDataSource(ds);            

            //fileName = DateTime.Now.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            //fileName = @"D:\Report_SNInformation" + fileName + ".pdf";
            //oDocument.ExportToDisk(ExportFormatType.PortableDocFormat, fileName);
            //--END Report Sign--
        }

        private void bgwCreateSign_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pcbLoad.Visible = false;
            Form2 oFrom = new Form2(oReport);
            oFrom.ShowDialog();
            //MessageBox.Show("Exported Successful | Path: " + fileName);
        }
    }
}
