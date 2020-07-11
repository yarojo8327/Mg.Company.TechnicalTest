using System;
using Mg.Company.Infraestructure.Core;
using Mg.Company.Infraestructure.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mg.Company.Domain.ServicesTests
{
    public static class ContextMock
    {
        private static ApplicationDbContext context;

        public static ApplicationDbContext Seed()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .EnableSensitiveDataLogging()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            context = new ApplicationDbContext(options);

            context.Employees.AddRange(
                new Employee
                {
                    Id = 1,
                    FirstName = "Yesion",
                    Surname = "Rojo",
                    SecondSurname = "Acevedo",
                    Document = "12345688",
                    ContractTypeId = 1,
                    SalaryValue = 1250000,
                    Active = true
                },
               new Employee
               {
                   Id = 2,
                   FirstName = "Jesus",
                   Surname = "Estiven",
                   SecondSurname = "Suarez",
                   Document = "89384937",
                   SalaryValue = 1050000,
                   ContractTypeId = 1,
                   Active = true
               });

            context.ContractTypes.AddRange(
                 new ContractType
                 {
                     Id = 1,
                     Description = "Salario Mensual",
                     Active = true
                 },
                new ContractType
                {
                    Id = 2,
                    Description = "Salario Por Hora",
                    Active = true
                });

            context.SaveChanges();
            return context;
        }
    }
}
