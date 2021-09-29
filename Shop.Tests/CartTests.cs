using System;
using Xunit;
using Shop.Domain;

namespace Shop.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyCart_AddProduct_CartHasProducts()
        {
            Cart cart = new Cart();
            cart.AddProduct(new Product{ Name = "iPad Pro"});
            Assert.True(cart.CartItems.Count > 0);
        }

        [Fact]
        public void EmptyCart_AddProductHeroInkPen_CartHasItInProducts()
        {
            Cart cart = new Cart();
            cart.AddProduct(new Product{ Name = "Hero Ink Pen"});
            Assert.Equal("Hero Ink Pen", cart.CartItems[0].Product.Name);
        }

        [Fact]
        public void EmptyCart_AddProductHeroInkPenWithQuantity2_CartHasItInProductsTwice()
        {
            Cart cart = new Cart();
            cart.AddProduct(new Product{ Name = "Hero Ink Pen"}, 2);
            Assert.Equal(2, cart.CartItems[0].Quantity);
        }

        [Fact]
        public void CartWithOneProduct_RemoveProduct_CartEmpty()
        {
            Cart cart = new Cart();
            Product product = new Product(){ Name = "Hero Ink Pen"};
            cart.AddProduct(product, 2);
            cart.RemoveProduct(product);
            Assert.True(cart.CartItems.Count == 0);
        }

         [Fact]
        public void CartWithOneProduct_RemoveProduct_CartHasRemovedItem()
        {
            Cart cart = new Cart();
            Product product = new Product(){ Name = "Hero Ink Pen"};
            cart.AddProduct(product, 2);
            cart.RemoveProduct(product);
            Assert.True(cart.DomainEvents.Count == 1);
        }

        [Fact]
        public void TwoCartWithSameProduct_RemoveProduct_CartHasRemovedItem()
        {
            Cart cart1 = new Cart(){CartId = 1};
            Cart cart2 = new Cart(){CartId = 2};
            Product product = new Product(){ Name = "Hero Ink Pen"};
            cart1.AddProduct(product);
            cart2.AddProduct(product);
            Assert.False(cart1.equals(cart2));
        }
    }
}
