using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Interface d'accès aux livres
    /// </summary>
    public interface ILivreRepository
    {
        /// <summary>
        /// Récupère la liste des livres
        /// </summary>
        /// <returns></returns>
        IList<Livre> GetAll();

        /// <summary>
        /// Récupère la liste des livres mepruntables (non empruntés)
        /// </summary>
        /// <returns></returns>
        IList<Livre> GetEmpruntables();
    }
}
