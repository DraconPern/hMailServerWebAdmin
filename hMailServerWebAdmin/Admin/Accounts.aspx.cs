using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hMailServerWebAdmin.Admin
{
    public partial class Accounts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                hMailServerNetRemote.Application app = RemoteActivation.GetAuthenticatedRemotehMailServerApplication();
                if (app == null)
                    Response.End();

                hMailServerNetRemote.Domain dom = app.Domains.ItemByDBID(Convert.ToInt32(Request.QueryString["ID"]));
           
                DomainName.Text = dom.Name;

                List<hMailServerNetRemote.Account> accounts = new List<hMailServerNetRemote.Account>();
                hMailServerNetRemote.Accounts accs = dom.Accounts;
                int c = accs.Count;
                
                for (int i = 0; i < c; i++)
                {
                    accounts.Add(accs[i]);
                }

                AccountList.DataSource = accounts;
                AccountList.DataBind();
            }
        }
    }
}