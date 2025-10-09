using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDauphine
{
    public class Voiture
    {
        private const double ConversionKmMiles=0.621;
        public string Couleur { get; } = "Bleu";
        public double VitesseMaximale { get; set; } = 100;
        
        public double VitesseMaximaleMiles
        {
            get { return ConversionKmMiles * VitesseMaximale; }
        }

        public Voiture(string? couleur=null)
        {
            if(couleur!=null) Couleur = couleur;
        }

        public Voiture(
            string couleur, 
            double vitesseMaximale,
            double distanceParcourue=0.0)
        {
            Couleur = couleur;
            VitesseMaximale=vitesseMaximale;
            DistanceParcourue=distanceParcourue;
        }
        public double DistanceParcourue { get; set; }

        public void Trajet(double distance)
        {
            DistanceParcourue += distance;
        }

        public void Trajet(string distance)
        {
            if (distance.Contains("km"))
                Trajet(double.Parse(distance.Replace("km","")));
            else if(distance.Contains("miles"))
                Trajet(
                    double.Parse(distance.Replace("miles", ""))
                    /ConversionKmMiles);
            else
                throw new Exception("Données invalides ...");
        }
    }
}
