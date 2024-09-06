using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLogics;

namespace LegacyWebFormApp.DataAccess
{
    using LegacyWebFormApp.Core;
    public class TenantDataAccess
    {
        private readonly LegacyState state;

        public TenantDataAccess(LegacyState state)
        {
            this.state = state;
        }

        internal TenantInfo GetTenantInfo()
        {
            var tenantId = this.state.TenantId;
            var connectionString = this.state.DbConnection;
            // logic to connect to database using connectionString
            // fetch TenantInfo from database for the tenant with tenantId
            return new TenantInfo();
        }
    }
}