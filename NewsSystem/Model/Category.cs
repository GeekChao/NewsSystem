using System;

namespace NewsSystem
{
	public class Category
	{
		private int cateId;
		private String cateName;
		public const int ACTIVITY = 1;
		public const int ACADEMIC = 2;
		public const int ELSE = 3;

		public Category (){
			
		}

		public Category (int cateId, String cateName)
		{
			this.cateId = cateId;
			this.cateName = cateName;
		}

		public int CateId
		{
			get { return cateId; }
			set { cateId = value; }
		}

		public string CateName
		{
			get { return CateName; }
			set { CateName = value; }
		}
	}
}

