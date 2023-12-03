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
    public partial class Information : Form
    {
        informationDAL info = new informationDAL();
        
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            DataTable dt = info.selectinfo();
            int position = 150;
#region information de facons manueele
            //string[,] tab =new  string[100,2];
            //tab[0,0]=("recrutement scientifique");
            //tab[0, 1] = ("rerutement des enseignant de mathematiques");
            //tab[0, 0] = ("recrutement litteraire");
            //tab[0, 1] = ("rerutement des enseignant de francais au lycee de byamassi dans la ville de yaounde pour plus d'informations contacter le service d'acceuil pour avoir plus d'informations");
            //for (int i = 0; i < 20; i++)
            //{
                

            //    for (int j = 0; j < 2; j++)
            //    {
            //        string texte = "lbtitre"+ "" + i;
            //        string txt = "lbdesc" + "" + i;
                   
                       
            //            Label label=new Label();
            //            label.Name = texte;
            //            label.ForeColor = Color.Red;
            //            label.AutoSize = true;
            //        // definir la police de l'information
            //            label.Font = new System.Drawing.Font(label.Font.FontFamily, 20);
            //            label.Text = tab[0, 0];
            //            //label.Text = texte;
            //            label.Location = new Point(350, position);
            //            this.Controls.Add(label);
            //            Label lbdate = new Label();
            //            lbdate.ForeColor = Color.Blue;
            //            lbdate.AutoSize = true;
            //            lbdate.Font = new System.Drawing.Font(lbdate.Font.FontFamily, 15);
            //            lbdate.Text = DateTime.Now.ToShortDateString();
            //            lbdate.Location = new Point(750, position);
                       
            //            this.Controls.Add(lbdate);
            //            position += 45;


            //            Label lbdesc = new Label();
            //            lbdesc.ForeColor = Color.Black;
            //            lbdesc.Name = txt;
            //            lbdesc.Text = tab[0, 1];
            //            lbdesc.Height = 18;
            //            //   definir la largeur maximal pour que le contenue s'adapte automatiquement
            //            lbdesc.MaximumSize = new System.Drawing.Size(300, 0);
            //            // modifier la police du texte contenu dans le label
            //            lbdesc.Font = new Font(lbdesc.Font.FontFamily, 15);
            //            lbdesc.AutoSize = true;
            //            lbdesc.Location = new Point(350, position);
            //            this.Controls.Add(lbdesc);
            //            position += 255;
                    

            //    }
                //Label lb = new Label();
                //lb.ForeColor = Color.Red;
                //lb.Font.Style.Equals(FontStyle.Bold);
                //lb.Font.Size.Equals(18);

                //lb.Text = "bonjour";

                //lb.Location = new Point(300, position);
                //this.Controls.Add(lb);
#endregion
            foreach (DataRow item in dt.Rows)
            {
                   
                        Label label=new Label();
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
                        lbdate.Text =item["date_envoie"].ToString();
                        lbdate.Anchor = AnchorStyles.Top;
                        lbdate.Anchor = AnchorStyles.Right;
                        lbdate.BackColor = Color.Transparent;
                        lbdate.Location = new Point(550, (position));
                        
                        this.Controls.Add(lbdate);
                        position += 50;


                        Label lbdesc = new Label();
                        lbdesc.ForeColor = Color.Black;
                        //lbdesc.Name = txt;
                        lbdesc.Text = item["message"].ToString();
                        //lbdesc.Height = 18;
                        //   definir la largeur maximal pour que le contenue s'adapte automatiquement
                        lbdesc.MaximumSize = new System.Drawing.Size(800, 0);
                        // modifier la police du texte contenu dans le label
                        lbdesc.Font = new Font(lbdesc.Font.FontFamily, 15);
                        lbdesc.AutoSize = true;
                        lbdesc.Anchor = AnchorStyles.None;
                        lbdesc.Location = new Point(250, position);
                        this.Controls.Add(lbdesc);
                        position += 100;
                
                        //lbServ.Location = new Point(250, (position + 30));
                        //this.Controls.Add(lbServ);
                // libelle service
                        Label lblibServ = new Label();
                        lblibServ.ForeColor = Color.Green;
                        //lbdesc.Name = txt;
                        lblibServ.Text = " Nom du service :  " + item["nomService"].ToString();
                        //lbServ.Height = 18;
                        //   definir la largeur maximal pour que le contenue s'adapte automatiquement
                        //lblibServ.MaximumSize = new System.Drawing.Size(600, 0);
                        // modifier la police du texte contenu dans le label
                        lblibServ.Font = new Font(lbdesc.Font.FontFamily,15,FontStyle.Bold);
                        lblibServ.AutoSize = true;
                        lblibServ.Anchor = AnchorStyles.None;
                        lblibServ.Location = new Point(250, position );
                        this.Controls.Add(lblibServ);
                        //position += 30;
                        //nom du service
                        //Label lbServ = new Label();
                        //lbServ.ForeColor = Color.Blue;
                        ////lbdesc.Name = txt;
                        //lbServ.Text = "------------------------------------------------------------------------------------------------------------------------------------------------------";
                        ////lbServ.Height = 18;
                        ////   definir la largeur maximal pour que le contenue s'adapte automatiquement
                        ////lbServ.MaximumSize = new System.Drawing.Size(300, 0);
                        //// modifier la police du texte contenu dans le label
                        //lbServ.Font = new Font(lbdesc.Font.FontFamily, 15);
                        //lbServ.AutoSize = true;
                        //lbServ.Anchor = AnchorStyles.Left;
                        //lbServ.Location = new Point(200, (position+30 ));
                        //this.Controls.Add(lbServ);
                        position += 80;
                    
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
