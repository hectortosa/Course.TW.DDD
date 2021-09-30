using System.Collections.Generic;

namespace Shop.Domain
{
    public class Cart
    {
        public int CartId {get;set;}
        public List<CartItem> CartItems { get; set; }
        public List<DomainEvent> DomainEvents { get; set; }
        public Cart() {CartItems = new List<CartItem>();
        DomainEvents= new List<DomainEvent>();}

        public void AddProduct(Product product, int quantity = 1)
        {
            CartItems.Add(new CartItem { Product = product, Quantity = quantity });
        }

        public void RemoveProduct(Product product)
        {
            CartItems.RemoveAll(item => item.Product.Name == product.Name);
            DomainEvents.Add(new DomainEvent { Name = product.Name, Type = "Remove"});
        }
    }
}