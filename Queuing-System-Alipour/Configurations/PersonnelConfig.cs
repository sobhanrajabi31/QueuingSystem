using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Queuing_System_Alipour.Entities;

namespace Queuing_System_Alipour.Configurations
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
