using System;
using System.Data;

namespace NewsSystem
{
	public interface SQLHelper
	{
		void connectDB();
		void closeDB();
	}
}

