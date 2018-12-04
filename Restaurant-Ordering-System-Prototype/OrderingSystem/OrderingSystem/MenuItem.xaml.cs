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
    /// Interaction logic for MenuButton.xaml
    /// </summary>
    public partial class MenuItem : UserControl
    {
        public MenuItem()
        {
            InitializeComponent();
        }

        public ImageSource foodImage
        {
            get { return FoodImage.Source; }
            set { FoodImage.Source = value; }
        }

        public String itemName
        {
            get { return ItemName.Text; }
            set { ItemName.Text = value; }
        }

        public String itemDescription
        {
            get { return ItemDescription.Text; }
            set { ItemDescription.Text = value; }
        }

        public String price
        {
            get { return Price.Text; }
            set { Price.Text = value; }
        }

        public event EventHandler AddToOrderButtonClicked;
        private void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            if (AddToOrderButtonClicked != null)
            {
                AddToOrderButtonClicked(this, e);
            }
        }
    }
}
