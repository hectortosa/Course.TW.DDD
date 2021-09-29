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
            cart.AddProduct(new Product(){ Name = "iPad Pro" }, 2);
            cart.AddProduct(new Product(){ Name = "Hero Ink Pen" });

            Console.WriteLine("Items in the cart: ");
            foreach (var cartItem in cart.CartItems)
            {
                Console.WriteLine(cartItem.Product.Name);
            }

            Console.WriteLine("Deleting Hero Ink Pen...");
             cart.RemoveProduct(new Product(){ Name = "Hero Ink Pen" });

            Console.WriteLine("Items in the cart: ");
            foreach (var cartItem in cart.CartItems)
            {
                Console.WriteLine(cartItem.Product.Name);
            }
        }
    }
}
