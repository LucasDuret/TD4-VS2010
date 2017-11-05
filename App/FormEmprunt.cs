using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Domain;

namespace App
{
    /// <summary>
    /// Dialogue de saisie d'un nouvel emprunt
    /// </summary>
    public partial class FormEmprunt : Form
    {
        public FormEmprunt(IList<Utilisateur> utilisateurs, IList<Livre> livres)
        {
            InitializeComponent();

            // Ajout des utilisateurs dans la liste déroulante
            cbUtil.Items.AddRange(utilisateurs.ToArray<Utilisateur>());
            if (cbUtil.Items.Count > 0)
            {
                // sélection du 1er élément de la liste
                cbUtil.SelectedIndex = 0;
            }

            // Ajout des livres dans la liste déroulante
            cbLivre.Items.AddRange(livres.ToArray<Livre>());
            if (cbLivre.Items.Count > 0)
            {
                // sélection du 1er élément de la liste
                cbLivre.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Renvoie l'utilisateur choisi comme emprunteur
        /// </summary>
        /// <returns></returns>
        public Utilisateur GetEmprunteur()
        {
            return (Utilisateur)cbUtil.SelectedItem;
        }

        /// <summary>
        /// Renvoie le livre emprunté
        /// </summary>
        /// <returns></returns>
        public Livre GetLivreEmprunte()
        {
            return (Livre)cbLivre.SelectedItem;
        }
    }
}
