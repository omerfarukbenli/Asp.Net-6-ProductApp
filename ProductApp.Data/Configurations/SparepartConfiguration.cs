using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Data.Configurations
{
    public class SparepartConfiguration : IEntityTypeConfiguration<Sparepart>
    {
        public void Configure(EntityTypeBuilder<Sparepart> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.SparepartCode).IsRequired().HasMaxLength(50);
            builder.Property(x => x.SparepartName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.SparepartPrice).IsRequired().HasColumnType("int");
        }
    }
}
