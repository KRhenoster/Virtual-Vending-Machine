using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Menu
    {
       
        public void Display()
        {
           VendingMachine vm = new VendingMachine(); // keeps all data, how many money, and whats in the vending machine
           FileText filetext = new FileText();
            vm.VendingItems = filetext.GetVendingItems();

            while(true)
            {

                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine("(1) Display Vending Machine Items: ");
                Console.WriteLine("(2) Purchase");
                Console.WriteLine("(3) Exit");

                Console.Write("Select an option from the Main Menu: ");
               string input = Console.ReadLine();

                if(input == "1") 
                {
                    Console.WriteLine("Displaying Items");
                    //Dictionary<string, VendingItem> items = filetext.GetVendingItems();
                    Console.WriteLine($"{"Number".PadRight(15)} {"ProductName".PadRight(20)} {"Price".PadRight(20)} {"Stock".PadRight(20)}");
                    foreach (KeyValuePair<string, VendingItem> item in vm.VendingItems)
                    {
                        VendingItem vendingItem = item.Value; //getting the vendingitem for every key. //you cannot pad non string items
                        Console.WriteLine($"{item.Key.PadRight(15)} {vendingItem.ProductName.PadRight(20)} {vendingItem.Price.ToString().PadRight(20)} {vendingItem.ItemsRemaining.ToString().PadRight(20)}");
                    }
                } else if (input == "2")
                {
                    ItemMenu itemMenu = new ItemMenu();
                    itemMenu.vendingmachine = vm; //
                    itemMenu.Display();
                } else if(input.ToUpper() == "E")
                {
                    Console.WriteLine("Exit");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }
                Console.ReadLine(); 
            }
        }
    }
}
