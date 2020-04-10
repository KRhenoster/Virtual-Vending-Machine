using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class ItemMenu 
    {

        public VendingMachine vendingmachine { get; set; }

        
     

        public void Display()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Please choose your options:");
                Console.WriteLine("1) >> Feed Money");
                Console.WriteLine("2) >> Select Product");
                Console.WriteLine("3) >> Finish Transaction");
                Console.WriteLine("E) >> Return to Main Menu");
                Console.WriteLine($"Money in Machine: {vendingmachine.MoneyCount.MoneyInMachine.ToString("C")}"); // this displays how much money is in the machine
                Console.Write("What option do you want to select? ");
                
                string output = Console.ReadLine();
                

                if (output == "1")
                {
                    Console.WriteLine(">>> How much do you want to insert?");
                    while (true)
                    {
                        Console.Write("1, 2, 5, 10 dollars? ");
                        string amountToSubmit = Console.ReadLine();
                        if (amountToSubmit == "1"
                            || amountToSubmit == "2"
                            || amountToSubmit == "5"
                            || amountToSubmit == "10")
                        {
                            if (!vendingmachine.MoneyCount.AddMoney(amountToSubmit)) // this adds the amount submitted
                            {
                                Console.WriteLine("Insert a correct amount:");
                            }


                            else
                            {
                                Console.WriteLine($"Money in Machine: {vendingmachine.MoneyCount.MoneyInMachine.ToString("C")}");
                                break;
                            }

                        }
                    }

                }
            
            else 
                if(output == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("Displaying Items");
                        Dictionary<string, VendingItem> items = vendingmachine.VendingItems;
                        Console.WriteLine($"{"Number".PadRight(15)} {"ProductName".PadRight(20)} {"Price".PadRight(20)} {"Stock".PadRight(20)}");
                        foreach (KeyValuePair<string, VendingItem> item in items)
                        {
                            VendingItem vendingItem = item.Value; //getting the vendingitem for every key. //you cannot pad non string items
                            Console.WriteLine($"{item.Key.PadRight(15)} {vendingItem.ProductName.PadRight(20)} {vendingItem.Price.ToString().PadRight(20)} {vendingItem.ItemsRemaining.ToString().PadRight(20)}");
                        }
                        Console.Write("What option do you want to select? ");

                        string choice = Console.ReadLine();
                        if (!items.ContainsKey(choice))
                        {
                            Console.WriteLine("Error. Wrong Selection!!!");
                            Console.ReadLine(); //when selecting something outside the library an error message pops up
                        }
                        else 
                        {
                            

                            //From TOM: You don't need to instantiate another MoneyCount object, one
                            //already exits from the parent class. You can just access it.
                            vendingmachine.MoneyCount.RemoveMoney(items[choice].Price);
                            items[choice].ItemsRemaining--;
                            //vendingmachine.MoneyCount.ReturnChange();
                            // End of Tom Comments
                            VendingItem vendingitem = items[choice];
                            Console.WriteLine($"You've Selected {vendingitem.ProductName}");
                            Console.WriteLine($"{vendingitem.ProductMessage()}");
                            Console.ReadLine();
                            break;
                           
                        } 
                    } //itemmenu is not a vendingmachine 
                    

                }
                if(output == "3")
                {
                    Console.WriteLine("Finishing Transaction");
                    Console.WriteLine(vendingmachine.MoneyCount.ReturnChange()); //return change is a method
                    Console.WriteLine($"Your change is: {vendingmachine.MoneyCount.MoneyInMachine.ToString("C")}");
                    Console.WriteLine($"Money in Machine: {vendingmachine.MoneyCount.MoneyInMachine.ToString("C")}");
                } 
                else if (output.ToUpper() == "E") // this allows the user to exit and return to the main menu
                {
                    Console.WriteLine("Returning to main menu");
                    break;
                }
                else
                {
                   // Console.WriteLine("Please try again");
                }
                Console.ReadLine();
            }
        }
    }
}