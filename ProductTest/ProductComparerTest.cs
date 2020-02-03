using TariffComparer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TariffComparer.BL;
using System.Collections.Generic;

namespace ProductTest
{
    [TestClass]
    public class ProductComparerTest
    {
        private readonly IProductComparer ProductComparerInstance;
        public ProductComparerTest()
        {
            ProductComparerInstance = new ProductComparer();
        }
        [TestMethod]
        public void Test_SortProductList_3500()
        {

            List<Product> productList=ProductComparerInstance.CreateAndSortProductList(3500);
            Assert.IsTrue(productList[0].AnnualCosts<=productList[1].AnnualCosts);
        }
        [TestMethod]
        public void Test_PackagedTariff_4500()
        {

            List<Product> productList = ProductComparerInstance.CreateAndSortProductList(4500);
            Assert.IsTrue(productList[0].AnnualCosts <= productList[1].AnnualCosts);
        }
        [TestMethod]
        public void Test_PackagedTariff_6000()
        {

            List<Product> productList = ProductComparerInstance.CreateAndSortProductList(6000);
            Assert.IsTrue(productList[0].AnnualCosts <= productList[1].AnnualCosts);
        }
    }
}
