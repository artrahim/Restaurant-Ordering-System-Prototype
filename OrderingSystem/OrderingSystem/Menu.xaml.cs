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
       double price = 0.0;
        public Starters()
        {
            InitializeComponent();
            subtotalLabel.Content = "Subtotal: $" + price;
            taxLabel.Content = "Tax: $" + price;
            totalLabel.Content = "Total: $" + price; 
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
            sizes.Add("Starter Size  $12.99");
            sizes.Add("Double Order  $23.00");

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
            

            OrderPopup op = new OrderPopup(orderSummery, "Chicken Wings", menuItems,utilityGrid,subtotalLabel, taxLabel, totalLabel);
            StarterFrame.Children.Add(op);
        }

        private void AddGarlicBread_Click(object sender, EventArgs e)
        {
            // create list of expanders
            // split all expanders into their own list of strings
            // first item is content type (follow same name, it uses string comparison)
            //  second item is header name (don't use whitespaces?)

            List<String> sizes = new List<String>();
            List<String> dips = new List<String>();

            List<List<String>> menuItems = new List<List<String>>();

            sizes.Add("RadioButton");
            sizes.Add("Sizes");
            sizes.Add("1 Slice  $1.80");
            sizes.Add("2 Slices  $3.20");

            dips.Add("CheckBox");
            dips.Add("Dips");
            dips.Add("Beefy Bolognese meat sauce + $3.25");

            menuItems.Add(sizes);
            menuItems.Add(dips);

            OrderPopup op = new OrderPopup(orderSummery, "Garlic Bread", menuItems, utilityGrid, subtotalLabel, taxLabel, totalLabel);
            StarterFrame.Children.Add(op);
        }

        private void AddThaiBites_Click(object sender, EventArgs e)
        {
            // create list of expanders
            // split all expanders into their own list of strings
            // first item is content type (follow same name, it uses string comparison)
            //  second item is header name (don't use whitespaces?)

            List<String> types = new List<String>();
            List<String> dips = new List<String>();

            List<List<String>> menuItems = new List<List<String>>();

            types.Add("RadioButton");
            types.Add("Types");
            types.Add("Breaded Chicken Breast  $13.00");
            types.Add("Breaded Shrimps  $13.00");

            dips.Add("CheckBox");
            dips.Add("Dips");
            dips.Add("Blue Cheese Dip + $2.60");
            dips.Add("Chipotle Caesar Dip + $2.60");
            dips.Add("Ranch Dip + $2.60");
            dips.Add("Creamy Garlic Dip + $2.60");
            dips.Add("Cactus Dip + $2.60");

            menuItems.Add(types);
            menuItems.Add(dips);


            OrderPopup op = new OrderPopup(orderSummery, "Thai Bites", menuItems, utilityGrid, subtotalLabel, taxLabel, totalLabel);
            StarterFrame.Children.Add(op);
        }

        private void AddPestoChicken_Click(object sender, EventArgs e)
        {
            // create list of expanders
            // split all expanders into their own list of strings
            // first item is content type (follow same name, it uses string comparison)
            //  second item is header name (don't use whitespaces?)

            List<String> cheese = new List<String>();
            List<String> noodle = new List<String>();
            List<String> extra = new List<String>();


            List<List<String>> menuItems = new List<List<String>>();

            cheese.Add("RadioButton");
            cheese.Add("Baked with cheese?");
            cheese.Add("No $12.99");
            cheese.Add("Yes $15.99");

            noodle.Add("RadioButton");
            noodle.Add("Noodle");
            noodle.Add("Fettuccini");
            noodle.Add("Penne");
            noodle.Add("Spaghetti");
            noodle.Add("GlutenWise Fussili + $2.00");

            extra.Add("CheckBox");
            extra.Add("Extra Add");
            extra.Add("Bacon + $2.30");
            extra.Add("Diced Chicken + $2.30");
            extra.Add("Shrimp + $2.60");
            extra.Add("Fresh Mushrooms + $2.10");
            extra.Add("Green Peppers + $2.10");
            extra.Add("Onion + $2.10");

            menuItems.Add(cheese);
            menuItems.Add(noodle);
            menuItems.Add(extra);


            OrderPopup op = new OrderPopup(orderSummery, "Pesto Chicken Penne", menuItems, utilityGrid, subtotalLabel, taxLabel, totalLabel);
            PastaFrame.Children.Add(op);
        }

        private void AddBostonRoyal_Click(object sender, EventArgs e)
        {
            // create list of expanders
            // split all expanders into their own list of strings
            // first item is content type (follow same name, it uses string comparison)
            //  second item is header name (don't use whitespaces?)

            List<String> crust = new List<String>();
            List<String> sizes = new List<String>();
            List<String> dips = new List<String>();
            List<String> cheese = new List<String>();
            List<String> veggies = new List<String>();
            List<String> meat = new List<String>();

            List<List<String>> menuItems = new List<List<String>>();

            
            crust.Add("RadioButton");
            crust.Add("Types");
            crust.Add("BP's Oroginal Crust");

            sizes.Add("RadioButton");
            sizes.Add("Sizes");
            sizes.Add("8\" Indy + $13.00");
            sizes.Add("10\" Small + $18.00");
            sizes.Add("8\" Meduim + $28.00");
            sizes.Add("8\" Large + $32.50");

            cheese.Add("CheckBox");
            cheese.Add("Cheese");
            cheese.Add("Cheddar+ $2.30");
            cheese.Add("Feta + $2.30");
            cheese.Add("Italian Cheese Blend + $2.30");
            cheese.Add("Pizza Mozzarella + $2.30");

            meat.Add("CheckBox");
            meat.Add("Meat");
            meat.Add("Chicken + $2.30");
            meat.Add("Salami + $2.30");
            meat.Add("Pepperoni + $2.30");
            meat.Add("Ground Beef + $2.30");
            meat.Add("Bacon + $2.30");

            veggies.Add("CheckBox");
            veggies.Add("Veggies");
            veggies.Add("Red Onion + $2.10");
            veggies.Add("Peppers + $2.10");
            veggies.Add("Black Olive + $2.10");
            veggies.Add("Mushroom + $2.10");
            veggies.Add("Tomatoes + $2.10");
            veggies.Add("Pineapple + $2.10");

            dips.Add("CheckBox");
            dips.Add("Dips");
            dips.Add("Blue Cheese Dip + $2.50");
            dips.Add("Chipotle Caesar Dip + $2.50");
            dips.Add("Ranch Dip + $2.50");
            dips.Add("Creamy Garlic Dip + $2.50");
            dips.Add("Cactus Dip + $2.50");

            menuItems.Add(crust);
            menuItems.Add(sizes);
            menuItems.Add(cheese);
            menuItems.Add(meat);
            menuItems.Add(veggies);
            menuItems.Add(dips);


            OrderPopup op = new OrderPopup(orderSummery, "Boston Royal", menuItems, utilityGrid, subtotalLabel, taxLabel, totalLabel);
            PizzaFrame.Children.Add(op);
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

        private void sendOrder_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new LastScreen());
        }
    }
}
