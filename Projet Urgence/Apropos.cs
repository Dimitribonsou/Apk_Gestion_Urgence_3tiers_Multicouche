using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Apropos : Form
    {
        public Apropos()
        {
            InitializeComponent();
        }

        private void Apropos_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(@"D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\Projet Urgence\Apropos.txt"))
            {
                string text = reader.ReadToEnd();
                richTextBoxApropos.Text = text;
            }
        }
    }
}
