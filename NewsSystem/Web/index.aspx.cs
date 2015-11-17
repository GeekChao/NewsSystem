using System;
using System.Web;
using System.Web.UI;

namespace NewsSystem
{
	
	public partial class index : System.Web.UI.Page
	{
		public News mHotActNews = new News ();
		public News mHotAcaNews = new News ();
		public News mHotElseNews = new News ();

		protected void Page_Load(object sender, EventArgs e)
		{
			NewsDAO mNewsDAO = new NewsDAO ();
				// get hotest activity news
			mNewsDAO.selectHotNews (Constant.NEWSACTIVITY, mHotActNews);
				// get hotest academic news
			mNewsDAO.selectHotNews (Constant.NEWSACADEMIC, mHotAcaNews);
				//get hotest else news
			mNewsDAO.selectHotNews (Constant.NEWSELSE, mHotElseNews);
			this.DataBind ();
		}

		public void searchBtnClick(object sender, EventArgs e)
		{
			String text = mSearchText.Value.ToString().Trim();
			Response.Redirect ("searchResults.aspx?search=" + text);
		}
	}
}

