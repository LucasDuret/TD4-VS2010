using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Domain;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liste des utilisateurs :");
            IUtilisateurRepository utilRepo = new UtilisateurRepository();
            IList<Utilisateur> utils = utilRepo.GetAll();
            foreach (Utilisateur util in utils) {
                Console.WriteLine(util);
            }
            Console.WriteLine();
            Console.WriteLine("Liste des livres :");
            ILivreRepository livreRepo = new LivreRepository();
            foreach (Livre livre in livreRepo.GetAll())
            {
                Console.WriteLine(livre);
            }
            Console.WriteLine();
            Console.WriteLine("Liste des livres empruntables :");
            IList<Livre> livresEmpruntables = livreRepo.GetEmpruntables();
            foreach (Livre livre in livresEmpruntables)
            {
                Console.WriteLine(livre);
            }
            Console.WriteLine();
            Console.WriteLine("Liste des emprunts :");
            IEmpruntRepository empruntRepo = new EmpruntRepository();
            foreach (Emprunt emprunt in empruntRepo.GetAll())
            {
                Console.WriteLine(emprunt);
            }
            Console.WriteLine();
            Console.WriteLine("Liste des emprunts non rendus :");
            foreach (Emprunt emprunt in empruntRepo.GetEmpruntsNonRendus())
            {
                Console.WriteLine(emprunt);
            }
            Console.WriteLine();
            Console.Write("Ajout d'un nouvel emprunt... ");
            Emprunt empr = new Emprunt(utils[0], livresEmpruntables[0]);
            empruntRepo.Save(empr);
            Console.WriteLine("Id : " + empr.Id);

            Console.WriteLine();
            Console.Write("Enregistrement d'un retour... ");
            empr.Rendu = true;
            empruntRepo.Save(empr);
            Console.WriteLine("Terminé");

            Console.WriteLine("\nTests OK !");

            Console.ReadKey();
        }
    }
}
