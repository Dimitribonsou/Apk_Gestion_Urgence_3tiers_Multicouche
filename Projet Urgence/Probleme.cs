using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BLL;
using DAL;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Probleme : Form
    {
        ProblemeBLL pb = new ProblemeBLL();
        ProblemeDAL pba = new ProblemeDAL();
       
       private string name, mdp;
        public Probleme()
        {
            InitializeComponent();
        }
        public Probleme(string usrName)
        {
            InitializeComponent();
            this.name = usrName;
            pb.nomPersonnel = name;

        }
        public Probleme(string usrName, string usrPassword)
        {
            InitializeComponent();
            this.name = usrName;
            this.mdp= usrPassword;
            pb.nomPersonnel = name;
        }

        private void btnPb_Click(object sender, EventArgs e)
        {

            try
            {
                pb.libelle = txtNom.Text;
                pb.nomService = cmbService.SelectedItem.ToString();
                pb.date = dtpDate.Value;
                pb.description = txtDesc.Text;
               
                if (string.IsNullOrEmpty(txtDesc.Text) || string.IsNullOrEmpty(cmbService.SelectedItem.ToString()))
                {
                    MessageBox.Show("Erreur vous avez laissez vide un champ obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pba.pbexiste(txtNom.Text))
                {
                    MessageBox.Show("Désole se probème à déja été signaler ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pba.Addpb(pb);
                    MessageBox.Show("problème signaler avec succes", "Signal Probleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
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
        private void ClearForm()
        {
            txtNom.Text = string.Empty;
            txtDesc.Text = string.Empty;
            cmbService.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
        }

        private void Probleme_Load(object sender, EventArgs e)
        {
            cmbService.Items.Clear();
            DataTable dt = pba.selectServices();
            foreach (DataRow item in dt.Rows)
            {
               
                cmbService.Items.Add(item[0]);
            }
        }
    }
}
