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
    public sealed partial class DivisonTwo : Page
    {
        public DivisonTwo()
        {
            this.InitializeComponent();
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            //bring user back to the main page
            Frame.Navigate(typeof(HomePage));
        }

        private void BohsLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.161596, Longitude = -9.54416 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);


        }

        private void MerlinLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2834, Longitude = -8.9837 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);


        }

        private void MervueBLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.28180, Longitude = -9.0205 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);


        }

        private void ColgaLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2313, Longitude = -8.8491 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);


        }

        private void HibsBLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2817, Longitude = -9.0464 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);


        }

        private void KiltullaghLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2737, Longitude = -8.6324 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);


        }

        private void BluesLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 49.8219, Longitude = -24.0387 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);


        }

        private void kfcLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2647, Longitude = -9.1300 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            Frame.Navigate(typeof(Map), cityCenter);


        }

        private async void BohsInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://sitebuilder.blacknight.com/preview/sites/galwaybohsfc.com/"));

        }

        private async void MerlinInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://merlinwoodsfc.blogspot.ie/2016/08/merlin-woods-fc-womens.html"));
        }

        private async void MervueInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.mervueunited.com/"));

        }

        private async void ColgaInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.colgafc.ie/"));

        }

        private async void HibsInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.facebook.com/galway.hibernians/"));

        }

        private async void KiltullaghInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.facebook.com/kiltullaghpioneersfc/"));

        }

        private async void BluesInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.facebook.com/dynamobluesfc/"));

        }

        private async void KfcInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://sitebuilder.blacknight.com/preview/sites/galwaybohsfc.com/"));

        }
    }
}
