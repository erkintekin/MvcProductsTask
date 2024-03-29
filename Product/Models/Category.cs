using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Models
{
    public class Category
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Products> Products { get; set; } = new List<Products>();
    }
}