using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
//using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Aide : Form
    {
        public Aide()
        {
            InitializeComponent();
        }

        private void Aide_Load(object sender, EventArgs e)
        {

    

            //// Créer une instance de l'application Word
            //Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();

            //// Ouvrir le document Word
            //Document doc = word.Documents.Open(@"D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\ugency.docx");

            //// Enregistrer le contenu du document dans un fichier texte
            //doc.SaveAs(@"D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\ugency1.txt", WdSaveFormat.wdFormatText);

            //// Fermer le document Word
            //doc.Close();

            //// Fermer l'ap
            using (StreamReader reader = new StreamReader(@"D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\urgency1.txt"))
            {


                richTextBoxAide.Text = reader.ReadToEnd();
            }
            
      

          

       

        }

       
    }
}
