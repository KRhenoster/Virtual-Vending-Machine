using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
   public class Gum : VendingItem
    {
        public Gum(string productName, decimal price, int itemsRemaining) : base(productName, price, itemsRemaining)
        {
            //ProductName = productName;
            //Price = price;
            //ItemsRemaining = itemsRemaining;
        }
        
        public override string  ProductMessage()
        {
            return "Chew, Chew, Yum!";
        }
    }
}
