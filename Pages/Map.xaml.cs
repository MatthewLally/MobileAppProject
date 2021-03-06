﻿using System;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Services.Maps;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MobileAppProject.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Map : Page
    {
        public Helper Helper = new Helper(); //Calls helper class
        public int indexPosition = 1;

        public Map()
        {
            this.InitializeComponent();
        }

        private void addIconToLocation(Geopoint location, string name)
        {

            
            MapIcon mapIcon = new MapIcon();
            mapIcon.Location = location;
            mapIcon.Title = String.Format("{0}\nLatLng:{1}\nLongLng:{2}", name, location.Position.Latitude, location.Position.Longitude);

        }

        private async void ShowRouteOnMap(Geopoint startPoint, Geopoint endPoint) //get route 
        {
           
            MapRouteFinderResult routeResult = await MapRouteFinder.GetDrivingRouteAsync( //get result from map
                startPoint, endPoint,
                MapRouteOptimization.Time, //Get result optimised from time
                MapRouteRestrictions.None);

            
            if (routeResult.Status == MapRouteFinderStatus.Success) //If route Results finds a map route do this
            {
                myMap.Routes.Clear();
                MapRouteView viewOfRoute = new MapRouteView(routeResult.Route); //set map route as route result
                viewOfRoute.RouteColor = Colors.Yellow; //sets route color in yellow
                viewOfRoute.OutlineColor = Colors.Black;

                myMap.Routes.Add(viewOfRoute);
                await myMap.TrySetViewBoundsAsync(routeResult.Route.BoundingBox, null, MapAnimationKind.None);

            }
            else
            {
                //If route is not found do this
                var message = new MessageDialog("Cannot find a route");
                await message.ShowAsync();
            }
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
           
            Geopoint Destination = (Geopoint)e.Parameter;
            Geopoint myPoint = await Helper.Position();
            myMap.ZoomLevel = 20; //sets map zoom level
            myMap.Center = myPoint;
            indexPosition++; //adds one to the index position
            ShowRouteOnMap(myPoint, Destination); //Shows user and destination on help

            Geopoint position = await Helper.Position(); //Waiting for position 
            DependencyObject marker = Helper.Marker();
            myMap.Children.Add(marker);
            MapControl.SetLocation(marker, position);
            MapControl.SetNormalizedAnchorPoint(marker, new Point(0.5, 0.5));
            myMap.ZoomLevel = 16;
            myMap.Center = position;


        }
    }
}

