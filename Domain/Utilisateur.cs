using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Modélise un utilisateur de la bibliothèque
    /// </summary>
    public class Utilisateur
    {
        /// <summary>
        /// IDentifiant de l'utilisateur
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Nom de l'utilisateur
        /// </summary>
        public virtual string Nom { get; set; }

        /// <summary>
        /// Prénom de l'utilisateur
        /// </summary>
        public virtual string Prenom { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Utilisateur() { }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        public Utilisateur(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        /// <summary>
        /// Décrit un utilisateur
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Prenom + " " + Nom;
        }
    }
}
