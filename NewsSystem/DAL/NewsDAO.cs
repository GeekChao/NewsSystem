﻿using System;
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
		private String sql;

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

		public void selectAll(Repeater rep)
		{
			sql = "SELECT * FROM News ORDER BY news_date DESC;";
			bindReapter (sql, rep);
		}

		public void searchNews(String text, Repeater rep)
		{
			sql = "SELECT * FROM News WHERE news_title LIKE '%" + text + "%';";
			bindReapter (sql, rep);
		}

		public void selectHotNews(String category, News mNews)
		{
			sql = "SELECT * FROM News INNER JOIN Comment ON com_news_id = news_id INNER JOIN Category C1 ON cate_id = news_cate_id WHERE cate_name = '";
			switch (category) 
			{
			case Constant.NEWSACTIVITY:
				sql = sql + Constant.NEWSACTIVITY + "' ORDER BY thumb_num DESC LIMIT 1;";
				exectueQuery (sql, mNews);
				break;
			case Constant.NEWSACADEMIC:
				sql = sql + Constant.NEWSACADEMIC +  "' ORDER BY thumb_num DESC LIMIT 1;";
				exectueQuery (sql, mNews);
				break;
			case Constant.NEWSELSE:
				sql = sql + Constant.NEWSELSE +  "' ORDER BY thumb_num DESC LIMIT 1;";
				exectueQuery (sql, mNews);
				break;
			default:
				break;
			}
		}

		public void selectByID(String id, News mNews)
		{
			sql = "SELECT * FROM News WHERE news_id = " + id + ";";
			exectueQuery (sql, mNews);
		}

		public void deleteByID(String id, Repeater rep)
		{
			sql = "DELETE FROM NEWS WHERE news_id = " + id + ";";
			bindReapter (sql, rep);
		}

		public void updateByID(String id, int type)
		{
			if (type == Constant.THUMBUP) {
				sql = "UPDATE Comment SET thumb_num = thumb_num + 1 WHERE com_news_id = " + id + ";";
			} else if (type == Constant.THUMBDOWN) {
				sql = "UPDATE Comment SET thumb_num = thumb_num - 1 WHERE com_news_id = " + id + ";";
			}

			mDbcmd = mDbcon.CreateCommand ();
			mDbcmd.CommandText = sql;
			mReader = mDbcmd.ExecuteReader ();
			cleanUp ();
		}

		public void updateNews(News mNews)
		{
			sql = " UPDATE NEWS SET news_title = '" + mNews.NewsTitle + "', "
				+ "news_date = '" + mNews.NewsDate + "', "
				+ "news_img_url = '" + mNews.NewsImgUrl + "', "
				+ "news_text = '" + mNews.NewsText + "', "
				+ "news_cate_id = " + mNews.NewsCateId + " "
				+ "WHERE news_id = " + mNews.NewsId + ";"; 
			mDbcmd = mDbcon.CreateCommand ();
			mDbcmd.CommandText = sql;
			mReader = mDbcmd.ExecuteReader ();
			cleanUp();
		}

		public void insertNews(News mNews)
		{	
			sql = "INSERT INTO News(news_title, news_date, news_text, news_img_url, news_cate_id) VALUES('"
			             + mNews.NewsTitle + "', '" + mNews.NewsDate + "', '" + mNews.NewsText + "', '" + mNews.NewsImgUrl
						 + "', " + mNews.NewsCateId + " );";
			mDbcmd = mDbcon.CreateCommand ();
			mDbcmd.CommandText = sql;
			mReader = mDbcmd.ExecuteReader ();
			cleanUp();
			//init comments associated with the news. Assuming no same title !!!!!!!! Using trigger in the future.
			sql ="INSERT INTO Comment(thumb_num, com_news_id)" + "SELECT " 
				+ Constant.THUMBNUM + ", " + "news_id FROM NEWS WHERE news_title = '" + mNews.NewsTitle + "';";
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

