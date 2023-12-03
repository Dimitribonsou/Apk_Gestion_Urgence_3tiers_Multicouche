using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Chargement : Form
    {
        public Chargement()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Chargement_Load(object sender, EventArgs e)
        {

        }
        int pourcentage = 13;
        private void timer1_Tick(object sender, EventArgs e)
        {
           if(pourcentage<100)
           {
               pourcentage += 2;
               guna2CircleProgressBar1.Value = pourcentage;
               lbChagement.Text = pourcentage + "%";
           }
           if (pourcentage >= 100)
           {
               timer1.Stop();
               FormConnexionPersonnel fcn = new FormConnexionPersonnel();
               fcn.Show();
               this.Hide();
           }

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
