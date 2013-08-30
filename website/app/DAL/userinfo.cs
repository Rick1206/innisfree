using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:userinfo
	/// </summary>
	public partial class userinfo
	{
		public userinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("ID", "userinfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from userinfo");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
			parameters[0].Value = ID;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.userinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into userinfo(");
			strSql.Append("uname,usex,uage,uphone,uemail,wid,wname,parameter1,parameter2)");
			strSql.Append(" values (");
			strSql.Append("@uname,@usex,@uage,@uphone,@uemail,@wid,@wname,@parameter1,@parameter2)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@uname", OleDbType.VarChar,255),
					new OleDbParameter("@usex", OleDbType.VarChar,255),
					new OleDbParameter("@uage", OleDbType.VarChar,255),
					new OleDbParameter("@uphone", OleDbType.VarChar,255),
					new OleDbParameter("@uemail", OleDbType.VarChar,255),
					new OleDbParameter("@wid", OleDbType.VarChar,255),
					new OleDbParameter("@wname", OleDbType.VarChar,255),
					new OleDbParameter("@parameter1", OleDbType.VarChar,255),
					new OleDbParameter("@parameter2", OleDbType.VarChar,255)};
			parameters[0].Value = model.uname;
			parameters[1].Value = model.usex;
			parameters[2].Value = model.uage;
			parameters[3].Value = model.uphone;
			parameters[4].Value = model.uemail;
			parameters[5].Value = model.wid;
			parameters[6].Value = model.wname;
			parameters[7].Value = model.parameter1;
			parameters[8].Value = model.parameter2;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.userinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update userinfo set ");
			strSql.Append("uname=@uname,");
			strSql.Append("usex=@usex,");
			strSql.Append("uage=@uage,");
			strSql.Append("uphone=@uphone,");
			strSql.Append("uemail=@uemail,");
			strSql.Append("wid=@wid,");
			strSql.Append("wname=@wname,");
			strSql.Append("parameter1=@parameter1,");
			strSql.Append("parameter2=@parameter2");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@uname", OleDbType.VarChar,255),
					new OleDbParameter("@usex", OleDbType.VarChar,255),
					new OleDbParameter("@uage", OleDbType.VarChar,255),
					new OleDbParameter("@uphone", OleDbType.VarChar,255),
					new OleDbParameter("@uemail", OleDbType.VarChar,255),
					new OleDbParameter("@wid", OleDbType.VarChar,255),
					new OleDbParameter("@wname", OleDbType.VarChar,255),
					new OleDbParameter("@parameter1", OleDbType.VarChar,255),
					new OleDbParameter("@parameter2", OleDbType.VarChar,255),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
			parameters[0].Value = model.uname;
			parameters[1].Value = model.usex;
			parameters[2].Value = model.uage;
			parameters[3].Value = model.uphone;
			parameters[4].Value = model.uemail;
			parameters[5].Value = model.wid;
			parameters[6].Value = model.wname;
			parameters[7].Value = model.parameter1;
			parameters[8].Value = model.parameter2;
			parameters[9].Value = model.ID;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from userinfo ");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from userinfo ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString());
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
		public Maticsoft.Model.userinfo GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,uname,usex,uage,uphone,uemail,wid,wname,parameter1,parameter2 from userinfo ");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
			parameters[0].Value = ID;

			Maticsoft.Model.userinfo model=new Maticsoft.Model.userinfo();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.userinfo DataRowToModel(DataRow row)
		{
			Maticsoft.Model.userinfo model=new Maticsoft.Model.userinfo();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["uname"]!=null)
				{
					model.uname=row["uname"].ToString();
				}
				if(row["usex"]!=null)
				{
					model.usex=row["usex"].ToString();
				}
				if(row["uage"]!=null)
				{
					model.uage=row["uage"].ToString();
				}
				if(row["uphone"]!=null)
				{
					model.uphone=row["uphone"].ToString();
				}
				if(row["uemail"]!=null)
				{
					model.uemail=row["uemail"].ToString();
				}
				if(row["wid"]!=null)
				{
					model.wid=row["wid"].ToString();
				}
				if(row["wname"]!=null)
				{
					model.wname=row["wname"].ToString();
				}
				if(row["parameter1"]!=null)
				{
					model.parameter1=row["parameter1"].ToString();
				}
				if(row["parameter2"]!=null)
				{
					model.parameter2=row["parameter2"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,uname,usex,uage,uphone,uemail,wid,wname,parameter1,parameter2 ");
			strSql.Append(" FROM userinfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM userinfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
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
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from userinfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OleDbParameter[] parameters = {
					new OleDbParameter("@tblName", OleDbType.VarChar, 255),
					new OleDbParameter("@fldName", OleDbType.VarChar, 255),
					new OleDbParameter("@PageSize", OleDbType.Integer),
					new OleDbParameter("@PageIndex", OleDbType.Integer),
					new OleDbParameter("@IsReCount", OleDbType.Boolean),
					new OleDbParameter("@OrderType", OleDbType.Boolean),
					new OleDbParameter("@strWhere", OleDbType.VarChar,1000),
					};
			parameters[0].Value = "userinfo";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

