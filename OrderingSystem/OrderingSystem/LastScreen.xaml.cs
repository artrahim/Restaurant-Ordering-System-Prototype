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
    /// Interaction logic for LastScreen.xaml
    /// </summary>
    public partial class LastScreen : Page
    {
        public LastScreen()
        {
            InitializeComponent();
        }

        private void CallServer_Click(object sender, RoutedEventArgs e)
        {
            popUpServer.IsOpen = true;
            utilityGrid.Visibility = System.Windows.Visibility.Visible;
        }

        private void CloseCallServer_Click(object sender, RoutedEventArgs e)
        {

            popUpServer.IsOpen = false;
            utilityGrid.Visibility = System.Windows.Visibility.Collapsed;


        }

        private void FinishPay_Click(object sender, RoutedEventArgs e)
        {
            PopUpFinishPay.IsOpen = true;
            utilityGrid.Visibility = System.Windows.Visibility.Visible;
        }


        private void CloseFinishPay_Click(object sender, RoutedEventArgs e)
        {

            this.NavigationService.Navigate(new WelcomeScreen());
            utilityGrid.Visibility = System.Windows.Visibility.Collapsed;


        }

        private void ContinueBrowsing_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Starters());
        }
    }
}
