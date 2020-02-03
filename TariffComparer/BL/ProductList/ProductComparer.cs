using System.Collections.Generic;

namespace TariffComparer.BL
{
    public class ProductComparer : IProductComparer
    {
        public List<Product> CreateAndSortProductList(int consumption)
        {
            Product productA = new ProductA();
            productA.CalculateAndSaveAnnualCost(consumption);
            Product productB = new ProductB();
            productB.CalculateAndSaveAnnualCost(consumption);
            List<Product> productLIst = new List<Product>();
            productLIst.Add(productA);
            productLIst.Add(productB);
            productLIst.Sort((x, y) =>
                x.AnnualCosts.CompareTo(y.AnnualCosts));
            return productLIst;
        }
    }
}
