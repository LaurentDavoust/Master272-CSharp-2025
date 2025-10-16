using ExerciceDauphine.ExerciceCompteBancaire;

namespace ExerciceDauphineTests
{
    [TestClass]
    public sealed class CompteCourantTests
    {
        [TestMethod]
        public void TestDepot()
        {
            var compte = new CompteCourant();
            compte.Deposer(100);
            Assert.AreEqual(100, compte.Solde);
        }

        [TestMethod]
        public void TestRetrait()
        {
            var compte = new CompteCourant();
            compte.Deposer(100);
            compte.Retrait(40);
            Assert.AreEqual(60, compte.Solde);
        }

        [TestMethod]
        public void TestInteret()
        {
            var compte = new CompteEpargne(new Utilisateur(), 0);
            compte.Deposer(100);
            compte.CalculInteret();
            Assert.AreEqual(100+0.03/365*100, compte.Solde);
        }

        [TestMethod]
        public void TestVirement()
        {
            var compte1= new CompteCourant(new Utilisateur(), 100);
            var compte2 = new CompteEpargne(new Utilisateur(), 50);
            compte1.Virement(compte2, 30);
            Assert.AreEqual(70, compte1.Solde);
            Assert.AreEqual(80, compte2.Solde);
        }
    }
}
