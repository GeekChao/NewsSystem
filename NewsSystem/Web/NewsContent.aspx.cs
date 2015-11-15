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
		private String sql;

		protected void Page_Load(object sender, EventArgs e)
		{
			newsId = Request.QueryString ["newsId"];
			sql = "SELECT * FROM News WHERE news_id = " + newsId + ";";
			mNewsDAO.selectByID (sql, mNews);
			this.DataBind ();
		}

		public void thumbsUpBtnClick(object sender, EventArgs e)
		{
			sql = "UPDATE Comment SET thumb_num = thumb_num + 1 WHERE com_news_id = " + newsId+ ";";
			mNewsDAO.updateByID (sql);
		}

		public void thumbsDownBtnClick(object sender, EventArgs e)
		{
			sql = "UPDATE Comment SET thumb_num = thumb_num - 1 WHERE com_news_id = " + newsId+ ";";
			mNewsDAO.updateByID (sql);
		}
	}
}

