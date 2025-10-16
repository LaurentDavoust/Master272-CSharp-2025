using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDauphine.ExerciceCompteBancaire
{
    public abstract class Compte
    {
        public double Solde { get; protected set; }
        private List<MouvementCompte> Mouvements { get; set; }
                            =new List<MouvementCompte>();

        protected void Mouvement(double montant, string typeMouvement="")
        {
            Mouvements.Add(new MouvementCompte(typeMouvement, montant));
            Solde += montant;
        }

        public void Deposer(double montant, string? libelle = null)
        {
            Mouvement(montant, libelle == null ? "Dépôt" : libelle);
        }


        public void Retrait(double montant, string? libelle=null)
        {
            Mouvement(-montant, libelle==null?"Retrait":libelle);
        }

        public bool Virement(
            Compte compteDestinataire,
            double montant
        )
        {
            if (Solde < montant) return false;
            Retrait(montant, "Virement sortant");
            compteDestinataire.Deposer(montant, "Virement entrant");
            return true;
        }
    }
}
