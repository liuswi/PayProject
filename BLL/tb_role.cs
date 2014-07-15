using System;
using System.Data;
using System.Collections.Generic;
using Model;
namespace BLL
{
	/// <summary>
	/// tb_role
	/// </summary>
	public partial class tb_role
	{
		private readonly DAL.tb_role dal=new DAL.tb_role();
		public tb_role()
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
		public bool Exists(int ROLEID)
		{
			return dal.Exists(ROLEID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.tb_role model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.tb_role model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ROLEID)
		{
			
			return dal.Delete(ROLEID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string ROLEIDlist )
		{
			return dal.DeleteList(ROLEIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.tb_role GetModel(int ROLEID)
		{
			
			return dal.GetModel(ROLEID);
		}

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public Maticsoft.Model.tb_role GetModelByCache(int ROLEID)
        //{
			
        //    string CacheKey = "tb_roleModel-" + ROLEID;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(ROLEID);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (Maticsoft.Model.tb_role)objModel;
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
		public List<Model.tb_role> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.tb_role> DataTableToList(DataTable dt)
		{
			List<Model.tb_role> modelList = new List<Model.tb_role>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.tb_role model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.tb_role();
					if(dt.Rows[n]["ROLEID"]!=null && dt.Rows[n]["ROLEID"].ToString()!="")
					{
						model.ROLEID=int.Parse(dt.Rows[n]["ROLEID"].ToString());
					}
					if(dt.Rows[n]["ROLENAME"]!=null && dt.Rows[n]["ROLENAME"].ToString()!="")
					{
					model.ROLENAME=dt.Rows[n]["ROLENAME"].ToString();
					}
					if(dt.Rows[n]["ROLERIGHT"]!=null && dt.Rows[n]["ROLERIGHT"].ToString()!="")
					{
					model.ROLERIGHT=dt.Rows[n]["ROLERIGHT"].ToString();
					}
					if(dt.Rows[n]["ISADMIN"]!=null && dt.Rows[n]["ISADMIN"].ToString()!="")
					{
						if((dt.Rows[n]["ISADMIN"].ToString()=="1")||(dt.Rows[n]["ISADMIN"].ToString().ToLower()=="true"))
						{
						model.ISADMIN=true;
						}
						else
						{
							model.ISADMIN=false;
						}
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

