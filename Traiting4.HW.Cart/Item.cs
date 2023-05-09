using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Traiting4.HW.Cart
{
    public class Item
    {
        // Properties
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; }

        // Constructor
        public Item(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
};
