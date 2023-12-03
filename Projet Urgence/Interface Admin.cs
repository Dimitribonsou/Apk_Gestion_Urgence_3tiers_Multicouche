using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Interface_Admin : Form
    {
        Form currentFrom;
        public Interface_Admin()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Interface_Admin_Load(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToShortDateString();
            AcceuilAdmin ac =new AcceuilAdmin();
            OuvrirFormulaire(ac);
        }
        private void OuvrirFormulaire(Form child)
        {
            try
            {
                if (panelContainer.Controls != null)
                {
                    panelContainer.Controls.Clear();
                }
                currentFrom = child;
                currentFrom.TopLevel = false;
                currentFrom.Dock = DockStyle.Fill;
                currentFrom.FormBorderStyle = FormBorderStyle.None;
                this.panelContainer.Controls.Add(currentFrom);
                currentFrom.Show();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }

        }
        private void iconButton5_Click(object sender, EventArgs e)
        {
            FormConnexionPersonnel fp = new FormConnexionPersonnel();
            fp.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHeure.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            lbPage.Text = "SERVICES";
            OuvrirFormulaire(new Service());
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            lbPage.Text = "PERSONNELS";
            OuvrirFormulaire(new Personnel());
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            lbPage.Text = "PERSONNELS";
            OuvrirFormulaire(new Information());
        }

        private void btnHistorique_Click(object sender, EventArgs e)
        {
            lbPage.Text = "HISTORIQUE";
           
        }

        private void btnAide_Click(object sender, EventArgs e)
        {
            lbPage.Text = "AIDE";
            OuvrirFormulaire(new Aide());
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            AcceuilAdmin ad = new AcceuilAdmin();
            OuvrirFormulaire(ad);
           
        }

        private void btnApropos_Click(object sender, EventArgs e)
        {
            Apropos ap = new Apropos();
            OuvrirFormulaire(ap);
        }

        private void btnRapport_Click(object sender, EventArgs e)
        {
            panelMenu2.Visible = true;
            panelDocumentation.Visible = false;
        }

        private void btnDocumentation_Click(object sender, EventArgs e)
        {
            panelDocumentation.Visible = true;
            panelMenu2.Visible = false;
        }

        private void btnShowPersonnels_Click(object sender, EventArgs e)
        {
            ReportsForms.RapportPersonnels rp = new ReportsForms.RapportPersonnels();
            OuvrirFormulaire(rp);
        }

        private void btnShowService_Click(object sender, EventArgs e)
        {
            ReportsForms.RapportServices rp = new ReportsForms.RapportServices();
            OuvrirFormulaire(rp);
        }

        private void btnShowPleinte_Click(object sender, EventArgs e)
        {
            ReportsForms.RapportAlerte alt = new ReportsForms.RapportAlerte();
            OuvrirFormulaire(alt);
        }

        private void btnShowService_Click_1(object sender, EventArgs e)
        {
            ReportsForms.RapportServices rp = new ReportsForms.RapportServices();
            OuvrirFormulaire(rp);
        }

      

    }
}
