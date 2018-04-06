using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Collections.ObjectModel;

namespace BillCalculatorWFP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // static private OrderManager orderManager = new OrderManager();


        List<MenuOption> Menus = new List<MenuOption>();
        OrderList orderList = new OrderList();

        decimal subTotal = 0;
        float taxRate = 0.13f;
        decimal totalCost=0;
        public MainWindow()
        {
            InitializeComponent();
            LoadMeneOptions();

        }

        private void LoadMeneOptions()
        {
            Menus.Add(new MenuOption("Coffee", "Beverages", 1.25m, 1));
            Menus.Add(new MenuOption("Tea", "Beverages", 1.50m, 1));
            Menus.Add(new MenuOption("Soda", "Beverages", 1.95m, 1));
            Menus.Add(new MenuOption("Mineral Water", "Beverages", 2.9m, 1));
            Menus.Add(new MenuOption("Juice", "Beverages", 2.25m, 1));
            Menus.Add(new MenuOption("Milk", "Beverages", 1.25m, 1));
            Menus.Add(new MenuOption("Hot Chocolate", "Beverages", 2.5m, 1));
            Menus.Add(new MenuOption("Orange Juice", "Beverages", 1.23m, 1));
            Menus.Add(new MenuOption("Buffalo Wings", "Appetizer", 5.95m, 1));
            Menus.Add(new MenuOption("Buffalo Fingers", "Appetizer", 6.95m, 1));
            Menus.Add(new MenuOption("Potato Skins", "Appetizer", 8.95m, 1));
            Menus.Add(new MenuOption("Mushroom Caps", "Appetizer", 8.95m, 1));
            Menus.Add(new MenuOption("Shrimp Cocktail", "Appetizer", 12.95m, 1));
            Menus.Add(new MenuOption("Chips and Salsa", "Appetizer", 6.95m, 1));
            Menus.Add(new MenuOption("Seafood Alfredo", "Main Course", 15.95m, 1));
            Menus.Add(new MenuOption("Chicken Alfredo", "Main Course", 13.95m, 1));
            Menus.Add(new MenuOption("Chicken Picatta", "Main Course", 13.95m, 1));
            Menus.Add(new MenuOption("Turkey Club", "Main Course", 11.95m, 1));
            Menus.Add(new MenuOption("Lobster Pie", "Main Course", 19.95m, 1));
            Menus.Add(new MenuOption("Turkey Club", "Main Course", 20.95m, 1));
            Menus.Add(new MenuOption("Prime Rib", "Main Course", 18.95m, 1));
            Menus.Add(new MenuOption("Shrimp Scampi", "Main Course", 13.95m, 1));
            Menus.Add(new MenuOption("Turkey Dinner", "Main Course", 14.95m, 1));
            Menus.Add(new MenuOption("Stuffed Chicken", "Main Course", 13.95m, 1));
            Menus.Add(new MenuOption("Apple Pie", "Dessert", 5.95m, 1));
            Menus.Add(new MenuOption("Carrot Cake", "Dessert", 3.95m, 1));
            Menus.Add(new MenuOption("Sundae", "Dessert", 5.95m, 1));
            Menus.Add(new MenuOption("Mud Pie", "Dessert", 4.95m, 1));
            Menus.Add(new MenuOption("Apple Crisp", "Dessert", 5.95m, 1));

            for (int i = 0; i < Menus.Count; i++)
            {
                MenuOption aa = Menus[i];
                String bb = aa.Category;
                switch (bb)
                {
                    case "Beverages":
                        cboBeverage.Items.Add(aa.ItemName + "     $" + aa.Price);
                        break;
                    case "Appetizer":
                        cboAppetizer.Items.Add(aa.ItemName + "     $" + aa.Price);
                        break;
                    case "Main Course":
                        cboMainCourse.Items.Add(aa.ItemName + "     $" + aa.Price);
                        break;
                    case "Dessert":
                        cboDessert.Items.Add(aa.ItemName + "     $" + aa.Price);
                        break;
                    default:
                        break;
                }

            }
            dgOrder.ItemsSource = orderList;
        }


        private void cbo_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox selectedCombobox = (ComboBox)sender;
            String selectedItemName = selectedCombobox.SelectedItem.ToString().Split('$')[0].TrimEnd(' '); //extract selected item name
            MenuOption selectedItem = Menus.Find(item => item.ItemName.Equals(selectedItemName));

            if (orderList.Any(item => item.ItemName.Equals(selectedItemName)))
            {
                orderList.UpdateOrderedList(selectedItemName);
            }
            else
            {
                orderList.Add(selectedItem);
            }

            CalculateInvoice();
        }



        private void RemoveOrderedItemBtn_Click(object sender, RoutedEventArgs e)
        {

            if (dgOrder.SelectedIndex >= 0)
            {
                MenuOption item2Remove = dgOrder.SelectedItem as MenuOption; // choose the selected row

                for (int i = 0; i < orderList.Count; i++)
                {
                    if (orderList[i].ItemName.Equals(item2Remove.ItemName))
                    {
                        orderList.RemoveAt(i);
                        break;
                    }
                }

                CalculateInvoice();
            }
            else { MessageBox.Show("No item has been selected to remove"); }
        }

        private void dgOrder_Selected(object sender, RoutedEventArgs e)
        {
            RemoveOrderedItemBtn.IsEnabled = true;
        }

        public void CalculateInvoice()
        {
            subTotal = 0;
            foreach (MenuOption orderedItem in orderList)
            {
                subTotal += orderedItem.Price * orderedItem.Quantity;
            }

            decimal tax = subTotal * (decimal)taxRate;
            totalCost = subTotal + tax;

            ctrlSubTotal.Text = subTotal.ToString();
            ctrlTax.Text = tax.ToString();
            ctrlTotal.Text = totalCost.ToString();   
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            ctrlSubTotal.Text = string.Empty;
            ctrlTax.Text = string.Empty;
            ctrlTotal.Text = string.Empty;
            orderList.Clear();

            cboAppetizer.SelectedIndex = -1;
            cboBeverage.SelectedIndex = -1;
            cboDessert.SelectedIndex = -1;
            cboMainCourse.SelectedIndex = -1;
        }

        
        private void dgOrder_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            //can also use e.Row to grab updated 
            // int updatedRow = ((DataGrid)sender).ItemContainerGenerator.IndexFromContainer(e.Row);
            //TextBox textbox = e.EditingElement as TextBox;
            try
            {
                dgOrder.Dispatcher.BeginInvoke(new Action(() => dgOrder.Items.Refresh()), System.Windows.Threading.DispatcherPriority.Background);
            }
            catch (Exception){}

            MenuOption updatedOrderItem = (MenuOption)dgOrder.SelectedItem;
            if (updatedOrderItem != null)
            {
                if (orderList.Any(item => item.ItemName.Equals(updatedOrderItem.ItemName)))
                {
                    orderList.UpdateOrderedList(updatedOrderItem.ItemName);
                }
            }
                CalculateInvoice();
        }

        private void cbo_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox selectedCombobox = (ComboBox)sender;
            String selectedItemName = selectedCombobox.SelectedItem.ToString().Split('$')[0].TrimEnd(' '); //extract selected item name
            MenuOption selectedItem = Menus.Find(item => item.ItemName.Equals(selectedItemName));

            if (orderList.Any(item => item.ItemName.Equals(selectedItemName)))
            {
                orderList.UpdateOrderedList(selectedItemName);
            }
            else
            {
                orderList.Add(selectedItem);
            }

            CalculateInvoice();
        }

    }
}
