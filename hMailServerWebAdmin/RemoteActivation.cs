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
        public static ClassFactory GetRemoteClassFactory()
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

        public static ClassFactory GetRemoteClassFactory(string hMailServerWebAdminRemoteUrl)
        {
            string url = hMailServerWebAdminRemoteUrl;
            if (!url.EndsWith("/"))
                url += "/";

            hMailServerNetRemote.ClassFactory cf = (hMailServerNetRemote.ClassFactory)Activator.GetObject(
              typeof(hMailServerNetRemote.ClassFactory), url + "Remote.soap");

            return cf;
        }

        public static Application GetRemotehMailServerApplication()
        {
            hMailServerNetRemote.ClassFactory cf = RemoteActivation.GetRemoteClassFactory();

            hMailServerNetRemote.Application app;
            if (HttpContext.Current.Session["hMailServerNetRemoteApplication"] == null)
            {
                app = cf.CreateApplication();
                HttpContext.Current.Session["hMailServerNetRemoteApplication"] = app;
            }
            else
            {
                app = (hMailServerNetRemote.Application)HttpContext.Current.Session["hMailServerNetRemoteApplication"];
            }
                        
            return app;
        }

        public static Application GetAuthenticatedRemotehMailServerApplication()
        {
            hMailServerNetRemote.Application app = GetRemotehMailServerApplication();
            if (!app.Authenticated)
            {
                FormsAuthentication.SignOut();
                FormsAuthentication.RedirectToLoginPage();
                return null;
            }

            return app;
        }

        public static Application GetLocalhMailServerApplication()
        {
            hMailServerNetRemote.ClassFactory cf = new ClassFactory();

            hMailServerNetRemote.Application app;
            if (HttpContext.Current.Session["hMailServerNetRemoteApplication"] == null)
            {
                app = cf.CreateApplication();
                HttpContext.Current.Session["hMailServerNetRemoteApplication"] = app;
            }
            else
            {
                app = (hMailServerNetRemote.Application)HttpContext.Current.Session["hMailServerNetRemoteApplication"];
            }

            return app;
        }
    }
}
