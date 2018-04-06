using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02_Inventory
{
    class InventoryItem
    {
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public InventoryItem(int itemNo, string description, int quantity, double price)
        {
            this.ItemNo = itemNo;
            this.Description = description;
            this.Quantity = quantity;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"#{ItemNo}: {Description} - {Quantity} in stock - {Price:C}";
        }
    }
}
