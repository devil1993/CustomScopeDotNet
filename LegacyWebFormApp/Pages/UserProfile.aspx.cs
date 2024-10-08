﻿using BusinessLogics;
using LegacyWebFormApp.Core;
using LegacyWebFormApp.DataAccess.Adapters;
using LegacyWebFormApp.DIContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Extensions.DependencyInjection;

namespace LegacyWebFormApp.Pages
{
    public partial class UserProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LegacyState state = LegacyState.FromSession(Session);

            using (var scope = DIContainer.ServiceProvider.GetServiceScope())
            {
                var stateFromContainer = scope.ServiceProvider.GetRequiredService<LegacyState>();

                stateFromContainer.UserId = state.UserId;
                stateFromContainer.TenantId = state.TenantId;
                stateFromContainer.DbConnection = state.DbConnection;

                var userDashboardProvider = scope.ServiceProvider.GetRequiredService<UserDashboardProvider>();
                var welcomeMessage = userDashboardProvider.GetWelcomeMessage();

                this.lWelcomeMsg.Text = welcomeMessage;
            }


        }
    }
}