using System;
using System.Collections.Generic;
using System.Text;

namespace TariffComparer.BL
{
    public abstract class Product
    {
        public abstract string TariffName { get; }
        protected double _annualCosts;
        public double AnnualCosts { get { return _annualCosts; } }
        public abstract void CalculateAndSaveAnnualCost(int Consumption);

    }
}
