using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using System.Collections;

namespace hMailServerWebAdmin
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup

            // server registration using http
            IDictionary properties = new Hashtable();
            properties["machineName"] = Properties.Settings.Default.hMailServerWebAdminMachineName;
            HttpServerChannel channel = new HttpServerChannel(properties, null);
            ChannelServices.RegisterChannel(channel, false);

            LifetimeServices.LeaseTime = TimeSpan.FromMinutes(10);
            LifetimeServices.RenewOnCallTime = TimeSpan.FromMinutes(15);

            RemotingConfiguration.RegisterWellKnownServiceType(new WellKnownServiceTypeEntry(
               typeof(hMailServerNetRemote.ClassFactory),
               "Remote.soap",
               WellKnownObjectMode.SingleCall
            ));

            // client registration (for calling a server) using http
            BinaryClientFormatterSinkProvider clnt = new BinaryClientFormatterSinkProvider();
            HttpClientChannel client = new HttpClientChannel((IDictionary) null, clnt);
            ChannelServices.RegisterChannel(client, false);
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

    }
}
