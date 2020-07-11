using Mg.Company.Infraestructure.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mg.Company.Infraestructure.Core
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContractType>().HasData(
                new ContractType
                {
                    Id = 1,
                    Description = "Salario Mensual",
                    Active = true
                }
            );

            modelBuilder.Entity<ContractType>().HasData(
                new ContractType
                {
                    Id = 2,
                    Description = "Salario Por Hora",
                    Active = true
                }
            );

            modelBuilder.Entity<Employee>().HasData(
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
                }
            );
            modelBuilder.Entity<Employee>().HasData(
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
                }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 3,
                    FirstName = "Maria",
                    Surname = "Lopera",
                    SecondSurname = "Hernandez",
                    Document = "32489703",
                    ContractTypeId = 1,
                    SalaryValue = 1000000,
                    Active = true
                }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 4,
                    FirstName = "Daniel",
                    Surname = "Alvarez",
                    SecondSurname = "Acevedo",
                    Document = "20930323",
                    ContractTypeId = 1,
                    SalaryValue = 978500,
                    Active = true
                }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 5,
                    FirstName = "Gabriel",
                    Surname = "Alvarez",
                    SecondSurname = "Villa",
                    Document = "102930293",
                    ContractTypeId = 1,
                    SalaryValue = 2325000,
                    Active = true
                }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 6,
                    FirstName = "Maria",
                    Surname = "Fernanda",
                    SecondSurname = "Agudelo",
                    Document = "192839748",
                    ContractTypeId = 2,
                    SalaryValue = 18720,
                    Active = true
                }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 7,
                    FirstName = "Carlos",
                    Surname = "Villa",
                    SecondSurname = "Granada",
                    Document = "28309282",
                    ContractTypeId = 2,
                    SalaryValue = 20000,
                    Active = true
                }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 8,
                    FirstName = "Angela",
                    Surname = "Pelaez",
                    SecondSurname = "Rivera",
                    Document = "73829320",
                    ContractTypeId = 2,
                    SalaryValue = 12500,
                    Active = true
                }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 9,
                    FirstName = "Mateo",
                    Surname = "Henao",
                    SecondSurname = "Henao",
                    Document = "128982287",
                    ContractTypeId = 2,
                    SalaryValue = 9876,
                    Active = true
                }
            );


        }
    }
}
