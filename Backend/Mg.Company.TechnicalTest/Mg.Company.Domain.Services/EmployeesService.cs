using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Mg.Company.Common.Utils;
using Mg.Company.Domain.Services.Dto;
using Mg.Company.Domain.Services.Factory;
using Mg.Company.Domain.Services.Interfaces;
using Mg.Company.Infraestructure.Core.Entities;
using Mg.Company.Infraestructure.Core.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Mg.Company.Domain.Services
{
    public class EmployeesService : IEmployeesService
    {

        private readonly IUnitOfWork _unitOfWork;      
        private readonly IMapper _mapper;

        public EmployeesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;          
            this._mapper = mapper;
        }

        public IEnumerable<EmployeeDto> GetAllEmployees()
        {
            IEnumerable<Employee> employees = this._unitOfWork.EmployeeRepository.AsQueryable().Include(x => x.ContractType).ToList();

            List<EmployeeDto> listEmployees = (from e in employees
                                               select new EmployeeDto
                                               {
                                                   Id = e.Id,
                                                   Document = e.Document,
                                                   FirstName = e.FirstName,
                                                   Surname = e.Surname,
                                                   SecondSurname = e.SecondSurname,
                                                   ContractTypeDescription = e.ContractType.Description,
                                                   SalaryValue = e.SalaryValue,
                                                   AnnualSalary = CalculateSalary((ContractTypes)e.ContractTypeId, e.SalaryValue),
                                                   Active = e.Active

                                               }).ToList();

            return listEmployees.OrderBy(e => e.Document).ToList();
        }


        public EmployeeDto GetEmployeesByDocumentNumber(string documentNumber)
        {
            Employee employee = this._unitOfWork.EmployeeRepository.FirstOrDefault(e => e.Document.Equals(documentNumber), d => d.ContractType);

            if (employee == null)
                return null;            

            EmployeeDto oEmployee = _mapper.Map<EmployeeDto>(employee);
            oEmployee.ContractTypeDescription = employee.ContractType.Description;
            oEmployee.AnnualSalary = CalculateSalary((ContractTypes)employee.ContractTypeId, employee.SalaryValue);
            return oEmployee;


        }


        private decimal CalculateSalary(ContractTypes contractType, decimal SalaryValue)
        {
            Factory.ContractType contract =  FactoryCreator.Creator(contractType);
            return contract.GetAnnualSalary(SalaryValue);
        }
    }
}
