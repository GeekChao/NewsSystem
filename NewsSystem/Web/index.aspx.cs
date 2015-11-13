using System;
using System.Web;
using System.Web.UI;

namespace NewsSystem
{
	
	public partial class index : System.Web.UI.Page
	{
		
		public void searchBtnClick(object sender, EventArgs e)
		{
			String str = mSearchText.Value.ToString();
			if (str == null) {
				Response.Write ("string is empty");
			} else {
				Response.Write (str);
			}
			//Response.Redirect ("searchResults.aspx?search=" + str);
		}
	}
}

