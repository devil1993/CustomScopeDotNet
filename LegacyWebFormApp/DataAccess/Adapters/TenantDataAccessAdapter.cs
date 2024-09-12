using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLogics;
using LegacyWebFormApp.Core;

namespace LegacyWebFormApp.DataAccess.Adapters
{
    public class TenantDataAccessAdapter : ITenantDataAccess
    {
        private TenantDataAccess tenantDataAccess;

        public TenantDataAccessAdapter(TenantDataAccess tenantDataAccess)
        {
            this.tenantDataAccess = tenantDataAccess;
        }

        public TenantInfo GetCurrentTenantInformation()
        {
            return tenantDataAccess.GetTenantInfo();
        }
    }
}