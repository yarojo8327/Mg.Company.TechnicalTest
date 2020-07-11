
namespace Mg.Company.Domain.Services.Factory
{
    class MonthlyContract : ContractType
    {
        public override decimal GetAnnualSalary(decimal value)
        {
            return value * 12;
        }
    }
}
