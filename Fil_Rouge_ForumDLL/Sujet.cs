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

        private int _idSujet;

        public int IdSujet
        {
            get { return _idSujet; }
            set { _idSujet = value; }
        }

        private string _Desc;

        public string Desc
        {
            get { return _Desc; }
            set { _Desc = value; }
        }


        #endregion
        #region "Constructeurs"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idsujet"></param>
        /// <param name="desc"></param>
        /// <param name="categorie"></param>
        public Sujet(int idsujet, string desc, Categorie categorie)
        {
            _idSujet = idsujet;
            _Desc = desc;


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
