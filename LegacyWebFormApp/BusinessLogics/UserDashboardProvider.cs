using LegacyWebFormApp.Core;
using LegacyWebFormApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegacyWebFormApp.BusinessLogics
{
    public class UserDashboardProvider
    {
        public string GetWelcomeMessage(State state)
        {
            var tenantDataAccess = new TenantDataAccess(state.DbConnection);
            var tenantInfo = tenantDataAccess.GetTenantInfo(state.TenantId);
            var tenantProvider = new TenantProvider(tenantInfo);

            var userDataAccess = new UserDataAccess(state.DbConnection);

            var welcomeMessage = tenantProvider.GenerateWelcomeMessage(userDataAccess.GetUserName(state.UserId));

            return welcomeMessage;
        }
    }
}