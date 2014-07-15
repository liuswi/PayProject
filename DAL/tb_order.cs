using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;
namespace DAL
{
	/// <summary>
	/// 数据访问类:tb_order
	/// </summary>
	public partial class tb_order
	{
		public tb_order()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ORDERID", "tb_order"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ORDERID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_order");
			strSql.Append(" where ORDERID=@ORDERID");
			SqlParameter[] parameters = {
					new SqlParameter("@ORDERID", SqlDbType.Int,4)
};
			parameters[0].Value = ORDERID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.tb_order model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_order(");
			strSql.Append("ORDERNO,ORDERTIME,BUSID,ORDERPRICE,USERID)");
			strSql.Append(" values (");
			strSql.Append("@ORDERNO,@ORDERTIME,@BUSID,@ORDERPRICE,@USERID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ORDERNO", SqlDbType.NVarChar,100),
					new SqlParameter("@ORDERTIME", SqlDbType.DateTime),
					new SqlParameter("@BUSID", SqlDbType.Int,4),
					new SqlParameter("@ORDERPRICE", SqlDbType.NVarChar,50),
					new SqlParameter("@USERID", SqlDbType.Int,4)};
			parameters[0].Value = model.ORDERNO;
			parameters[1].Value = model.ORDERTIME;
			parameters[2].Value = model.BUSID;
			parameters[3].Value = model.ORDERPRICE;
			parameters[4].Value = model.USERID;

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
		public bool Update(Model.tb_order model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_order set ");
			strSql.Append("ORDERNO=@ORDERNO,");
			strSql.Append("ORDERTIME=@ORDERTIME,");
			strSql.Append("BUSID=@BUSID,");
			strSql.Append("ORDERPRICE=@ORDERPRICE,");
			strSql.Append("USERID=@USERID");
			strSql.Append(" where ORDERID=@ORDERID");
			SqlParameter[] parameters = {
					new SqlParameter("@ORDERNO", SqlDbType.NVarChar,100),
					new SqlParameter("@ORDERTIME", SqlDbType.DateTime),
					new SqlParameter("@BUSID", SqlDbType.Int,4),
					new SqlParameter("@ORDERPRICE", SqlDbType.NVarChar,50),
					new SqlParameter("@USERID", SqlDbType.Int,4),
					new SqlParameter("@ORDERID", SqlDbType.Int,4)};
			parameters[0].Value = model.ORDERNO;
			parameters[1].Value = model.ORDERTIME;
			parameters[2].Value = model.BUSID;
			parameters[3].Value = model.ORDERPRICE;
			parameters[4].Value = model.USERID;
			parameters[5].Value = model.ORDERID;

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
		public bool Delete(int ORDERID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_order ");
			strSql.Append(" where ORDERID=@ORDERID");
			SqlParameter[] parameters = {
					new SqlParameter("@ORDERID", SqlDbType.Int,4)
};
			parameters[0].Value = ORDERID;

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
		public bool DeleteList(string ORDERIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_order ");
			strSql.Append(" where ORDERID in ("+ORDERIDlist + ")  ");
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
		public Model.tb_order GetModel(int ORDERID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ORDERID,ORDERNO,ORDERTIME,BUSID,ORDERPRICE,USERID from tb_order ");
			strSql.Append(" where ORDERID=@ORDERID");
			SqlParameter[] parameters = {
					new SqlParameter("@ORDERID", SqlDbType.Int,4)
};
			parameters[0].Value = ORDERID;

			Model.tb_order model=new Model.tb_order();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ORDERID"]!=null && ds.Tables[0].Rows[0]["ORDERID"].ToString()!="")
				{
					model.ORDERID=int.Parse(ds.Tables[0].Rows[0]["ORDERID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ORDERNO"]!=null && ds.Tables[0].Rows[0]["ORDERNO"].ToString()!="")
				{
					model.ORDERNO=ds.Tables[0].Rows[0]["ORDERNO"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ORDERTIME"]!=null && ds.Tables[0].Rows[0]["ORDERTIME"].ToString()!="")
				{
					model.ORDERTIME=DateTime.Parse(ds.Tables[0].Rows[0]["ORDERTIME"].ToString());
				}
				if(ds.Tables[0].Rows[0]["BUSID"]!=null && ds.Tables[0].Rows[0]["BUSID"].ToString()!="")
				{
					model.BUSID=int.Parse(ds.Tables[0].Rows[0]["BUSID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ORDERPRICE"]!=null && ds.Tables[0].Rows[0]["ORDERPRICE"].ToString()!="")
				{
					model.ORDERPRICE=ds.Tables[0].Rows[0]["ORDERPRICE"].ToString();
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
			strSql.Append("select ORDERID,ORDERNO,ORDERTIME,BUSID,ORDERPRICE,USERID ");
			strSql.Append(" FROM tb_order ");
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
			strSql.Append(" ORDERID,ORDERNO,ORDERTIME,BUSID,ORDERPRICE,USERID ");
			strSql.Append(" FROM tb_order ");
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
			parameters[0].Value = "tb_order";
			parameters[1].Value = "ORDERID";
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

