using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ILivreRepository livreRepository = new LivreRepository();
            IUtilisateurRepository utilisateurRepository = new UtilisateurRepository();
            IEmpruntRepository empruntRepository = new EmpruntRepository();            
            Application.Run(new MainForm(livreRepository, utilisateurRepository, empruntRepository));
        }
    }
}
