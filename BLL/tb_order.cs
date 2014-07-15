using System;
using System.Data;
using System.Collections.Generic;
using Model;
namespace BLL
{
	/// <summary>
	/// tb_order
	/// </summary>
	public partial class tb_order
	{
		private readonly DAL.tb_order dal=new DAL.tb_order();
		public tb_order()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ORDERID)
		{
			return dal.Exists(ORDERID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.tb_order model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.tb_order model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ORDERID)
		{
			
			return dal.Delete(ORDERID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string ORDERIDlist )
		{
			return dal.DeleteList(ORDERIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.tb_order GetModel(int ORDERID)
		{
			
			return dal.GetModel(ORDERID);
		}

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public Maticsoft.Model.tb_order GetModelByCache(int ORDERID)
        //{
			
        //    string CacheKey = "tb_orderModel-" + ORDERID;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(ORDERID);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (Maticsoft.Model.tb_order)objModel;
        //}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.tb_order> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.tb_order> DataTableToList(DataTable dt)
		{
			List<Model.tb_order> modelList = new List<Model.tb_order>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.tb_order model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.tb_order();
					if(dt.Rows[n]["ORDERID"]!=null && dt.Rows[n]["ORDERID"].ToString()!="")
					{
						model.ORDERID=int.Parse(dt.Rows[n]["ORDERID"].ToString());
					}
					if(dt.Rows[n]["ORDERNO"]!=null && dt.Rows[n]["ORDERNO"].ToString()!="")
					{
					model.ORDERNO=dt.Rows[n]["ORDERNO"].ToString();
					}
					if(dt.Rows[n]["ORDERTIME"]!=null && dt.Rows[n]["ORDERTIME"].ToString()!="")
					{
						model.ORDERTIME=DateTime.Parse(dt.Rows[n]["ORDERTIME"].ToString());
					}
					if(dt.Rows[n]["BUSID"]!=null && dt.Rows[n]["BUSID"].ToString()!="")
					{
						model.BUSID=int.Parse(dt.Rows[n]["BUSID"].ToString());
					}
					if(dt.Rows[n]["ORDERPRICE"]!=null && dt.Rows[n]["ORDERPRICE"].ToString()!="")
					{
					model.ORDERPRICE=dt.Rows[n]["ORDERPRICE"].ToString();
					}
					if(dt.Rows[n]["USERID"]!=null && dt.Rows[n]["USERID"].ToString()!="")
					{
						model.USERID=int.Parse(dt.Rows[n]["USERID"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

