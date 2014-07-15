using System;
namespace Model
{
	/// <summary>
	/// tb_order:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_order
	{
		public tb_order()
		{}
		#region Model
		private int _orderid;
		private string _orderno;
		private DateTime? _ordertime;
		private int? _busid;
		private string _orderprice;
		private int? _userid;
		/// <summary>
		/// 
		/// </summary>
		public int ORDERID
		{
			set{ _orderid=value;}
			get{return _orderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORDERNO
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ORDERTIME
		{
			set{ _ordertime=value;}
			get{return _ordertime;}
		}
		/// <summary>
		/// 所属业务
		/// </summary>
		public int? BUSID
		{
			set{ _busid=value;}
			get{return _busid;}
		}
		/// <summary>
		/// 付款金额
		/// </summary>
		public string ORDERPRICE
		{
			set{ _orderprice=value;}
			get{return _orderprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? USERID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		#endregion Model

	}
}

