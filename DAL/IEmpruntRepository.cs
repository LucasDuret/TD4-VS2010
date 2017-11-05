using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Interface d'accès aux emprunts
    /// </summary>
    public interface IEmpruntRepository
    {
        /// <summary>
        /// Récupère la liste des meprunts
        /// </summary>
        /// <returns></returns>
        IList<Emprunt> GetAll();

        /// <summary>
        /// Récupère la liste des meprunts non rendus (empruntés)
        /// </summary>
        /// <returns></returns>
        IList<Emprunt> GetEmpruntsNonRendus();

        /// <summary>
        /// Sauvegarde un emprunt
        /// </summary>
        /// <param name="emprunt">l'emprunt</param>
        void Save(Emprunt emprunt);
    }
}
