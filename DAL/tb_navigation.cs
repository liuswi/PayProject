using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;//Please add references
namespace DAL
{
	/// <summary>
	/// 数据访问类:tb_navigation
	/// </summary>
	public partial class tb_navigation
	{
		public tb_navigation()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "tb_navigation"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_navigation");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 查询是否存在该记录
        /// </summary>
        public bool Exists(string name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_navigation");
            strSql.Append(" where name=@name ");
            SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50)};
            parameters[0].Value = name;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.tb_navigation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_navigation(");
			strSql.Append("nav_type,name,title,sub_title,link_url,sort_id,is_lock,remark,parent_id,class_list,class_layer,channel_id,action_type,is_sys)");
			strSql.Append(" values (");
			strSql.Append("@nav_type,@name,@title,@sub_title,@link_url,@sort_id,@is_lock,@remark,@parent_id,@class_list,@class_layer,@channel_id,@action_type,@is_sys)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@nav_type", SqlDbType.NVarChar,50),
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@title", SqlDbType.NVarChar,100),
					new SqlParameter("@sub_title", SqlDbType.NVarChar,100),
					new SqlParameter("@link_url", SqlDbType.NVarChar,255),
					new SqlParameter("@sort_id", SqlDbType.Int,4),
					new SqlParameter("@is_lock", SqlDbType.TinyInt,1),
					new SqlParameter("@remark", SqlDbType.NVarChar,500),
					new SqlParameter("@parent_id", SqlDbType.Int,4),
					new SqlParameter("@class_list", SqlDbType.NVarChar,500),
					new SqlParameter("@class_layer", SqlDbType.Int,4),
					new SqlParameter("@channel_id", SqlDbType.Int,4),
					new SqlParameter("@action_type", SqlDbType.NVarChar,500),
					new SqlParameter("@is_sys", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.nav_type;
			parameters[1].Value = model.name;
			parameters[2].Value = model.title;
			parameters[3].Value = model.sub_title;
			parameters[4].Value = model.link_url;
			parameters[5].Value = model.sort_id;
			parameters[6].Value = model.is_lock;
			parameters[7].Value = model.remark;
			parameters[8].Value = model.parent_id;
			parameters[9].Value = model.class_list;
			parameters[10].Value = model.class_layer;
			parameters[11].Value = model.channel_id;
			parameters[12].Value = model.action_type;
			parameters[13].Value = model.is_sys;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.tb_navigation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_navigation set ");
			strSql.Append("nav_type=@nav_type,");
			strSql.Append("name=@name,");
			strSql.Append("title=@title,");
			strSql.Append("sub_title=@sub_title,");
			strSql.Append("link_url=@link_url,");
			strSql.Append("sort_id=@sort_id,");
			strSql.Append("is_lock=@is_lock,");
			strSql.Append("remark=@remark,");
			strSql.Append("parent_id=@parent_id,");
			strSql.Append("class_list=@class_list,");
			strSql.Append("class_layer=@class_layer,");
			strSql.Append("channel_id=@channel_id,");
			strSql.Append("action_type=@action_type,");
			strSql.Append("is_sys=@is_sys");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@nav_type", SqlDbType.NVarChar,50),
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@title", SqlDbType.NVarChar,100),
					new SqlParameter("@sub_title", SqlDbType.NVarChar,100),
					new SqlParameter("@link_url", SqlDbType.NVarChar,255),
					new SqlParameter("@sort_id", SqlDbType.Int,4),
					new SqlParameter("@is_lock", SqlDbType.TinyInt,1),
					new SqlParameter("@remark", SqlDbType.NVarChar,500),
					new SqlParameter("@parent_id", SqlDbType.Int,4),
					new SqlParameter("@class_list", SqlDbType.NVarChar,500),
					new SqlParameter("@class_layer", SqlDbType.Int,4),
					new SqlParameter("@channel_id", SqlDbType.Int,4),
					new SqlParameter("@action_type", SqlDbType.NVarChar,500),
					new SqlParameter("@is_sys", SqlDbType.TinyInt,1),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.nav_type;
			parameters[1].Value = model.name;
			parameters[2].Value = model.title;
			parameters[3].Value = model.sub_title;
			parameters[4].Value = model.link_url;
			parameters[5].Value = model.sort_id;
			parameters[6].Value = model.is_lock;
			parameters[7].Value = model.remark;
			parameters[8].Value = model.parent_id;
			parameters[9].Value = model.class_list;
			parameters[10].Value = model.class_layer;
			parameters[11].Value = model.channel_id;
			parameters[12].Value = model.action_type;
			parameters[13].Value = model.is_sys;
			parameters[14].Value = model.id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_navigation ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_navigation ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.tb_navigation GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,nav_type,name,title,sub_title,link_url,sort_id,is_lock,remark,parent_id,class_list,class_layer,channel_id,action_type,is_sys from tb_navigation ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			Model.tb_navigation model=new Model.tb_navigation();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["nav_type"]!=null && ds.Tables[0].Rows[0]["nav_type"].ToString()!="")
				{
					model.nav_type=ds.Tables[0].Rows[0]["nav_type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["name"]!=null && ds.Tables[0].Rows[0]["name"].ToString()!="")
				{
					model.name=ds.Tables[0].Rows[0]["name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["title"]!=null && ds.Tables[0].Rows[0]["title"].ToString()!="")
				{
					model.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sub_title"]!=null && ds.Tables[0].Rows[0]["sub_title"].ToString()!="")
				{
					model.sub_title=ds.Tables[0].Rows[0]["sub_title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["link_url"]!=null && ds.Tables[0].Rows[0]["link_url"].ToString()!="")
				{
					model.link_url=ds.Tables[0].Rows[0]["link_url"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sort_id"]!=null && ds.Tables[0].Rows[0]["sort_id"].ToString()!="")
				{
					model.sort_id=int.Parse(ds.Tables[0].Rows[0]["sort_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["is_lock"]!=null && ds.Tables[0].Rows[0]["is_lock"].ToString()!="")
				{
					model.is_lock=int.Parse(ds.Tables[0].Rows[0]["is_lock"].ToString());
				}
				if(ds.Tables[0].Rows[0]["remark"]!=null && ds.Tables[0].Rows[0]["remark"].ToString()!="")
				{
					model.remark=ds.Tables[0].Rows[0]["remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["parent_id"]!=null && ds.Tables[0].Rows[0]["parent_id"].ToString()!="")
				{
					model.parent_id=int.Parse(ds.Tables[0].Rows[0]["parent_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["class_list"]!=null && ds.Tables[0].Rows[0]["class_list"].ToString()!="")
				{
					model.class_list=ds.Tables[0].Rows[0]["class_list"].ToString();
				}
				if(ds.Tables[0].Rows[0]["class_layer"]!=null && ds.Tables[0].Rows[0]["class_layer"].ToString()!="")
				{
					model.class_layer=int.Parse(ds.Tables[0].Rows[0]["class_layer"].ToString());
				}
				if(ds.Tables[0].Rows[0]["channel_id"]!=null && ds.Tables[0].Rows[0]["channel_id"].ToString()!="")
				{
					model.channel_id=int.Parse(ds.Tables[0].Rows[0]["channel_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["action_type"]!=null && ds.Tables[0].Rows[0]["action_type"].ToString()!="")
				{
					model.action_type=ds.Tables[0].Rows[0]["action_type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["is_sys"]!=null && ds.Tables[0].Rows[0]["is_sys"].ToString()!="")
				{
					model.is_sys=int.Parse(ds.Tables[0].Rows[0]["is_sys"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,nav_type,name,title,sub_title,link_url,sort_id,is_lock,remark,parent_id,class_list,class_layer,channel_id,action_type,is_sys ");
			strSql.Append(" FROM tb_navigation ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,nav_type,name,title,sub_title,link_url,sort_id,is_lock,remark,parent_id,class_list,class_layer,channel_id,action_type,is_sys ");
			strSql.Append(" FROM tb_navigation ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "tb_navigation";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/


        /// <summary>
        /// 取得所有类别列表(已经排序好)
        /// </summary>
        /// <param name="parent_id">父ID</param>
        /// <param name="nav_type">导航类别</param>
        /// <returns>DataTable</returns>
        public DataTable GetList(int parent_id, string nav_type)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,nav_type,name,title,sub_title,link_url,sort_id,is_lock,remark,parent_id,class_list,class_layer,channel_id,action_type,is_sys");
            strSql.Append(" FROM tb_navigation");
            strSql.Append(" where nav_type='" + nav_type + "' order by sort_id asc,id asc");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            DataTable oldData = ds.Tables[0] as DataTable;
            if (oldData == null)
            {
                return null;
            }
            //复制结构
            DataTable newData = oldData.Clone();
            //调用迭代组合成DAGATABLE
            GetChilds(oldData, newData, parent_id);
            return newData;
        }

        /// <summary>
        /// 从内存中取得所有下级类别列表（自身迭代）
        /// </summary>
        private void GetChilds(DataTable oldData, DataTable newData, int parent_id)
        {
            DataRow[] dr = oldData.Select("parent_id=" + parent_id);
            for (int i = 0; i < dr.Length; i++)
            {
                //添加一行数据
                DataRow row = newData.NewRow();
                row["id"] = int.Parse(dr[i]["id"].ToString());
                row["nav_type"] = dr[i]["nav_type"].ToString();
                row["name"] = dr[i]["name"].ToString();
                row["title"] = dr[i]["title"].ToString();
                row["sub_title"] = dr[i]["sub_title"].ToString();
                row["link_url"] = dr[i]["link_url"].ToString();
                row["sort_id"] = int.Parse(dr[i]["sort_id"].ToString());
                row["is_lock"] = int.Parse(dr[i]["is_lock"].ToString());
                row["remark"] = dr[i]["remark"].ToString();
                row["parent_id"] = int.Parse(dr[i]["parent_id"].ToString());
                row["class_list"] = dr[i]["class_list"].ToString();
                row["class_layer"] = int.Parse(dr[i]["class_layer"].ToString());
                row["channel_id"] = int.Parse(dr[i]["channel_id"].ToString());
                row["action_type"] = dr[i]["action_type"].ToString();
                row["is_sys"] = int.Parse(dr[i]["is_sys"].ToString());
                newData.Rows.Add(row);
                //调用自身迭代
                this.GetChilds(oldData, newData, int.Parse(dr[i]["id"].ToString()));
            }
        }

		#endregion  Method
	}
}

