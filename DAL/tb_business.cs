using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;
namespace DAL
{
	/// <summary>
	/// 数据访问类:tb_business
	/// </summary>
	public partial class tb_business
	{
		public tb_business()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("BUSID", "tb_business"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int BUSID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_business");
			strSql.Append(" where BUSID=@BUSID");
			SqlParameter[] parameters = {
					new SqlParameter("@BUSID", SqlDbType.Int,4)
};
			parameters[0].Value = BUSID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.tb_business model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_business(");
			strSql.Append("BUSNAME,BUSPRICE,BUSDETAILS,DEPID)");
			strSql.Append(" values (");
			strSql.Append("@BUSNAME,@BUSPRICE,@BUSDETAILS,@DEPID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@BUSNAME", SqlDbType.NVarChar,100),
					new SqlParameter("@BUSPRICE", SqlDbType.NVarChar,50),
					new SqlParameter("@BUSDETAILS", SqlDbType.NVarChar,500),
					new SqlParameter("@DEPID", SqlDbType.Int,4)};
			parameters[0].Value = model.BUSNAME;
			parameters[1].Value = model.BUSPRICE;
			parameters[2].Value = model.BUSDETAILS;
			parameters[3].Value = model.DEPID;

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
		public bool Update(Model.tb_business model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_business set ");
			strSql.Append("BUSNAME=@BUSNAME,");
			strSql.Append("BUSPRICE=@BUSPRICE,");
			strSql.Append("BUSDETAILS=@BUSDETAILS,");
			strSql.Append("DEPID=@DEPID");
			strSql.Append(" where BUSID=@BUSID");
			SqlParameter[] parameters = {
					new SqlParameter("@BUSNAME", SqlDbType.NVarChar,100),
					new SqlParameter("@BUSPRICE", SqlDbType.NVarChar,50),
					new SqlParameter("@BUSDETAILS", SqlDbType.NVarChar,500),
					new SqlParameter("@DEPID", SqlDbType.Int,4),
					new SqlParameter("@BUSID", SqlDbType.Int,4)};
			parameters[0].Value = model.BUSNAME;
			parameters[1].Value = model.BUSPRICE;
			parameters[2].Value = model.BUSDETAILS;
			parameters[3].Value = model.DEPID;
			parameters[4].Value = model.BUSID;

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
		public bool Delete(int BUSID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_business ");
			strSql.Append(" where BUSID=@BUSID");
			SqlParameter[] parameters = {
					new SqlParameter("@BUSID", SqlDbType.Int,4)
};
			parameters[0].Value = BUSID;

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
		public bool DeleteList(string BUSIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_business ");
			strSql.Append(" where BUSID in ("+BUSIDlist + ")  ");
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
		public Model.tb_business GetModel(int BUSID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BUSID,BUSNAME,BUSPRICE,BUSDETAILS,DEPID from tb_business ");
			strSql.Append(" where BUSID=@BUSID");
			SqlParameter[] parameters = {
					new SqlParameter("@BUSID", SqlDbType.Int,4)
};
			parameters[0].Value = BUSID;

			Model.tb_business model=new Model.tb_business();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["BUSID"]!=null && ds.Tables[0].Rows[0]["BUSID"].ToString()!="")
				{
					model.BUSID=int.Parse(ds.Tables[0].Rows[0]["BUSID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["BUSNAME"]!=null && ds.Tables[0].Rows[0]["BUSNAME"].ToString()!="")
				{
					model.BUSNAME=ds.Tables[0].Rows[0]["BUSNAME"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BUSPRICE"]!=null && ds.Tables[0].Rows[0]["BUSPRICE"].ToString()!="")
				{
					model.BUSPRICE=ds.Tables[0].Rows[0]["BUSPRICE"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BUSDETAILS"]!=null && ds.Tables[0].Rows[0]["BUSDETAILS"].ToString()!="")
				{
					model.BUSDETAILS=ds.Tables[0].Rows[0]["BUSDETAILS"].ToString();
				}
				if(ds.Tables[0].Rows[0]["DEPID"]!=null && ds.Tables[0].Rows[0]["DEPID"].ToString()!="")
				{
					model.DEPID=int.Parse(ds.Tables[0].Rows[0]["DEPID"].ToString());
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
			strSql.Append("select BUSID,BUSNAME,BUSPRICE,BUSDETAILS,DEPID ");
			strSql.Append(" FROM tb_business ");
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
			strSql.Append(" BUSID,BUSNAME,BUSPRICE,BUSDETAILS,DEPID ");
			strSql.Append(" FROM tb_business ");
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
			parameters[0].Value = "tb_business";
			parameters[1].Value = "BUSID";
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

