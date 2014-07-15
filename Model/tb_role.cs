using System;
namespace Model
{
	/// <summary>
	/// tb_role:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_role
	{
		public tb_role()
		{}
		#region Model
		private int _roleid;
		private string _rolename;
		private string _roleright;
		private bool? _isadmin;
		/// <summary>
		/// 
		/// </summary>
		public int ROLEID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ROLENAME
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// 权限
		/// </summary>
		public string ROLERIGHT
		{
			set{ _roleright=value;}
			get{return _roleright;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool? ISADMIN
		{
			set{ _isadmin=value;}
			get{return _isadmin;}
		}
		#endregion Model

	}
}

