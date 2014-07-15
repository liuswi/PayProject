using System;
using System.Data;
using System.Collections.Generic;
using Model;
namespace BLL
{
	/// <summary>
	/// tb_department
	/// </summary>
	public partial class tb_department
	{
		private readonly DAL.tb_department dal=new DAL.tb_department();
		public tb_department()
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
		public bool Exists(int DEPID)
		{
			return dal.Exists(DEPID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.tb_department model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.tb_department model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int DEPID)
		{
			
			return dal.Delete(DEPID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string DEPIDlist )
		{
			return dal.DeleteList(DEPIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.tb_department GetModel(int DEPID)
		{
			
			return dal.GetModel(DEPID);
		}

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public Maticsoft.Model.tb_department GetModelByCache(int DEPID)
        //{
			
        //    string CacheKey = "tb_departmentModel-" + DEPID;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(DEPID);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (Maticsoft.Model.tb_department)objModel;
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
		public List<Model.tb_department> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.tb_department> DataTableToList(DataTable dt)
		{
			List<Model.tb_department> modelList = new List<Model.tb_department>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.tb_department model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.tb_department();
					if(dt.Rows[n]["DEPID"]!=null && dt.Rows[n]["DEPID"].ToString()!="")
					{
						model.DEPID=int.Parse(dt.Rows[n]["DEPID"].ToString());
					}
					if(dt.Rows[n]["DEPNAME"]!=null && dt.Rows[n]["DEPNAME"].ToString()!="")
					{
					model.DEPNAME=dt.Rows[n]["DEPNAME"].ToString();
					}
					if(dt.Rows[n]["DEPPARID"]!=null && dt.Rows[n]["DEPPARID"].ToString()!="")
					{
						model.DEPPARID=int.Parse(dt.Rows[n]["DEPPARID"].ToString());
					}
					if(dt.Rows[n]["DEPSORT"]!=null && dt.Rows[n]["DEPSORT"].ToString()!="")
					{
						model.DEPSORT=int.Parse(dt.Rows[n]["DEPSORT"].ToString());
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

