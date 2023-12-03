using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DAL;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ReportsForms
{
    public partial class RapportAlerte : Form
    {
        ReportDocument rpt = new ReportDocument();
        ProblemeDAL pb = new ProblemeDAL();
        public RapportAlerte()
        {
            InitializeComponent();
        }

        private void RapportAlerte_Load(object sender, EventArgs e)
        {
            rpt.Load(@"D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\Projet Urgence\Reports\AlerteReport.rpt");
            DataTable dt = pb.selectAllProbleme();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;

        }
    }
}
