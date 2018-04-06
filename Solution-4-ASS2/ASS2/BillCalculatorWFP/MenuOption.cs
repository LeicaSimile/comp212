using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCalculatorWFP
{
    public class MenuOption: INotifyPropertyChanged
    {
        private int quantity;
        public string ItemName { get; private set; }
        public string Category { get; private set; }
        public decimal Price { get; private set; }

        //user can only change quantity in GUI
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value != this.quantity)
                {
                    this.quantity = value;
                   // NotifyPropertyChanged("Quantity");

                    // Call OnPropertyChanged whenever the property is updated
                    OnPropertyChanged("Quantity");
                }
            }
        }

        public MenuOption(string Name, string category, decimal price, int qty)
        {
            ItemName = Name;
            Category = category;
            Price = price;
            Quantity = qty;
        }

        public event PropertyChangedEventHandler PropertyChanged; 

        // Create OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
