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
        private readonly LegacyState state;

        public UserDataAccessAdapter(LegacyStateWrapper state)
        {
            this.state = state;
        }
        public string GetCurrentUserName()
        {
            return (new DataAccess.UserDataAccess(state)).GetUserName();
        }
    }
}