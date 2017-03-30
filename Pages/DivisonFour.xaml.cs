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
    public sealed partial class DivisonFour : Page
    {
        public DivisonFour()
        {
            this.InitializeComponent();
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            //bring user back to the main page
            Frame.Navigate(typeof(HomePage));
        }

        private void clareGalwayLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2869, Longitude = -9.0073 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void cregmoreLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.3409, Longitude = -8.9457 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void BluesLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 49.8219, Longitude = -24.0387 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void craughwellLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2453, Longitude = -8.7645 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void athenryLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.3084, Longitude = -8.7672 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void loughreaLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2302, Longitude = -8.6267 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void ColemanstownLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.3897, Longitude = -8.6178 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void stbernardsLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.4365, Longitude = -8.7480 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private async void CregmoreInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.cregmoreclaregalwayfc.net/home/"));

        }

        private async void BluesInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.facebook.com/dynamobluesfc/"));

        }

        private async void CraughwellInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.craughwellunitedfc.com/"));

        }

        private async void AthenryInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.athenryfootballclub.com/"));

        }

        private async void LoughreaInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://loughrearamsfc.com/"));

        }

        private async void ColemanstownInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.colemanstownunited.com/"));

        }

        private async void StbernardsInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.facebook.com/bernardsfootball/"));

        }
    }
}
