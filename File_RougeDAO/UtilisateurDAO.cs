using Fil_Rouge_ForumDLL;
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
    /// La classe UtilisateurDAO, permet d'accèdé aux données, et interagir avec la base de données.
    /// </summary>
    public static class UtilisateurDAO
    {
        #region "Property et attributs"

        private static SqlConnection con = ConnexionSQLServer.GetConnexion();

        #endregion

        #region "Constructeurs"
        #endregion

        #region "Methodes"

        /// <summary>
        /// La méthode login, permet à un utilisateur de s'identifier
        /// </summary>
        /// <param name="login">Le Login (NOM)</param>
        /// <param name="password">LE mot de passe</param>
        /// <returns></returns>
        public static Utilisateur Login( string login, string password)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetLoginPassword";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmLogin = cmd.CreateParameter();
            parmLogin.ParameterName = "@LOGIN";
            parmLogin.Value = login;
            cmd.Parameters.Add(parmLogin);

            SqlParameter parmMPD = cmd.CreateParameter();
            parmMPD.ParameterName = "@PASSWORD";
            parmMPD.Value = password;
            cmd.Parameters.Add(parmMPD);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Login");
            da.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                return GetUtilisateurByID(int.Parse(row["ID_UTILISATEUR"].ToString()));
            }
            return null;

        }

        public static Utilisateur GetUtilisateurByID( int iduser)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetUserByID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@ID_UTILISATEUR";
            parm.Value = iduser;
            cmd.Parameters.Add(parm);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Utilisateur");
            da.Fill(dt);
            //con.Close();

            if(dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                Utilisateur user = new Utilisateur(int.Parse(row["ID_UTILISATEUR"].ToString()), row["LOGIN"].ToString(), row["PASSWORD"].ToString(), (bool)row["ROLEMODERA"]);
                return user;
            }
            return null;
        }

        public static List<Utilisateur> GetAllUsers()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllUtilisateurs";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Utilisateur");
            //con.Close();

            if(dt.Rows.Count >= 1)
            {
                List<Utilisateur> _Utilisateurs = new List<Utilisateur>();
                foreach(DataRow row in dt.Rows)
                {
                    Utilisateur user = new Utilisateur(int.Parse(row["ID_UTILISATEUR"].ToString()), row["LOGIN"].ToString(), row["PASSWORD"].ToString(), (bool)row["ROLEMODERA"]);
                    _Utilisateurs.Add(user);
                }
                return _Utilisateurs;
            }
            return null;

        }
        #endregion

        #region "Methodes héritées et substituées"
        #endregion

        #region "Methodes à implementer pour les interfaces"
        #endregion
    }
}
