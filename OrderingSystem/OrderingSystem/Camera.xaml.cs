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
    /// Interaction logic for Camera.xaml
    /// </summary>
    public partial class Camera : UserControl
    {
        public Camera()
        {
            InitializeComponent();
            cameraPopUp.IsOpen = true;
        }

        private void Camera_Switch_Scene_1(object sender, RoutedEventArgs e)
        {
            cameraPopUp_Tom.IsOpen = true;
        }

        private void Camera_Switch_Scene_2(object sender, RoutedEventArgs e)
        {
            cameraPopUp_ID.IsOpen = true;
        }

        private void Camera_Switch_Scene_3(object sender, RoutedEventArgs e)
        {
            cameraPopUp_ID_Tom.IsOpen = true;
        }

        private void Camera_Switch_Scene_4(object sender, RoutedEventArgs e)
        {
            cameraPopUp_ID_Tom.IsOpen = false;
            cameraPopUp_ID.IsOpen = false;
            cameraPopUp_Tom.IsOpen = false;
            cameraPopUp.IsOpen = false;
        }
    }
}
