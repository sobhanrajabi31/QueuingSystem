using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Queuing_System_Alipour.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queuing_System_Alipour.Configurations
{
    public class AtelierConfig : IEntityTypeConfiguration<Atelier>
    {
        public void Configure(EntityTypeBuilder<Atelier> entity)
        {
            entity.Property(x => x.FullName)
                .IsRequired()
                .HasMaxLength(30);

            entity.HasIndex(x => x.PhoneNumber)
                .IsUnique();

            entity.Property(x => x.PhoneNumber)
                .IsRequired()
                .HasMaxLength(11);

            entity.Property(x => x.QueueCreatedAt)
                .IsRequired();

            entity.Property(x => x.QueueDuration)
                .IsRequired();

            entity.Property(x => x.QueueStatus)
                .IsRequired();

            entity.Property(x => x.Note)
                .HasMaxLength(100);
        }
    }
}
