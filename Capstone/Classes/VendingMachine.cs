using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        private MachineInventory machineInventory = new MachineInventory(); 
        public VendingMachine()
        {
            FileText filetext = new FileText();
            this.VendingItems = filetext.GetVendingItems(); // this calls to the filetext. initial state
            this.MoneyCount = new MoneyCount(new MachineInventory()); //full vending machine with no money. initial state
            this.MoneyCount = new MoneyCount(this.machineInventory);
        }
        public Dictionary<string, VendingItem> VendingItems { get; set; } //property. dictionary is the return type

        public MoneyCount MoneyCount { get;}

        public decimal MoneyInMachine
        {
            get
            {
                return this.MoneyCount.MoneyInMachine;
            }
        }

        public void RemoveItem(string itemNumber)
        {
            Dictionary<string, VendingItem> vendingItems = this.VendingItems; //checking
            vendingItems.Remove(itemNumber); //removing
            this.VendingItems = vendingItems; //took from existing vending items, removed one item and put back the vendingitems. updated version

            string message = $"{this.VendingItems[itemNumber].ProductName.ToUpper()} {itemNumber}";

            //This is the money before the user inputs in the money
            decimal before = this.MoneyCount.MoneyInMachine;

            // Remove the money
           this.MoneyCount.RemoveMoney(this.VendingItems[itemNumber].Price);

           
            decimal after = this.MoneyCount.MoneyInMachine; //this displays current money in machine 
 
        }

        

    }
}

