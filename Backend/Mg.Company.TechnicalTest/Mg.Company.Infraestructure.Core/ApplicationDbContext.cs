using Mg.Company.Infraestructure.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mg.Company.Infraestructure.Core
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }


        public DbSet<Employee> Employees { get; set; }

        public DbSet<ContractType> ContractTypes { get; set; }
    }
}
