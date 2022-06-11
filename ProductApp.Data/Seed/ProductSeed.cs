using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Data.Seed
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                    new Product { Id = 1, ProductCode = "1", ProductName = "ürün1", ProductPrice = 1000 },
                    new Product { Id = 2, ProductCode = "2", ProductName = "ürün2", ProductPrice = 2000 },
                    new Product { Id = 3, ProductCode = "3", ProductName = "ürün3", ProductPrice = 3000 },
                    new Product { Id = 4, ProductCode = "4", ProductName = "ürün4", ProductPrice = 4000 });
        }
    }
}
