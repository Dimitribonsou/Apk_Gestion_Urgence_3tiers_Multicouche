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
    public partial class RapportServices : Form
    {
        ReportDocument rpt = new ReportDocument();
        ServiceDAL sa = new ServiceDAL();
        public RapportServices()
        {
            InitializeComponent();
        }

        private void RapportServices_Load(object sender, EventArgs e)
        {
            rpt.Load(@"D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\Projet Urgence\Reports\ServiceReport.rpt");
            DataTable dt = sa.selectAllService();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
