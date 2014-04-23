using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;
using RD.Model;

namespace RD.DAL
{
    public class D_Index : D_Main
    {
        /// <summary>
        /// 根据ID获取文章数据
        /// </summary>
        /// <returns></returns>
        public DataTable getNewsByID(int id)
        {
            return getDataByID(@"SELECT n.ID, s.Sort_Name, s.Sort_Value, n.News_Tital, n.News_Content, u.User_Name, 
                                          n.News_AddTime, n.News_EditTime, n.News_Images, n.News_Count
                                    FROM ((R_News n LEFT OUTER JOIN
                                          R_NewsSort s ON n.Sort_ID = s.ID) INNER JOIN
                                          R_User u ON n.User_ID = u.ID) where n.ID=@ID", id).Tables[0];
        }

        /// <summary>
        /// 查询文章今天是否访问过
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public DataSet searchRead(R_Read r)
        {
            DataSet ds = new DataSet();
            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                DbCommand cmd = db.GetSqlStringCommand(@"select * from R_Read where News_ID=@News_ID and Read_IP=@Read_IP");
                db.AddInParameter(cmd, "@News_ID", DbType.Int32, r.News_ID);
                db.AddInParameter(cmd, "@Read_IP", DbType.String, r.Read_IP);
                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception) { }
            return ds;
        }

        /// <summary>
        /// 更新访问量
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int updateRead(R_Read r)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(@"update R_Read set  Read_Time=@Read_Time,Read_Count=@Read_Count where News_ID=@News_ID and Read_IP=@Read_IP");
            db.AddInParameter(cmd, "@Read_Time", DbType.Date, DateTime.Now.Date);
            db.AddInParameter(cmd, "@Read_Count", DbType.Int32, r.Read_Count);
            db.AddInParameter(cmd, "@News_ID", DbType.Int32, r.News_ID);
            db.AddInParameter(cmd, "@Read_IP", DbType.String, r.Read_IP);
            return db.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// 添加访问量
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int addRead(R_Read r)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(@"INSERT INTO R_Read
                                                (News_ID, Read_IP, Read_Time, Read_Count)
                                VALUES   (@News_ID, @Read_IP, @Read_Time, @Read_Count)");
            db.AddInParameter(cmd, "@News_ID", DbType.Int32, r.News_ID);
            db.AddInParameter(cmd, "@Read_IP", DbType.String, r.Read_IP);
            db.AddInParameter(cmd, "@Read_Time", DbType.Date, DateTime.Now.Date);
            db.AddInParameter(cmd, "@Read_Count", DbType.Int32, 1);
            return db.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// 根据Sort_Value获取数据
        /// </summary>
        /// <param name="sort_Value">Sort_Value</param>
        /// <returns>数据表</returns>
        public DataTable getDataBySort_Value(string sort_Value)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(@"SELECT n.ID, s.Sort_Name, s.Sort_Value, n.News_Tital, n.News_Content, u.User_Name, 
                                          n.News_AddTime, n.News_EditTime, n.News_Images, n.News_Count
                                    FROM ((R_News n LEFT OUTER JOIN
                                          R_NewsSort s ON n.Sort_ID = s.ID) INNER JOIN
                                          R_User u ON n.User_ID = u.ID)  where s.Sort_Value =@Sort_Value ORDER BY n.ID DESC");
            db.AddInParameter(cmd, "@Sort_Value", DbType.String, sort_Value);
            return db.ExecuteDataSet(cmd).Tables[0];
        }

        /// <summary>
        /// 获取最新新闻
        /// </summary>
        /// <returns></returns>
        public DataTable getNews()
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(@"SELECT n.ID, s.Sort_Name, s.Sort_Value, n.News_Tital, n.News_Content, u.User_Name, 
                                          n.News_AddTime, n.News_EditTime, n.News_Images, n.News_Count
                                    FROM ((R_News n LEFT OUTER JOIN
                                          R_NewsSort s ON n.Sort_ID = s.ID) INNER JOIN
                                          R_User u ON n.User_ID = u.ID)  where s.Sort_Value not like 'about' ORDER BY n.ID DESC");
            return db.ExecuteDataSet(cmd).Tables[0];
        }

        /// <summary>
        /// 获取推荐阅读
        /// </summary>
        /// <returns></returns>
        public DataTable getDataByReading()
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(@"SELECT n.ID, s.Sort_Name, s.Sort_Value, n.News_Tital, n.News_Content, u.User_Name, 
                                          n.News_AddTime, n.News_EditTime, n.News_Images, n.News_Count
                                    FROM ((R_News n LEFT OUTER JOIN
                                          R_NewsSort s ON n.Sort_ID = s.ID) INNER JOIN
                                          R_User u ON n.User_ID = u.ID)  where n.News_Reading=@News_Reading ORDER BY n.ID DESC");
            db.AddInParameter(cmd, "@News_Reading", DbType.Int32, 1);
            return db.ExecuteDataSet(cmd).Tables[0];
        }

        /// <summary>
        /// 获取图片
        /// </summary>
        /// <returns></returns>
        public DataTable getDataByImg()
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(@"SELECT n.ID, s.Sort_Name, s.Sort_Value, n.News_Tital, n.News_Content, u.User_Name, 
                                          n.News_AddTime, n.News_EditTime, n.News_Images, n.News_Count
                                    FROM ((R_News n LEFT OUTER JOIN
                                          R_NewsSort s ON n.Sort_ID = s.ID) INNER JOIN
                                          R_User u ON n.User_ID = u.ID)  where n.News_ImageBool=@News_Reading ORDER BY n.ID DESC");
            db.AddInParameter(cmd, "@News_ImageBool", DbType.Int32, 1);
            return db.ExecuteDataSet(cmd).Tables[0];
        }

        #region 获取数据
                /// <summary>
        /// 获取所有友情链接数据
        /// </summary>
        /// <returns>DataTable数据</returns>
        public DataTable getLinks()
        {
            return getDataTable("select  * from R_Links");
        }

        /// <summary>
        /// 获取热门新闻
        /// </summary>
        /// <returns></returns>
        public DataTable getHotNews()
        {
            return getDataTable(@"SELECT   n.ID, s.Sort_Name, s.Sort_Value, n.News_Tital, n.News_Content, u.User_Name, n.News_AddTime, n.News_EditTime, 
                                     r.NewsCount
                            FROM      (((R_News n LEFT OUTER JOIN
                                                (SELECT   News_ID, SUM(Read_Count) AS NewsCount
                                                 FROM      R_Read
                                                 GROUP BY News_ID) r ON r.News_ID = n.ID) INNER JOIN
                                            R_NewsSort s ON n.Sort_ID = s.ID) INNER JOIN
                                            R_User u ON n.User_ID = u.ID)
                            WHERE   (s.Sort_Value NOT LIKE 'about')
                            ORDER BY r.NewsCount DESC");
        }
        #endregion
    }
}
