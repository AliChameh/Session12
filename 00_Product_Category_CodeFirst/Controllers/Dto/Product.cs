using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00_Product_Category_CodeFirst.Controllers.Dto
{
    public class Product
    {
        public Guid Id { get; set; }
        public ProductCategory Category { get; set; }
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get { return Quantity * UnitPrice; } }

    }
}
