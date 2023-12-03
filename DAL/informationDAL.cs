using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace DAL
{
    public class informationDAL
    {

        #region insertion de donne dans la bd
        public void Addinfo(InformationBLL info)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
            {
                cn.Open();
                string query = "INSERT INTO [Information] (libelle,date_envoie,date_expiration,message,nomService) VALUES(@titre,@date_debut,@date_fin,@description,@nomService)";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {

                    cmd.Parameters.AddWithValue("@titre", info.titre);
                    cmd.Parameters.AddWithValue("@date_debut", info.date_envoie);

                    cmd.Parameters.AddWithValue("@date_fin", info.date_expiration);

                    cmd.Parameters.AddWithValue("@description", info.message);

                    cmd.Parameters.AddWithValue("@nomService", info.nomService);


                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
        #region mise a jour du programme
        public void Updateinfo(InformationBLL info)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
            {
                cn.Open();
                string query = "UPDATE  [Information]  SET libelle=@titre,date_envoie=@date_debut,date_expiration=@date_fin,message=@description,nomService=@nomService WHERE id_info=@id";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {

                    cmd.Parameters.AddWithValue("@titre", info.titre);
                    cmd.Parameters.AddWithValue("@id", info.id);
                    cmd.Parameters.AddWithValue("@date_debut", info.date_envoie);

                    cmd.Parameters.AddWithValue("@date_fin", info.date_expiration);

                    cmd.Parameters.AddWithValue("@description", info.message);

                    cmd.Parameters.AddWithValue("@nomService", info.nomService);


                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
        #region selection de tout les programmes de planifications
        public DataTable selectinfo()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
            {
                cn.Open();
                string query = "SELECT * FROM  [Information] ORDER BY date_envoie DESC";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {

                    //cmd.Parameters.AddWithValue("@nomService", pg.service);
                    //SqlDataReader lect = cmd.ExecuteReader();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        #endregion
        #region selection des id des informations
        public int selectIdInfoByLibelle(InformationBLL info)
        {
            
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
            {
                cn.Open();
                string query = "SELECT id_info FROM  [Information] WHERE libelle=@libelle";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@libelle", info.titre);
                int id = (int)cmd.ExecuteScalar();
                return id;
            }
        }
        #endregion
        #region verifie l'existance d'un  tout les programmes de planifications
        public bool existeinfo(InformationBLL info)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
            {
                cn.Open();
                string query = "SELECT COUNT(*) FROM [Information] WHERE libelle=@titre";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@titre", info.titre);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        #endregion
        #region suppression d'un nouveau programme
        public void deleteInfo(InformationBLL info)
        {

            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
            {
                cn.Open();
                string query = "DELETE FROM [Information] WHERE id_info=@id";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@id", info.id);
                    cmd.ExecuteNonQuery();

                }
            }
        }
        #endregion
    }
}
