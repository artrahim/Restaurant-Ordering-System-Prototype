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

namespace OrderingSystem
{
    /// <summary>
    /// Interaction logic for Starters.xaml
    /// </summary>
    public partial class Starters : Page
    {
        public Starters()
        {
            InitializeComponent();
        }
        private void AddToOrder_Click_1(object sender, RoutedEventArgs e)
        {
            PopUpAddToOrder_1.IsOpen = true;
        }

        private void CancelButton_1_Click(object sender, RoutedEventArgs e)
        {
            PopUpAddToOrder_1.IsOpen = false;
            naked.IsChecked = false;
            medium.IsChecked = false;
            mild.IsChecked = false;
            hot.IsChecked = false;
            bbq.IsChecked = false;
            thai.IsChecked = false;
            honey.IsChecked = false;
            salt.IsChecked = false;
            memphis.IsChecked = false;
            blue.IsChecked = false;
            chip.IsChecked = false;
            ranch.IsChecked = false;
        }
    }
}
