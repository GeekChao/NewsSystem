using System;
using System.Web;
using System.Web.UI;

namespace NewsSystem
{
	
	public partial class insertNews : System.Web.UI.Page
	{
		private News mNews = new News();
		private const String IMG_BASE_PATH = "images/";

		protected void Page_Load(object sender, EventArgs e)
		{
		}

		public void btnSubmitClick(object sender, EventArgs e)
		{
			mNews.NewsTitle = Request.Form["title"];
			if (radAct.Checked) {
				mNews.NewsCateId = Category.ACTIVITY;
			} else if (radAca.Checked) {
				mNews.NewsCateId = Category.ACADEMIC;
			} else if (radElse.Checked) {
				mNews.NewsCateId = Category.ELSE;
			}
			mNews.NewsImgUrl = IMG_BASE_PATH +  Request.Form ["img"];
			mNews.NewsDate = ProcessData.getFormatedDateTime ();
			mNews.NewsText = mTextArea.InnerText;
			new NewsDAO ().insertNews (mNews);
		}
	}
}

