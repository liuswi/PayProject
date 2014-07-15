using System;
using System.Data;
using System.Collections.Generic;
using Model;
namespace BLL
{
	/// <summary>
	/// tb_business
	/// </summary>
	public partial class tb_business
	{
		private readonly DAL.tb_business dal=new DAL.tb_business();
		public tb_business()
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
		public bool Exists(int BUSID)
		{
			return dal.Exists(BUSID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.tb_business model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.tb_business model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int BUSID)
		{
			
			return dal.Delete(BUSID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string BUSIDlist )
		{
			return dal.DeleteList(BUSIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.tb_business GetModel(int BUSID)
		{
			
			return dal.GetModel(BUSID);
		}

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public Maticsoft.Model.tb_business GetModelByCache(int BUSID)
        //{
			
        //    string CacheKey = "tb_businessModel-" + BUSID;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(BUSID);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (Maticsoft.Model.tb_business)objModel;
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
		public List<Model.tb_business> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.tb_business> DataTableToList(DataTable dt)
		{
			List<Model.tb_business> modelList = new List<Model.tb_business>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.tb_business model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.tb_business();
					if(dt.Rows[n]["BUSID"]!=null && dt.Rows[n]["BUSID"].ToString()!="")
					{
						model.BUSID=int.Parse(dt.Rows[n]["BUSID"].ToString());
					}
					if(dt.Rows[n]["BUSNAME"]!=null && dt.Rows[n]["BUSNAME"].ToString()!="")
					{
					model.BUSNAME=dt.Rows[n]["BUSNAME"].ToString();
					}
					if(dt.Rows[n]["BUSPRICE"]!=null && dt.Rows[n]["BUSPRICE"].ToString()!="")
					{
					model.BUSPRICE=dt.Rows[n]["BUSPRICE"].ToString();
					}
					if(dt.Rows[n]["BUSDETAILS"]!=null && dt.Rows[n]["BUSDETAILS"].ToString()!="")
					{
					model.BUSDETAILS=dt.Rows[n]["BUSDETAILS"].ToString();
					}
					if(dt.Rows[n]["DEPID"]!=null && dt.Rows[n]["DEPID"].ToString()!="")
					{
						model.DEPID=int.Parse(dt.Rows[n]["DEPID"].ToString());
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

