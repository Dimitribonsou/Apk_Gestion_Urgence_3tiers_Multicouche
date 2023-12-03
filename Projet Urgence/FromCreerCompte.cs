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
    public partial class FromCreerCompte : Form
    {
        public FromCreerCompte()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            userBLL usr = new userBLL();
            userDAL usd = new userDAL();
            usr.nom = txtNom.Text;
            usr.prenom = txtPrenom.Text;
            usr.email = txtEmail.Text;
            usr.quartier = txtQuartier.Text;
            usr.telephone = txtTel.Text;
            usr.password = txtPassword.Text;
               bool verify= usd.userexiste(usr.nom);
               if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtPrenom.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text)
                   || string.IsNullOrEmpty(txtTel.Text) || string.IsNullOrEmpty(txtQuartier.Text))
               {
                   MessageBox.Show("Vous avez l'obligation de remplir tout les Champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               else if (verify)
               {
                   MessageBox.Show("Desole un Compte existe deja avec le  nom  "+txtNom.Text, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               else
               {
                   usd.userinsert(usr);
                   MessageBox.Show("Compte creer avec succes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   FormConnexionPersonnel fc = new FormConnexionPersonnel();
                   fc.Show();
                   this.Hide();
               }
            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtQuartier.Text = string.Empty;
            txtTel.Text = string.Empty;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormConnexionPersonnel fp = new FormConnexionPersonnel();
            fp.Show();
            this.Hide();
        }
    }
}
