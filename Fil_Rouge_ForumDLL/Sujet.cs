using Fil_Rouge_ForumDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fil_Rouge_Forum
{
    /// <summary>
    /// La classe sujet, permet de voir tous les sujets d'une rubrique
    /// Pemet de voir les reponses, concernant un sujet
    /// Elle comporte un identifiant, titre du sujet, la description, la rubrique et les reponses
    /// </summary>
    class Sujet
    {

        #region "Property et attributs"
        /// <summary>
        /// La liste de reponse, concernant un sujet
        /// </summary>
        private List<Reponse> _Reponses;

        public List<Reponse> Reponses
        {
            get { return _Reponses; }
            set { _Reponses = value; }
        }

        /// <summary>
        /// l'identifiant du sujet
        /// </summary>
        private int _IdSujet;

        public int IdSujet
        {
            get { return _IdSujet; }
            set { _IdSujet = value; }
        }

        /// <summary>
        /// La description d'un sujet
        /// </summary>
        private string _Desc;

        public string Desc
        {
            get { return _Desc; }
            set { _Desc = value; }
        }

        /// <summary>
        /// La date de la création du sujet
        /// </summary>
        private DateTime _Datecreation;

        public DateTime Datecreation
        {
            get { return _Datecreation; }
            set { _Datecreation = value; }
        }

        /// <summary>
        /// La rubrique à la quelle appartient le sujet
        /// </summary>
        private Categorie _Cat;

        public Categorie Cat
        {
            get { return _Cat; }
            set { _Cat = value; }
        }

        /// <summary>
        /// Le titre du sujet
        /// </summary>
        private string _Titre;

        public string Titre
        {
            get { return _Titre; }
            set { _Titre = value; }
        }

        #endregion

        #region "Constructeurs"

        /// <summary>
        /// Constructeur d'un nouveau sujet, sans reponse
        /// </summary>
        /// <param name="id">L'identifiant du sujet</param>
        /// <param name="description">La description du sujet</param>
        /// <param name="titre">Le titre du sujet</param>
        /// <param name="categorie">La rubrique à la quelle appartient le sujet</param>
        public Sujet(int id, string description, string titre, Categorie categorie)
        {
            this.IdSujet = id;
            this.Desc = description;
            this.Titre = titre;
            this.Cat = categorie;
            this.Reponses = new List<Reponse>();
            this.Datecreation = DateTime.Now;
        }

        /// <summary>
        /// Constructeur d'un sujet, avec des reponse, on fait appel au constructeur du sujet sans reponse
        /// </summary>
        /// <param name="id">L'identifiant du sujet</param>
        /// <param name="description">La description du sujet</param>
        /// <param name="titre">Le titre du sujet</param>
        /// <param name="categorie">La rubrique du sujet</param>
        /// <param name="Reponses">Les reponses du sujet</param>
        public Sujet(int id, string description, string titre, Categorie categorie, List<Reponse> Reponses) : this(id, description, titre, categorie)
        {
            _Reponses = Reponses;
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
