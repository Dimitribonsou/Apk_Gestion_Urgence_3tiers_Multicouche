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
    public partial class Interface_Service : Form
    {
        Form currentFrom = new Form();
        string nomService;
        public Interface_Service()
        {
            InitializeComponent();
            lbDate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
        }
        public Interface_Service( string service)
        {
            InitializeComponent();
            this.nomService = service;
            lbNomService.Text = nomService.ToUpper();
            lbDate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnDeconnect_Click(object sender, EventArgs e)
        {
            FormConnexionPersonnel fc = new FormConnexionPersonnel();
            fc.Show();
            this.Hide();
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            lbPage.Text = "PERSONNELS";
            OuvrirFormulaire(new PersonnelService(nomService));
        }

        private void btnPleinte_Click(object sender, EventArgs e)
        {
            lbPage.Text = "PLEINTES";
            OuvrirFormulaire(new Probleme(nomService));
        }

        private void btnPublication_Click(object sender, EventArgs e)
        {
            lbPage.Text = "PUBLICATIONS";
            OuvrirFormulaire(new Publication(nomService));
        }

        private void btnPlanification_Click(object sender, EventArgs e)
        {
            lbPage.Text = "PLANIFICATIONS";
            OuvrirFormulaire(new Planification(nomService));
        }

        private void btnAide_Click(object sender, EventArgs e)
        {
            lbPage.Text = "AIDE";
            OuvrirFormulaire(new Aide());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHeure.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            AcceuilService ac = new AcceuilService(nomService);
            OuvrirFormulaire(ac);
        }

        private void Interface_Service_Load(object sender, EventArgs e)
        {
            AcceuilService ac = new AcceuilService(nomService);
            OuvrirFormulaire(ac);
        }

        private void btnApropos_Click(object sender, EventArgs e)
        {
            Apropos ap = new Apropos();
            OuvrirFormulaire(ap);
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            lbPage.Text = "INFORMATIONS";
            OuvrirFormulaire(new Information());
        }

    }
}
