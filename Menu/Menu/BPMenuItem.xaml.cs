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

namespace Menu
{
    /// <summary>
    /// Interaction logic for BPMenuItem.xaml
    /// </summary>
    public partial class BPMenuItem : UserControl
    {
        public BPMenuItem()
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
    }
}
