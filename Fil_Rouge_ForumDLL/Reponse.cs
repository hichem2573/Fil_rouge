using Fil_Rouge_ForumDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fil_Rouge_Forum
{

    /// <summary>
    /// La classe reponse permet de voir toutes les reponse, concernant un sujet donnée 
    /// d'une rubrique donnée
    /// </summary>
    class Reponse
    {
       
        #region "Property et attributs"
        /// <summary>
        /// 
        /// </summary>
        private int _IdRep;

        public int IdRep
        {
            get { return _IdRep; }
            set { _IdRep = value; }
        }

        private string _TxtReponse;

        public string TxtReponse
        {
            get { return _TxtReponse; }
            set { _TxtReponse = value; }
        }

        private DateTime _Date;

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }


        private Sujet _Sujet;

        public Sujet Sujet
        {
            get { return _Sujet; }
            set { _Sujet = value; }
        }

        private Utilisateur _Utilisateur;

        public Utilisateur Utilisateur
        {
            get { return _Utilisateur; }
            set { _Utilisateur = value; }
        }


        private string _Auteur;

        public string Auteur
        {
            get { return _Auteur; }
            set { _Auteur = value; }
        }


        #endregion

        #region "Constructeurs"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="textrep"></param>
        /// <param name="date"></param>
        /// <param name="utilisateur"></param>
        /// <param name="sujet"></param>
        public Reponse(int id, string textrep, DateTime date, Utilisateur utilisateur, Sujet sujet)
        {
            this.IdRep = id;
            this.TxtReponse = textrep;
            this.Date = date;
            this.Utilisateur = utilisateur;
            this.Sujet = sujet;
            this.Auteur = utilisateur.Login;

        }
        #endregion

        #region "Methodes"

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetNomUtilisateur()
        {
            return Utilisateur.Login;

        }
        #endregion

        #region "Methodes héritées et substituées"
        #endregion

        #region "Methodes à implementer pour les interfaces"
        #endregion

    }

   
}
