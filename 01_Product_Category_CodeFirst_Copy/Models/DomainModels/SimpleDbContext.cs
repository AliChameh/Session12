using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_Product_Category_CodeFirst_Copy.Models.DomainModels
{
    public class SimpleDbContext : DbContext
    {
        #region [- ctor -]
        public SimpleDbContext()
        {

        }
        #endregion

        #region [- Aggregates -]
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        #endregion

        #region [-  OnConfiguring(DbContextOptionsBuilder optionsBuilder) -]
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Session12_Product_Category_Copy;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
        #endregion
    }
}
