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
    public class Reponse
    {

        #region "Property et attributs"
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

        private Sujet _Sujet;

        public Sujet Sujet
        {
            get { return _Sujet; }
            set { _Sujet = value; }
        }

        private DateTime _DateRep;

        public DateTime DateRep
        {
            get { return _DateRep; }
            set { _DateRep = value; }
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
        /// Constructeur de la reponse 
        /// </summary>
        /// <param name="idreponse">L'identifiant de la reponse</param>
        /// <param name="textrep">Le text de la reponse</param>
        /// <param name="date">Date de création de la reponse</param>
        /// <param name="utilisateur">l'utilisateur</param>
        /// <param name="sujet">Sujet au quel appartient la reponse</param>
        public Reponse(int idreponse, string textrep, DateTime date, Utilisateur utilisateur, Sujet sujet)
        {
            this.IdRep = idreponse;
            this.TxtReponse = textrep;
            this.DateRep = date;
            this.Utilisateur = utilisateur;
            this.Sujet = sujet;
            this.Auteur = utilisateur.Login;
        }
        #endregion

        #region "Methodes"

        /// <summary>
        /// La méthode permet de reccupèré le nom de l'utilisateur 
        /// </summary>
        /// <returns>Le login (nom de l'utilisateur)</returns>
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
