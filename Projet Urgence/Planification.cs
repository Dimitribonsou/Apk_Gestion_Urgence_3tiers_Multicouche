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
    public partial class Planification : Form
    {
       private  string nomService;
        ProgrammeBLL info = new ProgrammeBLL();
        ProgrammeDAL da = new ProgrammeDAL();
        public Planification()
        {
            InitializeComponent();
            LoadData();
        }
        public Planification( string service)
        {
            InitializeComponent();
            this.nomService = service;
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            info.libelle = txtlibelle.Text;
            info.description = txtdesc.Text;
            info.date_debut = dtpEnvoie.Value;
            info.date_fin = dtpExpiration.Value;
            info.service = nomService;
            info.id =Convert.ToInt32( dgvPlanification.CurrentRow.Cells[0].Value);

            try
            {
                da.UpdateProgramme(info);
                MessageBox.Show("Programme Mis a jour avec succes", "Publication", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            LoadData();
            ClearForm();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            txtdesc.Text = string.Empty;
            txtlibelle.Text = string.Empty;
            dtpEnvoie.Value = DateTime.Now;
            dtpExpiration.Value =DateTime.Now;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            info.libelle= txtlibelle.Text;
            info.description = txtdesc.Text;
            info.date_debut= dtpEnvoie.Value;
            info.date_fin = dtpExpiration.Value;
            info.service = nomService;
            try
            {
                if (string.IsNullOrEmpty(txtlibelle.Text) || string.IsNullOrEmpty(txtdesc.Text))
                {
                    MessageBox.Show("Veuillez remplie tout les champs ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    da.AddProgramme(info);
                    MessageBox.Show("Programme Publier avec succes", "Publication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
            LoadData();
            ClearForm();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            info.libelle = txtlibelle.Text;
            info.description = txtdesc.Text;
            info.date_debut = dtpEnvoie.Value;
            info.date_fin = dtpExpiration.Value;
            info.service = nomService;
            try
            {
                da.deleteProgramme(info);
                MessageBox.Show("Programme Suprimer avec succes", "Publication", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            LoadData();
            ClearForm();
        }
        private void LoadData()
        {
            dgvPlanification.DataSource = da.selectProgramme(nomService);
        }

        private void dgvPlanification_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtlibelle.Text = dgvPlanification.CurrentRow.Cells[1].Value.ToString();
            txtdesc.Text = dgvPlanification.CurrentRow.Cells[4].Value.ToString();
            dtpEnvoie.Value = Convert.ToDateTime(dgvPlanification.CurrentRow.Cells[2].Value);
            dtpExpiration.Value =Convert.ToDateTime( dgvPlanification.CurrentRow.Cells[3].Value);
        }
    }
}
