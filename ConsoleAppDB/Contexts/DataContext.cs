using ConsoleAppDB.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDB.Contexts
{
    internal class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<AdressEntity> Adresses { get; set; }
        public DbSet<CategoriesEntity> Categories { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ManufactureEntity> Manufactures { get; set; }
        public DbSet<ProductPriceEntity> ProductPrices { get; set; }
        public DbSet<CurrencyEntity> Currencies { get; set; }





        
    }
}
