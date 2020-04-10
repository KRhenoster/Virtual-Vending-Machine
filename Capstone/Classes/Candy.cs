using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Candy : VendingItem
    {
        public Candy(string productName, decimal price, int itemsRemaining) : base(productName,price,itemsRemaining)
        {
            //ProductName = productName;
            //Price = price;
            //ItemsRemaining = itemsRemaining;
        }
        

        public override string ProductMessage()
        {
            return "Munch, Munch, Yum!";
        }
    }
}
