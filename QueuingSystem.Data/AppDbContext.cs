using Microsoft.EntityFrameworkCore;
using QueuingSystem.Data.Configurations;
using QueuingSystem.Shared.Entities;

namespace QueuingSystem.Data
{
    public sealed class AppDbContext : DbContext
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
