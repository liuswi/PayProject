using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;
namespace DAL
{
	/// <summary>
	/// 数据访问类:tb_user
	/// </summary>
	public partial class tb_user
	{
		public tb_user()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("USERID", "tb_user"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int USERID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_user");
			strSql.Append(" where USERID=@USERID");
			SqlParameter[] parameters = {
					new SqlParameter("@USERID", SqlDbType.Int,4)
};
			parameters[0].Value = USERID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 检查用户名是否存在
        /// </summary>
        public bool Exists(string user_name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_user");
            strSql.Append(" where USERNAME=@user_name ");
            SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,100)};
            parameters[0].Value = user_name;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.tb_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_user(");
			strSql.Append("USERNAME,USERPWD,USERSTATUS,USERTYPE,USERROLEID,USERREALNAME,USERSEX,USERADDRESS,USERCARD,USERPHONE,USEREMALL,USERQUESTION,USERANSWER)");
			strSql.Append(" values (");
			strSql.Append("@USERNAME,@USERPWD,@USERSTATUS,@USERTYPE,@USERROLEID,@USERREALNAME,@USERSEX,@USERADDRESS,@USERCARD,@USERPHONE,@USEREMALL,@USERQUESTION,@USERANSWER)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@USERNAME", SqlDbType.NVarChar,50),
					new SqlParameter("@USERPWD", SqlDbType.NVarChar,50),
					new SqlParameter("@USERSTATUS", SqlDbType.Int,4),
					new SqlParameter("@USERTYPE", SqlDbType.Int,4),
					new SqlParameter("@USERROLEID", SqlDbType.Int,4),
					new SqlParameter("@USERREALNAME", SqlDbType.NVarChar,50),
					new SqlParameter("@USERSEX", SqlDbType.NVarChar,10),
					new SqlParameter("@USERADDRESS", SqlDbType.NVarChar,200),
					new SqlParameter("@USERCARD", SqlDbType.NVarChar,50),
					new SqlParameter("@USERPHONE", SqlDbType.NVarChar,50),
					new SqlParameter("@USEREMALL", SqlDbType.NVarChar,50),
					new SqlParameter("@USERQUESTION", SqlDbType.NVarChar,100),
					new SqlParameter("@USERANSWER", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.USERNAME;
			parameters[1].Value = model.USERPWD;
			parameters[2].Value = model.USERSTATUS;
			parameters[3].Value = model.USERTYPE;
			parameters[4].Value = model.USERROLEID;
			parameters[5].Value = model.USERREALNAME;
			parameters[6].Value = model.USERSEX;
			parameters[7].Value = model.USERADDRESS;
			parameters[8].Value = model.USERCARD;
			parameters[9].Value = model.USERPHONE;
			parameters[10].Value = model.USEREMALL;
			parameters[11].Value = model.USERQUESTION;
			parameters[12].Value = model.USERANSWER;

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
		public bool Update(Model.tb_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_user set ");
			strSql.Append("USERNAME=@USERNAME,");
			strSql.Append("USERPWD=@USERPWD,");
			strSql.Append("USERSTATUS=@USERSTATUS,");
			strSql.Append("USERTYPE=@USERTYPE,");
			strSql.Append("USERROLEID=@USERROLEID,");
			strSql.Append("USERREALNAME=@USERREALNAME,");
			strSql.Append("USERSEX=@USERSEX,");
			strSql.Append("USERADDRESS=@USERADDRESS,");
			strSql.Append("USERCARD=@USERCARD,");
			strSql.Append("USERPHONE=@USERPHONE,");
			strSql.Append("USEREMALL=@USEREMALL,");
			strSql.Append("USERQUESTION=@USERQUESTION,");
			strSql.Append("USERANSWER=@USERANSWER");
			strSql.Append(" where USERID=@USERID");
			SqlParameter[] parameters = {
					new SqlParameter("@USERNAME", SqlDbType.NVarChar,50),
					new SqlParameter("@USERPWD", SqlDbType.NVarChar,50),
					new SqlParameter("@USERSTATUS", SqlDbType.Int,4),
					new SqlParameter("@USERTYPE", SqlDbType.Int,4),
					new SqlParameter("@USERROLEID", SqlDbType.Int,4),
					new SqlParameter("@USERREALNAME", SqlDbType.NVarChar,50),
					new SqlParameter("@USERSEX", SqlDbType.NVarChar,10),
					new SqlParameter("@USERADDRESS", SqlDbType.NVarChar,200),
					new SqlParameter("@USERCARD", SqlDbType.NVarChar,50),
					new SqlParameter("@USERPHONE", SqlDbType.NVarChar,50),
					new SqlParameter("@USEREMALL", SqlDbType.NVarChar,50),
					new SqlParameter("@USERQUESTION", SqlDbType.NVarChar,100),
					new SqlParameter("@USERANSWER", SqlDbType.NVarChar,100),
					new SqlParameter("@USERID", SqlDbType.Int,4)};
			parameters[0].Value = model.USERNAME;
			parameters[1].Value = model.USERPWD;
			parameters[2].Value = model.USERSTATUS;
			parameters[3].Value = model.USERTYPE;
			parameters[4].Value = model.USERROLEID;
			parameters[5].Value = model.USERREALNAME;
			parameters[6].Value = model.USERSEX;
			parameters[7].Value = model.USERADDRESS;
			parameters[8].Value = model.USERCARD;
			parameters[9].Value = model.USERPHONE;
			parameters[10].Value = model.USEREMALL;
			parameters[11].Value = model.USERQUESTION;
			parameters[12].Value = model.USERANSWER;
			parameters[13].Value = model.USERID;

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
		public bool Delete(int USERID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_user ");
			strSql.Append(" where USERID=@USERID");
			SqlParameter[] parameters = {
					new SqlParameter("@USERID", SqlDbType.Int,4)
};
			parameters[0].Value = USERID;

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
		public bool DeleteList(string USERIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_user ");
			strSql.Append(" where USERID in ("+USERIDlist + ")  ");
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
		public Model.tb_user GetModel(int USERID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 USERID,USERNAME,USERPWD,USERSTATUS,USERTYPE,USERROLEID,USERREALNAME,USERSEX,USERADDRESS,USERCARD,USERPHONE,USEREMALL,USERQUESTION,USERANSWER from tb_user ");
			strSql.Append(" where USERID=@USERID");
			SqlParameter[] parameters = {
					new SqlParameter("@USERID", SqlDbType.Int,4)
};
			parameters[0].Value = USERID;

			Model.tb_user model=new Model.tb_user();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["USERID"]!=null && ds.Tables[0].Rows[0]["USERID"].ToString()!="")
				{
					model.USERID=int.Parse(ds.Tables[0].Rows[0]["USERID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["USERNAME"]!=null && ds.Tables[0].Rows[0]["USERNAME"].ToString()!="")
				{
					model.USERNAME=ds.Tables[0].Rows[0]["USERNAME"].ToString();
				}
				if(ds.Tables[0].Rows[0]["USERPWD"]!=null && ds.Tables[0].Rows[0]["USERPWD"].ToString()!="")
				{
					model.USERPWD=ds.Tables[0].Rows[0]["USERPWD"].ToString();
				}
				if(ds.Tables[0].Rows[0]["USERSTATUS"]!=null && ds.Tables[0].Rows[0]["USERSTATUS"].ToString()!="")
				{
					model.USERSTATUS=int.Parse(ds.Tables[0].Rows[0]["USERSTATUS"].ToString());
				}
				if(ds.Tables[0].Rows[0]["USERTYPE"]!=null && ds.Tables[0].Rows[0]["USERTYPE"].ToString()!="")
				{
					model.USERTYPE=int.Parse(ds.Tables[0].Rows[0]["USERTYPE"].ToString());
				}
				if(ds.Tables[0].Rows[0]["USERROLEID"]!=null && ds.Tables[0].Rows[0]["USERROLEID"].ToString()!="")
				{
					model.USERROLEID=int.Parse(ds.Tables[0].Rows[0]["USERROLEID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["USERREALNAME"]!=null && ds.Tables[0].Rows[0]["USERREALNAME"].ToString()!="")
				{
					model.USERREALNAME=ds.Tables[0].Rows[0]["USERREALNAME"].ToString();
				}
				if(ds.Tables[0].Rows[0]["USERSEX"]!=null && ds.Tables[0].Rows[0]["USERSEX"].ToString()!="")
				{
					model.USERSEX=ds.Tables[0].Rows[0]["USERSEX"].ToString();
				}
				if(ds.Tables[0].Rows[0]["USERADDRESS"]!=null && ds.Tables[0].Rows[0]["USERADDRESS"].ToString()!="")
				{
					model.USERADDRESS=ds.Tables[0].Rows[0]["USERADDRESS"].ToString();
				}
				if(ds.Tables[0].Rows[0]["USERCARD"]!=null && ds.Tables[0].Rows[0]["USERCARD"].ToString()!="")
				{
					model.USERCARD=ds.Tables[0].Rows[0]["USERCARD"].ToString();
				}
				if(ds.Tables[0].Rows[0]["USERPHONE"]!=null && ds.Tables[0].Rows[0]["USERPHONE"].ToString()!="")
				{
					model.USERPHONE=ds.Tables[0].Rows[0]["USERPHONE"].ToString();
				}
				if(ds.Tables[0].Rows[0]["USEREMALL"]!=null && ds.Tables[0].Rows[0]["USEREMALL"].ToString()!="")
				{
					model.USEREMALL=ds.Tables[0].Rows[0]["USEREMALL"].ToString();
				}
				if(ds.Tables[0].Rows[0]["USERQUESTION"]!=null && ds.Tables[0].Rows[0]["USERQUESTION"].ToString()!="")
				{
					model.USERQUESTION=ds.Tables[0].Rows[0]["USERQUESTION"].ToString();
				}
				if(ds.Tables[0].Rows[0]["USERANSWER"]!=null && ds.Tables[0].Rows[0]["USERANSWER"].ToString()!="")
				{
					model.USERANSWER=ds.Tables[0].Rows[0]["USERANSWER"].ToString();
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
			strSql.Append("select USERID,USERNAME,USERPWD,USERSTATUS,USERTYPE,USERROLEID,USERREALNAME,USERSEX,USERADDRESS,USERCARD,USERPHONE,USEREMALL,USERQUESTION,USERANSWER ");
			strSql.Append(" FROM tb_user ");
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
			strSql.Append(" USERID,USERNAME,USERPWD,USERSTATUS,USERTYPE,USERROLEID,USERREALNAME,USERSEX,USERADDRESS,USERCARD,USERPHONE,USEREMALL,USERQUESTION,USERANSWER ");
			strSql.Append(" FROM tb_user ");
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
			parameters[0].Value = "tb_user";
			parameters[1].Value = "USERID";
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

