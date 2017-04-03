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
using Windows.UI.Popups;
using MobileAppProject.PageHelpers;
using System.Collections.ObjectModel;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MobileAppProject.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReadPlayers : Page
    {
        public ReadPlayers()
        {
            this.InitializeComponent();
            this.Loaded += ReadPlayersList_Loaded;
        }
        ObservableCollection<Players> DB_PlayersList = new ObservableCollection<Players>();

        private void ReadPlayersList_Loaded(object sender, RoutedEventArgs e)
        {
            //create a list to get the meployees from the db
            ReadAllPlayers dbPlayers = new ReadAllPlayers();
            DB_PlayersList = dbPlayers.GetAllPlayers();

            //if (dbPlayers.Count > 0)
            {
                //enable buttons when there is more than one item
                //Btn_Delete.IsEnabled = true;
                //Delete.IsEnabled = true;
            }
            //bind db record to list box and display the latest record
            //(new records weill be put at the end... so by ordering by desending we get the latest record first)
            //use of a lambda expression
            listBoxobj.ItemsSource = DB_PlayersList.OrderByDescending(i => i.playerId).ToList();
        }

        private void AddPlayer_Click(object sender, RoutedEventArgs e)
        {
            //navigate to the AddEmployees page when this button is clicked
            Frame.Navigate(typeof(AddPlayers));
        }

        private void listBoxobj_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedplayerId = 0;
            //make sure that an item is selected
            if (listBoxobj.SelectedIndex != -1)
            {
                //get the selected listbox items employeeId
                Players listitem = listBoxobj.SelectedItem as Players;
                //show the delete update page with the selected employeeID
                Frame.Navigate(typeof(DeleteUpdatePlayers), SelectedplayerId = listitem.playerId);

            }
        }

        //provides the user with an alternative way to add and delete

        private void AddEmp_Click(object sender, RoutedEventArgs e)
        {
            //navigate to Add employees
            Frame.Navigate(typeof(AddPlayers));
        }

        }
}
