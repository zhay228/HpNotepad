using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data;
using System.Data.SQLite;
using DBFactory;
using HpModel;

namespace HpDAL
{
    public class DType
    {
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetAllType()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select TypeId,Name Type ");
            sql.Append(" FROM Dat_Type order by Name");

            SQLiteParameter[] parameters = {};
            SQLiteServer server = new SQLiteServer();
            return server.ExecuteQuery(sql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(MType model)
        {
            int id = -1;
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO Dat_Type(");
            sql.Append("TypeId,Name,Remark)");
            sql.Append(" values (");
            sql.Append("@TypeId,@Name,@Remark)");
            SQLiteServer server = new SQLiteServer();
            try
            {
                SQLiteParameter[] parameters = {
                    new SQLiteParameter("@TypeId",  DbType.Int32,4),
                    new SQLiteParameter("@Name", DbType.String,100),
                    new SQLiteParameter("@Remark", DbType.String,200), 
                };
                id = int.Parse(server.ExecuteQuery("select ifnull(max(TypeId),0) from Dat_Type").Rows[0][0].ToString()) + 1;
                parameters[0].Value = id;
                parameters[1].Value = model.Name;
                parameters[2].Value = model.Name; 

                server.ExecuteNonQuery(sql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.WriteErrLog(ex);
                return id;
            }
            finally
            {

            }
            return id;
        }

    }
}
