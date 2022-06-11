using Microsoft.EntityFrameworkCore;
using ProductApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Data.Context
{
    public class ProductAppContext : DbContext
    {
        public ProductAppContext(DbContextOptions<ProductAppContext> options) : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ProductAppDatabase;Trusted_Connection=True;");
        //}


        public DbSet<Product> Products { get; set; }
        public DbSet<Sparepart> Spareparts { get; set; }
        public DbSet<ProductSparepart> ProductSpareparts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
