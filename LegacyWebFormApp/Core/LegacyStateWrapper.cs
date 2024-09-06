using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegacyWebFormApp.Core
{
    public class LegacyStateWrapper : LegacyState
    {
        private LegacyState _legacyState;
        public LegacyStateWrapper() { }

        public void SetInternalState(LegacyState state)
        {
            _legacyState = state;
        }

        public override string DbConnection { get => _legacyState.DbConnection; }
        public override string TenantId { get => _legacyState.TenantId; }
        public override string UserId { get => _legacyState.UserId; }
    }
}