using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fil_Rouge_Forum
{
    /// <summary>
    /// 
    /// </summary>
    class Sujet
    {


        #region "Property et attributs"

        /// <summary>
        /// Liste de reponse, concernant un sujet
        /// </summary>
        private List<Reponse> _Reponses;

        public List<Reponse> Reponse
        {
            get { return _Reponses; }

            set { _Reponses = value; }
        }

        /// <summary>
        /// Idetifiant du sujet
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
        /// Date de création d'un sujet
        /// </summary>
        private DateTime  _Datecreation;

        public DateTime  Datecreation
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
       /// constructeur d'un nouveau sujet sans aucune reponse
       /// </summary>
       /// <param name="id">L'identifiant du sujet</param>
       /// <param name="titre">Titre de sujet</param>
       /// <param name="description">La description du sujet</param>
       /// <param name="categorie">La rebrique a la quelle appartient le sujet</param>
       public Sujet(int id, string titre, string description, Categorie categorie)
        {
            this.IdSujet = id;
            this.Desc = description;
            this.Titre = titre;
            this.Datecreation = DateTime.Now;
            this.Reponse = new List<Reponse>();
            this.Cat = categorie;
        }

        //public Sujet(int id, string titre)
        //{
        //    IdSujet = id;
        //    Titre = titre;
        //}

        /// <summary>
        /// Constructeur d'un sujet ayant des reponses
        /// </summary>
        /// <param name="id">L'identifiant du sujet</param>
        /// <param name="description">La description du sujet</param>
        /// <param name="titre">Le titre du sujet</param>
        /// <param name="categorie">La rebrique à la quelle appartient le sujet</param>
        /// <param name="Reponses">Les reponse du sujet</param>
        public Sujet(int id, string description, string titre, Categorie categorie, List<Reponse> Reponses): this(id, titre, description, categorie)
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
