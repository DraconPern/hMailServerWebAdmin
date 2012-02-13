using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hMailServerWebAdmin.Admin
{
    public partial class DistributionLists : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hMailServerNetRemote.IApplication app = RemoteActivation.GetAuthenticatedRemotehMailServerApplication();
                if (app == null)
                    Response.End();

                hMailServerNetRemote.IDomain dom = app.Domains.ItemByDBID(Convert.ToInt32(Request.QueryString["ID"]));

                DomainName.Text = dom.Name;

                List<hMailServerNetRemote.IDistributionList> dls = new List<hMailServerNetRemote.IDistributionList>();
                hMailServerNetRemote.IDistributionLists d = dom.DistributionLists;
                int c = d.Count;

                for (int i = 0; i < c; i++)
                {
                    dls.Add(d[i]);
                }

                DistributionList.DataSource = dls;
                DistributionList.DataBind();
            }
        }
    }
}