using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Drink : VendingItem
    {
        public Drink(string productName, decimal price, int itemsRemaining) : base(productName, price, itemsRemaining)
        {
            //ProductName = productName;
            //Price = price;
            //ItemsRemaining = itemsRemaining;
        }
       
        public override string ProductMessage()
        {
            return "Glug, Glug, Yum!";
        }
    }
}
