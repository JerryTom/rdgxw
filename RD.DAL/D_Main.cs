using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace RD.DAL
{
    public class D_Main
    {
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>DataSet数据集</returns>
        public DataSet getData(string sql)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(sql);
            return db.ExecuteDataSet(cmd);
        }

        /// <summary>
        /// 获取数据表
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>DataTable数据表</returns>
        public DataTable getDataTable(string sql)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(sql);
            return db.ExecuteDataSet(cmd).Tables[0];
        }

        /// <summary>
        /// 获取总条数
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>返回查询到的总行数</returns>
        public int getCount(string sql)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(sql);
            return db.ExecuteDataSet(cmd).Tables[0].Rows.Count;
        }

        /// <summary>
        /// 根据ID删除数据
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="id">ID</param>
        /// <returns>受影响行数</returns>
        public int deleteData(string sql, int id)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(sql);
            db.AddInParameter(cmd, "@ID", DbType.Int32, id);
            return db.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// 根据ID获取数据
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataSet getDataByID(string sql, int id)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(sql);
            db.AddInParameter(cmd, "@ID", DbType.Int32, id);
            return db.ExecuteDataSet(cmd);
        }

        /// <summary>
        /// 根据Sort_ID获取文章数据
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="sid">Sort_ID</param>
        /// <returns></returns>
        public DataSet getDataBySort_ID(string sql, int sid)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(sql);
            db.AddInParameter(cmd, "@Sort_ID", DbType.Int32, sid);
            return db.ExecuteDataSet(cmd);
        }
    }
}
