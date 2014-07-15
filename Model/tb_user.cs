using System;
namespace Model
{
	/// <summary>
	/// tb_user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_user
	{
		public tb_user()
		{}
		#region Model
		private int _userid;
		private string _username;
		private string _userpwd;
		private int? _userstatus;
		private int? _usertype;
		private int? _userroleid;
		private string _userrealname;
		private string _usersex;
		private string _useraddress;
		private string _usercard;
		private string _userphone;
		private string _useremall;
		private string _userquestion;
		private string _useranswer;
		/// <summary>
		/// 
		/// </summary>
		public int USERID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USERNAME
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USERPWD
		{
			set{ _userpwd=value;}
			get{return _userpwd;}
		}
		/// <summary>
        /// 状态 0 待审核 1 正常 2 禁用
		/// </summary>
		public int? USERSTATUS
		{
			set{ _userstatus=value;}
			get{return _userstatus;}
		}
		/// <summary>
        /// 类型 0 注册用户 1系统用户
		/// </summary>
		public int? USERTYPE
		{
			set{ _usertype=value;}
			get{return _usertype;}
		}
		/// <summary>
		/// 角色ID
		/// </summary>
		public int? USERROLEID
		{
			set{ _userroleid=value;}
			get{return _userroleid;}
		}
		/// <summary>
		/// 真实姓名
		/// </summary>
		public string USERREALNAME
		{
			set{ _userrealname=value;}
			get{return _userrealname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USERSEX
		{
			set{ _usersex=value;}
			get{return _usersex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USERADDRESS
		{
			set{ _useraddress=value;}
			get{return _useraddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USERCARD
		{
			set{ _usercard=value;}
			get{return _usercard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USERPHONE
		{
			set{ _userphone=value;}
			get{return _userphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USEREMALL
		{
			set{ _useremall=value;}
			get{return _useremall;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USERQUESTION
		{
			set{ _userquestion=value;}
			get{return _userquestion;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USERANSWER
		{
			set{ _useranswer=value;}
			get{return _useranswer;}
		}
		#endregion Model

	}
}

