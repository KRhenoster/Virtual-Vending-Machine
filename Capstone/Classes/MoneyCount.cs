using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class MoneyCount
    {
        private MachineInventory Inventory;

        public MoneyCount(MachineInventory Inventory)
        {
            this.MoneyInMachine = 0M;
            this.Inventory = Inventory;
        }
        public decimal MoneyInMachine { get; private set; }

        public bool AddMoney(string amount)
        {
            if (!decimal.TryParse(amount, out decimal amountInserted))
            {
                amountInserted = 0M;
                return false;
            }

            string message = $"Feed Money: ";

            decimal moneybefore = this.MoneyInMachine; // checking to see if there's any current money in machine

            this.MoneyInMachine += amountInserted; //adds the money

            decimal moneyafter = this.MoneyInMachine; // this return a statement showing current money after money is inserted

            this.Inventory.Inventory(message, moneybefore, moneyafter); // this collects total inventory
            return true;
        }

        public bool RemoveMoney(decimal amountToRemove)
        {
            if (this.MoneyInMachine <= 0)
            {
                return false;
            }
            this.MoneyInMachine -= amountToRemove;
            return true;
        }

        public string ReturnChange()
        {
            string output = "";
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;

            string message = "Return Change: ";

            decimal moneybefore = this.MoneyInMachine;

            if (this.MoneyInMachine > 0)
            {
                while (this.MoneyInMachine > 0)
                {
                    if (this.MoneyInMachine >= 0.25M)
                    {
                        quarters++;
                        this.RemoveMoney(0.25M);
                    }
                    else
                    if (this.MoneyInMachine >= 0.10M)
                    {
                        dimes++;
                        this.RemoveMoney(0.10M);
                    }
                    else
                    if (this.MoneyInMachine >= 0.05M)
                    {
                        nickels++;
                        this.RemoveMoney(0.05M);
                    }
                   
                }
               // output = GetMessage(quarters, dimes, nickels);
                
                decimal moneyafter = this.MoneyInMachine;

               
                Inventory.Inventory(message, moneybefore, moneyafter); //checks inventory and returns message
            }
            else
            {
                output = "No change to return";
            }

            return output;
        }

        private string GetMessage(int quarters, int dimes, int nickels)
        {
            // we'll be returning a string and not an int/decimal when this prints to let the user know what change they'll be receiving
            string quarter = "";
            string dime = "";
            string nickel = "";
            // this returns what kind of change the user will be receiving in the form of quarters, nickels and dimes. 
            if (quarters > 0)
            {
               quarter = $"{quarters} quarters";
            }

            if (dimes > 0)
            {
                dime = $"{dimes} dimes";
            }

            if (nickels > 0)
            {
                nickel = $"{nickels} nickels";
            }

            string output = $"Your change is {quarter}{dime}{nickel} ";

           
             if (quarters > 0 || dimes > 0 || nickels > 0)
            {
                output += $"{quarter}{dime}{nickel}";
            }
            else
            {
                output = "No change to give.";
            }

            return output; 
        } 
    }
}




    













