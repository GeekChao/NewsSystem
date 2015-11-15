using System;
using System.Web;
using System.Web.UI;

namespace NewsSystem
{
	
	public partial class NewsContent : System.Web.UI.Page
	{
		public News mNews = new News();

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack) {
				NewsDAO mNewsDAO = new NewsDAO ();
				String newsId = Request.QueryString ["newsId"];
				String sql = "SELECT * FROM News WHERE news_id = " + newsId + ";";
				mNewsDAO.selectByID (sql, mNews);
				this.DataBind ();
			}
		}
	}
}

