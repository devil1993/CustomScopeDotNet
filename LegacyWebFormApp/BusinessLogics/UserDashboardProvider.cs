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
        public string GetWelcomeMessage(LegacyState state)
        {
            var tenantDataAccess = new TenantDataAccess(state);
            var tenantInfo = tenantDataAccess.GetTenantInfo();

            var tenantProvider = new TenantProvider(tenantInfo);
            var userDataAccess = new UserDataAccess(state);

            var welcomeMessage = tenantProvider.GenerateWelcomeMessage(userDataAccess.GetUserName());

            return welcomeMessage;
        }
    }
}