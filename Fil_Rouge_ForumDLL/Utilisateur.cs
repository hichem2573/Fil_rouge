using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fil_Rouge_ForumDLL
{
    /// <summary>
    /// Un utilisateur est identifier par son Login et son mot de passe 
    /// </summary>
    public class Utilisateur
    {

        #region "Property et attributs"

        /// <summary>
        /// L'identifiant de l'utilisateur
        /// </summary>
        private int _IdUtilisateur;

        public int IdUtilisateur
        {
            get { return _IdUtilisateur; }
            set { _IdUtilisateur = value; }
        }

        /// <summary>
        /// Le login de l'utilisateur, c'est son nom
        /// </summary>
        private string _Login;

        public string Login
        {
            get { return _Login; }
            set { _Login = value; }
        }

        /// <summary>
        /// Le mot de passe de l'utilisateur
        /// </summary>
        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        private bool _Role;

        public bool Role
        {
            get { return _Role; }
            set { _Role = value; }
        }



        #endregion

        #region "Constructeurs"
        /// <summary>
        /// Constructeur de l'utilisateur
        /// </summary>
        /// <param name="idutilisateur"> L'identifiant de l'utilisateur</param>
        /// <param name="login">Login de l'utilisateur</param>
        /// <param name="password">Le password de l'utilisateur</param>
        /// <param name="role">Le role de l'utilisateur ( Modérateur ou Utilistauer Connecter)</param>
        public Utilisateur(int idutilisateur, string login, string password, bool role)
        {
            this.IdUtilisateur = idutilisateur;
            this.Login = login;
            this.Password = password;
            this.Role = role;

        }
        #endregion

        #region "Methodes"
        #endregion

        #region "Methodes héritées et substituées"
        #endregion

        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
