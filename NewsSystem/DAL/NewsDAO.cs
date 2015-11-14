using System;
using System.Data;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace NewsSystem
{
	public class NewsDAO:MySqlHelper
	{
		private MySqlHelper mInstance;
		private IDbConnection mDbcon;
		private IDbCommand mDbcmd;
		private IDataReader mReader;

		public NewsDAO ()
		{
			mInstance = MySqlHelper.getInstance ();
			mDbcon = mInstance.Dbcon;
		}

		public void exectueQuery(String sql, News mNews)
		{
			mDbcmd = mDbcon.CreateCommand ();
			mDbcmd.CommandText = sql;
			mReader = mDbcmd.ExecuteReader ();

			while (mReader.Read ()) {
				mNews.NewsId = (ushort)mReader["news_id"];
				mNews.NewsTitle = (String)mReader["news_title"];
				mNews.NewsDate = (DateTime)mReader["news_date"];
				mNews.NewsText = (String)mReader["news_text"];
				mNews.NewsImgUrl = (String)mReader["news_img_url"];
				mNews.NewsCateId = (ushort)mReader["news_cate_id"];
			}
			//Console.Write (mNews.toString());
			cleanUp ();
		}

		public void searchNews(String sql, Repeater rep)
		{
			mDbcmd = mDbcon.CreateCommand ();
			mDbcmd.CommandText = sql;
			mReader = mDbcmd.ExecuteReader ();
			rep.DataSource = mReader;
			rep.DataBind ();
			cleanUp ();
		}

		public void selectHotNews(String category, News mNews)
		{
			String sql = "SELECT * FROM News INNER JOIN Comment ON com_news_id = news_id INNER JOIN Category C1 ON cate_id = news_cate_id WHERE cate_name = '";
			switch (category) 
			{
			case News.ACTIVITY:
				sql = sql + News.ACTIVITY + "' ORDER BY thumb_num DESC LIMIT 1;";
				exectueQuery (sql, mNews);
				Console.Write (sql);
				break;
			case News.ACADEMIC:
				sql = sql + News.ACADEMIC +  "' ORDER BY thumb_num DESC LIMIT 1;";
				exectueQuery (sql, mNews);
				break;
			case News.ELSE:
				sql = sql + News.ELSE +  "' ORDER BY thumb_num DESC LIMIT 1;";
				exectueQuery (sql, mNews);
				break;
			default:
				break;
			}
		}

		public void selectByID(String sql, News mNews)
		{
			exectueQuery (sql, mNews);
		}

		//release resources
		private void cleanUp()
		{
			if (mReader != null) {
				mReader.Close ();
				mReader = null;
			}
			if (mDbcmd != null) {
				mDbcmd.Dispose ();
				mDbcmd = null;
			}
		}
	}
}

