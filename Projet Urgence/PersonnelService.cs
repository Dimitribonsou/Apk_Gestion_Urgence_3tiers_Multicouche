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
    public partial class PersonnelService : Form
    {
        string nomService;
        userBLL usr = new userBLL();
        ServiceDAL   da = new ServiceDAL();
        public PersonnelService()
        {
            InitializeComponent();
        }
        public PersonnelService(string service)
        {
            InitializeComponent();
            this.nomService= service;
        }
     
        private void btnAnnnuler_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtQuartier.Text=string.Empty;
            txtTel.Text = string.Empty;

        }

        private void btnRetirer_Click(object sender, EventArgs e)
        {
            try
            {
                usr.nom = txtNom.Text;
                usr.prenom = txtPrenom.Text;

                usr.quartier = txtQuartier.Text;
                usr.email = txtEmail.Text;
                //usr.service = nomService;
                usr.telephone = txtTel.Text;
                usr.service = string.Empty;
                int id =Convert.ToInt32( dgvPersonnel.CurrentRow.Cells[0].Value);
                usr.id = id;
                da.Addpersonnel(usr);
                MessageBox.Show(" Personnel Retirer avec succes", "Retirer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPersonnel.DataSource = da.selectPersonnels();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                usr.nom = txtNom.Text;
                usr.prenom = txtPrenom.Text;
                usr.quartier = txtQuartier.Text;
                usr.email = txtEmail.Text;
                //usr.service = nomService;
                usr.telephone = txtTel.Text;
                usr.service = nomService;
                int id = da.GetIdByName(usr);
                usr.id = id;
                da.Addpersonnel(usr);
                MessageBox.Show(" Personnel Ajouter avec succes ","Ajout",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dgvPersonnel.DataSource = da.selectPersonnels();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void PersonnelService_Load(object sender, EventArgs e)
        {
            dgvPersonnel.DataSource = da.selectPersonnels();
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedItem.Equals("Nouveau Personnels"))
            {
                try
                {
                    //dgvPersonnel.Rows.Clear();
                    dgvPersonnel.DataSource = da.selectPersonnels();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message); 
                }
               
            }
            else
            {
                try
                {
                    //dgvPersonnel.Rows.Clear();
                    dgvPersonnel.DataSource = da.selectPersonnel(nomService);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message); 
                }
              
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSearch.SelectedIndex == -1)
                {
                    dgvPersonnel.DataSource = da.searchNewPersonnel(guna2TextBox1.Text);
                }
                else if (cmbSearch.SelectedItem.Equals("Personnels"))
                 {  
                    //dgvPersonnel.DataSource = da.searchNewPersonnel(guna2TextBox1.Text);
                     dgvPersonnel.DataSource = da.searchPersonnel(guna2TextBox1.Text, nomService);
                 }
                else 
                {

                    dgvPersonnel.DataSource = da.searchNewPersonnel(guna2TextBox1.Text);
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
          
          
        }

        private void dgvPersonnel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //nom,prenom,tel,email,quartier
            txtNom.Text = dgvPersonnel.CurrentRow.Cells[1].Value.ToString();
            txtPrenom.Text = dgvPersonnel.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text = dgvPersonnel.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvPersonnel.CurrentRow.Cells[4].Value.ToString();
            txtQuartier.Text = dgvPersonnel.CurrentRow.Cells[5].Value.ToString();
            txtPassword.Text = string.Empty;
        }

      
    }
}
