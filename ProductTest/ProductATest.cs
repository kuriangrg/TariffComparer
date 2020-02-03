using Microsoft.VisualStudio.TestTools.UnitTesting;
using TariffComparer.BL;

namespace ProductTest
{
    [TestClass]
    public class ProductATest
    {
        private readonly Product ProductInstanceA;
        public ProductATest()
        {
            ProductInstanceA = new ProductA();
        }
        [TestMethod]
        public void Test_BasicBill_3500()
        {
            ProductInstanceA.CalculateAndSaveAnnualCost(3500);
            Assert.AreEqual(ProductInstanceA.AnnualCosts, 830);
        }
        [TestMethod]
        public void Test_BasicBill_4500()
        {
            ProductInstanceA.CalculateAndSaveAnnualCost(4500);
            Assert.AreEqual(ProductInstanceA.AnnualCosts, 1050);
        }
        [TestMethod]
        public void Test_BasicBill_6000()
        {
            ProductInstanceA.CalculateAndSaveAnnualCost(6000);
            Assert.AreEqual(ProductInstanceA.AnnualCosts, 1380);
        }
    }
}
