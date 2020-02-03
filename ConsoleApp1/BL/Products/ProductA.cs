using System;
using System.Collections.Generic;
using System.Text;

namespace TariffComparer.BL
{
    public class ProductA : Product
    {
        public override string TariffName
        {
            get
            {
                return "Basic Electricity Bill";
            }
        }
        public override void CalculateAndSaveAnnualCost(int consumption)
        {
            //Calculate annual cost
            _annualCosts = 60 + (consumption * 0.22);
        }

    }
}
