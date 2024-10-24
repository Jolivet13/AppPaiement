using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiement
{
    internal class Utilisateur : Paiement
    {
        public string Nom { get; set; }
        public List<Paiement> Paiements { get; set; }

        public Utilisateur(decimal montant, string description,string nom) : base((double)montant, description)
        {
            Nom = nom;
            Paiements = new List<Paiement>();
        }

        public void AfficherInfos()
        {
            Console.WriteLine($"Nom: {Nom}");
            Console.WriteLine("Paiements:");
            foreach (var paiement in Paiements)
            {
                paiement.AfficherDetails();
            }
        }

        public void AjouterPaiement(Paiement paiement)
        {
            Paiements.Add(paiement);
        }
    }
}
