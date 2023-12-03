using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using BLL;
using DAL;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormConnexionPersonnel : Form
    {
        public FormConnexionPersonnel()
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormConnexionService fs = new FormConnexionService();
            fs.Show();
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
                if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Tous les champs ne sont pas correctement remplie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (da.connexionPersonnel(usr))
                {
                    MessageBox.Show("Connection reussit", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormPersonnel fp = new FormPersonnel(txtNom.Text, txtPassword.Text);
                    fp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou Mot de passe Incorrect", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNom.Text = txtPassword.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); 
            }
        

        }
    }
}
