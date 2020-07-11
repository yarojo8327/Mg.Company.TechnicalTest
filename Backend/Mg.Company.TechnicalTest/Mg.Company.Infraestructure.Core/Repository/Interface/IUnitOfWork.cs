using System;
using Mg.Company.Infraestructure.Core.Entities;

namespace Mg.Company.Infraestructure.Core.Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        Repository<Employee> EmployeeRepository { get; }

        Repository<ContractType> ContractTypeRepository { get; }

        new void Dispose();

        int Save();

    }
}
