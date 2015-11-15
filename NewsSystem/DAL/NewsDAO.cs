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

		private void exectueQuery(String sql, News mNews)
		{
			mDbcmd = mDbcon.CreateCommand ();
			mDbcmd.CommandText = sql;
			mReader = mDbcmd.ExecuteReader ();

			while (mReader.Read ()) {
				mNews.NewsId = (ushort)mReader["news_id"];
				mNews.NewsTitle = (String)mReader["news_title"];
				mNews.NewsDate = Convert.ToString((DateTime)mReader["news_date"]);
				mNews.NewsText = (String)mReader["news_text"];
				mNews.NewsImgUrl = (String)mReader["news_img_url"];
				mNews.NewsCateId = (ushort)mReader["news_cate_id"];
			}
			//Console.Write (mNews.toString());
			cleanUp ();
		}

		private void bindReapter(String sql, Repeater rep)
		{
			mDbcmd = mDbcon.CreateCommand ();
			mDbcmd.CommandText = sql;
			mReader = mDbcmd.ExecuteReader ();
			rep.DataSource = mReader;
			rep.DataBind ();
			cleanUp ();
		}

		public void selectAll(String sql, Repeater rep)
		{
			bindReapter (sql, rep);
		}

		public void searchNews(String sql, Repeater rep)
		{
			bindReapter (sql, rep);
		}

		public void selectHotNews(String category, News mNews)
		{
			String sql = "SELECT * FROM News INNER JOIN Comment ON com_news_id = news_id INNER JOIN Category C1 ON cate_id = news_cate_id WHERE cate_name = '";
			switch (category) 
			{
			case News.ACTIVITY:
				sql = sql + News.ACTIVITY + "' ORDER BY thumb_num DESC LIMIT 1;";
				exectueQuery (sql, mNews);
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

		public void deleteByID(String sql, Repeater rep)
		{
			bindReapter (sql, rep);
		}

		public void updateByID(String sql)
		{
			mDbcmd = mDbcon.CreateCommand ();
			mDbcmd.CommandText = sql;
			mReader = mDbcmd.ExecuteReader ();
			cleanUp ();
		}
	/*	INSERT INTO News(news_title, news_date, news_text, news_img_url, news_cate_id) 
		VALUES('DIWALI-The Festival of Lights', '2015-11-04 17:27:58', 'Diwali, one of the most important holidays on the Hindu calendar, is a time of reflection and contemplation of the past year, and a celebration of the new year to come. A festival of lights lasting five days, Diwali represents the triumph of good over evil and light over darkness. Holiday traditions include the lighting of special lamps and candles through the night, and the exchanging of gifts (usually sweets) to relatives and neighbors, wearing new clothes and lighting firecrackers.
			It is an official holiday in India, Nepal, Sri Lanka, Trinidad and Tobago, Malaysia and Singapore.
			My best wishes to you and your family for a new year filled with good health, happiness and prosperity. Happy Diwali to all, and may you join ISA members and friends on Friday, Nov. 13 at 6:00 pm in Kunsela Lecture Hall and Rm A129, for an evening of Indian singing, dancing, food, and celebration.',
			'images/Diwali.png', 1);  */
		public void insertNews(News mNews)
		{	
			String sql = "INSERT INTO News(news_title, news_date, news_text, news_img_url, news_cate_id) VALUES('"
			             + mNews.NewsTitle + " ', ' " + mNews.NewsDate + " ', ' " + mNews.NewsText + " ', ' " + mNews.NewsImgUrl
						 + " ', " + mNews.NewsCateId + " ); ";
			mDbcmd = mDbcon.CreateCommand ();
			mDbcmd.CommandText = sql;
			mReader = mDbcmd.ExecuteReader ();
			cleanUp();
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

