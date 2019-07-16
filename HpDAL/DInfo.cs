using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Sql;
using System.Data;
using System.Data.SQLite;
using DBFactory;
using HpModel;

namespace HpDAL
{
    public class DInfo
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(MInfo model)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO Dat_Info(");
            sql.Append("Id,IsCtrl,IsAlt,IsShift,Key,Title,Content,UserId,CreateDateTime,TypeId)");
            sql.Append(" values (");
            sql.Append("@Id,@IsCtrl,@IsAlt,@IsShift,@Key,@Title,@Content,@UserId,@CreateDateTime,@TypeId)");
            SQLiteServer server = new SQLiteServer();
            try
            {
                SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Id",  DbType.Int32,4),
                    new SQLiteParameter("@IsCtrl", DbType.Boolean),
                    new SQLiteParameter("@IsAlt", DbType.Boolean),
                    new SQLiteParameter("@IsShift", DbType.Boolean),
                    new SQLiteParameter("@Key", DbType.String,500),
                    new SQLiteParameter("@Title", DbType.String,500),
                    new SQLiteParameter("@Content", DbType.String,30000),
                    new SQLiteParameter("@UserId", DbType.Int16,100),
                    new SQLiteParameter("@CreateDateTime", DbType.DateTime),
                    new SQLiteParameter("@TypeId", DbType.Int16,100)
                };

                parameters[0].Value = int.Parse(server.ExecuteQuery("select ifnull(max(id),0) from Dat_Info").Rows[0][0].ToString()) + 1;
                parameters[1].Value = model.IsCtrl;
                parameters[2].Value = model.IsAlt;
                parameters[3].Value = model.IsShift;
                parameters[4].Value = model.Key;
                parameters[5].Value = model.Title;
                parameters[6].Value = model.Content;
                parameters[7].Value = model.UserId;
                parameters[8].Value = DateTime.Now.ToString();
                parameters[9].Value = model.TypeId;

                server.ExecuteNonQuery(sql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.WriteErrLog(ex);
                return false;
            }
            finally
            {

            }
            return true;
        }

        public bool Update(MInfo model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update Dat_Info set Title = @Title, Content =@Content,UserId=@UserId,CreateDateTime=@CreateDateTime,TypeId=@TypeId where Id = @Id");

            SQLiteServer server = new SQLiteServer();
            try
            {
                SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Id",  DbType.Int32,4),
                    new SQLiteParameter("@Title", DbType.String,500),
                    new SQLiteParameter("@Content", DbType.String,30000),
                    new SQLiteParameter("@UserId", DbType.Int16,100),
                    new SQLiteParameter("@CreateDateTime", DbType.DateTime),
                    new SQLiteParameter("@TypeId", DbType.Int16,100)};

                parameters[0].Value = model.Id;
                parameters[1].Value = model.Title;
                parameters[2].Value = model.Content;
                parameters[3].Value = model.UserId;
                parameters[4].Value = DateTime.Now.ToString();
                parameters[5].Value = model.TypeId;
                server.ExecuteNonQuery(sql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.WriteErrLog(ex);
                return false;
            }
            finally
            {

            }
            return true;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public bool Del(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from Dat_Info where id = @id ");
            SQLiteServer server = new SQLiteServer();
            SQLiteParameter[] parameters = { new SQLiteParameter("@Id", DbType.Int32, 4) };
            parameters[0].Value = id;
            return server.ExecuteNonQuery(sql.ToString(), parameters) > 0;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetAll(string title,int typeId)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select Id,d.rowid as 序号,t.Name 类型 , Title 标题, Content 内容  FROM Dat_Info d left join Dat_Type t on t.typeId = d.typeId where Title like '%" + title + "%' ");
            if (typeId != -1) {
                sql.Append(" and d.typeId =" + typeId);
            }
            sql.Append(" order by t.typeId");
           
            SQLiteServer server = new SQLiteServer();
            SQLiteParameter[] parameters = { };
            return server.ExecuteQuery(sql.ToString(), parameters);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public MInfo GetModel(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select Id, Title ,Content ,typeId FROM Dat_Info  where id = @id ");
            SQLiteServer server = new SQLiteServer();
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@id", DbType.Int16,100)
                                           };
            parameters[0].Value = id;
            MInfo model = new MInfo();
            DataTable dt = server.ExecuteQuery(sql.ToString(), parameters);
            if (dt.Rows.Count > 0)
            {
                model.Title = dt.Rows[0][1].ToString();
                model.Id = int.Parse(dt.Rows[0][0].ToString());
                model.Content = dt.Rows[0][2].ToString();
                model.TypeId = int.Parse(dt.Rows[0][3].ToString());
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetData(string title, int userId)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select Title,Content");
            sql.Append(" FROM Dat_Info where Title like '%" + title + "%' and UserId= @UserId");

            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@UserId", DbType.Int16,100)
                                           };
            parameters[0].Value = userId;
            SQLiteServer server = new SQLiteServer();
            return server.ExecuteQuery(sql.ToString(), parameters);
        }

        public bool IsExistName(string title)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select Title,Content");
            sql.Append(" FROM Dat_Info where Title = @Title");

            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Title",  DbType.String,500)
                                           };
            parameters[0].Value = title;
            SQLiteServer server = new SQLiteServer();
            return server.ExecuteQuery(sql.ToString(), parameters).Rows.Count > 0;
        }

        public DataTable GetAllData(string path)
        {
            SQLiteServer server = new SQLiteServer(path);
            string sql = "select * from Dat_Info order by typeId";
            return server.ExecuteQuery(sql);

        }
    }
}
