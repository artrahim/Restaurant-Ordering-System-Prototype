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
        ArrayList vars = new ArrayList();
        ArrayList menuItems = new ArrayList();
        
        public Starters()
        {
            InitializeComponent();
            menuItems.Add("Starter Size + $12.99");
            menuItems.Add("Double Order + $23.00 ");
            menuItems.Add("Plain");
            menuItems.Add("Medium");
            menuItems.Add("Mild");
            menuItems.Add("Hot");
            menuItems.Add("BBQ");
            menuItems.Add("Thai Chili");
            menuItems.Add("Honey Garlic");
            menuItems.Add("Salt And Pepper");
            menuItems.Add("Memphis Hot Sauce");
            menuItems.Add("Blue Cheese Dip");
            menuItems.Add("Chipotle Caesar Dip");
            menuItems.Add("Ranch Dip");
         //   menuItems.Add("Creamy Garlic Dip");
         //   menuItems.Add("Cactus Dip");
            vars.Add(single_1);
            vars.Add(double_1);
            vars.Add(naked);
            vars.Add(medium);
            vars.Add(mild);
            vars.Add(hot);
            vars.Add(bbq);
            vars.Add(thai);
            vars.Add(honey);
            vars.Add(salt);
            vars.Add(memphis);
            vars.Add(blue);
            vars.Add(chip);
            vars.Add(ranch);

        }

        private void CancelButton_1_Click(object sender, RoutedEventArgs e)
        {
            quantity_1 = 1;

            PopUpAddToOrder_ChickenWings.IsOpen = false;
            quantityBox_1.Text = quantity_1.ToString();
            expander_1.IsExpanded = false;
            expander_2.IsExpanded = false;
            expander_3.IsExpanded = false;
            single_1.IsChecked = false;
            double_1.IsChecked = false;
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

        public int quantity_1 = 1;

        private void add_1_Click(object sender, RoutedEventArgs e)
        {
            quantity_1++;
            quantityBox_1.Text = quantity_1.ToString();
        }

        private void minus_1_Click(object sender, RoutedEventArgs e)
        {
            if(quantity_1 <= 1)
            {
                quantity_1 = 1;
            }
            else { 
                quantity_1--;
            }
            quantityBox_1.Text = quantity_1.ToString();
        }

        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Expander orderSummeryExpander_1 = new Expander();
            orderSummeryExpander_1.IsExpanded = false;
            orderSummery.Children.Add(orderSummeryExpander_1);
            TextBox text1 = new TextBox();

            for (int i = 0; i < vars.Count; i++)
            {
                String checker = vars[i].ToString();
                if (checker.Contains("True"))
                {
                    String name = menuItems[i].ToString();
                    text1.Text = text1.Text + "\r\n" + name;
                    //orderSummary.Add(menuItems[i].ToString());

                }
            }
            text1.IsReadOnly = true;
            //text1.Foreground = new SolidColorBrush(Colors.Red);          CHANGE COLOR OF TEXT
            orderSummeryExpander_1.FontSize = 29;
            orderSummeryExpander_1.Header = "Chicken Wings";
            orderSummeryExpander_1.Content = text1;

        }

        private void MenuItem_ChickenWings(object sender, EventArgs e)
        {
            PopUpAddToOrder_ChickenWings.IsOpen = true;
        }
    }
}
