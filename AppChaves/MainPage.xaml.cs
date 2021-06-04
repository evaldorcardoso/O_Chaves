using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace AppChaves
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string destino = "/principalPage.xaml?";
            this.NavigationService.Navigate(new Uri(destino, UriKind.Relative));
        }
    }
}