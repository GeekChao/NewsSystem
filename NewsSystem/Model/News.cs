using System;

namespace NewsSystem
{
	public class News
	{
		private int newsId;
		private String newsTitle;
		private String newsDate;
		private String newsText;
		private String newsImgUrl;
		private int newsCateId;

		public News ()
		{
		}

		public News (int newsId, String newsTitle, String newsDate, String newsText, String newsImgUrl, int newsCateId)
		{
			this.newsId = newsId;
			this.newsTitle = newsTitle;
			this.newsDate = newsDate;
			this.newsText = newsText;
			this.newsImgUrl = newsImgUrl;
			this.newsCateId = newsCateId;
		}

		public int NewsId
		{
			get{return newsId;}
			set{newsId = value;}
		}

		public String NewsTitle
		{
			get{return newsTitle;}
			set{newsTitle = value;}
		}

		public String NewsDate
		{
			get{return newsDate;}
			set{newsDate = value;}
		}

		public String NewsText
		{
			get{return newsText;}
			set{newsText = value;}
		}

		public String NewsImgUrl
		{
			get{return newsImgUrl;}
			set{newsImgUrl = value;}
		}

		public int NewsCateId
		{
			get{return newsCateId;}
			set{newsCateId = value;}
		}

		public String toString()
		{
			return "ID:" + newsId + "\nTitle: " + newsTitle + "\nDate: " + newsDate
			+ "\nText: " + newsText + "\nImg: " + newsImgUrl + "\nCategory: " + newsCateId;
		}
	}
}

