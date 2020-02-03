using Microsoft.VisualStudio.TestTools.UnitTesting;
using TariffComparer.BL;

namespace ProductTest
{
    [TestClass]
    public class ProductBTest
    {
        private readonly Product ProductInstanceB;
        public ProductBTest()
        {
            ProductInstanceB = new ProductB();
        }
        [TestMethod]
        public void Test_PackagedTariff_3500()
        {

            ProductInstanceB.CalculateAndSaveAnnualCost(3500);
            Assert.AreEqual(ProductInstanceB.AnnualCosts, 800);
        }
        [TestMethod]
        public void Test_PackagedTariff_4500()
        {

            ProductInstanceB.CalculateAndSaveAnnualCost(4500);
            Assert.AreEqual(ProductInstanceB.AnnualCosts, 950);
        }
        [TestMethod]
        public void Test_PackagedTariff_6000()
        {

            ProductInstanceB.CalculateAndSaveAnnualCost(6000);
            Assert.AreEqual(ProductInstanceB.AnnualCosts, 1400);
        }
    }
}
