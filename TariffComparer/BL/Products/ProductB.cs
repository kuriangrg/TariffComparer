namespace TariffComparer.BL
{
    public class ProductB : Product
    {
        public override string TariffName   // overriding property
        {
            get
            {
                return "Packaged tariff";
            }
        }
        public override void CalculateAndSaveAnnualCost(int consumption)
        {
            //Calculate annual cost
            _annualCosts = consumption > 4000 ? (800 + ((consumption - 4000) * 0.3)) : 800;
        }
    }
}
