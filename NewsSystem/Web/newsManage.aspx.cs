using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSystem
{
	
	public partial class newsManage : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack) {
				initNewsManage ();
			}
		}

		public void initNewsManage()
		{
			NewsDAO mNewsDAO = new NewsDAO ();
			mNewsDAO.selectAll (repNewsManage);	
		}

		public void deleteNewsBtnClick(object sender, EventArgs e)
		{
			String id = ((LinkButton)sender).CommandArgument;
			NewsDAO mNewsDAO = new NewsDAO ();
			mNewsDAO.deleteByID (id, repNewsManage);
			initNewsManage ();
		}

		public void addNewsBtnClick(object sender, EventArgs e)
		{
			Response.Redirect ("./admin/insertNews.aspx");
		}

		public static string StringTruncat(string oldStr, int maxLength, string endWith)//新闻标题截取指定长度汉字超出部分以“...”代替
		{
			if (string.IsNullOrEmpty(oldStr))
				return oldStr + endWith;
			if (maxLength < 1)
				throw new Exception("返回的字符串长度必须大于[0] ");
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

		public static string GetWords(string str, int n)//新闻内容截取
		{
			if (str.Length > n)
				return str.Substring(0, n) + "...........";
			else
				return str;
		}

		public static string striphtml(string strhtml)  //新闻内容去HTML 标签
		{
			string stroutput = strhtml;
			//Regex regex = new Regex(@"<[^>]+>|</[^>]+>");
			//stroutput = regex.Replace(stroutput, "");
			return stroutput;
		}
	}
}

