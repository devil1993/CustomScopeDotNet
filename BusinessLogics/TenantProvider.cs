using System;

namespace BusinessLogics
{
    public class TenantProvider
    {
        private TenantInfo currentTenant;
        public TenantProvider(TenantInfo ti)
        {
            currentTenant = ti;
        }
        public string GenerateWelcomeMessage(string userName)
        {
            return $"Welcome to your \"{currentTenant.Name}\" dashboard, {userName}";
        }
    }
}
