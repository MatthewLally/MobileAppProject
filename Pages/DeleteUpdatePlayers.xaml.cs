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
using MobileAppProject.PageHelpers;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MobileAppProject.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DeleteUpdatePlayers : Page
    {
        int Selected_playerId = 0;
        DatabaseHelperClass Db_Helper = new DatabaseHelperClass(); 
        Players currentPlayer = new Players();
        public DeleteUpdatePlayers()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //get the selected player Id so it can be used to load other fields
            Selected_playerId = int.Parse(e.Parameter.ToString());
            //call the readPlayers method on the selected player
            currentPlayer = Db_Helper.ReadPlayers(Selected_playerId);

            //set the textbox's to the values retrieved from ReadPlayer
            NametxtBx.Text = currentPlayer.playerName;
            ClubtxtBx.Text = currentPlayer.playerClub;
            PositiontxtBx.Text = currentPlayer.playerPosition;
        }
        private void UpdatePlayer_Click(object sender, RoutedEventArgs e)
        {
            //set the new textbox values to currentPlayer
            currentPlayer.playerName = NametxtBx.Text;
            currentPlayer.playerClub = ClubtxtBx.Text;
            currentPlayer.playerPosition = PositiontxtBx.Text;

            //Update the db to the new values the user entered
            Db_Helper.UpdatePlayer(currentPlayer);
            //navigate to the ReadPlayers page so the user can see their changes
            Frame.Navigate(typeof(ReadPlayers));
        }
        private void DeletePlayer_Click(object sender, RoutedEventArgs e)
        {
            //Delete the selected player from the db
            Db_Helper.DeletePlayer(Selected_playerId);
            //navigate to the ListBox view so the user can see their changes
            Frame.Navigate(typeof(ReadPlayers));
        }
    }
}
