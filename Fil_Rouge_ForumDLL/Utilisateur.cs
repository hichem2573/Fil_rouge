using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fil_Rouge_ForumDLL
{
    /// <summary>
    /// La classe Utilisateur permet à un utilisateur de s'identifier avec 
    /// son login (nom) et son mot de passe
    /// </summary>
    public class Utilisateur
    {

        #region "Property et attributs"
        /// <summary>
        /// Le login (nom) de l'utilisateur
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

        /// <summary>
        /// L'identifiant de l'utilisateur
        /// </summary>
        private int _IdUser;

        public int UdUser
        {
            get { return _IdUser; }
            set { _IdUser = value; }
        }

        /// <summary>
        /// Le role de l'utilisateur, soit il est modérateur ou un utilisateur logged
        /// </summary>
        private bool _IsRoleModera;

        public bool IsRoleModera
        {
            get { return _IsRoleModera; }
            set { _IsRoleModera = value; }
        }

        #endregion

        #region "Constructeurs"

        /// <summary>
        /// constructeur d'un utilisateur
        /// </summary>
        /// <param name="iduser">L'identifiant de l'utilisateur</param>
        /// <param name="login">Le login de l'utilisateur</param>
        /// <param name="password">Le mot de passe de l'utilisateur</param>
        /// <param name="role">Le role attribut à un utilisateur</param>
        public Utilisateur(int iduser, string login, string password, bool isRoleModera)
        {
            this._IdUser = iduser;
            this.Login = login;
            this.Password = password;
            this.IsRoleModera = isRoleModera;
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
