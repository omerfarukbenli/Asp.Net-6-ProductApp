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
    public class ProductSparepartSeed : IEntityTypeConfiguration<ProductSparepart>
    {
        public void Configure(EntityTypeBuilder<ProductSparepart> builder)
        {
            builder.HasData(
                    new ProductSparepart { ProductID = 1, SparepartID = 1 },
                     new ProductSparepart { ProductID = 1, SparepartID = 2 },
                      new ProductSparepart { ProductID = 2, SparepartID = 3 },
                       new ProductSparepart { ProductID = 2, SparepartID = 4 },
                        new ProductSparepart { ProductID = 3, SparepartID = 5 },
                         new ProductSparepart { ProductID = 3, SparepartID = 6 },
                          new ProductSparepart { ProductID = 4, SparepartID = 7 },
                           new ProductSparepart { ProductID = 4, SparepartID = 8 }
                    );
        }
    }
}
