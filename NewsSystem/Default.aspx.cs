using System;
using System.Web;
using System.Web.UI;

namespace NewsSystem
{
	
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{	
			Response.Redirect ("/Web/index.aspx");
		}

//		public void button1Clicked (object sender, EventArgs args)
//		{
//			button1.Text = "You clicked me";
//			//Server.Transfer ("../Web/index.aspx", true);
//
//			NewsDAO mNewsDAO = new NewsDAO ();
//			News mNews = new News ();
//			mNewsDAO.selectByID ("SELECT * FROM News WHERE news_id = 1;", mNews);
//			Console.WriteLine (mNews.toString());
//		}
	}
}

