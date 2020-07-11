using System;
using Mg.Company.Infraestructure.Core.Entities;
using Mg.Company.Infraestructure.Core.Repository.Interface;

namespace Mg.Company.Infraestructure.Core.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;
        private bool disposed = false;


        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
        }

        private Repository<Employee> employeeRepository;
      

        private Repository<ContractType> contractTypeRepository;

        public Repository<Employee> EmployeeRepository
        {
            get
            {
                if (this.employeeRepository == null)
                    this.employeeRepository = new Repository<Employee>(_context);

                return employeeRepository;
            }
        }
       
        public Repository<ContractType> ContractTypeRepository
        {
            get
            {
                if (this.contractTypeRepository == null)
                    this.contractTypeRepository = new Repository<ContractType>(_context);

                return contractTypeRepository;
            }
        }

        public void Dispose()
        {
            UWDispose(true);
            GC.SuppressFinalize(this);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }


        protected virtual void UWDispose(bool disposing)
        {
            if (!this.disposed && disposing)
            {
                _context.Dispose();
            }

            this.disposed = true;
        }
    }
}
