using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BLL;
using System.Threading.Tasks;

namespace DAL
{
    public class userDAL
    {
        #region insertion des utilisateur

        public void userinsert(userBLL usr)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
            {
                cn.Open();
                string query = "INSERT INTO Personnel (nom,prenom,mdp,tel,email,quartier) VALUES(@nom,@prenom,@mdp,@tel,@email,@quartier)";
                using (SqlCommand cmd = new SqlCommand(query,cn))
                {
                    //cryptage du mot de passe
                    string password = Cryptogaphy.Encrypter(usr.password);
                    cmd.Parameters.AddWithValue("@nom", usr.nom);
                    cmd.Parameters.AddWithValue("@prenom", usr.prenom);
                    cmd.Parameters.AddWithValue("@mdp", password);
                    cmd.Parameters.AddWithValue("@tel", usr.telephone);
                    cmd.Parameters.AddWithValue("@email", usr.email);
                    cmd.Parameters.AddWithValue("@quartier", usr.quartier);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
        #region insertion des utilisateur

        public void userinsertAdmin(userBLL usr)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
            {
                cn.Open();
                string query = "INSERT INTO Personnel (nom,prenom,mdp,tel,email,quartier,role,Service) VALUES(@nom,@prenom,@mdp,@tel,@email,@quartier,@role,@Service)";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    //cryptage du mot de passe
                    string password = Cryptogaphy.Encrypter(usr.password);
                    cmd.Parameters.AddWithValue("@nom", usr.nom);
                    cmd.Parameters.AddWithValue("@prenom", usr.prenom);
                    cmd.Parameters.AddWithValue("@mdp", password);
                    cmd.Parameters.AddWithValue("@tel", usr.telephone);
                    cmd.Parameters.AddWithValue("@email", usr.email);
                    cmd.Parameters.AddWithValue("@quartier", usr.quartier);
                    cmd.Parameters.AddWithValue("@role", usr.role);
                    cmd.Parameters.AddWithValue("@Service", usr.service);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
        #region mise ajour d'un  utilisateur

        public void UpdateUsert(userBLL usr)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
            {
                cn.Open();
                string query = "UPDATE Personnel SET nom=@nom,prenom=@prenom,mdp=@mdp,tel=@tel,email=@email,quartier=@quartier WHERE nom=@nom";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    //cryptage du mot de passe
                    string password = Cryptogaphy.Encrypter(usr.password);
                    cmd.Parameters.AddWithValue("@nom", usr.nom);
                    cmd.Parameters.AddWithValue("@prenom", usr.prenom);
                    cmd.Parameters.AddWithValue("@mdp", password);
                    cmd.Parameters.AddWithValue("@tel", usr.telephone);
                    cmd.Parameters.AddWithValue("@email", usr.email);
                    cmd.Parameters.AddWithValue("@quartier", usr.quartier);
                    //cmd.Parameters.AddWithValue("@role", usr.role);
                    //cmd.Parameters.AddWithValue("@service", usr.service);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region suppression d'un nouveau programme
        public void deleteUser(userBLL usr)
        {

            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
            {
                cn.Open();
                string query = "DELETE [Personnel] WHERE id_perso=@id";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@id", usr.id);
                    cmd.ExecuteNonQuery();

                }
            }
        }
        #endregion
        #region mise ajour d'un  utilisateur

        public void UpdateUserAdmin(userBLL usr)
        {
            if (usr.password.Length < 15)
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
                {
                    cn.Open();
                    string query = "UPDATE Personnel SET nom=@nom,prenom=@prenom,mdp=@mdp,tel=@tel,email=@email,quartier=@quartier,role=@role,Service=@service WHERE id_perso=@id";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        //cryptage du mot de passe
                        //string password = Cryptogaphy.Encrypter(usr.password);
                        string password = Cryptogaphy.Encrypter(usr.password);
                        cmd.Parameters.AddWithValue("@nom", usr.nom);
                        cmd.Parameters.AddWithValue("@id", usr.id);
                        cmd.Parameters.AddWithValue("@prenom", usr.prenom);
                        cmd.Parameters.AddWithValue("@mdp", password);
                        cmd.Parameters.AddWithValue("@tel", usr.telephone);
                        cmd.Parameters.AddWithValue("@email", usr.email);
                        cmd.Parameters.AddWithValue("@quartier", usr.quartier);
                        cmd.Parameters.AddWithValue("@role", usr.role);
                        cmd.Parameters.AddWithValue("@service", usr.service);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
                {
                    cn.Open();
                    string query = "UPDATE Personnel SET nom=@nom,prenom=@prenom,mdp=@mdp,tel=@tel,email=@email,quartier=@quartier,role=@role,Service=@service WHERE id_perso=@id";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        //cryptage du mot de passe
                       
                        cmd.Parameters.AddWithValue("@nom", usr.nom);
                        cmd.Parameters.AddWithValue("@id", usr.id);
                        cmd.Parameters.AddWithValue("@prenom", usr.prenom);
                        cmd.Parameters.AddWithValue("@mdp", usr.password);
                        cmd.Parameters.AddWithValue("@tel", usr.telephone);
                        cmd.Parameters.AddWithValue("@email", usr.email);
                        cmd.Parameters.AddWithValue("@quartier", usr.quartier);
                        cmd.Parameters.AddWithValue("@role", usr.role);
                        cmd.Parameters.AddWithValue("@service", usr.service);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
           
        }
        #endregion
        
        #region verification si l'utilisateur existe dans la base de donne
        public bool userexiste(string nom)
        {
            int count;
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
            {
                if (string.IsNullOrEmpty(nom))
                {
                    return false;
                }
                cn.Open();
                string query = " SELECT COUNT(*)FROM Personnel WHERE nom=@nom";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    count = (int)cmd.ExecuteScalar();
                }
                return count > 0;
               
            }
         

        }

        #endregion
        #region verification si l'utilisateur est un personnel
        public bool connexionPersonnel(userBLL usr)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
            {
                cn.Open();
                string query = " SELECT mdp FROM Personnel WHERE nom=@nom";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@nom", usr.nom);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // recuperation du mot de passe crypter dans la base de donne
                            string storedpassword = reader.GetString(0);
                            // decryptage du mot de passe pour la comparaison
                            string password = Cryptogaphy.Decrypter(storedpassword);
                            //comparaison des mot de passe
                            if (password == usr.password)
                            {
                                return true;
                            }
                        }
                     
                    }
                }
                return false;
            }
        }
        #endregion
        #region verification si l'utilisateur appartient a un service
        public string connexionService(userBLL usr)
        {
            
            //string  nomService=null;
              string nomService=null;
              SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True");
            
                    cn.Open();
                string query = " SELECT mdp,Service,role FROM Personnel WHERE nom=@nom ";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@nom", usr.nom);
                  
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // recuperation du mot de passe crypter dans la base de donne
                            string storedpassword = reader.GetString(0);
                              string service=reader.GetValue(1).ToString();
                            int role=reader.GetInt32(2);
                             //string poste=role.ToString();
                            // decryptage du mot de passe pour la comparaison
                            string password = Cryptogaphy.Decrypter(storedpassword);
                            //comparaison des mot de passe
                            if ((password == usr.password && service !=null||role==3))
                            {
                                return service;
                            }
                          

                        }
                     
                    }
                }
                return "echec";
            
                //return  nomService;
        }
        #endregion
        #region verification si l'utilisateur est un admin
        public bool connexionAdmin(string nom, string mdp)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
            {
                cn.Open();
                string query = " SELECT role FROM Personnel WHERE nom=@nom AND mdp=@mdp";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    int role = 3;
                    cmd.Parameters.AddWithValue("@nom", nom);
                    string stockedpassword = Cryptogaphy.Encrypter(mdp);
                    cmd.Parameters.AddWithValue("@mdp", stockedpassword);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // recuperation du mot de passe crypter dans la base de donne
                            //string storedpassword = reader.GetString(0);
                            int poste = (int)reader.GetValue(0);
                            // decryptage du mot de passe pour la comparaison
                            //string password = Cryptogaphy.Decrypter(storedpassword);
                            //comparaison des mot de passe
                            if (poste == role)
                            {
                                return true;
                            }
                        }
                   
                    }
                }
                return false;
            }
        }
        #endregion
        #region selection de tout les champs
       public DataTable RemplirtxtPersonnel(string nom)
       {

           DataTable dt = new DataTable();
           //DataSet dt = new DataSet();
           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\Projet Urgence\DAL\Urgencedb.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = "SELECT mdp,role,Service FROM Personnel WHERE nom=@nom";
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

    }
}
