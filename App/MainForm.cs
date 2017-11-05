using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    /// <summary>
    /// Fenêtre principale de l'IHM
    /// </summary>
    public partial class MainForm : Form
    {
        private ILivreRepository livreRepository;
        private IUtilisateurRepository utilisateurRepository;
        private IEmpruntRepository empruntRepository;

        public MainForm(ILivreRepository livreRepository,
            IUtilisateurRepository utilisateurRepository,
            IEmpruntRepository empruntRepository)
        {
            InitializeComponent();

            this.utilisateurRepository = utilisateurRepository;
            //TODO

            AfficherContenu();
        }

        /// <summary>
        /// Rempllt les trois tableaux de l'IHM : utilisateurs, livres, emprunts
        /// </summary>
        private void AfficherContenu()
        {
            dgvUtils.Rows.Clear();  // suppression des éventuelles lignes existantes

            // Accès à la liste des utilisateurs et remplissage du tableau
            foreach (Utilisateur utilisateur in utilisateurRepository.GetAll())
            {
                string[] ligne = { utilisateur.Id.ToString(), utilisateur.Nom, utilisateur.Prenom };
                dgvUtils.Rows.Add(ligne);
            }
            // tri sur la 1ère colonne (id)
            dgvUtils.Sort(dgvUtils.Columns[0], ListSortDirection.Ascending);

            //TODO
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNouvelEmprunt_Click(object sender, EventArgs e)
        {
            FormEmprunt dlgEmprunt = new FormEmprunt(utilisateurRepository.GetAll(),
                livreRepository.GetEmpruntables());
            if (dlgEmprunt.ShowDialog() == DialogResult.OK)
            {
                //TODO

                AfficherContenu();
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
