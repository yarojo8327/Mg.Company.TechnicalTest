using System.Collections.Generic;
using Mg.Company.Domain.Services.Dto;

namespace Mg.Company.Domain.Services.Interfaces
{
    public interface IEmployeesService
    {
        IEnumerable<EmployeeDto> GetAllEmployees();

        EmployeeDto GetEmployeesByDocumentNumber(string documentNumber);
    }
}
