using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Models
{
    public class Repository
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Category> Category { get; set; } = new List<Category>();

    }
}