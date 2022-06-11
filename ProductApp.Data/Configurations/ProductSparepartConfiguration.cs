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
    public class ProductSparepartConfiguration : IEntityTypeConfiguration<ProductSparepart>
    {
        public void Configure(EntityTypeBuilder<ProductSparepart> builder)
        {
            builder.HasKey(a => new { a.SparepartID, a.ProductID });      
            builder.HasOne(a => a.Product).WithMany(a => a.ProductSpareparts).HasForeignKey(a => a.ProductID);
            builder.HasOne(a => a.Sparepart).WithMany(a => a.ProductSpareparts).HasForeignKey(a => a.SparepartID);
        }
    }
}




