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
            Assert.True(cart.Products.Count > 0);
        }

        [Fact]
        public void EmptyCart_AddProductHeroInkPen_CartHasItInProducts()
        {
            Cart cart = new Cart();
            cart.AddProduct(new Product{ Name = "Hero Ink Pen"});
            Assert.Equal("Hero Ink Pen", cart.Products[0].Name);
        }
    }
}
