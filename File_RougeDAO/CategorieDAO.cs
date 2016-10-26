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
    /// CategorieDAO, permet de récupérer les catégories, qui se trouvent dans la base de données
    /// </summary>
    public static class CategorieDAO
    {
        #region "Property et attributs"

        private static SqlConnection con = ConnexionSQLServer.GetConnexion();

        #endregion

        #region "Constructeurs"
        #endregion

        #region "Methodes"
        
        /// <summary>
        /// La méthodes GetAllCategories, permet de récupérer toutes les catégories
        /// enregistrées dans la base de données
        /// </summary>
        /// <returns>Les Catégories existant dans la bdd</returns>
        public static List<Categorie> GetAllCategories()
        {
            // con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllCategories";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Categorie");
            da.Fill(dt);
            //con.Close();

            if(dt.Rows.Count >= 1)
            {
                List<Categorie> _Categories = new List<Categorie>();
                foreach(DataRow row in dt.Rows)
                {
                    Categorie cat = new Categorie(int.Parse(row["ID_CATEGORIE"].ToString()), row["NOM_CATEGORIE"].ToString(), row["DESCRIPTION"].ToString());
                    cat.IdCat = int.Parse(row["ID_CATEGORIE"].ToString());
                    _Categories.Add(cat);
                }
                return _Categories;
            }
            return null;
        }

        /// <summary>
        /// La méthode GetCategorieById, permet de récuperer une catégorie 
        /// dont le l'identifiant est passé en parametre
        /// </summary>
        /// <param name="idcategorie">L'identifiant de la catégorie</param>
        /// <returns>La categorie</returns>
        public static Categorie GetCategorieByID(int idcategorie)
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetCategorieById";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@IdCategorie";
            parm.Value = idcategorie;
            cmd.Parameters.Add(parm);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Categorie");
            da.Fill(dt);
            //con.Close();

            if(dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                Categorie cat = new Categorie(idcategorie, row["NOM_CATEGORIE"].ToString(), row["DESCRIPTION"].ToString());
                return cat;
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
