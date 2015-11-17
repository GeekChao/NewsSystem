using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSystem
{
	
	public partial class newsManage : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack) {
				initNewsManage ();
			}
		}

		public void initNewsManage()
		{
			NewsDAO mNewsDAO = new NewsDAO ();
			mNewsDAO.selectAll (repNewsManage);	
		}

		public void deleteNewsBtnClick(object sender, EventArgs e)
		{
			String id = ((LinkButton)sender).CommandArgument;
			NewsDAO mNewsDAO = new NewsDAO ();
			mNewsDAO.deleteByID (id, repNewsManage);
			initNewsManage ();
		}

		public void addNewsBtnClick(object sender, EventArgs e)
		{
			Response.Redirect ("insertNews.aspx");
		}
	}
}

