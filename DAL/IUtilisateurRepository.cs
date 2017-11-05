using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Interface d'accès aux utilisateurs de la bibliothèque
    /// </summary>
    public interface IUtilisateurRepository
    {
        /// <summary>
        /// Récupère la liste des utilisateurs
        /// </summary>
        /// <returns></returns>
        IList<Utilisateur> GetAll();
    }
}
