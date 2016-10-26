using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fil_RougeDAO
{
    /// <summary>
    /// La classe ConnexionSQLServer permet la connexion à la base de données
    /// </summary>
    public static class ConnexionSQLServer
    {
        private static string connexionString = Properties.Settings.Default.InfoConnexion;

        /// <summary>
        /// La méthode static qui renvoie, une connexion à la base de données
        /// </summary>
        /// <returns>La connexion à la base de données</returns>
        public static SqlConnection GetConnexion()
        {
            SqlConnection connexion = new SqlConnection();
            connexion.ConnectionString = connexionString;

            return connexion;
        }

    }
}
