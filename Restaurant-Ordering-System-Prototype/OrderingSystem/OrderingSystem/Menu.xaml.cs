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
using System.Collections;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OrderingSystem
{
    /// <summary>
    /// Interaction logic for Starters.xaml
    /// </summary>
    public partial class Starters : Page
    {
      //  ArrayList orderSummary = new ArrayList();
        
        public Starters()
        {
            InitializeComponent();

        }
        private void AddChickenWings_Click(object sender, EventArgs e)
        {
            // create list of expanders
            // split all expanders into their own list of strings
            // first item is content type (follow same name, it uses string comparison)
            //  second item is header name (don't use whitespaces?)

            List<String> sizes = new List<String>();
            List<String> flavours = new List<String>();
            List<String> dips = new List<String>();

            List<List<String>> menuItems = new List<List<String>>();

            sizes.Add("RadioButton");
            sizes.Add("Sizes");
            sizes.Add("Starter Size + $12.99");
            sizes.Add("Double Order + $23.00");

            flavours.Add("RadioButton");
            flavours.Add("Flavour");
            flavours.Add("Plain");
            flavours.Add("Medium");
            flavours.Add("Mild");
            flavours.Add("Hot");
            flavours.Add("BBQ");
            flavours.Add("Thai Chili");
            flavours.Add("Honey Garlic");
            flavours.Add("Salt And Pepper");
            flavours.Add("Memphis Hot Sauce");

            dips.Add("CheckBox");
            dips.Add("Dips");
            dips.Add("Blue Cheese Dip");
            dips.Add("Chipotle Caesar Dip");
            dips.Add("Ranch Dip");
            dips.Add("Creamy Garlic Dip");
            dips.Add("Cactus Dip");

            menuItems.Add(sizes);
            menuItems.Add(flavours);
            menuItems.Add(dips);
            
            OrderPopup op = new OrderPopup(orderSummery, "Chicken Wings", menuItems,utilityGrid);
            StarterFrame.Children.Add(op);
        }
        private void CallServer_Click(object sender, RoutedEventArgs e)
        {

            popUpServer.IsOpen = true;


        }
        private void CloseCallServer_Click(object sender, RoutedEventArgs e)
        {

            popUpServer.IsOpen = false;


        }
    }
}
