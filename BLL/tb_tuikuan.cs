using System;
using System.Data;
using System.Collections.Generic;
using Model;
namespace BLL
{
	/// <summary>
	/// tb_tuikuan
	/// </summary>
	public partial class tb_tuikuan
	{
		private readonly DAL.tb_tuikuan dal=new DAL.tb_tuikuan();
		public tb_tuikuan()
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
		public bool Exists(int TUIKUANID)
		{
			return dal.Exists(TUIKUANID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.tb_tuikuan model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.tb_tuikuan model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int TUIKUANID)
		{
			
			return dal.Delete(TUIKUANID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string TUIKUANIDlist )
		{
			return dal.DeleteList(TUIKUANIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.tb_tuikuan GetModel(int TUIKUANID)
		{
			
			return dal.GetModel(TUIKUANID);
		}

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public Maticsoft.Model.tb_tuikuan GetModelByCache(int TUIKUANID)
        //{
			
        //    string CacheKey = "tb_tuikuanModel-" + TUIKUANID;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(TUIKUANID);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (Maticsoft.Model.tb_tuikuan)objModel;
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
		public List<Model.tb_tuikuan> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.tb_tuikuan> DataTableToList(DataTable dt)
		{
			List<Model.tb_tuikuan> modelList = new List<Model.tb_tuikuan>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.tb_tuikuan model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.tb_tuikuan();
					if(dt.Rows[n]["TUIKUANID"]!=null && dt.Rows[n]["TUIKUANID"].ToString()!="")
					{
						model.TUIKUANID=int.Parse(dt.Rows[n]["TUIKUANID"].ToString());
					}
					if(dt.Rows[n]["ORDERNO"]!=null && dt.Rows[n]["ORDERNO"].ToString()!="")
					{
					model.ORDERNO=dt.Rows[n]["ORDERNO"].ToString();
					}
					if(dt.Rows[n]["TUIKPRICE"]!=null && dt.Rows[n]["TUIKPRICE"].ToString()!="")
					{
					model.TUIKPRICE=dt.Rows[n]["TUIKPRICE"].ToString();
					}
					if(dt.Rows[n]["REASON"]!=null && dt.Rows[n]["REASON"].ToString()!="")
					{
					model.REASON=dt.Rows[n]["REASON"].ToString();
					}
					if(dt.Rows[n]["REMARK"]!=null && dt.Rows[n]["REMARK"].ToString()!="")
					{
					model.REMARK=dt.Rows[n]["REMARK"].ToString();
					}
					if(dt.Rows[n]["STATUS"]!=null && dt.Rows[n]["STATUS"].ToString()!="")
					{
						model.STATUS=int.Parse(dt.Rows[n]["STATUS"].ToString());
					}
					if(dt.Rows[n]["APPLYTIME"]!=null && dt.Rows[n]["APPLYTIME"].ToString()!="")
					{
						model.APPLYTIME=DateTime.Parse(dt.Rows[n]["APPLYTIME"].ToString());
					}
					if(dt.Rows[n]["REVIEWTIME"]!=null && dt.Rows[n]["REVIEWTIME"].ToString()!="")
					{
						model.REVIEWTIME=DateTime.Parse(dt.Rows[n]["REVIEWTIME"].ToString());
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

