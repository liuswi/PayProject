using System;
using System.Data;
using System.Collections.Generic;
using Model;
namespace BLL
{
	/// <summary>
	/// tb_user
	/// </summary>
	public partial class tb_user
	{
		private readonly DAL.tb_user dal=new DAL.tb_user();
		public tb_user()
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
		public bool Exists(int USERID)
		{
			return dal.Exists(USERID);
		}

        public bool Exists(string user_name)
        {
            return dal.Exists(user_name);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.tb_user model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.tb_user model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int USERID)
		{
			
			return dal.Delete(USERID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string USERIDlist )
		{
			return dal.DeleteList(USERIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.tb_user GetModel(int USERID)
		{
			
			return dal.GetModel(USERID);
		}

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public Maticsoft.Model.tb_user GetModelByCache(int USERID)
        //{
			
        //    string CacheKey = "tb_userModel-" + USERID;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(USERID);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (Maticsoft.Model.tb_user)objModel;
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
		public List<Model.tb_user> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.tb_user> DataTableToList(DataTable dt)
		{
			List<Model.tb_user> modelList = new List<Model.tb_user>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.tb_user model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.tb_user();
					if(dt.Rows[n]["USERID"]!=null && dt.Rows[n]["USERID"].ToString()!="")
					{
						model.USERID=int.Parse(dt.Rows[n]["USERID"].ToString());
					}
					if(dt.Rows[n]["USERNAME"]!=null && dt.Rows[n]["USERNAME"].ToString()!="")
					{
					model.USERNAME=dt.Rows[n]["USERNAME"].ToString();
					}
					if(dt.Rows[n]["USERPWD"]!=null && dt.Rows[n]["USERPWD"].ToString()!="")
					{
					model.USERPWD=dt.Rows[n]["USERPWD"].ToString();
					}
					if(dt.Rows[n]["USERSTATUS"]!=null && dt.Rows[n]["USERSTATUS"].ToString()!="")
					{
						model.USERSTATUS=int.Parse(dt.Rows[n]["USERSTATUS"].ToString());
					}
					if(dt.Rows[n]["USERTYPE"]!=null && dt.Rows[n]["USERTYPE"].ToString()!="")
					{
						model.USERTYPE=int.Parse(dt.Rows[n]["USERTYPE"].ToString());
					}
					if(dt.Rows[n]["USERROLEID"]!=null && dt.Rows[n]["USERROLEID"].ToString()!="")
					{
						model.USERROLEID=int.Parse(dt.Rows[n]["USERROLEID"].ToString());
					}
					if(dt.Rows[n]["USERREALNAME"]!=null && dt.Rows[n]["USERREALNAME"].ToString()!="")
					{
					model.USERREALNAME=dt.Rows[n]["USERREALNAME"].ToString();
					}
					if(dt.Rows[n]["USERSEX"]!=null && dt.Rows[n]["USERSEX"].ToString()!="")
					{
					model.USERSEX=dt.Rows[n]["USERSEX"].ToString();
					}
					if(dt.Rows[n]["USERADDRESS"]!=null && dt.Rows[n]["USERADDRESS"].ToString()!="")
					{
					model.USERADDRESS=dt.Rows[n]["USERADDRESS"].ToString();
					}
					if(dt.Rows[n]["USERCARD"]!=null && dt.Rows[n]["USERCARD"].ToString()!="")
					{
					model.USERCARD=dt.Rows[n]["USERCARD"].ToString();
					}
					if(dt.Rows[n]["USERPHONE"]!=null && dt.Rows[n]["USERPHONE"].ToString()!="")
					{
					model.USERPHONE=dt.Rows[n]["USERPHONE"].ToString();
					}
					if(dt.Rows[n]["USEREMALL"]!=null && dt.Rows[n]["USEREMALL"].ToString()!="")
					{
					model.USEREMALL=dt.Rows[n]["USEREMALL"].ToString();
					}
					if(dt.Rows[n]["USERQUESTION"]!=null && dt.Rows[n]["USERQUESTION"].ToString()!="")
					{
					model.USERQUESTION=dt.Rows[n]["USERQUESTION"].ToString();
					}
					if(dt.Rows[n]["USERANSWER"]!=null && dt.Rows[n]["USERANSWER"].ToString()!="")
					{
					model.USERANSWER=dt.Rows[n]["USERANSWER"].ToString();
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

