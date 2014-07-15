using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;
namespace DAL
{
	/// <summary>
	/// 数据访问类:tb_role
	/// </summary>
	public partial class tb_role
	{
		public tb_role()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ROLEID", "tb_role"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ROLEID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_role");
			strSql.Append(" where ROLEID=@ROLEID");
			SqlParameter[] parameters = {
					new SqlParameter("@ROLEID", SqlDbType.Int,4)
};
			parameters[0].Value = ROLEID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.tb_role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_role(");
			strSql.Append("ROLENAME,ROLERIGHT,ISADMIN)");
			strSql.Append(" values (");
			strSql.Append("@ROLENAME,@ROLERIGHT,@ISADMIN)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ROLENAME", SqlDbType.NVarChar,50),
					new SqlParameter("@ROLERIGHT", SqlDbType.NVarChar,50),
					new SqlParameter("@ISADMIN", SqlDbType.Bit,1)};
			parameters[0].Value = model.ROLENAME;
			parameters[1].Value = model.ROLERIGHT;
			parameters[2].Value = model.ISADMIN;

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
		public bool Update(Model.tb_role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_role set ");
			strSql.Append("ROLENAME=@ROLENAME,");
			strSql.Append("ROLERIGHT=@ROLERIGHT,");
			strSql.Append("ISADMIN=@ISADMIN");
			strSql.Append(" where ROLEID=@ROLEID");
			SqlParameter[] parameters = {
					new SqlParameter("@ROLENAME", SqlDbType.NVarChar,50),
					new SqlParameter("@ROLERIGHT", SqlDbType.NVarChar,50),
					new SqlParameter("@ISADMIN", SqlDbType.Bit,1),
					new SqlParameter("@ROLEID", SqlDbType.Int,4)};
			parameters[0].Value = model.ROLENAME;
			parameters[1].Value = model.ROLERIGHT;
			parameters[2].Value = model.ISADMIN;
			parameters[3].Value = model.ROLEID;

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
		public bool Delete(int ROLEID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_role ");
			strSql.Append(" where ROLEID=@ROLEID");
			SqlParameter[] parameters = {
					new SqlParameter("@ROLEID", SqlDbType.Int,4)
};
			parameters[0].Value = ROLEID;

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
		public bool DeleteList(string ROLEIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_role ");
			strSql.Append(" where ROLEID in ("+ROLEIDlist + ")  ");
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
		public Model.tb_role GetModel(int ROLEID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ROLEID,ROLENAME,ROLERIGHT,ISADMIN from tb_role ");
			strSql.Append(" where ROLEID=@ROLEID");
			SqlParameter[] parameters = {
					new SqlParameter("@ROLEID", SqlDbType.Int,4)
};
			parameters[0].Value = ROLEID;

			Model.tb_role model=new Model.tb_role();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ROLEID"]!=null && ds.Tables[0].Rows[0]["ROLEID"].ToString()!="")
				{
					model.ROLEID=int.Parse(ds.Tables[0].Rows[0]["ROLEID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ROLENAME"]!=null && ds.Tables[0].Rows[0]["ROLENAME"].ToString()!="")
				{
					model.ROLENAME=ds.Tables[0].Rows[0]["ROLENAME"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ROLERIGHT"]!=null && ds.Tables[0].Rows[0]["ROLERIGHT"].ToString()!="")
				{
					model.ROLERIGHT=ds.Tables[0].Rows[0]["ROLERIGHT"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ISADMIN"]!=null && ds.Tables[0].Rows[0]["ISADMIN"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["ISADMIN"].ToString()=="1")||(ds.Tables[0].Rows[0]["ISADMIN"].ToString().ToLower()=="true"))
					{
						model.ISADMIN=true;
					}
					else
					{
						model.ISADMIN=false;
					}
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
			strSql.Append("select ROLEID,ROLENAME,ROLERIGHT,ISADMIN ");
			strSql.Append(" FROM tb_role ");
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
			strSql.Append(" ROLEID,ROLENAME,ROLERIGHT,ISADMIN ");
			strSql.Append(" FROM tb_role ");
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
			parameters[0].Value = "tb_role";
			parameters[1].Value = "ROLEID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

