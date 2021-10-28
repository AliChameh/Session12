using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _00_Product_Category_CodeFirst.Models.DomainModels
{
    public class SimpleDbContext:DbContext
    {
        #region [- ctor -]
        public SimpleDbContext()
        {

        }
        #endregion

        #region [- OnConfiguring(DbContextOptionsBuilder optionsBuilder) -]
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Session12_MVC_00_Product_Category_CodeFirst;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        } 
        #endregion

        #region [- Aggregates -]
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<Product> Product { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
