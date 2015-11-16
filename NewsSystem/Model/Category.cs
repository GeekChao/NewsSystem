using System;

namespace NewsSystem
{
	public class Category
	{
		private int cateId;
		private String cateName;

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

