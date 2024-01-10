using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Models
{
    public class Products
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}