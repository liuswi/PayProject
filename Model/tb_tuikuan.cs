using System;
namespace Model
{
	/// <summary>
	/// tb_tuikuan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_tuikuan
	{
		public tb_tuikuan()
		{}
		#region Model
		private int _tuikuanid;
		private string _orderno;
		private string _tuikprice;
		private string _reason;
		private string _remark;
		private int? _status;
		private DateTime? _applytime;
		private DateTime? _reviewtime;
		private int? _userid;
		/// <summary>
		/// 
		/// </summary>
		public int TUIKUANID
		{
			set{ _tuikuanid=value;}
			get{return _tuikuanid;}
		}
		/// <summary>
		/// 订单唯一编号
		/// </summary>
		public string ORDERNO
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 退款金额
		/// </summary>
		public string TUIKPRICE
		{
			set{ _tuikprice=value;}
			get{return _tuikprice;}
		}
		/// <summary>
		/// 退款理由
		/// </summary>
		public string REASON
		{
			set{ _reason=value;}
			get{return _reason;}
		}
		/// <summary>
		/// 拒绝理由
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 审核状态
		/// </summary>
		public int? STATUS
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 申请时间
		/// </summary>
		public DateTime? APPLYTIME
		{
			set{ _applytime=value;}
			get{return _applytime;}
		}
		/// <summary>
		/// 回复时间
		/// </summary>
		public DateTime? REVIEWTIME
		{
			set{ _reviewtime=value;}
			get{return _reviewtime;}
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

