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
using System.Data.Entity;

// Angelica Catalan, 300846458
namespace Question1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BaseballEntities db = new BaseballEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            BindDatagrid();
            DisplayAll();
        }

        private void BindDatagrid()
        {
            db.Players.Load();
            dgPlayers.ItemsSource = db.Players.Local;
            dgtcId.Binding = new Binding("PlayerID");
            dgtcFirstName.Binding = new Binding("FirstName");
            dgtcLastName.Binding = new Binding("LastName");
            dgtcBattingAverage.Binding = new Binding("BattingAverage");
        }

        private void DisplayAll()
        {
            dgPlayers.ItemsSource = db.Players.Local;
        }

        private void DisplayPlayer()
        {
            String lastname = txtLastName.Text.ToLower();
            dgPlayers.ItemsSource = from player in db.Players.Local
                                    where player.LastName.ToLower().Contains(lastname)
                                    select player;

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            DisplayPlayer();
        }

        private void btnDisplayAll_Click(object sender, RoutedEventArgs e)
        {
            DisplayAll();
        }
    }
}
