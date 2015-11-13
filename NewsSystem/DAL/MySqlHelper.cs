using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace NewsSystem
{
	public class MySqlHelper:SQLHelper
	{
		private const String conStr = 
			"Server=localhost;" +
			"Database=NewsSystem;" +
			"User ID=zzz;" +
			"Password=123456;" +
			"Pooling=false";
		
		private IDbConnection mDbcon;
		private static MySqlHelper mInstance;

		public MySqlHelper ()
		{
			connectDB ();
		}

		public static MySqlHelper getInstance()
		{
			if(mInstance == null)
				mInstance = new MySqlHelper ();
			return mInstance;
		}

		public IDbConnection Dbcon
		{
			get{return mDbcon;}
		}
			
		public void connectDB()
		{
			mDbcon = new MySqlConnection (conStr);
			if (mDbcon.State == ConnectionState.Closed) 
			{
				mDbcon.Open ();
			}
		}

		public void closeDB()
		{
			mDbcon.Close ();
		}

	}
}

