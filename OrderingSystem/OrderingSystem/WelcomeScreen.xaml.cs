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
    /// Interaction logic for WelcomeScreen.xaml
    /// </summary>
    public partial class WelcomeScreen : Page
    {
        Menu menu_Page = new Menu();

        public WelcomeScreen()
        {
            InitializeComponent();
        }
        
        private void toMenu_Click(object sender, RoutedEventArgs e)
        {
            this._NavigationFrame2.NavigationService.Navigate(new Uri("Pages/Menu.xaml", UriKind.Relative));
            this._NavigationFrame2.NavigationService.Navigate(menu_Page);

            this.Content = menu_Page;
        }
        
    }
}
