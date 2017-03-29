using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace MobileAppProject.Pages
{
   public class Helper
    {
        public async Task<Geopoint> Position()
        {
            return (await new Geolocator().GetGeopositionAsync()).Coordinate.Point;
        }

        public UIElement Marker()
        {
            // Creates a canvas to show the user and their destination
            Canvas marker = new Canvas();
            Ellipse outer = new Ellipse();
            outer.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            outer.Margin = new Thickness(-12.5, -12.5, 0, 0);
            Ellipse inner = new Ellipse() { Width = 60, Height = 60 };
            inner.Margin = new Thickness(-10, -10, 0, 0);
            Ellipse core = new Ellipse { Width = 10, Height = 10 };
            core.Fill = new SolidColorBrush(Colors.Maroon);
            core.Margin = new Thickness(-10, -10, 0, 0);
            TextBlock you = new TextBlock();
            you.Text = "You are currently Here";
            you.Foreground = new SolidColorBrush(Colors.Aqua);
            you.Margin = new Thickness(-20, -30, 0, 0); ;
            marker.Children.Add(outer);
            marker.Children.Add(inner);
            marker.Children.Add(core);
            marker.Children.Add(you);
            return marker;
        }

        public UIElement MarkerText(String Text)
        {
            // Creating the text for the marker
            Canvas marker = new Canvas();
            TextBlock text = new TextBlock();
            text.Foreground = new SolidColorBrush(Colors.Red);
            marker.Background = new SolidColorBrush(Colors.Black);
            text.FontSize = 16;
            text.Text = Text;
            marker.Children.Add(text);
            return marker;

        }
    }
}

