using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using hMailServerNetRemote;


namespace hMailServerWebAdmin
{
    public class RemoteActivation
    {
        public static IClassFactory GetRemoteClassFactory()
        {
            string url = Properties.Settings.Default.hMailServerWebAdminRemoteUrl;
            if (url.Length == 0)
            {
                url = string.Format("{0}://{1}{2}{3}",
                                    HttpContext.Current.Request.Url.Scheme,
                                    HttpContext.Current.Request.Url.Host,
                                    HttpContext.Current.Request.Url.Port == 80
                                        ? string.Empty
                                        : ":" + HttpContext.Current.Request.Url.Port,
                                    HttpContext.Current.Request.ApplicationPath);
            }
            if (!url.EndsWith("/"))
                url += "/";

            hMailServerNetRemote.ClassFactory cf = (hMailServerNetRemote.ClassFactory)Activator.GetObject(
              typeof(hMailServerNetRemote.ClassFactory), url + "Remote.soap");

            return cf;
        }

        public static IClassFactory GetRemoteClassFactory(string hMailServerWebAdminRemoteUrl)
        {
            string url = hMailServerWebAdminRemoteUrl;
            if (!url.EndsWith("/"))
                url += "/";

            hMailServerNetRemote.ClassFactory cf = (hMailServerNetRemote.ClassFactory)Activator.GetObject(
              typeof(hMailServerNetRemote.ClassFactory), url + "Remote.soap");

            return cf;
        }

        public static IApplication GetRemotehMailServerApplication()
        {
            hMailServerNetRemote.IClassFactory cf = RemoteActivation.GetRemoteClassFactory();

            hMailServerNetRemote.IApplication app;
            if (HttpContext.Current.Session["hMailServerNetRemoteApplication"] == null)
            {
                app = cf.CreateApplication();
                HttpContext.Current.Session["hMailServerNetRemoteApplication"] = app;
            }
            else
            {
                app = (hMailServerNetRemote.IApplication)HttpContext.Current.Session["hMailServerNetRemoteApplication"];
            }
                        
            return app;
        }

        public static IApplication GetAuthenticatedRemotehMailServerApplication()
        {
            hMailServerNetRemote.IApplication app = GetRemotehMailServerApplication();
            if (!app.Authenticated)
            {
                FormsAuthentication.SignOut();
                FormsAuthentication.RedirectToLoginPage();
                return null;
            }

            return app;
        }

        public static IApplication GetLocalhMailServerApplication()
        {
            hMailServerNetRemote.ClassFactory cf = new ClassFactory();

            hMailServerNetRemote.IApplication app;
            if (HttpContext.Current.Session["hMailServerNetRemoteApplication"] == null)
            {
                app = cf.CreateApplication();
                HttpContext.Current.Session["hMailServerNetRemoteApplication"] = app;
            }
            else
            {
                app = (hMailServerNetRemote.IApplication)HttpContext.Current.Session["hMailServerNetRemoteApplication"];
            }

            return app;
        }
    }
}
