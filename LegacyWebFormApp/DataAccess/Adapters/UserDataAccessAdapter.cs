using BusinessLogics;
using LegacyWebFormApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegacyWebFormApp.DataAccess.Adapters
{
    public class UserDataAccessAdapter : IUserDataAccess
    {
        private readonly UserDataAccess userDataAccess;

        public UserDataAccessAdapter(UserDataAccess userDataAccess)
        {
            this.userDataAccess = userDataAccess;
        }
        public string GetCurrentUserName()
        {
            return userDataAccess.GetUserName();
        }
    }
}