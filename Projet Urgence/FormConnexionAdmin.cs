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
    public partial class FormConnexionAdmin : Form
    {
        string nompersonnel;
        public FormConnexionAdmin()
        {
            InitializeComponent();
        }
        public FormConnexionAdmin(string nom)
        {
            InitializeComponent();
            this.nompersonnel = nom;
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

        private void linklbService_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormConnexionService fs = new FormConnexionService();
            fs.Show();
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
                bool verify = da.connexionAdmin(usr.nom, usr.password);
                //MessageBox.Show(nomService);
                if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Tous les champs ne sont pas correctement remplie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verify)
                {
                    MessageBox.Show("Connection reussie", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Interface_Admin ia = new Interface_Admin();
                    ia.Show();
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

        private void FormConnexionAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
