using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Models
{
    public static class Repository
    {
        public static List<Product> Products { get; set; } = new List<Product>();
        public static List<Category> Categories { get; set; } = new List<Category>();

        public static void AddCategory(Category category)
        {

            Categories.Add(category);
        }
        public static void AddProduct(Product product)
        {

            Products.Add(product);
        }

    }
}