﻿using System;
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

        public WelcomeScreen()
        {
            InitializeComponent();
        }
        
        private void ToMenu_Click(object sender, RoutedEventArgs e)
        {

            this.NavigationService.Navigate(new Starters());

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
    }
}
