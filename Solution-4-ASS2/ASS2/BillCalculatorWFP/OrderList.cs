using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace BillCalculatorWFP
{
    public class OrderList : ObservableCollection<MenuOption>
    {
        public OrderList() : base()
        {}

        //make sure that the quantity is increased if an existing item is ordered again
        public bool UpdateOrderedList(string itemName)
        {
            bool updated = false;

            if (Count > 0)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (this[i].ItemName.Equals(itemName))
                    {
                        this[i].Quantity++;
                        updated= true;
                        break;
                    }
                }
            }
           return updated;
        }

        private void Quantity_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var handler = QuantityPropertyChanged;
            if (handler != null) { handler(sender, e); }
        }

        public event PropertyChangedEventHandler QuantityPropertyChanged;
    }
}
