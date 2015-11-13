using System;
using System.Web;
using System.Web.UI;

namespace NewsSystem
{
	
	public partial class index : System.Web.UI.Page
	{
		
		public void searchBtnClick(object sender, EventArgs e)
		{
			String text = mSearchText.Value.ToString().Trim();
			Response.Redirect ("searchResults.aspx?search=" + text);
		}

	}
}

