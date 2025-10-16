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
            var compte = new CompteEpargne();
            compte.Deposer(100);
            compte.CalculInteret();
            Assert.AreEqual(100+0.03/365*100, compte.Solde);
        }
    }
}
