using Microsoft.AspNet.SignalR;
using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.SessionState;
using WeaponAndWizardry.Code;

namespace WeaponAndWizardry
{
    /// <summary>
    /// Author: 
    ///     Name: Jia Qi Lee (George) Date: 2017-11-15
    /// </summary>
    public class Global : HttpApplication
    {
        //Lock for synchronization
        private static object _lock = new object();


        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void Session_Start(object sender, EventArgs e)
        {
            SessionHandler.Clients = GlobalHost.ConnectionManager.GetHubContext<SoundPlayerHub>().Clients;
        }
    }
}