using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MobileAppProject.PageHelpers;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using Microsoft.Data.Sqlite;
using Microsoft.Data.Sqlite.Internal;
namespace MobileAppProject.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddPlayers : Page
    {
        public AddPlayers()
        {
            this.InitializeComponent();
        }
        private async void AddPlayer_Click(object sender, RoutedEventArgs e) 
        {
            DatabaseHelperClass Db_Helper = new DatabaseHelperClass();//Create an object for DatabaseHelperClass.cs from PageHelpers/DatabaseHelperClass.cs 
            //if all fields have been filled in
            if (NametxtBx.Text != "" & PositiontxtBx.Text != "" & ClubtxtBx.Text != "")
            {
                //insert them into the database using the db Helper class
                Db_Helper.Insert(new Players(NametxtBx.Text, PositiontxtBx.Text, ClubtxtBx.Text));
                //after adding players bring the user to the listbox page to see their changes
                Frame.Navigate(typeof(ReadPlayers));
            }
            else
            {
                MessageDialog messageDialog = new MessageDialog("Please fill in all fields");//If fields are not filled prompt the user to fill them 
                await messageDialog.ShowAsync();
            }
        }
    }

    }
