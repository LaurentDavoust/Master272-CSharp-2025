using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDauphine.ExerciceCompteBancaire
{
    public class CompteCourant:Compte
    {
        public Utilisateur Utilisateur { get; private set; }

        public CompteCourant()
        {
            Utilisateur = new Utilisateur();
        }
        public CompteCourant(
            Utilisateur utilisateur,
            double soldeInitial = 0
            )
        {
            Utilisateur= utilisateur;
            Solde = Solde;
        }
    }
}
