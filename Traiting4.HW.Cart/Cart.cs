using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traiting4.HW.Cart
{
    public class Cart
    {
        public string Owner { get; set; }

        public Cart(string CartName)
        {
            if (CartName is not null)
            {
                Owner = CartName;
            }

            else
            {
                Owner = "Guest";

                ShowItemsInCart();
            }
        }
    private List<Item> cartItems = new List<Item>();



        public decimal Total
        {
            get
            {
               decimal total = 0;
               foreach (var item in cartItems)
               {
            total += item.Price * item.Quantity;
              }
               return total;
        }
    }
    public void ShowItemsInCart()
        {
            if (Total == 0)
            {
                Console.WriteLine($"Dear {Owner} Your cart is empty!");
            }
            else
            {
                Console.WriteLine($"Your list of products: ");
                foreach (var item in cartItems)
                { 
                    Console.WriteLine($"Name: {item.Name} -- Price: {item.Price} USD -- Amount: {item.Price * item.Quantity} USD");
                }
                Console.WriteLine($"Total Amount: {Total}");
                    
            }
        }

        public void AddItem(string name, int quantity, decimal price)
        {
            if (price <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(price), "The price should be greater then zero");
            }
            if (quantity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity), "The quantity should be greater then zero");

            }

            //var addeditem = cartItems.Find(n => n.Name.Equals(name));

            var addeditem = cartItems.FirstOrDefault(n => n.Name == name);

            if (addeditem != null)
            {
                addeditem.Quantity += quantity;
            }
            else
            {
                var item = new Item(name, quantity, price);
                cartItems.Add(item);
            }
        }

            public void RemoveItem(string name, int quantity)
            {
            // var item = cartItems.Find(n=> n.Name.Equals(name));
             var item = cartItems.FirstOrDefault(n => n.Name == name);

            if (quantity > item.Quantity)
            {
                item.Quantity -= quantity;
            }
            if (item == null)
            {
                throw new ArgumentNullException(nameof(quantity), "That item isn't added to your cart");
            }
            if (quantity == item.Quantity)
            {
                cartItems.Remove(item);
            }
        }

       


    }
}