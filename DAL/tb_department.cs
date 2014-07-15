using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;
namespace DAL
{
	/// <summary>
	/// 数据访问类:tb_department
	/// </summary>
	public partial class tb_department
	{
		public tb_department()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("DEPID", "tb_department"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int DEPID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_department");
			strSql.Append(" where DEPID=@DEPID");
			SqlParameter[] parameters = {
					new SqlParameter("@DEPID", SqlDbType.Int,4)
};
			parameters[0].Value = DEPID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.tb_department model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_department(");
			strSql.Append("DEPNAME,DEPPARID,DEPSORT)");
			strSql.Append(" values (");
			strSql.Append("@DEPNAME,@DEPPARID,@DEPSORT)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DEPNAME", SqlDbType.NVarChar,100),
					new SqlParameter("@DEPPARID", SqlDbType.Int,4),
					new SqlParameter("@DEPSORT", SqlDbType.Int,4)};
			parameters[0].Value = model.DEPNAME;
			parameters[1].Value = model.DEPPARID;
			parameters[2].Value = model.DEPSORT;

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
		public bool Update(Model.tb_department model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_department set ");
			strSql.Append("DEPNAME=@DEPNAME,");
			strSql.Append("DEPPARID=@DEPPARID,");
			strSql.Append("DEPSORT=@DEPSORT");
			strSql.Append(" where DEPID=@DEPID");
			SqlParameter[] parameters = {
					new SqlParameter("@DEPNAME", SqlDbType.NVarChar,100),
					new SqlParameter("@DEPPARID", SqlDbType.Int,4),
					new SqlParameter("@DEPSORT", SqlDbType.Int,4),
					new SqlParameter("@DEPID", SqlDbType.Int,4)};
			parameters[0].Value = model.DEPNAME;
			parameters[1].Value = model.DEPPARID;
			parameters[2].Value = model.DEPSORT;
			parameters[3].Value = model.DEPID;

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
		public bool Delete(int DEPID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_department ");
			strSql.Append(" where DEPID=@DEPID");
			SqlParameter[] parameters = {
					new SqlParameter("@DEPID", SqlDbType.Int,4)
};
			parameters[0].Value = DEPID;

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
		public bool DeleteList(string DEPIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_department ");
			strSql.Append(" where DEPID in ("+DEPIDlist + ")  ");
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
		public Model.tb_department GetModel(int DEPID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DEPID,DEPNAME,DEPPARID,DEPSORT from tb_department ");
			strSql.Append(" where DEPID=@DEPID");
			SqlParameter[] parameters = {
					new SqlParameter("@DEPID", SqlDbType.Int,4)
};
			parameters[0].Value = DEPID;

			Model.tb_department model=new Model.tb_department();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["DEPID"]!=null && ds.Tables[0].Rows[0]["DEPID"].ToString()!="")
				{
					model.DEPID=int.Parse(ds.Tables[0].Rows[0]["DEPID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DEPNAME"]!=null && ds.Tables[0].Rows[0]["DEPNAME"].ToString()!="")
				{
					model.DEPNAME=ds.Tables[0].Rows[0]["DEPNAME"].ToString();
				}
				if(ds.Tables[0].Rows[0]["DEPPARID"]!=null && ds.Tables[0].Rows[0]["DEPPARID"].ToString()!="")
				{
					model.DEPPARID=int.Parse(ds.Tables[0].Rows[0]["DEPPARID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DEPSORT"]!=null && ds.Tables[0].Rows[0]["DEPSORT"].ToString()!="")
				{
					model.DEPSORT=int.Parse(ds.Tables[0].Rows[0]["DEPSORT"].ToString());
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
			strSql.Append("select DEPID,DEPNAME,DEPPARID,DEPSORT ");
			strSql.Append(" FROM tb_department ");
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
			strSql.Append(" DEPID,DEPNAME,DEPPARID,DEPSORT ");
			strSql.Append(" FROM tb_department ");
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
			parameters[0].Value = "tb_department";
			parameters[1].Value = "DEPID";
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

