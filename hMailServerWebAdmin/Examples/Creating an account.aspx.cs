using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hMailServerWebAdmin.Examples
{
    public partial class Creating_an_account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hMailServerNetRemote.ClassFactory cf = RemoteActivation.GetRemoteClassFactory("http://216.167.175.124/hMailServerWebAdmin/");

            hMailServerNetRemote.Application application;
            if (Session["hMailServerNetRemoteApplication"] == null)
            {
                application = cf.CreateApplication();
                Session["hMailServerNetRemoteApplication"] = application;
            }
            else
            {
                application = (hMailServerNetRemote.Application)Session["hMailServerNetRemoteApplication"];
            }

            // the rest is the same
            application.Authenticate("Administrator", "your-main-hmailserver-password");

            // You can do it like VB, but let's do it the C# way. :)
            // hMailServerNetRemote.Domain domain = application.Domains.ItemByName("example.com");
            hMailServerNetRemote.Domain domain = application.Domains["example.com"];

            hMailServerNetRemote.Account account = domain.Accounts.Add();
            account.Address = "account@example.com";
            account.Password = "secret";
            account.Active = true;
            account.MaxSize = 100;
            account.Save();  
        }
    }
}