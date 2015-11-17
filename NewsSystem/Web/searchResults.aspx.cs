using System;
using System.Web;
using System.Web.UI.WebControls;

namespace NewsSystem
{
	
	public partial class searchResults : System.Web.UI.Page
	{
		public String searchText;

		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack){
				searchText = Request.QueryString["search"]; 
				NewsDAO mNewsDAO = new NewsDAO ();
				mNewsDAO.searchNews (searchText, repSearchResult);
			}
		}
	}
}

