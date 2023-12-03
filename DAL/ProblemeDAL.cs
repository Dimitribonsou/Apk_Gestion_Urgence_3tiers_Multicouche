using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL
{
    public class ProblemeDAL
    {
        #region signaler un probleme
        public void Addpb(ProblemeBLL pb)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
            {
                cn.Open();
                string query = "INSERT INTO [Probleme] (libelle,description,nomService,nomPersonne,datepb) VALUES(@libelle,@description,@nomService,@nomPersonne,@datepb)";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    //cryptage du mot de passe

                    cmd.Parameters.AddWithValue("@libelle", pb.libelle);
                    cmd.Parameters.AddWithValue("@description", pb.description);
                    cmd.Parameters.AddWithValue("@nomService", pb.nomService);
                    cmd.Parameters.AddWithValue("@nomPersonne", pb.nomPersonnel);
                    cmd.Parameters.AddWithValue("@datepb", pb.date);
                    cmd.ExecuteNonQuery();
                }

            }
        }
        #endregion
        #region method permettant de verifier si un probleme existe deja
        public bool pbexiste(string libelle)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
            {
                cn.Open();
                string query = "SELECT COUNT(*) FROM Probleme WHERE libelle=@libelle";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@libelle", libelle);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;// retourne true si le libelle existe deja et false dans le cas  contraire
                }
            }
        }

        #endregion
      #region affichage de tout les services
       public DataTable  selectServices ()
       {

           DataTable dt = new DataTable();
           //DataSet dt = new DataSet();
           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "SELECT nom FROM Service ORDER BY nom ASC";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {

                   SqlDataAdapter da = new SqlDataAdapter(cmd);
                   da.Fill(dt);
                   return dt; 
               }
            
           }
       }

       #endregion
       #region affichage des message de tout les services
       public DataTable selectMessageServices(string nom)
       {

           DataTable dt = new DataTable();
           //DataSet dt = new DataSet();
           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "SELECT libelle,description,datepb,nomPersonne FROM Probleme WHERE nomService=@nom  ORDER BY datepb DESC ";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {
                   cmd.Parameters.AddWithValue("@nom", nom);
                   SqlDataAdapter da = new SqlDataAdapter(cmd);
                   da.Fill(dt);
                   return dt;
               }

           }
       }

       #endregion
       #region affichage de tout les services
       public DataTable selectMessageAdmin()
       {
           string nom = "Administration";
           DataTable dt = new DataTable();
           //DataSet dt = new DataSet();
           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "SELECT libelle,description,datepb,nomPersonne FROM Probleme WHERE nomService=@nom  ORDER BY datepb DESC ";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {
                   cmd.Parameters.AddWithValue("@nom", nom);
                   SqlDataAdapter da = new SqlDataAdapter(cmd);
                   da.Fill(dt);
                   return dt;
               }

           }
       }

       #endregion
       public DataTable selectAllProbleme()
       {
          
           DataTable dt = new DataTable();
           //DataSet dt = new DataSet();
           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "SELECT * FROM Probleme  ORDER BY libelle DESC ";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {
                   
                   SqlDataAdapter da = new SqlDataAdapter(cmd);
                   da.Fill(dt);
                   return dt;
               }

           }
       }
        }
    }


