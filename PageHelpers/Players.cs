using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppProject.PageHelpers
{
    public class Players
    {
        //The Id property is marked as the Primary Key
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int playerId { get; set; }

        //get and set for Specific player details
        public string playerName { get; set; }
        public string playerClub { get; set; }
        public string playerPosition { get; set; }
        //to show when the record was made
        public string CreationDate { get; set; }

        //empty constructor
        public Players()
        {

        }

        //constructor to initialise the player details
        public Players(string name, string club, string position)
        {
            //initialise the variables
            playerName = name;
            playerClub = club;
            playerPosition = position;

            //set the currentDate to the current time (when the value was created)
            CreationDate = DateTime.Now.ToString();
        }
    }
}
