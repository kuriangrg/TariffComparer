using System;
using System.Collections.Generic;
using System.Text;

namespace TariffComparer.BL
{
    public interface IProductComparer
    {
        public List<Product> CreateAndSortProductList(int consumption);
    }
}
