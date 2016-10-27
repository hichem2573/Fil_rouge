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
    /// La classe ReponseDAO, permet la recupération des toutes les reponses, l'ajout d'une reponse à un sujet etc...
    /// dans la table reponse de notre base de données
    /// </summary>
    public static class ReponseDAO
    {
        #region "Property et attributs"

        private static SqlConnection con = ConnexionSQLServer.GetConnexion();

        #endregion

        #region "Constructeurs"
        #endregion

        #region "Methodes"

        /// <summary>
        /// La méthodes GetAllReponseBySujet, permet de recupérer toutes les reponses
        /// d'un sujet. dont l'identifiant est passé en parametre
        /// </summary>
        /// <param name="idsujet">L'identifiant du sujet</param>
        /// <returns>Les reponses, concernant un sujet. Dont l'identifiant est passé en parametre</returns>
        /// 
        public static List<Reponse> GetAllReponseBySujet( int idSujet)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllReponseByIdSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@IdSujet";
            parm.Value = idSujet;
            cmd.Parameters.Add(parm);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Reponse");
            da.Fill(dt);

            if(dt.Rows.Count >= 1)
            {
                List<Reponse> _Reponses = new List<Reponse>();
                foreach(DataRow row in dt.Rows)
                {
                    Reponse rep = new Reponse(int.Parse(row["ID_REPONSE"].ToString()), row["TEXT_REPONSE"].ToString(), DateTime.Parse(row["DATECREATION"].ToString()), UtilisateurDAO.GetUtilisateurByID(int.Parse(row["ID_UTILISATEUR"].ToString())), SujetDAO.GetSujetByID(idSujet));
                    _Reponses.Add(rep);
                }
                return _Reponses;
            }
            return null;

        }

        /// <summary>
        /// La méthode AddReponse, permet d'ajouter une reponse au sujet passé en paramateur
        /// par un utilisateur connecté
        /// </summary>
        /// <param name="idSujet">L'identifiant du sujet concerné</param>
        /// <param name="idUtilisateur">L'identifiant de l'utilisateur, qui répond</param>
        /// <param name="texte">Le texte de la reponse</param>
        /// <returns></returns>
        public static int AddReponse(int idSujet, int idUtilisateur, string texte)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "AddReponse";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdSujet = cmd.CreateParameter();
            parmIdSujet.ParameterName = "@ID_SUJET";
            parmIdSujet.Value = idSujet;
            cmd.Parameters.Add(parmIdSujet);

            SqlParameter parmIdUtilisateur = cmd.CreateParameter();
            parmIdUtilisateur.ParameterName = "@ID_UTILISATEUR";
            parmIdUtilisateur.Value = idUtilisateur;
            cmd.Parameters.Add(parmIdUtilisateur);

            SqlParameter parmText = cmd.CreateParameter();
            parmText.ParameterName = "@TEXT_REPONSE";
            parmText.Value = texte;
            cmd.Parameters.Add(parmText);

            con.Open();
            //excute une action T-SQL sur la connexion et retourne le nombres de lignes affectéess
            int nbLigne = cmd.ExecuteNonQuery();
            con.Close();
            return nbLigne;
        }

        /// <summary>
        /// La méthode DeleteReponse, permet la suppression d'une reponse
        /// dont l'id est passé en parametre
        /// </summary>
        /// <param name="idsujet">L'identifiant de la reponse</param>
        /// <returns>Le nombre de lignes supprimées, nbligne = 1 si tout va bien</returns>
        public static int DeleteReponse(int idReponse)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DeleteReponse";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdRep = cmd.CreateParameter();
            parmIdRep.ParameterName = "@ID_REPONSE";
            parmIdRep.Value = idReponse;
            cmd.Parameters.Add(parmIdRep);

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
