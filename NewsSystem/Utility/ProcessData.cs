using System;
using System.Text.RegularExpressions;

namespace NewsSystem
{
	public class ProcessData
	{
		//cut off string and add something in the end
		public static string stringTruncat(string oldStr, int maxLength, string endWith)
		{
			if (string.IsNullOrEmpty(oldStr))
				return oldStr + endWith;
			if (maxLength < 1)
				throw new Exception("empty string");
			if (oldStr.Length > maxLength)
			{
				string strTmp = oldStr.Substring(0, maxLength);
				if (string.IsNullOrEmpty(endWith))
					return strTmp;
				else
					return strTmp + endWith;
			}
			return oldStr;
		}

		//cut off string
		public static string getWords(string str, int n)
		{
			if (str.Length > n)
				return str.Substring(0, n) + "...........";
			else
				return str;
		}
		//remove html tag
		public static string stripHtml(string strhtml) 
		{
			string stroutput = strhtml;
			Regex regex = new Regex(@"<[^>]+>|</[^>]+>");
			stroutput = regex.Replace(stroutput, "");
			return stroutput;
		}
		//formate datetime
		public static String getFormatedDateTime()
		{
			return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		}
	}
}

