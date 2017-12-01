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

        // TODO:
        ///// <summary>
        ///// Strongly-typed string index for a Previously visited session
        ///// </summary>
        //private const string _previousSessionState = "previoussession";

        //public static HttpSessionState PreviousSessionState
        //{
        //    get
        //    {
        //        if (Application[""] == null)
        //        {
        //            return null;
        //        }
        //        else
        //        {
        //            return (HttpSessionState)HttpContext.Current.Session[_engine];
        //        }
        //    }
        //    set
        //    {
        //        _previousSessionState = value;
        //    }
        //}

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started
            lock (_lock)
            {
                SessionHandler.PreviousSessionState = Session;
            }
        }
    }
}