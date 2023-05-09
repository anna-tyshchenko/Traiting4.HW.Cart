using Traiting4.HW.Cart;
using System.Collections.Generic;
using System.Collections;
using System;


Console.WriteLine("Creating a new Shopping Cart");
var cart = new Cart("Anna");
Console.WriteLine("Let's see what we have");
cart.AddItem("Chicken", 1, 30 );
cart.AddItem("Tomatoes", 5, 7 );
cart.AddItem("Bananas", 3, 1 );


cart.ShowItemsInCart();

Console.WriteLine("Let's delete Chicken");
cart.RemoveItem("Chicken", 1);
cart.ShowItemsInCart();









