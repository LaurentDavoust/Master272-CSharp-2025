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
    }
}
