using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QueuingSystem.Shared.Entities;

namespace QueuingSystem.Data.Configurations
{
    public class PersonnelConfig : IEntityTypeConfiguration<Personnel>
    {
        public void Configure(EntityTypeBuilder<Personnel> entity)
        {
            entity.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(30);

            entity.Property(x => x.QueueCreatedAt)
                .IsRequired();

            entity.Property(x => x.QueueEndedAt)
                ;

            entity.Property(x => x.QueueStatus)
                .IsRequired();
        }
    }
}
