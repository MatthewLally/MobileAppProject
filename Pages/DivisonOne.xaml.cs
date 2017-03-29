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
    public sealed partial class DivisonOne : Page
    {
        public DivisonOne()
        {
            this.InitializeComponent();
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            //bring user back to the main page
            Frame.Navigate(typeof(HomePage));
        }

        private void RenmoreLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2760, Longitude = -9.0165 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void WestCoastLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.4136, Longitude = -9.5318 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void EastUnitedLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2869, Longitude = -9.0073 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void MareeLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2648, Longitude = -8.9297 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void NuiLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2859, Longitude = -9.0590 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void TuamCelticLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.5307, Longitude = -8.8666 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void WestLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.3557, Longitude = -8.7118 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void KinvaraLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.1044, Longitude = -8.9189 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void MoyneVillaLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.4705, Longitude = -9.1103 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void PatsLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.4975, Longitude = -9.0204 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }
    }
}
