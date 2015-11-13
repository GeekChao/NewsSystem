using System;
using System.Web;
using System.Web.UI;

namespace NewsSystem
{
	
	public partial class searchResults : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			String searchText = Request.QueryString["search"];
			Response.Write (searchText);
		}
		
	}
}

