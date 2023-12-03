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
    public partial class Personnel : Form
    {
        ServiceBLL sv = new ServiceBLL();
        ServiceDAL svd = new ServiceDAL();
        userBLL usrBLL = new userBLL();
        userDAL usrDAL = new userDAL();
        public Personnel()
        {
            InitializeComponent();
            LoadData();
        }

        private void Personnel_Load(object sender, EventArgs e)
        {
            DataTable dt = svd.selectNameServices();
            foreach (DataRow item in dt.Rows)
            {
                cmbService.Items.Add(item[0]);
            }


        }
        private void LoadData()
        {
            dgvPersonnel.DataSource =svd.selectAllPersonnels();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                usrBLL.id = Convert.ToInt32(dgvPersonnel.CurrentRow.Cells[0].Value);
                usrBLL.nom = txtNom.Text;
                usrBLL.prenom = txtPrenom.Text;
                usrBLL.password = txtPassword.Text;
                usrBLL.email = txtEmail.Text;
                usrBLL.telephone = txtTel.Text;
                usrBLL.role = Convert.ToInt32(cmbRole.SelectedItem);
                if (cmbService.SelectedIndex != -1)
                {
                    usrBLL.service = cmbService.SelectedItem.ToString();
                }
                else
                {
                    usrBLL.service = string.Empty;
                }
                usrBLL.quartier = txtQuartier.Text;

                if (string.IsNullOrEmpty(cmbRole.SelectedItem.ToString()) || string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtTel.Text))
                {
                    MessageBox.Show("Erreur vous avez laissez vide un champ obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    usrDAL.UpdateUserAdmin(usrBLL);
                    MessageBox.Show("Personnel Modifier  avec succes", " Modification Personnel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadData();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //usrBLL.id =Convert.ToInt32( dgvPersonnel.CurrentRow.Cells[0].Value);
                usrBLL.nom = txtNom.Text;
                usrBLL.prenom = txtPrenom.Text;
                usrBLL.password = txtPassword.Text;
                usrBLL.email = txtEmail.Text;
                usrBLL.telephone = txtTel.Text;
                usrBLL.role = Convert.ToInt32(cmbRole.SelectedItem);
                if (cmbService.SelectedIndex != -1)
                {
                    usrBLL.service = cmbService.SelectedItem.ToString();
                }
                else
                {
                    usrBLL.service = string.Empty;
                }
                usrBLL.quartier = txtQuartier.Text;
                if (string.IsNullOrEmpty(cmbRole.SelectedItem.ToString()) || string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtTel.Text))
                {
                    MessageBox.Show("Erreur vous avez laissez vide un champ obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (usrDAL.userexiste(usrBLL.nom))
                {
                    MessageBox.Show("Désole se Personnel à déja été Creer ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    usrDAL.userinsertAdmin(usrBLL);
                    MessageBox.Show("Personnel Ajouter  avec succes"," Ajout Personnel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadData();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                usrBLL.id = Convert.ToInt32(dgvPersonnel.CurrentRow.Cells[0].Value);
                usrBLL.nom = txtNom.Text;
                usrBLL.id = Convert.ToInt32(dgvPersonnel.CurrentRow.Cells[0].Value);
                if (string.IsNullOrEmpty(txtNom.Text) )
                {
                    MessageBox.Show("Veuillez selectionner la ligne a Supprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    usrDAL.deleteUser(usrBLL);
                    MessageBox.Show("Personnel Supprimer avec succes", "Suppression Personnel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadData();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }
        private void ClearForm()
        {
            txtNom.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtQuartier.Text = string.Empty;
            txtTel.Text=string.Empty;
            cmbRole.SelectedIndex = 0;
            cmbService.SelectedIndex = -1;
        }
        private void dgvPersonnel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvPersonnel_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //id_perso,nom,prenom,tel,email,quartier
            DataTable dt = usrDAL.RemplirtxtPersonnel(txtNom.Text);
            foreach (DataRow item in dt.Rows)
            {
                txtPassword.Text = item["mdp"].ToString();
                cmbRole.SelectedItem = item["role"].ToString();
                cmbService.SelectedItem = item["Service"].ToString();
            }
            txtNom.Text = dgvPersonnel.CurrentRow.Cells[1].Value.ToString();
            txtPrenom.Text = dgvPersonnel.CurrentRow.Cells[2].Value.ToString();
            //txtPassword.Text = dgvPersonnel.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = dgvPersonnel.CurrentRow.Cells[3].Value.ToString();
           //cmbService.SelectedItem = dgvPersonnel.CurrentRow.Cells[5].Value.ToString();
           //cmbRole.SelectedItem = dgvPersonnel.CurrentRow.Cells[6].Value.ToString();
           txtEmail.Text = dgvPersonnel.CurrentRow.Cells[4].Value.ToString();
           txtQuartier.Text = dgvPersonnel.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
