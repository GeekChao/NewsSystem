using System;
using System.Web;
using System.Web.UI;

namespace NewsSystem
{
	
	public partial class NewsContent : System.Web.UI.Page
	{
		public News mNews = new News();
		private String newsId;
		private NewsDAO mNewsDAO = new NewsDAO ();

		protected void Page_Load(object sender, EventArgs e)
		{
			newsId = Request.QueryString ["newsId"];
			mNewsDAO.selectByID (newsId, mNews);
			this.DataBind ();
		}

		public void thumbsUpBtnClick(object sender, EventArgs e)
		{
			mNewsDAO.updateByID (newsId, Constant.THUMBUP);
		}

		public void thumbsDownBtnClick(object sender, EventArgs e)
		{
			mNewsDAO.updateByID (newsId, Constant.THUMBDOWN);
		}
	}
}

