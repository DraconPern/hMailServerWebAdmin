using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hMailServerWebAdmin.Admin
{
    public partial class Domain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hMailServerNetRemote.Application app = RemoteActivation.GetAuthenticatedRemotehMailServerApplication();
            if (app == null)
                Response.End();

            hMailServerNetRemote.Domain dom = app.Domains.ItemByDBID(Convert.ToInt32(Request.QueryString["ID"]));

            if (!IsPostBack)            
            {
                DomainName.Text = dom.Name;
                Enabled.Checked = dom.Active;
                AccountLink.NavigateUrl = "~/Admin/Accounts.aspx?ID=" + Request.QueryString["ID"];
                Aliases.NavigateUrl = "~/Admin/DomainAliases.aspx?ID=" + Request.QueryString["ID"];
                DistributionLists.NavigateUrl = "~/Admin/DistributionLists.aspx?ID=" + Request.QueryString["ID"];
            }
            else
            {    
                dom.Name = DomainName.Text;
                dom.Active = Enabled.Checked;
                dom.Save();
            }
            

        }
    }
}