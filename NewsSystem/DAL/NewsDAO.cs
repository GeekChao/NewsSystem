using System;
using System.Data;
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

		public void selectByID(String sql, News mNews)
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
			cleanUp ();
		}

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

