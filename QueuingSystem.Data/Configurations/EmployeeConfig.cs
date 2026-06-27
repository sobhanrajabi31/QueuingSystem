using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QueuingSystem.Shared.Entities;

namespace QueuingSystem.Data.Configurations
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> entity)
        {
            entity.HasIndex(x => x.Username)
                .IsUnique();

            entity.Property(x => x.Username)
                .IsRequired()
                .HasMaxLength(20);

            entity.Property(x => x.Password)
                .IsRequired();

            entity.Property(x => x.Role)
                .IsRequired()
                .HasMaxLength(1);
        }
    }
}
