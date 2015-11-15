using System;
using System.Web;
using System.Web.UI;

namespace NewsSystem
{
	
	public partial class insertNews : System.Web.UI.Page
	{
		private News mNews = new News();

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
			mNews.NewsDate = ProcessData.getFormatedDateTime ();
			mNews.NewsText = mTextArea.InnerText;
			mNews.NewsImgUrl = ProcessData.getImgSrcFromHtml(mNews.NewsText);
			//Console.Write (DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
			new NewsDAO ().insertNews (mNews);
		}
	}
}

