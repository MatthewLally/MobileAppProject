using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MobileAppProject.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PremierDivison : Page
    {
        public PremierDivison()
        {
            this.InitializeComponent();
        }
        private void AthenryClick(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.3084, Longitude = -8.7672 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            //bring user back to the main page
            Frame.Navigate(typeof(HomePage));
        }
    }
}
