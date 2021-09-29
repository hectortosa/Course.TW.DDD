using System;
using System.Collections.Generic;

namespace Shop.Domain
{
    public class Cart
    {
        public List<Product> Products { get; set; }

        public Cart()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
    }
}