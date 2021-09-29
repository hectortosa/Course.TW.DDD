using System;
using Shop.Domain;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to THE SHOP!");

            Cart cart = new Cart();
            cart.AddProduct(new Product(){ Name = "iPad Pro" });
            cart.AddProduct(new Product(){ Name = "Hero Ink Pen" });

            Console.WriteLine("Items in the cart: ");
            foreach (var product in cart.Products)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}
