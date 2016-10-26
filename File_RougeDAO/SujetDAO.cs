using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fil_RougeDAO
{
    public static class SujetDAO
    {
        #region "Property et attributs"

        private static SqlConnection con = ConnexionSQLServer.GetConnexion();

        #endregion

        #region "Constructeurs"
        #endregion

        #region "Methodes"

        public static List<Sujet> GetAllSujets()
        {
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
        }
        #endregion

        #region "Methodes héritées et substituées"
        #endregion

        #region "Methodes à implementer pour les interfaces"
        #endregion 
    }
}
