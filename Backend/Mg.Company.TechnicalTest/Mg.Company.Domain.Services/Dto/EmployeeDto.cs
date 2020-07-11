namespace Mg.Company.Domain.Services.Dto
{
    public class EmployeeDto
    {
       
        public int Id { get; set; }

        public string Document { get; set; }        

        public string ContractTypeDescription { get; set; }

        public string FirstName { get; set; }
        
        public string Surname { get; set; }

        public decimal SalaryValue { get; set; }

        public string SecondSurname { get; set; }

        public decimal AnnualSalary { get; set; }

        public bool Active { get; set; }

    }
}
