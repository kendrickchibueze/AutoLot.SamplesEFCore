using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLot.SamplesDAL.Entities
{
    public class DriverConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.OwnsOne(o => o.PersonInfo,
            pd =>
            {
                pd.Property<string>(nameof(Person.FirstName))
                    .HasColumnName(nameof(Person.FirstName))
                    .HasColumnType("nvarchar(50)");
                            pd.Property<string>(nameof(Person.LastName))
                    .HasColumnName(nameof(Person.LastName))
                    .HasColumnType("nvarchar(50)");
            });
            builder.Navigation(d => d.PersonInfo).IsRequired(true);
        }
    }
}

