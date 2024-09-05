using LegacyWebFormApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegacyWebFormApp.DataAccess
{
    public class UserDataAccess
    {
        private LegacyState state;

        public UserDataAccess(LegacyState state)
        {
            this.state = state;
        }

        internal string GetUserName()
        {
            // logic to connect the database with state.DbConnection
            // and get the name of the user using state.UserId
            return "Dummy UserName";
        }
    }
}