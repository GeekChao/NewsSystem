using System;
using System.Web;
using System.Web.UI;

namespace NewsSystem
{
	
	public partial class updateNews : System.Web.UI.Page
	{
		private static String mNewsId;
		public News mNews = new News();
		private const String IMG_BASE_PATH = "images/";

		protected void Page_Load()
		{
			if (!Page.IsPostBack) {
				mNewsId = Request.QueryString ["newsId"];
				new NewsDAO ().selectByID (mNewsId, mNews);
				setRadioBtn (mNews.NewsCateId);
				this.DataBind ();
			}
		}

		public String setImgName(String url)
		{
			String[] str = url.Split('/');
			return str [1];
		}

		private void setRadioBtn(int cateId)
		{
			switch (cateId) {
			case Constant.CATEACTIVITY:
					radAct.Checked = true;
					radAca.Checked = false;
					radElse.Checked = false;
					break;
			case Constant.CATEACADEMIC:
					radAct.Checked = false;
					radAca.Checked = true;
					radElse.Checked = false;
					break;
			case Constant.CATEELSE:
					radAct.Checked = false;
					radAca.Checked = false;
					radElse.Checked = true;
					break;
				default:
					break;
			}
		}
			
		public void btnSubmitClick(object sender, EventArgs e)
		{
			if (radAct.Checked) {
				mNews.NewsCateId = Constant.CATEACTIVITY;
			} else if (radAca.Checked) {
				mNews.NewsCateId = Constant.CATEACADEMIC;
			} else if (radElse.Checked) {
				mNews.NewsCateId = Constant.CATEELSE;
			}

			mNews.NewsId = Int32.Parse (mNewsId);
			mNews.NewsTitle = Request.Form["title"];
			mNews.NewsImgUrl = IMG_BASE_PATH +  Request.Form["img"];
			mNews.NewsDate = ProcessData.getFormatedDateTime ();
			mNews.NewsText = mTextArea.InnerText;
			Console.Write (mNews.toString());
			new NewsDAO ().updateNews (mNews);
		}
	}
		
}

