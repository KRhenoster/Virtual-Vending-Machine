using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Chip : VendingItem
    {
        public Chip(string productName, decimal price, int itemsRemaining) : base(productName, price, itemsRemaining)
        {
            //ProductName = productName;
            //Price = price;
            //ItemsRemaining = itemsRemaining;
        }
      

        public override string ProductMessage()
        {
            return "Crunch, Crunch, Yum!";
        }
    }
}
