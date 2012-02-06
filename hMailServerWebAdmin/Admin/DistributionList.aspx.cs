using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hMailServerWebAdmin.Admin
{
    public partial class DistributionList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hMailServerNetRemote.Application app = RemoteActivation.GetAuthenticatedRemotehMailServerApplication();
            if (app == null)
                Response.End();

            string[] sp = Request.QueryString["Address"].Split(new Char[] { '@' });
            if (sp.Length != 2)
            {
                Response.StatusCode = 404;
                Response.End();
            }

            hMailServerNetRemote.Domain domain = app.Domains.ItemByName(sp[1]);
            if (domain == null)
            {
                Response.StatusCode = 404;
                Response.End();
            }

            hMailServerNetRemote.DistributionList ds = domain.DistributionLists.ItemByAddress(Request.QueryString["Address"]);
            if (ds == null)
            {
                Response.StatusCode = 404;
                Response.End();
            }

            hMailServerNetRemote.DistributionListRecipients re = ds.Recipients;

            if (!IsPostBack)
            {
                DistributionListName.Text = ds.Address;

                List<hMailServerNetRemote.DistributionListRecipient> addys = new List<hMailServerNetRemote.DistributionListRecipient>();
                int c = re.Count;                
                for (int i = 0; i < c; i++)
                {
                    addys.Add(re[i]);
                }

                AddressList.DataSource = addys;
                AddressList.DataBind();
            }

        }
    }
}