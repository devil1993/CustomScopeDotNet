using BusinessLogics;
using LegacyWebFormApp.Core;
using LegacyWebFormApp.DataAccess.Adapters;
using LegacyWebFormApp.DIContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LegacyWebFormApp.Pages
{
    public partial class UserProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LegacyState state = LegacyState.FromSession(Session);

            var userDashboardProvider = ServiceProvider.GetRequiredService<UserDashboardProvider>();

            var welcomeMessage = userDashboardProvider.GetWelcomeMessage();

            this.lWelcomeMsg.Text = welcomeMessage;
        }
    }
}