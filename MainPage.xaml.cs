using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MobileAppProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            myFrame.Navigate(typeof(HomePage));
        }
        private void MainMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void PremierDivisonBtn_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(PremierDivison));
        }

        private void DivisonOneBtn_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(DivisonOne));
        }

        private void DivisonTwoBtn_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(DivisonTwo));
        }

        private void DivisonThreeBtn_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(Divison3));
        }

        private void DivisonFourBtn_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(DivisonFour));
        }

    }
}
