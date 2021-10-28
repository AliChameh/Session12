using System;

namespace _00_Product_Category_CodeFirst.Models.DomainModels
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public ProductCategory Category { get; set; }
        public decimal Price { get { return Quantity * UnitPrice; } }

    }
}
