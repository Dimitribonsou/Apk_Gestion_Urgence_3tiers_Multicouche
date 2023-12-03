using System;
using System.Collections.Generic;
using System.Linq;
using BLL;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ServiceDAL
   {
       #region ajout d'un nouveau service 
       public void addService(ServiceBLL sv)
       {

           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "INSERT INTO [Service] (nom,filiere,description,create_at) VALUES(@nom,@filiere,@description,@create_at)";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {
            
                   cmd.Parameters.AddWithValue("@nom",sv.nom );
                   cmd.Parameters.AddWithValue("@filiere", sv.filiere);
                   cmd.Parameters.AddWithValue("@description", sv.description);
                   cmd.Parameters.AddWithValue("@create_at", DateTime.Now.ToShortDateString());
                 
                   cmd.ExecuteNonQuery();
               }
           }
       }
       #endregion
       #region verifier si un service existe
       public bool existeService(string nom)
       {
           

           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "SELECT COUNT(*) FROM Service WHERE nom=@nom";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {
                   cmd.Parameters.AddWithValue("@nom",nom);
                   int count = (int)cmd.ExecuteScalar();

                   return count > 0;
               }
           }
       }
       #endregion
       #region affichage de tout les services
       public DataTable selectService()
       {
           DataTable dt = new DataTable();

           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "SELECT id_serv,nom as nomService, filiere,create_at as DateCreation,description FROM [Service] ORDER BY nom ASC";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {

                       SqlDataAdapter da = new SqlDataAdapter(cmd);
                       da.Fill(dt);
               }
               return dt;
           }
       }
       #endregion
       public DataTable selectAllService()
       {
           DataTable dt = new DataTable();

           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "SELECT * FROM [Service] ORDER BY nom ASC";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {

                   SqlDataAdapter da = new SqlDataAdapter(cmd);
                   da.Fill(dt);
               }
               return dt;
           }
       }
       #region affichage de tout les services
       public DataTable selectNameServices()
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
       #region suppresion d'un service
       public void deleteService(ServiceBLL sv)
       {
           DataTable dt = new DataTable();

           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "DELETE  Service WHERE id_serv=@id ";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {
                   cmd.Parameters.AddWithValue("@id", sv.id);
                   cmd.ExecuteNonQuery();
               }
            
           }
       }
       #endregion
       #region mise a jour de service
       public void updateService(ServiceBLL sv)
       {
           

           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "UPDATE   Service  SET nom=@nom,filiere=@filiere,description=@description WHERE id_serv=@id ";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {
                   cmd.Parameters.AddWithValue("@nom", sv.nom);
                   cmd.Parameters.AddWithValue("@id", sv.id);
                   cmd.Parameters.AddWithValue("@filiere", sv.filiere);
                   cmd.Parameters.AddWithValue("@description", sv.description);
                   cmd.ExecuteNonQuery();
               }

           }
       }
       #endregion
       #region mise ajour d'un  utilisateur

       public void Addpersonnel(userBLL usr)
       {
           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "UPDATE Personnel SET nom=@nom,prenom=@prenom,tel=@tel,email=@email,quartier=@quartier,Service=@service WHERE id_perso=@id";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {
                   //cryptage du mot de passe
                   //string password = Cryptogaphy.Encrypter(usr.password);
                   cmd.Parameters.AddWithValue("@nom", usr.nom);
                   cmd.Parameters.AddWithValue("@id", usr.id);
                   cmd.Parameters.AddWithValue("@prenom", usr.prenom);
                   //cmd.Parameters.AddWithValue("@mdp", password);
                   cmd.Parameters.AddWithValue("@tel", usr.telephone);
                   cmd.Parameters.AddWithValue("@email", usr.email);
                   cmd.Parameters.AddWithValue("@quartier", usr.quartier);
                   //cmd.Parameters.AddWithValue("@role",usr.role);
                   cmd.Parameters.AddWithValue("@service", usr.service);
                   cmd.ExecuteNonQuery();
               }
           }
       }
       #endregion
       #region Recuperation de l'id du personnel
       public int GetIdByName(userBLL usr)
       {
           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = " SELECT id_perso FROM Personnel WHERE nom=@nom";
               SqlCommand cmd = new SqlCommand(query, cn);

               cmd.Parameters.AddWithValue("@nom", usr.nom);
               int id = (int)cmd.ExecuteScalar();
               return id;

           }
       }
       #endregion
       #region affichage de tout les services
       public DataTable selectPersonnel(string service)
       {
           DataTable dt = new DataTable();

           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "SELECT id_perso,nom,prenom,tel,email,quartier FROM Personnel WHERE Service=@service ORDER BY nom ASC";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {
                   cmd.Parameters.AddWithValue("@service", service);
                       SqlDataAdapter da = new SqlDataAdapter(cmd);
                       da.Fill(dt);
                       return dt;
               }
            
           }
       }
       #endregion
       #region affichage de tout les services
       public DataTable selectPersonnels()
       {
           DataTable dt = new DataTable();

           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "SELECT id_perso,nom,prenom,tel,email,quartier FROM Personnel WHERE Service IS NULL ORDER BY nom ASC";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {
                   SqlDataAdapter da = new SqlDataAdapter(cmd);
                   da.Fill(dt);
                   return dt;
               }

           }
       }
       #endregion
       #region rechercher tous les personnels
       public DataTable selectAllPersonnels()
       {
           DataTable dt = new DataTable();

           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "SELECT id_perso,nom,prenom,tel,Service as nomService,quartier FROM Personnel  ORDER BY nom ASC";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {
                   SqlDataAdapter da = new SqlDataAdapter(cmd);
                   da.Fill(dt);
                   return dt;
               }

           }
       }
       #endregion
       #region affichage de tout les services en fonction du nom rechercher
       public DataTable searchPersonnel(string nom,string service)
       {
           DataTable dt = new DataTable();

           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "SELECT id_perso,nom,prenom,tel,email,quartier FROM Personnel WHERE nom like '"+ nom+"%' AND Service=@service ORDER BY nom ASC";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {
                   cmd.Parameters.AddWithValue("@service", service);
                   SqlDataAdapter da = new SqlDataAdapter(cmd);
                   da.Fill(dt);
                   return dt;
               }

           }
       }
       #endregion
  
       #region affichage de tout les services en fonction du nom rechercher
       public DataTable searchNewPersonnel(string nom)
       {
           DataTable dt = new DataTable();

           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "SELECT id_perso,nom,prenom,tel,email,quartier FROM Personnel WHERE nom like '" + nom + "%' AND Service IS NULL ORDER BY nom ASC";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {
                   cmd.Parameters.AddWithValue("@service", nom);
                   SqlDataAdapter da = new SqlDataAdapter(cmd);
                   da.Fill(dt);
                   return dt;
               }

           }
       }
       #endregion
   }
}
