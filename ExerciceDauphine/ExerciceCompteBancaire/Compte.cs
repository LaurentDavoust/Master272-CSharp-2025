using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDauphine.ExerciceCompteBancaire
{
    public abstract class Compte
    {
        public double Solde { get; private set; }
        private List<MouvementCompte> Mouvements { get; set; }
                            =new List<MouvementCompte>();

        protected void Mouvement(double montant, string typeMouvement="")
        {
            Mouvements.Add(new MouvementCompte(typeMouvement, montant));
            Solde += montant;
        }

        public void Deposer(double montant)
        {
            Mouvement(montant, "Depot");
        }


        public void Retrait(double montant)
        {
            Mouvement(-montant, "Retrait");
        }
    }
}
