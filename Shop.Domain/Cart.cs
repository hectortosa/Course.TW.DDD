using System.Collections.Generic;

namespace Shop.Domain
{
    public class Cart
    {
        public List<CartItem> CartItems { get; set; }
        //Creo que ya están listos, pero no puedo lanzar la consola para los tests
        public Cart() => CartItems = new List<CartItem>();

        public void AddProduct(Product product, int quantity = 1)
        {
            CartItems.Add(new CartItem { Product = product, Quantity = quantity });
        }

        public void RemoveProduct(Product product)
        {
            CartItems.RemoveAll(item => item.Product.Name == product.Name);
        }
    }
}