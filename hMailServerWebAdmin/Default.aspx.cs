using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using hMailServerNetRemote;

namespace hMailServerWebAdmin
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            hMailServerNetRemote.ClassFactory cf = RemoteActivation.GetRemoteClassFactory("http://216.167.175.124/hMailServerWebAdmin/");

            hMailServerNetRemote.Application app;
            if (Session["hMailServerNetRemoteApplication"] == null)
            {
                app = cf.CreateApplication();
                Session["hMailServerNetRemoteApplication"] = app;
            }
            else
            {
                app = (hMailServerNetRemote.Application)Session["hMailServerNetRemoteApplication"];
            }
            
            // the rest is the same
            hMailServerNetRemote.Account account = app.Authenticate(Username.Text, Password.Text);
            hMailServerNetRemote.Domain d = app.Domains["frontmotion.com"];

            hMailServerNetRemote.DistributionList l = d.DistributionLists.ItemByAddress("testabcd@frontmotion.com");            
            l.Recipients.Add("eric@frontmotion.com");              
             * */
        }
    }
}
