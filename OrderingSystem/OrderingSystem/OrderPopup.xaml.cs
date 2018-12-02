using System;
using System.Collections;
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
    /// Interaction logic for OrderPopup.xaml
    /// </summary>
    public partial class OrderPopup : UserControl
    {
        private StackPanel order;
        private String name;
        private List<Expander> expanders = new List<Expander>();
        private List<List<String>> menuItems = new List<List<String>>();
        private List<List<RadioButton>> radioButtons = new List<List<RadioButton>>();
        private List<List<CheckBox>> checkBoxes = new List<List<CheckBox>>();
        private List<String> headers = new List<String>();
        private int quantity = 1;
        private TextBox customerDet = new TextBox();

        public OrderPopup(StackPanel orderPanel, String orderName, List<List<String>> optionStrings)
        {
            InitializeComponent();
            PopUpAddToOrder.IsOpen = true;
            order = orderPanel;
            name = orderName;
            menuItems = optionStrings;
            

            createContentLists(optionStrings);
            createExpanders(radioButtons, checkBoxes);


        }


        private void CancelButton_1_Click(object sender, RoutedEventArgs e)
        {
            quantity = 1;
            PopUpAddToOrder.IsOpen = false;
            quantityBox.Text = quantity.ToString();

            for(int exCount = 0;exCount < expanders.Count; exCount++)
            {
                expanders[exCount].IsExpanded = false;
            }

            for (int radioCount = 0; radioCount < radioButtons.Count; radioCount++)
            {
                for (int rb = 0; rb < radioButtons[radioCount].Count; rb++)
                {
                    radioButtons[radioCount][rb].IsChecked = false;
                }
            }
            for (int buttonCount = 0; buttonCount < checkBoxes.Count; buttonCount++)
            {
                for (int cb = 0; cb < checkBoxes[buttonCount].Count; cb++)
                {
                    checkBoxes[buttonCount][cb].IsChecked = false;
                }
            }


        }

        private void AddToOrder_Click(object sender, RoutedEventArgs e)
        {

            Expander orderSummeryExpander_1 = new Expander();
            orderSummeryExpander_1.IsExpanded = false;
            order.Children.Add(orderSummeryExpander_1);
            TextBox customizations = new TextBox();
            Color colour = new Color();
            colour = Color.FromRgb(255, 255, 255);
            SolidColorBrush textColour = new SolidColorBrush(colour);
            double price = 0.0;
            

            for (int radioButtonSets = 0; radioButtonSets < radioButtons.Count; radioButtonSets++)
            {
                for (int radioButtonCount = 0; radioButtonCount < radioButtons[radioButtonSets].Count; radioButtonCount++)
                {
                    if (radioButtons[radioButtonSets][radioButtonCount].IsChecked == true)
                    {
                        String name = radioButtons[radioButtonSets][radioButtonCount].Content.ToString();
                        customizations.Text += "\r\n" + name;
                        if (name.Contains('$'))
                        {
                            price += getPrice(name);
                        }
                    }
                }
            }
            for (int checkBoxSets = 0; checkBoxSets < checkBoxes.Count; checkBoxSets++)
            {
                for (int checkBoxCount = 0; checkBoxCount < checkBoxes[checkBoxSets].Count; checkBoxCount++)
                {
                    if (checkBoxes[checkBoxSets][checkBoxCount].IsChecked == true)
                    {
                        String name = checkBoxes[checkBoxSets][checkBoxCount].Content.ToString();
                        customizations.Text += "\r\n" + name;
                        if (name.Contains('$'))
                        {
                            price += getPrice(name);
                        }
                    }
                }
            }
            
            customizations.Text += "\r\n * " + customerDet.Text;
            customizations.IsReadOnly = true;
            /*
            //create grid for header text alignment
            Grid headerGrid = new Grid();
            headerGrid.Children.Add(orderSummeryExpander_1);
            headerGrid.MinWidth = 480;

            //create columns to place text in
            ColumnDefinition c1 = new ColumnDefinition();
            c1.Width = new GridLength(1, GridUnitType.Star);

            //add columns to grid
            headerGrid.ColumnDefinitions.Add(c1);
            */

            orderSummeryExpander_1.FontSize = 29;
            orderSummeryExpander_1.Header = "   " + name + " x" + quantity + " $" + (price * quantity).ToString("n2");
            orderSummeryExpander_1.Foreground = textColour;
            orderSummeryExpander_1.Content = customizations;

        }

        private double getPrice(String s)
        {
            String[] priceString = s.Split('$');
            priceString[1].Trim();
            double price = Convert.ToDouble(priceString[1]);
            return price;
        }

        private void add_1_Click(object sender, RoutedEventArgs e)
        {
            quantity++;
            quantityBox.Text = quantity.ToString();
        }

        private void minus_1_Click(object sender, RoutedEventArgs e)
        {
            if (quantity <= 1)
            {
                quantity = 1;
            }
            else
            {
                quantity--;
            }
            quantityBox.Text = quantity.ToString();
        }

        private void createExpanders(List<List<RadioButton>> buttonList, List<List<CheckBox>> boxList)
        {
            int headerCount = 0;

            //create radiobutton expanders
            for (int expander = 0; expander < buttonList.Count; expander++)
            {
                Expander current = new Expander();
                StackPanel currentMenu = new StackPanel();
                current.Header = "Select " + headers[headerCount];
                headerCount++;
                for (int radioButtonCount = 0; radioButtonCount < buttonList[expander].Count; radioButtonCount++)
                {
                    Border stackborder = new Border();
                    Color colour = new Color();
                    colour = Color.FromRgb(255, 255, 255);
                    SolidColorBrush borderColour = new SolidColorBrush(colour);
                    stackborder.BorderBrush = borderColour;
                    stackborder.BorderThickness = new Thickness(4, 2, 4, 2);

                    stackborder.Child = buttonList[expander][radioButtonCount];
                    currentMenu.Children.Add(stackborder);

                }
                current.Content = currentMenu;
                popupStackPanel.Children.Add(current);
                expanders.Add(current);
            }

            //create checkbox expanders
            for (int expander = 0; expander < boxList.Count; expander++)
            {
                Expander current = new Expander();
                StackPanel currentMenu = new StackPanel();
                current.Header = "Select " + headers[headerCount];
                headerCount++;
                for (int checkBoxCount = 0; checkBoxCount < boxList[expander].Count; checkBoxCount++)
                {
                    Border stackborder = new Border();
                    Color colour = new Color();
                    colour = Color.FromRgb(255, 255, 255);
                    SolidColorBrush borderColour = new SolidColorBrush(colour);
                    stackborder.BorderBrush = borderColour;
                    stackborder.BorderThickness = new Thickness(4, 2, 4, 2);

                    stackborder.Child = boxList[expander][checkBoxCount];
                    currentMenu.Children.Add(stackborder);

                }
                current.Content = currentMenu;
                popupStackPanel.Children.Add(current);
                expanders.Add(current);

            }

            //add details at bottom of popup
            Label details = new Label();
            details.Content = "Additional Details For Order:";
            details.Margin = new Thickness(0,20,0,0);
            details.FontSize = 20;
            popupStackPanel.Children.Add(details);

            //add textbox
            customerDet.TextWrapping = TextWrapping.Wrap;
            customerDet.FontSize = 20;
            customerDet.Margin = new Thickness(20, 10, 40, 20);
            customerDet.MinHeight = 100;
            customerDet.MaxHeight = 100;
            popupStackPanel.Children.Add(customerDet);

        }

        private void createContentLists(List<List<String>> menuStrings)
        {
            //create list of expanders needed
            //for each expander must include type (radiobutton, checkbox)
            //separate to expanders based on 

            for (int i = 0; i < menuItems.Count; i++)
            {
                //if its a radiobutton, add it to a list of a list of radiobuttons
                headers.Add(menuItems[i][1]);
                if (menuItems[i][0].Equals("RadioButton"))
                {
                    List<RadioButton> current = new List<RadioButton>();
                    for (int j = 2; j < menuItems[i].Count; j++)
                    {
                        //create button
                        RadioButton rb = new RadioButton();
                        rb.GroupName = menuItems[i][1];
                        rb.Content = menuItems[i][j];
                        rb.FontSize = 20;
                        current.Add(rb);
                    }
                    radioButtons.Add(current);
                }
                //if its a checkbox, add it to a list of a list of checkboxes
                if (menuItems[i][0].Equals("CheckBox"))
                {
                    List<CheckBox> current = new List<CheckBox>();
                    for (int j = 2; j < menuItems[i].Count; j++)
                    {
                        //create checkbox
                        CheckBox rb = new CheckBox();
                        rb.Content = menuItems[i][j];
                        rb.FontSize = 20;
                        current.Add(rb);
                    }
                    checkBoxes.Add(current);
                }
            }

        }

    }
}
