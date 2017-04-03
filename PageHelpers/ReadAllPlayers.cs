using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppProject.PageHelpers
{
    class ReadAllPlayers
    {
        //create an instance of the dbhelper class
        DatabaseHelperClass Db_Helper = new DatabaseHelperClass();

        //get all players method
        //pass it an observable coleection
        public ObservableCollection<Players> GetAllPlayers()
        {
            //use read players method in dbhelper class
            return Db_Helper.ReadPlayers();
        }
    }
}
