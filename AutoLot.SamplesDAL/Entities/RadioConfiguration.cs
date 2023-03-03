using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLot.SamplesDAL.Entities
{
    public class RadioConfiguration : IEntityTypeConfiguration<Radio>
    {
        public void Configure(EntityTypeBuilder<Radio> builder)
        {
            builder.Property(e => e.CarId).HasColumnName("InventoryId");
            builder.HasIndex(e => e.CarId, "IX_Radios_CarId").IsUnique();
            builder.HasOne(d => d.CarNavigation)
            .WithOne(p => p.RadioNavigation)
            .HasForeignKey<Radio>(d => d.CarId);
        }
    }
}
