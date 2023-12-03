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
    public partial class Service : Form
    {
        ServiceBLL srv = new ServiceBLL();
        ServiceDAL srvDal = new ServiceDAL();
        public Service()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                srv.id = Convert.ToInt32(dgvService.CurrentRow.Cells[0].Value);
                srv.nom = txtNom.Text;
                srv.description = txtDesc.Text;
                srv.filiere = txtFilire.Text;
                if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtFilire.Text) )
                {
                    MessageBox.Show("Erreur vous avez laissez vide un champ obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (srvDal.existeService(srv.nom))
                {
                    MessageBox.Show("Désole se Service existe déja  ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    srvDal.addService(srv);
                    MessageBox.Show("Service Ajouter avec succes", "Signal Probleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                srv.id = Convert.ToInt32(dgvService.CurrentRow.Cells[0].Value);
                srv.nom = txtNom.Text;
                srv.description = txtDesc.Text;
                srv.filiere = txtFilire.Text;
                if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtFilire.Text))
                {
                    MessageBox.Show("Erreur vous avez laissez vide un champ obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    srvDal.updateService(srv);
                    MessageBox.Show("Service Modifier avec succes", "Modification Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                srv.id = Convert.ToInt32(dgvService.CurrentRow.Cells[0].Value);
                srv.nom = txtNom.Text;
                srv.description = txtDesc.Text;
                srv.filiere = txtFilire.Text;
                if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtFilire.Text))
                {
                    MessageBox.Show("Veuillez selectionner la ligne a Supprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    srvDal.deleteService(srv);
                    MessageBox.Show("Service Supprimer avec succes", "Suppression Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtDesc.Text = string.Empty;
            txtFilire.Text = string.Empty;
        }
        private void LoadData()
        {
            dgvService.DataSource = srvDal.selectService();
        }
        private void dgvService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Service_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvService_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtNom.Text = dgvService.CurrentRow.Cells[1].Value.ToString();
            txtFilire.Text = dgvService.CurrentRow.Cells[2].Value.ToString();
            txtDesc.Text = dgvService.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
