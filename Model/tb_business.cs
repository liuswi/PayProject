using System;
namespace Model
{
	/// <summary>
	/// tb_business:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_business
	{
		public tb_business()
		{}
		#region Model
		private int _busid;
		private string _busname;
		private string _busprice;
		private string _busdetails;
		private int? _depid;
		/// <summary>
		/// 
		/// </summary>
		public int BUSID
		{
			set{ _busid=value;}
			get{return _busid;}
		}
		/// <summary>
		/// 业务名称
		/// </summary>
		public string BUSNAME
		{
			set{ _busname=value;}
			get{return _busname;}
		}
		/// <summary>
		/// 付款金额
		/// </summary>
		public string BUSPRICE
		{
			set{ _busprice=value;}
			get{return _busprice;}
		}
		/// <summary>
		/// 业务描述
		/// </summary>
		public string BUSDETAILS
		{
			set{ _busdetails=value;}
			get{return _busdetails;}
		}
		/// <summary>
		/// 所属部门
		/// </summary>
		public int? DEPID
		{
			set{ _depid=value;}
			get{return _depid;}
		}
		#endregion Model
        
	}
}

