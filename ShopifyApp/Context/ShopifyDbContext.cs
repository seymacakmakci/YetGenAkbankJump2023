using Microsoft.EntityFrameworkCore;
using ShopifyApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifyApp.Context
{
    public class ShopifyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=;Port=5432;Database=ShopifySeyma;User Id=;Password=;\r\n");
        }
    }
}