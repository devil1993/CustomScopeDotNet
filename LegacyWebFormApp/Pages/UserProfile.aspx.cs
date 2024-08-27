using LegacyWebFormApp.Core;
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
            State state = State.FromSession(Session);
            var userDashboardProvider = new BusinessLogics.UserDashboardProvider();

            var welcomeMessage = userDashboardProvider.GetWelcomeMessage(state);

            this.lWelcomeMsg.Text = welcomeMessage;
        }
    }
}