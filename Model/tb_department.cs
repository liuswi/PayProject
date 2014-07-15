using System;
namespace Model
{
	/// <summary>
	/// tb_department:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_department
	{
		public tb_department()
		{}
		#region Model
		private int _depid;
		private string _depname;
		private int? _depparid;
		private int? _depsort;
		/// <summary>
		/// 
		/// </summary>
		public int DEPID
		{
			set{ _depid=value;}
			get{return _depid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEPNAME
		{
			set{ _depname=value;}
			get{return _depname;}
		}
		/// <summary>
		/// 上级部门
		/// </summary>
		public int? DEPPARID
		{
			set{ _depparid=value;}
			get{return _depparid;}
		}
		/// <summary>
		/// 排序序号
		/// </summary>
		public int? DEPSORT
		{
			set{ _depsort=value;}
			get{return _depsort;}
		}
		#endregion Model

	}
}

