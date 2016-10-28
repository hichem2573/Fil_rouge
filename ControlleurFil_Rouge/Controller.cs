using Fil_Rouge_Forum;
using Fil_Rouge_ForumDLL;
using Fil_RougeDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlleurFil_Rouge
{
    /// <summary>
    /// La classe controller, permet de faire le lien entre la base de données
    /// Et le DAO 
    /// </summary>
    public static class Controller
    {
        #region Méthode Categories

        /// <summary>
        /// La methode static GetAllCategories, permet de voir toutes les catégorie du forum
        /// </summary>
        /// <returns>Tous les catégories du forum</returns>
        public static List<Categorie> GetAllCategories()
        {
            return CategorieDAO.GetAllCategories();
        }

        /// <summary>
        /// La methode GetCategorieByID, permet de recupérer une categorie, 
        /// en lui passant l'identifiant en parametre
        /// </summary>
        /// <param name="idcategorie">L'identifiant de la catégorie</param>
        /// <returns>La catégorie, de l'index passer en parametre</returns>
        public static Categorie GetCategorieByID(int idcategorie)
        {
            return CategorieDAO.GetCategorieByID(idcategorie);
        }

        #endregion

        #region Méthode Sujets

        /// <summary>
        /// La méthode GetAllSujets, permet de recupérer tous les sujets du forum
        /// </summary>
        /// <returns>La list des sujets</returns>
        public static List<Sujet> GetAllSujets()
        {
            return SujetDAO.GetAllSujets();
        }

        /// <summary>
        /// La méthode GetSujetsByCategorie, permet de recupérer tous les sujets
        /// d'une catégorie, dont l'identifiant est passé en parametre
        /// </summary>
        /// <param name="idcategorie">L'identifiant de la categorie</param>
        /// <returns>La liste des tous les sujets, d'une catégorie donnée</returns>
        public static List<Sujet> GetSujetsByCategorie(int idcategorie)
        {
            return SujetDAO.GetSujetsByCategorie(idcategorie);
        }

        /// <summary>
        /// La Méthode GetSujetByID, permet de retourné un sujet dont l'identifiant est passé en parametre
        /// </summary>
        /// <param name="idsujet">L'identifiant du sujet</param>
        /// <returns>Le sujet, dont l'identifiant est passé en paramatre </returns>
        public static Sujet GetSujetByID(int idsujet)
        {
            return SujetDAO.GetSujetByID(idsujet);
        }

        /// <summary>
        /// La méthode AddSujet, permet l'ajout d'un nouveau sujet à la table sujet 
        /// dans la base de données
        /// </summary>
        /// <param name="idCategorie">L'identifiant de la catégorie</param>
        /// <param name="idUtilisateur">L'identifiant de l'utilisateur</param>
        /// <param name="description">La description du sujet</param>
        /// <param name="titre">Le titre su sujet</param>
        /// <returns>Le nombre de ligne, nbligne = 1, si tout se passe bien</returns>
        public static int AddSujet(int idUtilisateur, int idCategorie, string description, string titre)
        {
            return SujetDAO.AddSujet(idUtilisateur, idCategorie, description, titre);
        }


        /// <summary>
        /// La méthode EditSujet, permet la modification du titre d'un sujet, et/ou la description
        /// on passant l'ancien sujet en parametre
        /// </summary>
        /// <param name="sujet">Sujet</param>
        /// <param name="newTitre">Nouveau Titre</param>
        /// <param name="newDescription">Nouvelle description</param>
        /// <returns>Le nombre des lignes affectées, nbligne = 1, si tout se passe bien</returns>
        public static int EditSujet(Sujet sujet, string newTitre, string newDescription)
        {
            return SujetDAO.EditSujet(sujet, newTitre, newDescription);
        }

        /// <summary>
        /// La méthode DeleteSujet, permet la suppression d'un sujet
        /// dont l'id est passé en parametre
        /// </summary>
        /// <param name="idsujet">L'identifiant du sujet</param>
        /// <returns>Le nombre de lignes supprimées, nbligne = 1 si tout va bien</returns>
        public static int DeleteSujet(int idsujet)
        {
            return SujetDAO.DeleteSujet(idsujet);
        }

        #endregion

        #region Méthode Reponses

        /// <summary>
        /// La méthodes GetAllReponseBySujet, permet de recupérer toutes les reponses
        /// d'un sujet. dont l'identifiant est passé en parametre
        /// </summary>
        /// <param name="idsujet">L'identifiant du sujet</param>
        /// <returns>Les reponses, concernant un sujet. Dont l'identifiant est passé en parametre</returns>
        /// 
        public static List<Reponse> GetAllReponseBySujet(int idSujet)
        {
            return ReponseDAO.GetAllReponseBySujet(idSujet);
        }

        /// <summary>
        /// La méthode AddReponse, permet d'ajouter une reponse au sujet passé en paramateur
        /// par un utilisateur connecté
        /// </summary>
        /// <param name="idSujet">L'identifiant du sujet concerné</param>
        /// <param name="idUtilisateur">L'identifiant de l'utilisateur, qui répond</param>
        /// <param name="texte">Le texte de la reponse</param>
        /// <returns></returns>
        public static int AddReponse(int idSujet, int idUtilisateur, string texte)
        {
            return ReponseDAO.AddReponse(idSujet, idUtilisateur, texte);
        }

        /// <summary>
        /// La méthode DeleteReponse, permet la suppression d'une reponse
        /// dont l'id est passé en parametre
        /// </summary>
        /// <param name="idsujet">L'identifiant de la reponse</param>
        /// <returns>Le nombre de lignes supprimées, nbligne = 1 si tout va bien</returns>
        public static int DeleteReponse(int idReponse)
        {
            return ReponseDAO.DeleteReponse(idReponse);
        }
        #endregion

        #region Méthode Utilisateurs

        /// <summary>
        /// La méthode login, permet à un utilisateur de s'identifier
        /// </summary>
        /// <param name="login">Le Login (NOM)</param>
        /// <param name="password">LE mot de passe</param>
        /// <returns></returns>
        public static Utilisateur Login(string login, string password)
        {
            return UtilisateurDAO.Login(login, password);
        }

        #endregion

    }
}
