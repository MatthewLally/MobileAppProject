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
            return (await new Geolocator().GetGeopositionAsync()).Coordinate.Point; //Waiting to get location of user
        }

        public UIElement Marker()
        {
            // Creates a canvas to show the user and their destination
            Canvas marker = new Canvas(); //creates a canvas
            Ellipse outer = new Ellipse();//Creates an ellipse
            outer.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            outer.Margin = new Thickness(-12.5, -12.5, 0, 0);
            Ellipse inner = new Ellipse() { Width = 60, Height = 60 };
            inner.Margin = new Thickness(-10, -10, 0, 0);
            Ellipse core = new Ellipse { Width = 10, Height = 10 };
            core.Fill = new SolidColorBrush(Colors.Maroon);
            core.Margin = new Thickness(-10, -10, 0, 0);
            TextBlock you = new TextBlock();
            you.Text = "You are currently Here"; //Prints a text block telling users where they are
            you.Foreground = new SolidColorBrush(Colors.Black);
            you.Margin = new Thickness(-20, -30, 0, 0); ;
            marker.Children.Add(outer);
            marker.Children.Add(inner);
            marker.Children.Add(core);
            marker.Children.Add(you);
            return marker;
        }

        public UIElement MarkerText(String Text)
        {
            // Creating marker
            Canvas marker = new Canvas();
            TextBlock text = new TextBlock();
            text.Foreground = new SolidColorBrush(Colors.Red);
            marker.Background = new SolidColorBrush(Colors.Black);
            text.FontSize = 16; //seting font size
            text.Text = Text;
            marker.Children.Add(text);
            return marker; //returns the marker

        }
    }
}

