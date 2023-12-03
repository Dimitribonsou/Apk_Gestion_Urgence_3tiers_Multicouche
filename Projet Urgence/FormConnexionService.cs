using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BLL;
using DAL;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormConnexionService: Form
    {
        public FormConnexionService()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = " Masquer le mot de passe";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                checkBox1.Text = " Afficher le mot de passe";
                txtPassword.PasswordChar = '*';
            }
        }

        private void linklbPersonnel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormConnexionPersonnel fp = new FormConnexionPersonnel();
            fp.Show();
            this.Hide();
        }

        private void linklbAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormConnexionAdmin fa = new FormConnexionAdmin();
            fa.Show();
            this.Hide();
        }

        private void linklbNewCompte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FromCreerCompte fc = new FromCreerCompte();
            fc.Show();
            this.Hide();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                userDAL da = new userDAL();
                userBLL usr = new userBLL();
                usr.nom = txtNom.Text;
                usr.password = txtPassword.Text;
                string nomService = da.connexionService(usr);
                //MessageBox.Show(nomService);
                if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Tous les champs ne sont pas correctement remplie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (nomService != "echec")
                {
                    MessageBox.Show("Connection reussie", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Interface_Service sv = new Interface_Service(nomService);
                    sv.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas le droit d'acceder a cette partie du system", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNom.Text = txtPassword.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); 
            }
      
        }

        private void FormConnexionService_Load(object sender, EventArgs e)
        {

        }
    }
}
