namespace Mg.Company.Domain.Services.Factory
{
    class HourlyContract : ContractType
    {
        public override decimal GetAnnualSalary(decimal value)
        {
            return (120 * value) * 12;
        }
    }
}
