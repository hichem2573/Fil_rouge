using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fil_Rouge_Forum
{
    /// <summary>
    /// La classe catégorie, se compose d'un identifiant unique pour chaque rubrique
    /// Le nom de celle-ci (libelle) et une description pour chaque catégorie
    /// </summary>
    public class Categorie
    {

        #region "Property et attributs"

        /// <summary>
        /// L'identifiant de la rubrique
        /// </summary>
        private int _IdCat;

        public int IdCat
        {
            get { return _IdCat; }
            set { _IdCat = value; }
        }

        /// <summary>
        /// Le libelle de la rubrique
        /// </summary>
        private string _Nom;

        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        /// <summary>
        /// La description de la rubrique
        /// </summary>
        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        #endregion

        #region "Constructeurs"

        /// <summary>
        /// Constructeur d'une catégorie
        /// </summary>
        /// <param name="identifiant">L'identifiant de la rubrique</param>
        /// <param name="libelle">Le nom de la rubrique</param>
        /// <param name="description">La description de la rubrique</param>
        public Categorie(int identifiant, string libelle, string description)
        {
            this.IdCat = identifiant;
            this.Nom = libelle;
            this.Description = description;
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
