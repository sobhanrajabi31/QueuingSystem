using Microsoft.EntityFrameworkCore;
using Queuing_System_Alipour.Configurations;
using Queuing_System_Alipour.Entities;
using System.Configuration;

namespace Queuing_System_Alipour
{
    public sealed class AppDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connections.AppCS);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new AtelierConfig());
            modelBuilder.ApplyConfiguration(new PersonnelConfig());
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Atelier> Ateliers { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
    }
}
