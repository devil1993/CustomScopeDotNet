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
        private LegacyState state;

        public TenantDataAccessAdapter(LegacyStateWrapper state)
        {
            this.state = state;
        }

        public TenantInfo GetCurrentTenantInformation()
        {
            return new TenantDataAccess(state).GetTenantInfo();
        }
    }
}