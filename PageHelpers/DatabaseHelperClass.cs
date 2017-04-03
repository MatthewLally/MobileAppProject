using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MobileAppProject.PageHelpers
{
    public class DatabaseHelperClass
    {
        SQLiteConnection dbConn;

        //Create Table 
        public async Task<bool> onCreate(string DB_PATH)
        {
            //have to use async and await as the task runs for a while
            try
            {
                //Create the table if it doesn't exist(happens when CheckFileExists returns false)
                if (!CheckFileExists(DB_PATH).Result)
                {
                    //create a new connection to the db at the path specified in app.cs
                    using (dbConn = new SQLiteConnection(DB_PATH))
                    {
                        //create the table from the players.cs in the page helpers
                        dbConn.CreateTable<Players>();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        } //onCreate

        //check if the file exists(for the database)
        private async Task<bool> CheckFileExists(string fileName)
        {
            try
            {
                var store = await Windows.Storage.ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                return true;
            }
            catch
            {
                //return false if the file doesnt exist, so we can create the table (above and in dbHelper)
                return false;
            }
        }

        //get one player when its selected

        //get back the player that has been selected from the db
        //pass the method the player id that the user wants
        public Players ReadPlayers(int playerId)
        {
            //get a connection to the database
            using (var dbConn = new SQLiteConnection(App.DB_PATH))
            {
                //execute the select statement on the player table where the id is equal to the playerId selected
                var existingPlayer = dbConn.Query<Players>("select * from Players where playerId =" + playerId).FirstOrDefault();
                return existingPlayer;
                //reurn the player that was returned
            }
        }

        //retrieve all players to be displayed in a list

        //pass the method an observable colelction of players
        public ObservableCollection<Players> ReadPlayers()
        {
            //get a connection to the database
            using (var dbConn = new SQLiteConnection(App.DB_PATH))
            {
                //create a list of players from the data in the table
                List<Players> myCollection = dbConn.Table<Players>().ToList<Players>();
                //make an observable collection out of the list
                ObservableCollection<Players> playersList = new ObservableCollection<Players>(myCollection);
                //return the observable collection
                return playersList;
            }
        }
        public void Insert(Players newPlayer)
        {
            //get a connection to the database
            using (var dbConn = new SQLiteConnection(App.DB_PATH))
            {
                //use the SQLite insert method to add a new player to the table
                dbConn.Insert(newPlayer);
            }
        }
             public void DeletePlayer(int playerId)
        {
            //get connection
            using (var dbConn = new SQLiteConnection(App.DB_PATH))
            {
               
                var existingPlayer = dbConn.Query<Players>("select * from Players where playerId =" + playerId).FirstOrDefault();

                //check that the record is not null
                if (existingPlayer != null)
                {
                    //use the SQLite method to delete the player
                    dbConn.Delete(existingPlayer);
                }
            }
            }
        public void UpdatePlayer(Players player)
        {
            //get a conenction to the db
            using (var dbConn = new SQLiteConnection(App.DB_PATH))
            {
                
                var existingPlayer = dbConn.Query<Players>("select * from Players where playerId =" + player.playerId).FirstOrDefault();
                //if the record is not empty
                if (existingPlayer != null)
                {
                    //set the new values entered to the variables in the model
                    existingPlayer.playerName = player.playerName;
                    existingPlayer.playerClub = player.playerClub;
                    existingPlayer.playerPosition = player.playerPosition;

                    //use the SQLite update method to update the record
                    dbConn.Update(existingPlayer);
                }
            }
            }
        }
}
