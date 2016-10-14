using Fil_Rouge_ForumDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fil_Rouge_Forum
{
    class Sujet
    {


        #region "Property et attributs"
        //private List<Sujet> _Sujets = new List<Sujet>();

        //public List<Sujet> Sujets
        //{
        //    get { return _Sujets; }
        //}

        private int _IdSujet;

        public int IdSujet
        {
            get { return _IdSujet; }
            set { _IdSujet = value; }
        }

        private string _Desc;

        public string Desc
        {
            get { return _Desc; }
            set { _Desc = value; }
        }

        private DateTime  _Datecreation;

        public DateTime  Datecreation
        {
            get { return _Datecreation; }
            set { _Datecreation = value; }
        }

        private Categorie _Cat;

        public Categorie Cat
        {
            get { return _Cat; }
            set { _Cat = value; }
        }

        private string _Titre;

        public string Titre
        {
            get { return _Titre; }
            set { _Titre = value; }
        }

        private Utilisateur _Auteur;

        public Utilisateur Auteur
        {
            get { return _Auteur; }
            set { _Auteur = value; }
        }





        #endregion
        #region "Constructeurs"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idsujet"></param>
        /// <param name="desc"></param>
        /// <param name="categorie"></param>
        public Sujet(int Idsujet, string Desc, Categorie Cat, Utilisateur Auteur)
        {
            this._IdSujet = IdSujet;
            this._Cat = Cat;
            this._Desc = Desc;
            this._Datecreation = Datecreation;
            this._Titre = Titre;
            this._Auteur = Auteur;
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
