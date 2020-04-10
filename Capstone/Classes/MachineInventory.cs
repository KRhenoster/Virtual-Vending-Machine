using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{
    public class MachineInventory
    {
        //log.txt file allocation 
        public void Inventory(string message, decimal moneybefore, decimal moneyafter)
        {
            DateTime date = DateTime.Now;
            string dateString = date.ToString("MM/dd/yyyy hh:mm:ss tt");
            dateString = dateString;

            message = message;

           string moneybeforeString = moneybefore.ToString("C");
            moneybeforeString = moneybeforeString;

            string moneyafterString = moneyafter.ToString("C");

            string InventoryLine = $"{dateString} {message} {moneybeforeString} {moneyafterString}";
            
            

            try
            {
                using (StreamWriter sw = new StreamWriter("Log.txt", true))
                {
                    sw.WriteLine(InventoryLine);
                    sw.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Error!!!!!!");
                return;
            }
        }
    }
}
