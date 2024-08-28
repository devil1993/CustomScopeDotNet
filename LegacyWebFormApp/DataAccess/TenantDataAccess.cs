using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegacyWebFormApp.DataAccess
{
    using LegacyWebFormApp.Core;
    public class TenantDataAccess
    {
        private string dbConnection;

        public TenantDataAccess(string dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        internal TenantInfo GetTenantInfo(string tenantId)
        {
            // logic to fetch TenantInfo from database
            return new TenantInfo();
        }
    }
}