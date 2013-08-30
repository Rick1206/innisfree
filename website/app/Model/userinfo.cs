using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// userinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class userinfo
	{
		public userinfo()
		{}
		#region Model
		private int _id;
		private string _uname;
		private string _usex;
		private string _uage;
		private string _uphone;
		private string _uemail;
		private string _wid;
		private string _wname;
		private string _parameter1;
		private string _parameter2;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string uname
		{
			set{ _uname=value;}
			get{return _uname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string usex
		{
			set{ _usex=value;}
			get{return _usex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string uage
		{
			set{ _uage=value;}
			get{return _uage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string uphone
		{
			set{ _uphone=value;}
			get{return _uphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string uemail
		{
			set{ _uemail=value;}
			get{return _uemail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string wid
		{
			set{ _wid=value;}
			get{return _wid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string wname
		{
			set{ _wname=value;}
			get{return _wname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string parameter1
		{
			set{ _parameter1=value;}
			get{return _parameter1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string parameter2
		{
			set{ _parameter2=value;}
			get{return _parameter2;}
		}
		#endregion Model

	}
}

