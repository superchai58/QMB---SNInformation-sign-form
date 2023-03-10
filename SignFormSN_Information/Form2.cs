using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignFormSN_Information
{
    public partial class Form2 : Form
    {
        crReport oReports = new crReport();
        public Form2(crReport oReport)
        {
            InitializeComponent();
            oReports = new crReport();
            oReports = oReport;
        }

        private void Form2_Load(object sender, EventArgs e)
        {                       
            vwReport.ReportSource = oReports;            
            vwReport.Refresh();            
        }        
    }
}
