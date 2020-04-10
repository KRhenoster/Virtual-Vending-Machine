using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    //@"C:\Users\Student\workspace\csharp-capstone-module-1-team-1\vendingmachine.csv"
    public abstract class VendingItem
    {
        
        public string ProductName { get; set; } //property

        public decimal Price { get; set; }

        public int ItemsRemaining { get; set; }

        public string MessageWhenSoldOut { get; set; }

        public virtual string ProductMessage()
        {
            return "";
        }

        public VendingItem()
        {

        }

        public VendingItem(string productName, decimal price, int itemsRemaining)
        {
            if (productName == null)
            {
                productName = "Unknown";
            }
            this.ProductName = productName;
            this.Price = price;
            this.ItemsRemaining = itemsRemaining;
            this.MessageWhenSoldOut = $"Sold out of {productName}!\nBuy something else!";
            
        }
        public bool RemoveItem()
        {
            if (this.ItemsRemaining > 0)
            {
                this.ItemsRemaining--;
                return true;
            }

            return false;
        }
    }
}
   

