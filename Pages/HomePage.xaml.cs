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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MobileAppProject.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
        }

        private void Premier_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(PremierDivison));
        }

        private void DivisonOne_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(DivisonOne));
        }

        private void DivisonTwo_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(DivisonTwo));
        }

        private void DivisonThree_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(DivisonThree));
        }

        private void DivisonFour_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(DivisonFour));
        }
    }
}
