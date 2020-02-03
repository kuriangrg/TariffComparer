using TariffComparer.BL;
using System;
using System.Collections.Generic;

namespace TariffComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the consumption");
            int consumption = Convert.ToInt32(Console.ReadLine());
            IProductComparer productCompare = new ProductComparer();
            List<Product> productLIst = productCompare.CreateAndSortProductList(consumption);
            Console.WriteLine("Consumption List");
            Console.WriteLine("-----------------------");
            foreach (var product in productLIst)
            {
                Console.WriteLine(product.TariffName + " - " + product.AnnualCosts);
            }
        }

    }
    

}




