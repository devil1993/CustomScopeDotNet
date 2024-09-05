using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogics
{
    public class UserDashboardProvider
    {
        private ITenantDataAccess tenantDataAccess;
        private IUserDataAccess userDataAccess;
        public UserDashboardProvider(ITenantDataAccess tenantDataAccess, IUserDataAccess userDataAccess)
        {
            this.tenantDataAccess = tenantDataAccess;
            this.userDataAccess = userDataAccess;
        }
        public string GetWelcomeMessage()
        {
            var tenantInfo = tenantDataAccess.GetCurrentTenantInformation();

            var tenantProvider = new TenantProvider(tenantInfo);

            var welcomeMessage = tenantProvider.GenerateWelcomeMessage(userDataAccess.GetCurrentUserName());

            return welcomeMessage;
        }
    }
}
