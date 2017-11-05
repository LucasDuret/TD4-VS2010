using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Modélise un emprunt d'un livre par un utilisateur
    /// </summary>
    public class Emprunt
    {
        /// <summary>
        /// Identifiant de l'emprunt
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Date de l'emprunt
        /// </summary>
        public virtual DateTime Date { get; set; }

        /// <summary>
        /// L'emprunt est-il déjà rendu ?
        /// </summary>
        public virtual bool Rendu { get; set; }

        /// <summary>
        /// Utilisateur qui a emprunté le livre
        /// </summary>
        public virtual Utilisateur Emprunteur { get; set; }

        /// <summary>
        /// Livre emprunté
        /// </summary>
        public virtual Livre Livre { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Emprunt() { }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="emprunteur"></param>
        /// <param name="livre"></param>
        public Emprunt(Utilisateur emprunteur, Livre livre)
        {
            Emprunteur = emprunteur;
            Livre = livre;
            Date = DateTime.Now;
            Rendu = false;
        }

        //TODO
    }
}
