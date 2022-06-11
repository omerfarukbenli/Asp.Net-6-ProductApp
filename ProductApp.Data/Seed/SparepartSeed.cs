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
    public class SparepartSeed : IEntityTypeConfiguration<Sparepart>
    {
        public void Configure(EntityTypeBuilder<Sparepart> builder)
        {
            builder.HasData(
                    new Sparepart { Id = 1, SparepartCode = "1", SparepartName = "yedek parça 1", SparepartPrice = 100 },
                    new Sparepart { Id = 2, SparepartCode = "2", SparepartName = "yedek parça 2", SparepartPrice = 200 },
                    new Sparepart { Id = 3, SparepartCode = "3", SparepartName = "yedek parça 3", SparepartPrice = 300 },
                    new Sparepart { Id = 4, SparepartCode = "4", SparepartName = "yedek parça 4", SparepartPrice = 400 },
                    new Sparepart { Id = 5, SparepartCode = "5", SparepartName = "yedek parça 5", SparepartPrice = 500 },
                    new Sparepart { Id = 6, SparepartCode = "6", SparepartName = "yedek parça 6", SparepartPrice = 600 },
                    new Sparepart { Id = 7, SparepartCode = "7", SparepartName = "yedek parça 7", SparepartPrice = 700 },
                    new Sparepart { Id = 8, SparepartCode = "8", SparepartName = "yedek parça 8", SparepartPrice = 800 });
        }
    }
}
