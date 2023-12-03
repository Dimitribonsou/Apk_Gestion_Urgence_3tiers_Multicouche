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
    public partial class RapportPersonnels : Form
    {
        ReportDocument rpt = new ReportDocument();
        ServiceDAL sa = new ServiceDAL();
        public RapportPersonnels()
        {
            InitializeComponent();
        }

        private void RapportPersonnels_Load(object sender, EventArgs e)
        {
            rpt.Load(@"D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\Projet Urgence\Reports\PersonnelReport.rpt");
            DataTable dt = sa.selectAllPersonnels();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
