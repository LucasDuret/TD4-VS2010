using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Modélise un livre de la bibliothèque
    /// </summary>
    public class Livre
    {
        /// <summary>
        /// Identifiant du livre
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Numéro de série du livre (sur 14 caractères en tout)
        /// Voir http://fr.wikipedia.org/wiki/International_Standard_Book_Number
        /// </summary>
        public virtual string ISBN { get; set; }

        /// <summary>
        /// Titre du livre
        /// </summary>
        public virtual string Titre { get; set; }

        /// <summary>
        /// Nom de l'auteur du livre
        /// </summary>
        public virtual string Auteur { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Livre() { }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="titre"></param>
        /// <param name="auteur"></param>
        public Livre(string isbn, string titre, string auteur)
        {
            ISBN = isbn;
            Titre = titre;
            Auteur = auteur;
        }

        /// <summary>
        /// Décrit un livre
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Titre;
        }
    }
}
