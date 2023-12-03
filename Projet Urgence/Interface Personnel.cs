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
    public partial class FormPersonnel : Form
    {
        Form currentFrom= new Form();
        private string username, userpassword;
        public FormPersonnel()
        {
            InitializeComponent();
        }
        public FormPersonnel(string nom,string mdp)
        {
            InitializeComponent();
            this.username = nom;
            this.userpassword = mdp;
        }
        //methode pour charger le contenu des formulaires dans le formulaire d'acceuil
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Probleme PB = new Probleme(this.username,this.userpassword);
            lbPage.Text = "PROBLEME";
            OuvrirFormulaire(PB);
            //PB.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            lbPage.Text = "INFORMATION";
            OuvrirFormulaire(new Information());
        }

        private void btnApropos_Click(object sender, EventArgs e)
        {
            lbPage.Text = "A PROPOS";
            OuvrirFormulaire(new Apropos());
        }

        private void btnAide_Click(object sender, EventArgs e)
        {
            lbPage.Text = "AIDE";
            OuvrirFormulaire(new Aide());
        }

        private void FormPersonnel_Load(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
            AcceuilPersonnel ac = new AcceuilPersonnel();
            OuvrirFormulaire(ac);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHeure.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            FormConnexionPersonnel fp = new FormConnexionPersonnel();
            fp.Show();
            this.Hide();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            AcceuilPersonnel ac = new AcceuilPersonnel();
            OuvrirFormulaire(ac);
        }
    }
}
