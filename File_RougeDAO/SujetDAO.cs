using Fil_Rouge_Forum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fil_RougeDAO
{
    /// <summary>
    /// La classe SujetDAO, permet la recupération des tous les sujet, l'ajout d'un sujet etc...
    /// dans la table sujet de notre base de données
    /// </summary>
    public static class SujetDAO
    {
        #region "Property et attributs"
        
        private static SqlConnection con = ConnexionSQLServer.GetConnexion();

        #endregion

        #region "Constructeurs"
        #endregion

        #region "Methodes"
        /// <summary>
        /// La méthode GetAllSujet, retourne tous les sujets du forum
        /// </summary>
        /// <returns>Tous les sujets</returns>
        public static List<Sujet> GetAllSujets()
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable("Sujet");
            da.Fill(dt);
            //con.Close();

            if(dt.Rows.Count >= 1)
            {
                List<Sujet> _Sujets = new List<Sujet>();

                foreach(DataRow row in dt.Rows)
                {
                    _Sujets.Add(new Sujet(int.Parse(row["ID_SUJET"].ToString()), row["TITRE"].ToString(), row["DESCRIPTION"].ToString(), CategorieDAO.GetCategorieByID(int.Parse(row["ID_CATEGORIE"].ToString()))));
                }

                return _Sujets;
            }

            return null;
        } 
        /// <summary>
        /// La methode GetSujetsByCategorie, permet de récupéré tous les sujets d'une catégorie, passé en parametre
        /// </summary>
        /// <param name="idcategorie">L'identifiant de la catégorie</param>
        /// <returns>La liste des sujets pour une catégorie donnée</returns>

        public static List<Sujet> GetSujetsByCategorie(int idcategorie)
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllSujetsByCategorie";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@Id_categorie";
            parm.Value = idcategorie;
            cmd.Parameters.Add(parm);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("AllSujets");
            da.Fill(dt);
            //con.Close();

            if(dt.Rows.Count >= 1)
            {
                List<Sujet> _Sujets = new List<Sujet>();

                // parcours des toutes lignes de notre table 
                foreach(DataRow row in dt.Rows)
                {
                    _Sujets.Add(new Sujet(int.Parse(row["ID_SUJET"].ToString()), row["TITRE"].ToString(), row["DESCRIPTION"].ToString(), CategorieDAO.GetCategorieByID(idcategorie)));

                }
                return _Sujets;
            }
            return null;
        }

        /// <summary>
        /// La Méthode GetSujetByID, permet de retourné un sujet dont l'identifient est passé en parametre
        /// </summary>
        /// <param name="idsujet">L'identifient du sujet</param>
        /// <returns>Le sujet, dont l'identification est passé en paramatre </returns>
        public static Sujet GetSujetByID( int idsujet)
        {
           //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetSubjetByID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@IdSujet";
            parm.Value = idsujet;

            cmd.Parameters.Add(parm);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("SUJET");
            da.Fill(dt);
            //con.Close();

            if(dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                Sujet sujet = new Sujet(int.Parse(row["ID_SUJET"].ToString()), row["TITRE"].ToString(), row["DESCRIPTION"].ToString(), CategorieDAO.GetCategorieByID(int.Parse(row["ID_CATEGORIE"].ToString())));

                return sujet;
            }

            return null;
        }

        /// <summary>
        /// La méthode EditSujet, permet la modification du titre d'un sujet, et/ou la description
        /// on passant l'ancien sujet en parametre
        /// </summary>
        /// <param name="sujet"></param>
        /// <param name="newTitre"></param>
        /// <param name="newDescription"></param>
        /// <returns>Le nombre des lignes affectées, nbligne = 1, si tout se passe bien</returns>
        public static int EditSujet(Sujet sujet, string newTitre, string newDescription)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "EditSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdSujet = cmd.CreateParameter();
            parmIdSujet.ParameterName = "@ID_SUJET";
            parmIdSujet.Value = sujet.IdSujet;
            cmd.Parameters.Add(parmIdSujet);

            SqlParameter paramNewTitre = cmd.CreateParameter();
            paramNewTitre.ParameterName = "@NEW_TITRE";
            paramNewTitre.Value = newTitre;
            cmd.Parameters.Add(paramNewTitre);

            SqlParameter parmOldTitre = cmd.CreateParameter();
            parmOldTitre.ParameterName = "@OLD_TITRE";
            parmOldTitre.Value = sujet.Titre;
            cmd.Parameters.Add(parmOldTitre);

            SqlParameter parmNewDesc = cmd.CreateParameter();
            parmNewDesc.ParameterName = "@NEW_DESC";
            parmNewDesc.Value = newDescription;
            cmd.Parameters.Add(parmNewDesc);

            SqlParameter parmOldDesc = cmd.CreateParameter();
            parmOldDesc.ParameterName = "@OLD_DESC";
            parmOldDesc.Value = sujet.Desc;
            cmd.Parameters.Add(parmOldDesc);

            con.Open();
            int nbLigne = cmd.ExecuteNonQuery();
            con.Close();
            return nbLigne;
        }
        /// <summary>
        /// La méthode AddSujet, permet l'ajout d'un nouveau sujet à la table sujet 
        /// dans la base de données
        /// </summary>
        /// <param name="idCategorie">L'identifiant de la catégorie</param>
        /// <param name="idUtilisateur">L'identifiant de l'utilisateur</param>
        /// <param name="description">La description du sujet</param>
        /// <param name="titre">Le titre su sujet</param>
        /// <returns>Le nombre de ligne, nbligne = 1, si tout se passe bien</returns>
        public static int AddSujet(int idUtilisateur, int idCategorie, string description, string titre)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "AddSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdUtilisateur = cmd.CreateParameter();
            parmIdUtilisateur.ParameterName = "@ID_UTILISATEUR";
            parmIdUtilisateur.Value = idUtilisateur;
            cmd.Parameters.Add(parmIdUtilisateur);

            SqlParameter parmIdCategorie = cmd.CreateParameter();
            parmIdCategorie.ParameterName = "@ID_CATEGORIE";
            parmIdCategorie.Value = idCategorie;
            cmd.Parameters.Add(parmIdCategorie);

            SqlParameter parmDescri = cmd.CreateParameter();
            parmDescri.ParameterName = "@DESCRIPTION";
            parmDescri.Value = description;
            cmd.Parameters.Add(parmDescri);

            SqlParameter parmTitre = cmd.CreateParameter();
            parmTitre.ParameterName = "@TITRE";
            parmTitre.Value = titre;
            cmd.Parameters.Add(parmTitre);

            con.Open();
            int nbLigne = cmd.ExecuteNonQuery();
            con.Close();
            return nbLigne;
        }

        /// <summary>
        /// La méthode DeleteSujet, permet la suppression d'un sujet
        /// dont l'id est passé en parametre
        /// </summary>
        /// <param name="idsujet">L'identifiant du sujet</param>
        /// <returns>Le nombre de lignes supprimées, nbligne = 1 si tout va bien</returns>
        public static int DeleteSujet(int idsujet)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DeleteSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdSujet = cmd.CreateParameter();
            parmIdSujet.ParameterName = "@ID_SUJET";
            parmIdSujet.Value = idsujet;
            cmd.Parameters.Add(parmIdSujet);

            con.Open();
            int nbLigne = cmd.ExecuteNonQuery();
            con.Close();
            return nbLigne;

        }
        #endregion

        #region "Methodes héritées et substituées"
        #endregion

        #region "Methodes à implementer pour les interfaces"
        #endregion 
    }
}
