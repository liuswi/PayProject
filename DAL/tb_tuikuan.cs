using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;
namespace DAL
{
	/// <summary>
	/// 数据访问类:tb_tuikuan
	/// </summary>
	public partial class tb_tuikuan
	{
		public tb_tuikuan()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("TUIKUANID", "tb_tuikuan"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int TUIKUANID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_tuikuan");
			strSql.Append(" where TUIKUANID=@TUIKUANID");
			SqlParameter[] parameters = {
					new SqlParameter("@TUIKUANID", SqlDbType.Int,4)
};
			parameters[0].Value = TUIKUANID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.tb_tuikuan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_tuikuan(");
			strSql.Append("ORDERNO,TUIKPRICE,REASON,REMARK,STATUS,APPLYTIME,REVIEWTIME,USERID)");
			strSql.Append(" values (");
			strSql.Append("@ORDERNO,@TUIKPRICE,@REASON,@REMARK,@STATUS,@APPLYTIME,@REVIEWTIME,@USERID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ORDERNO", SqlDbType.NVarChar,50),
					new SqlParameter("@TUIKPRICE", SqlDbType.NVarChar,50),
					new SqlParameter("@REASON", SqlDbType.NVarChar,4000),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,400),
					new SqlParameter("@STATUS", SqlDbType.Int,4),
					new SqlParameter("@APPLYTIME", SqlDbType.DateTime),
					new SqlParameter("@REVIEWTIME", SqlDbType.DateTime),
					new SqlParameter("@USERID", SqlDbType.Int,4)};
			parameters[0].Value = model.ORDERNO;
			parameters[1].Value = model.TUIKPRICE;
			parameters[2].Value = model.REASON;
			parameters[3].Value = model.REMARK;
			parameters[4].Value = model.STATUS;
			parameters[5].Value = model.APPLYTIME;
			parameters[6].Value = model.REVIEWTIME;
			parameters[7].Value = model.USERID;

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
		public bool Update(Model.tb_tuikuan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_tuikuan set ");
			strSql.Append("ORDERNO=@ORDERNO,");
			strSql.Append("TUIKPRICE=@TUIKPRICE,");
			strSql.Append("REASON=@REASON,");
			strSql.Append("REMARK=@REMARK,");
			strSql.Append("STATUS=@STATUS,");
			strSql.Append("APPLYTIME=@APPLYTIME,");
			strSql.Append("REVIEWTIME=@REVIEWTIME,");
			strSql.Append("USERID=@USERID");
			strSql.Append(" where TUIKUANID=@TUIKUANID");
			SqlParameter[] parameters = {
					new SqlParameter("@ORDERNO", SqlDbType.NVarChar,50),
					new SqlParameter("@TUIKPRICE", SqlDbType.NVarChar,50),
					new SqlParameter("@REASON", SqlDbType.NVarChar,4000),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,400),
					new SqlParameter("@STATUS", SqlDbType.Int,4),
					new SqlParameter("@APPLYTIME", SqlDbType.DateTime),
					new SqlParameter("@REVIEWTIME", SqlDbType.DateTime),
					new SqlParameter("@USERID", SqlDbType.Int,4),
					new SqlParameter("@TUIKUANID", SqlDbType.Int,4)};
			parameters[0].Value = model.ORDERNO;
			parameters[1].Value = model.TUIKPRICE;
			parameters[2].Value = model.REASON;
			parameters[3].Value = model.REMARK;
			parameters[4].Value = model.STATUS;
			parameters[5].Value = model.APPLYTIME;
			parameters[6].Value = model.REVIEWTIME;
			parameters[7].Value = model.USERID;
			parameters[8].Value = model.TUIKUANID;

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
		public bool Delete(int TUIKUANID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_tuikuan ");
			strSql.Append(" where TUIKUANID=@TUIKUANID");
			SqlParameter[] parameters = {
					new SqlParameter("@TUIKUANID", SqlDbType.Int,4)
};
			parameters[0].Value = TUIKUANID;

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
		public bool DeleteList(string TUIKUANIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_tuikuan ");
			strSql.Append(" where TUIKUANID in ("+TUIKUANIDlist + ")  ");
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
		public Model.tb_tuikuan GetModel(int TUIKUANID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TUIKUANID,ORDERNO,TUIKPRICE,REASON,REMARK,STATUS,APPLYTIME,REVIEWTIME,USERID from tb_tuikuan ");
			strSql.Append(" where TUIKUANID=@TUIKUANID");
			SqlParameter[] parameters = {
					new SqlParameter("@TUIKUANID", SqlDbType.Int,4)
};
			parameters[0].Value = TUIKUANID;

			Model.tb_tuikuan model=new Model.tb_tuikuan();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["TUIKUANID"]!=null && ds.Tables[0].Rows[0]["TUIKUANID"].ToString()!="")
				{
					model.TUIKUANID=int.Parse(ds.Tables[0].Rows[0]["TUIKUANID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ORDERNO"]!=null && ds.Tables[0].Rows[0]["ORDERNO"].ToString()!="")
				{
					model.ORDERNO=ds.Tables[0].Rows[0]["ORDERNO"].ToString();
				}
				if(ds.Tables[0].Rows[0]["TUIKPRICE"]!=null && ds.Tables[0].Rows[0]["TUIKPRICE"].ToString()!="")
				{
					model.TUIKPRICE=ds.Tables[0].Rows[0]["TUIKPRICE"].ToString();
				}
				if(ds.Tables[0].Rows[0]["REASON"]!=null && ds.Tables[0].Rows[0]["REASON"].ToString()!="")
				{
					model.REASON=ds.Tables[0].Rows[0]["REASON"].ToString();
				}
				if(ds.Tables[0].Rows[0]["REMARK"]!=null && ds.Tables[0].Rows[0]["REMARK"].ToString()!="")
				{
					model.REMARK=ds.Tables[0].Rows[0]["REMARK"].ToString();
				}
				if(ds.Tables[0].Rows[0]["STATUS"]!=null && ds.Tables[0].Rows[0]["STATUS"].ToString()!="")
				{
					model.STATUS=int.Parse(ds.Tables[0].Rows[0]["STATUS"].ToString());
				}
				if(ds.Tables[0].Rows[0]["APPLYTIME"]!=null && ds.Tables[0].Rows[0]["APPLYTIME"].ToString()!="")
				{
					model.APPLYTIME=DateTime.Parse(ds.Tables[0].Rows[0]["APPLYTIME"].ToString());
				}
				if(ds.Tables[0].Rows[0]["REVIEWTIME"]!=null && ds.Tables[0].Rows[0]["REVIEWTIME"].ToString()!="")
				{
					model.REVIEWTIME=DateTime.Parse(ds.Tables[0].Rows[0]["REVIEWTIME"].ToString());
				}
				if(ds.Tables[0].Rows[0]["USERID"]!=null && ds.Tables[0].Rows[0]["USERID"].ToString()!="")
				{
					model.USERID=int.Parse(ds.Tables[0].Rows[0]["USERID"].ToString());
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
			strSql.Append("select TUIKUANID,ORDERNO,TUIKPRICE,REASON,REMARK,STATUS,APPLYTIME,REVIEWTIME,USERID ");
			strSql.Append(" FROM tb_tuikuan ");
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
			strSql.Append(" TUIKUANID,ORDERNO,TUIKPRICE,REASON,REMARK,STATUS,APPLYTIME,REVIEWTIME,USERID ");
			strSql.Append(" FROM tb_tuikuan ");
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
			parameters[0].Value = "tb_tuikuan";
			parameters[1].Value = "TUIKUANID";
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

