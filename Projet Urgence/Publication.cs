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
    public partial class Publication : Form
    {
        InformationBLL info = new InformationBLL();
        informationDAL da = new informationDAL();
        string nomService;
        public Publication()
        {
            InitializeComponent();
        }
        public Publication(string service)
        {
            InitializeComponent();
            this.nomService = service;
        }

        private void ClearForm()
        {
            txtMessage.Text = string.Empty;
            txtTitre.Text = string.Empty;
            dtpEnvoie.Value = DateTime.Now;
            dtpExpiration.Value = DateTime.Now;
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            info.titre = txtTitre.Text;
            info.message = txtMessage.Text;
            info.date_envoie = dtpEnvoie.Value;
            info.date_expiration = dtpExpiration.Value;
            info.nomService = nomService;
            try
            {
                info.titre = txtTitre.Text;
                int id = Convert.ToInt32(dgvInfo.CurrentRow.Cells[0].Value);
                info.id = id;
                da.Updateinfo(info);
                MessageBox.Show("Mise A Jour Effectuer Avec Succes", "Mise A Jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteInfo_Click(object sender, EventArgs e)
        {
            try
            {
                info.titre = txtTitre.Text;
                int id = da.selectIdInfoByLibelle(info);
                info.id = id;
                da.deleteInfo(info);
                MessageBox.Show("Suppression Effectuer Avec Succes", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void LoadData()
        {
           // dgvInfo.Rows.Clear();
            dgvInfo.DataSource = da.selectinfo();
        }

        private void Publication_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMessage.Text = dgvInfo.CurrentRow.Cells[2].Value.ToString();
            txtTitre.Text = dgvInfo.CurrentRow.Cells[1].Value.ToString();
            dtpEnvoie.Value = Convert.ToDateTime(dgvInfo.CurrentRow.Cells[3].Value);
            dtpExpiration.Value = Convert.ToDateTime(dgvInfo.CurrentRow.Cells[4].Value);
        }

        private void btnPublier_Click(object sender, EventArgs e)
        {
            info.titre = txtTitre.Text;
            info.message = txtMessage.Text;
            info.date_envoie = dtpEnvoie.Value;
            info.date_expiration = dtpExpiration.Value;
            info.nomService = nomService;
            try
            {
                //int id = da.selectIdInfoByLibelle(info);
                //info.id = id;
                da.Addinfo(info);
        
                MessageBox.Show("Publication Effectuer Avec Succes", "Publier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
