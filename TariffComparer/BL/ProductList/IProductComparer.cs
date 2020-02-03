using System.Collections.Generic;

namespace TariffComparer.BL
{
    public interface IProductComparer
    {
        public List<Product> CreateAndSortProductList(int consumption);
    }
}
