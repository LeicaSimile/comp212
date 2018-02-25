using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryItem[] inventory = {
                    new InventoryItem(83, "Electric sander", 7, 59.98),
                    new InventoryItem(24, "Power saw", 18, 99.99),
                    new InventoryItem(7, "Sledge hammer", 11, 21.55),
                    new InventoryItem(77, "Hammer", 76, 11.99),
                    new InventoryItem(39, "Lawn mower", 3, 79.95),
                    new InventoryItem(68, "Screwdriver", 106, 7.99),
                    new InventoryItem(56, "Jig Saw", 21, 11.95),
                    new InventoryItem(3, "Wrench", 34, 7.95),
                };

            // Use LINQ to sort the data by item description
            var sortedByDescription =
                from item in inventory
                orderby item.Description
                select item;
            foreach (var item in sortedByDescription)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            // Use LINQ to select the item description and quantity, and sort the results by quantity

            // Use LINQ to select the item description and its total value (i.e., quantity * unit price),
            // order the results by totel value

            // Use LINQ to retrieve and display the most expensive item
        }
    }
}
