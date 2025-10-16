using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDauphine.ExerciceCompteBancaire
{
    public class CompteEpargne:CompteCourant
    {
        private static double TauxInteret = 0.03;
        private const double Taux = 0.04;
        public void CalculInteret()
        {
            Mouvement(
                TauxInteret * Solde/365.0, 
                "intérêt du jour"
                );
        }
    }
}
