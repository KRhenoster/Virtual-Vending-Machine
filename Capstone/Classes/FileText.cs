using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.Classes
{
    public class FileText
    {
        private const int itemNumber = 0;
        private const int ProductName = 1;
        private const int Price = 2;
        private const int itemType = 3;

        public Dictionary<string, VendingItem> GetVendingItems()
        {
            Dictionary<string, VendingItem> items = new Dictionary<string, VendingItem>();
            string directory = Directory.GetCurrentDirectory();
            string filename = @"vendingmachine.csv";
            string fullpath = Path.Combine(directory, filename);

            string file = "";
            if (File.Exists(fullpath))
            {
                file = fullpath;

                try
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string[] itemDetails = line.Split("|");
                            

                           // Console.WriteLine($"{itemDetails[0]} {itemDetails[1]} {itemDetails[2]} {itemDetails[3]}");

                            string productName = itemDetails[ProductName];
                            //Console.Write(productName);
                            

                            if(!decimal.TryParse(itemDetails[FileText.Price], out decimal Price))
                            {
                                
                                Price = 0M;
                            }
                            int itemsRemaining = 5;

                            VendingItem item;

                            switch(itemDetails[itemType])
                            {
                                case "Chip":
                                item = new Chip(productName, Price, itemsRemaining);
                                    break;
                                case "Drink":
                                    item = new Drink(productName, Price, itemsRemaining);
                                    break;
                                case "Gum":
                                    item = new Gum(productName, Price, itemsRemaining);
                                    break;
                                default:
                                    item = new Candy(productName, Price, itemsRemaining);
                                    break;
                            }
                            items.Add(itemDetails[itemNumber], item);
                        } 

                        
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Sorry file couldn't open");
                }
                
            }
            //Console.WriteLine(items.Count); // count gets the size of the dictionary
            return items;
        }
        
    }
}
