using System;

namespace NewsSystem
{
	public class Comment
	{
		private int comId;
		private String content;
		private int thumbNum;
		private DateTime comDate;
		private int comNewsId;
		public const int THUMBUP = 1;
		public const int THUMBDOWN = -1;

		public Comment ()
		{
		}

		public Comment (int comId, String content, int thumbNum, DateTime comDate, int comNewsId)
		{
			this.comId = comId;
			this.content = content;
			this.thumbNum = thumbNum;
			this.comDate = comDate;
			this.comNewsId = comNewsId;
		}

		public int ComId
		{
			get{ return comId;}
			set{ comId = value;}
		}

		public String Content
		{
			get{ return content;}
			set{ content = value;}
		}

		public int ThumbNum
		{
			get{ return thumbNum;}
			set{ thumbNum = value;}
		}

		public DateTime ComDate
		{
			get{ return comDate;}
			set{ comDate = value;}
		}

		public int ComNewsId
		{
			get{ return comNewsId;}
			set{ comNewsId = value;}
		}
	}
}

