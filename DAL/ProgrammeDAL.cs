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
   public  class ProgrammeDAL
   { 
       #region insertion de donne dans la bd
       public void AddProgramme(ProgrammeBLL pg)
       {
           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "INSERT INTO [Programme] (titre,date_debut,date_fin,description,nomService) VALUES(@titre,@date_debut,@date_fin,@description,@nomService)";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {
                  
                   cmd.Parameters.AddWithValue("@titre", pg.libelle);
                   cmd.Parameters.AddWithValue("@date_debut", pg.date_debut);

                   cmd.Parameters.AddWithValue("@date_fin", pg.date_fin);

                   cmd.Parameters.AddWithValue("@description", pg.description);

                   cmd.Parameters.AddWithValue("@nomService", pg.service);

                  
                   cmd.ExecuteNonQuery();
               }
           }
       }
       #endregion
       #region mise a jour du programme
       public void UpdateProgramme(ProgrammeBLL pg)
       {
           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "UPDATE  [Programme]  SET titre=@titre,date_debut=@date_debut,date_fin=@date_fin,description=@description,nomService=@nomService WHERE id_prog=@id";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {

                   cmd.Parameters.AddWithValue("@titre", pg.libelle);
                   cmd.Parameters.AddWithValue("@date_debut", pg.date_debut);

                   cmd.Parameters.AddWithValue("@date_fin", pg.date_fin);

                   cmd.Parameters.AddWithValue("@description", pg.description);

                   cmd.Parameters.AddWithValue("@nomService", pg.service);
                   cmd.Parameters.AddWithValue("@id", pg.id);

                   cmd.ExecuteNonQuery();
               }
           }
       }
       #endregion
       #region selection de tout les programmes de planifications
       public DataTable selectProgramme(string service)
       {
           DataTable dt=new DataTable();
           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "SELECT * FROM  [Programme] WHERE nomService=@nomService";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {

                   cmd.Parameters.AddWithValue("@nomService", service);
                  
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
               }
           }
       }
       #endregion
       #region selection de tout les programmes de planifications
       public DataTable selectAllProgramme()
       {
           DataTable dt = new DataTable();
           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "SELECT * FROM  [Programme] ";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {

               
                  
                   SqlDataAdapter da = new SqlDataAdapter(cmd);
                   da.Fill(dt);
                   return dt;
               }
           }
       }
       #endregion
       #region verifie l'existance d'un  tout les programmes de planifications
       public bool existeProgramme(ProgrammeBLL pg)
       {
           DataTable dt = new DataTable();
           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "SELECT COUNT(*) FROM [Programme] WHERE nomService=@nomService";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {
                   cmd.Parameters.AddWithValue("@nomService", pg.service);

                   int count = (int)cmd.ExecuteScalar();
                   return count > 0;
               }
           }
       }
       #endregion
       #region suppression d'un nouveau programme
       public void deleteProgramme(ProgrammeBLL pg)
       {
          
           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "DELETE [Programme] WHERE titre=@titre";
               using (SqlCommand cmd = new SqlCommand(query, cn))
               {
                   cmd.Parameters.AddWithValue("@titre", pg.libelle);
                   cmd.ExecuteNonQuery();
                  
               }
           }
       }
       #endregion
   }
}
