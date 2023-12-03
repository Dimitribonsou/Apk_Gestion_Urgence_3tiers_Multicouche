using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DAL;
using BLL;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AcceuilService : Form
    {
        ProblemeBLL pb = new ProblemeBLL();
        ProblemeDAL pba = new ProblemeDAL();
        string nomService = null;
        public AcceuilService()
        {
            InitializeComponent();
        }
        public AcceuilService(string nom)
        {
            InitializeComponent();
            this.nomService = nom;
        }

        private void AcceuilService_Load(object sender, EventArgs e)
        {
            DataTable dt = pba.selectMessageServices(nomService);
            int position = 180;

            foreach (DataRow item in dt.Rows)
            {
                
                    Label label = new Label();
                    label.ForeColor = Color.Red;
                    label.AutoSize = true;
                    //label.Width = 250;
                    //label.Height = 350;
                    // definir la police de l'information
                    label.Font = new System.Drawing.Font(label.Font.FontFamily, 20);
                    label.Text = item["libelle"].ToString();
                    //   definir la largeur maximal pour que le contenue s'adapte automatiquement
                    //label.MaximumSize = new System.Drawing.Size(800, 0);
                    //label.Text = texte;
                    label.Anchor = AnchorStyles.None;
                    label.Location = new Point(250, position);
                    this.Controls.Add(label);
                    Label lbdate = new Label();

                    lbdate.ForeColor = Color.Blue;
                    lbdate.AutoSize = true;
                    lbdate.Font = new System.Drawing.Font(lbdate.Font.FontFamily, 15);
                    lbdate.Text = item["datepb"].ToString();
                    lbdate.Anchor = AnchorStyles.Top;
                    lbdate.Anchor = AnchorStyles.Right;
                    lbdate.BackColor = Color.Transparent;
                    lbdate.Location = new Point(550, (position));

                    this.Controls.Add(lbdate);
                    position += 80;


                    Label lbdesc = new Label();
                    lbdesc.ForeColor = Color.Black;
                    //lbdesc.Name = txt;
                    lbdesc.Text = item["description"].ToString();
                    //lbdesc.Height = 18;
                    //   definir la largeur maximal pour que le contenue s'adapte automatiquement
                    lbdesc.MaximumSize = new System.Drawing.Size(800, 0);
                    // modifier la police du texte contenu dans le label
                    lbdesc.Font = new Font(lbdesc.Font.FontFamily, 15);
                    lbdesc.AutoSize = true;
                    lbdesc.Anchor = AnchorStyles.None;
                    lbdesc.Location = new Point(250, position);
                    this.Controls.Add(lbdesc);
                    position += 80;

                    //lbServ.Location = new Point(250, (position + 30));
                    //this.Controls.Add(lbServ);
                    // libelle service
                    Label lblibServ = new Label();
                    lblibServ.ForeColor = Color.Green;
                    //lbdesc.Name = txt;
                    lblibServ.Text = " Nom du Personnel :  " + item["nomPersonne"].ToString();
                    //lbServ.Height = 18;
                    //   definir la largeur maximal pour que le contenue s'adapte automatiquement
                    //lblibServ.MaximumSize = new System.Drawing.Size(600, 0);
                    // modifier la police du texte contenu dans le label
                    lblibServ.Font = new Font(lbdesc.Font.FontFamily, 15, FontStyle.Bold);
                    lblibServ.AutoSize = true; 
                    lblibServ.Anchor = AnchorStyles.None;
                    lblibServ.Location = new Point(250, position);
                    this.Controls.Add(lblibServ);
                    position += 100;
                
               
            }
        }
    }
}
