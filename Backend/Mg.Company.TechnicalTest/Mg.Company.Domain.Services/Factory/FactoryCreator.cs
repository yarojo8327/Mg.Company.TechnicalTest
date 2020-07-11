using Mg.Company.Common.Utils;

namespace Mg.Company.Domain.Services.Factory
{
    internal class FactoryCreator
    {
        public static ContractType Creator(ContractTypes contractType)
        {
            switch (contractType)
            {
                case ContractTypes.HourlySalary:

                    return new HourlyContract();

                case ContractTypes.MonthlySalary:

                    return new MonthlyContract();

                default:
                    return null;
            }

        }
    }
}
