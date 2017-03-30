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
    public sealed partial class DivisonThree : Page
    {
        public DivisonThree()
        {
            this.InitializeComponent();
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            //bring user back to the main page
            Frame.Navigate(typeof(HomePage));
        }

        private void MacDaraLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2641, Longitude = -9.5983 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void OafcLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.4285, Longitude = -9.3189 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void BohsLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.161596, Longitude = -9.54416 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void CoisLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2641, Longitude = -9.5983 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void ramblersLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.3150, Longitude = -8.9835 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void nuiLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2859, Longitude = -9.0590 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void corribCelticLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2765, Longitude = -9.0803 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private void barnaLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2518, Longitude = -9.1475 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);

        }

        private async void MacDaraInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.facebook.com/macdarafc?lst=100000613345351%3A100000634865583%3A1490718892"));

        }

        private async void OafcInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.oughterardafc.com/"));

        }

        private async void BohsInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://sitebuilder.blacknight.com/preview/sites/galwaybohsfc.com/"));

        }

        private async void CoisInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.cscf.ie/"));


        }

        private async void RamblersInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://ramblerstest.weebly.com/"));


        }

        private async void NuiInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.nuigalway.ie/soccer/"));   

        }

        private async void CorribCelticInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://sites.google.com/site/corribcelticafc//club-information/"));

        }

        private async void BarnaInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.sacarbnaf.com/apps/blog/"));


        }

        private void RamblersInfo_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
