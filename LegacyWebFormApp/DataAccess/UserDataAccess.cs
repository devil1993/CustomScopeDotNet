using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegacyWebFormApp.DataAccess
{
    public class UserDataAccess
    {
        private string dbConnection;

        public UserDataAccess(string dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        internal string GetUserName(string userId)
        {
            // logic to get the name of the user from database.
            return "Dummy UserName";
        }
    }
}