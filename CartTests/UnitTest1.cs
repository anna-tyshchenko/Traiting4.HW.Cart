using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using Traiting4.HW.Cart;

namespace CartTests
{
    public class Tests
    {
        Cart cart;

        [SetUp]
        public void Setup()
        {
            cart = new Cart("CartName");
            cart.AddItem("Chicken", 1, 30);
            cart.AddItem("Tomatoes", 5, 7);
        }

        [Test]
        public void AddSomeItem()
        {
            Assert.That(cart, Is.All.Not.Null);

        }
    }
}




/*Create tests for your e-shop cart to cover situations of:
adding items to  the shoppingCart
removing items from the shoppingCartdd
verifying correct price calculation
*/