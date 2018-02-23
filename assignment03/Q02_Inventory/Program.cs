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
        }
    }
}
