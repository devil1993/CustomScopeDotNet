using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegacyWebFormApp.Core
{
    public class State
    {
        public string UserId { get; set; }
        public string TenantId { get; set; }
        public string DbConnection { get; set; }

        public static State FromSession(System.Web.SessionState.HttpSessionState session)
        {
            return new State();
        }
    }
}