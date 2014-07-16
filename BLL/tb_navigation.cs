using System;
using System.Data;
using System.Collections.Generic;
using Model;
namespace BLL
{
	/// <summary>
	/// tb_navigation
	/// </summary>
	public partial class tb_navigation
	{
		private readonly DAL.tb_navigation dal=new DAL.tb_navigation();
		public tb_navigation()
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
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}
        /// <summary>
        /// 查询名称是否存在
        /// </summary>
        public bool Exists(string name)
        {
            return dal.Exists(name);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.tb_navigation model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.tb_navigation model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			return dal.Delete(id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			return dal.DeleteList(idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.tb_navigation GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public Maticsoft.Model.tb_navigation GetModelByCache(int id)
        //{
			
        //    string CacheKey = "tb_navigationModel-" + id;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(id);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (Maticsoft.Model.tb_navigation)objModel;
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
		public List<Model.tb_navigation> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.tb_navigation> DataTableToList(DataTable dt)
		{
			List<Model.tb_navigation> modelList = new List<Model.tb_navigation>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.tb_navigation model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.tb_navigation();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["nav_type"]!=null && dt.Rows[n]["nav_type"].ToString()!="")
					{
					model.nav_type=dt.Rows[n]["nav_type"].ToString();
					}
					if(dt.Rows[n]["name"]!=null && dt.Rows[n]["name"].ToString()!="")
					{
					model.name=dt.Rows[n]["name"].ToString();
					}
					if(dt.Rows[n]["title"]!=null && dt.Rows[n]["title"].ToString()!="")
					{
					model.title=dt.Rows[n]["title"].ToString();
					}
					if(dt.Rows[n]["sub_title"]!=null && dt.Rows[n]["sub_title"].ToString()!="")
					{
					model.sub_title=dt.Rows[n]["sub_title"].ToString();
					}
					if(dt.Rows[n]["link_url"]!=null && dt.Rows[n]["link_url"].ToString()!="")
					{
					model.link_url=dt.Rows[n]["link_url"].ToString();
					}
					if(dt.Rows[n]["sort_id"]!=null && dt.Rows[n]["sort_id"].ToString()!="")
					{
						model.sort_id=int.Parse(dt.Rows[n]["sort_id"].ToString());
					}
					if(dt.Rows[n]["is_lock"]!=null && dt.Rows[n]["is_lock"].ToString()!="")
					{
						model.is_lock=int.Parse(dt.Rows[n]["is_lock"].ToString());
					}
					if(dt.Rows[n]["remark"]!=null && dt.Rows[n]["remark"].ToString()!="")
					{
					model.remark=dt.Rows[n]["remark"].ToString();
					}
					if(dt.Rows[n]["parent_id"]!=null && dt.Rows[n]["parent_id"].ToString()!="")
					{
						model.parent_id=int.Parse(dt.Rows[n]["parent_id"].ToString());
					}
					if(dt.Rows[n]["class_list"]!=null && dt.Rows[n]["class_list"].ToString()!="")
					{
					model.class_list=dt.Rows[n]["class_list"].ToString();
					}
					if(dt.Rows[n]["class_layer"]!=null && dt.Rows[n]["class_layer"].ToString()!="")
					{
						model.class_layer=int.Parse(dt.Rows[n]["class_layer"].ToString());
					}
					if(dt.Rows[n]["channel_id"]!=null && dt.Rows[n]["channel_id"].ToString()!="")
					{
						model.channel_id=int.Parse(dt.Rows[n]["channel_id"].ToString());
					}
					if(dt.Rows[n]["action_type"]!=null && dt.Rows[n]["action_type"].ToString()!="")
					{
					model.action_type=dt.Rows[n]["action_type"].ToString();
					}
					if(dt.Rows[n]["is_sys"]!=null && dt.Rows[n]["is_sys"].ToString()!="")
					{
						model.is_sys=int.Parse(dt.Rows[n]["is_sys"].ToString());
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

        /// <summary>
        /// 取得所有类别列表
        /// </summary>
        /// <param name="parent_id">父ID</param>
        /// <param name="nav_type">导航类别</param>
        /// <returns>DataTable</returns>
        public DataTable GetList(int parent_id, string nav_type)
        {
            return dal.GetList(parent_id, nav_type);
        }

		#endregion  Method
	}
}

