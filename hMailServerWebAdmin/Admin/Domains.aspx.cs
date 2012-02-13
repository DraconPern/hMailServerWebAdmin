using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;


namespace hMailServerWebAdmin.Admin
{
    public partial class Domains : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hMailServerNetRemote.IApplication app = RemoteActivation.GetAuthenticatedRemotehMailServerApplication();
                if (app == null)
                    Response.End();
                List<hMailServerNetRemote.IDomain> domains = new List<hMailServerNetRemote.IDomain>();
                int c = app.Domains.Count;
                hMailServerNetRemote.IDomains ds = app.Domains;

                for (int i = 0; i < c; i++)
                {
                    domains.Add(ds[i]);
                }

                DomainList.DataSource = domains;
                DomainList.DataBind();
            }
        }
    }
}