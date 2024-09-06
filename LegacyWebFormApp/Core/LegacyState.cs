using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegacyWebFormApp.Core
{
    public class LegacyState
    {
        public virtual string UserId { get; set; }
        public virtual string TenantId { get; set; }
        public virtual string DbConnection { get; set; }

        public static LegacyState FromSession(System.Web.SessionState.HttpSessionState session)
        {
            // Logic to fetch State information from the HttpSession goes here
            // We would connect some state provider to get information about the
            // logged in user, connect some tenancy resolver to identify the
            // related tenant, connect to some secure configuration store to fetch
            // database connection for the corresponding tenant etc. 
            // For the shake of simplicity, we new up for the discusison.

            return new LegacyState();
        }
    }
}