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
    class Reponse
    {
       
        #region "Property et attributs"
        private int _IdRep;

        public int IdCate
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

        private string _Descr;

        public string Descr
        {
            get { return _Descr; }
            set { _Descr = value; }
        }


        #endregion

        #region "Constructeurs"
        #endregion

        #region "Methodes"
        #endregion

        #region "Methodes héritées et substituées"
        #endregion

        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
