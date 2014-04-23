using Microsoft.Practices.EnterpriseLibrary.Data;
using RD.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD.DAL
{
    public class D_News : D_Main
    {
        /// <summary>
        /// 获取文章,无参数
        /// </summary>
        /// <returns></returns>
        public DataSet getNewsData()
        {
            return getData(@"SELECT   n.ID, n.Sort_ID,s.Sort_Name, s.Sort_Value, n.News_Tital, n.News_Content, u.User_Name, 
                                          n.News_AddTime, n.News_EditTime, n.News_Images,r.NewsCount,n.News_Reading,n.News_ImageBool  
                            FROM      (((R_News n LEFT OUTER JOIN
                                                (SELECT   News_ID, SUM(Read_Count) AS NewsCount
                                                 FROM      R_Read
                                                 GROUP BY News_ID) r ON r.News_ID = n.ID) INNER JOIN
                                            R_NewsSort s ON n.Sort_ID = s.ID) INNER JOIN
                                            R_User u ON n.User_ID = u.ID)
                            WHERE s.Sort_Value NOT LIKE 'about'
                            ORDER BY r.NewsCount DESC");
        }

        /// <summary>
        /// 根据Sort_ID获取文章
        /// </summary>
        /// <param name="sid">Sort_ID</param>
        /// <returns></returns>
        public DataSet getDataBySort_ID(int sid)
        {
            return getDataBySort_ID(@"SELECT   n.ID, n.Sort_ID,s.Sort_Name, s.Sort_Value, n.News_Tital, n.News_Content, u.User_Name, 
                                          n.News_AddTime, n.News_EditTime, n.News_Images,r.NewsCount,n.News_Reading,n.News_ImageBool  
                                        FROM      (((R_News n LEFT OUTER JOIN
                                                            (SELECT   News_ID, SUM(Read_Count) AS NewsCount
                                                             FROM      R_Read
                                                             GROUP BY News_ID) r ON r.News_ID = n.ID) INNER JOIN
                                                        R_NewsSort s ON n.Sort_ID = s.ID) INNER JOIN
                                                        R_User u ON n.User_ID = u.ID)
                                        WHERE n.Sort_ID=@Sort_ID and s.Sort_Value NOT LIKE 'about'
                                        ORDER BY r.NewsCount DESC", sid);
        }

        /// <summary>
        /// 根据ID获取文章数据
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public DataSet getNewsByID(int id)
        {
            return getDataByID(@"SELECT n.ID, n.Sort_ID,s.Sort_Name, s.Sort_Value, n.News_Tital, n.News_Content, u.User_Name, 
                                          n.News_AddTime, n.News_EditTime, n.News_Images, n.News_Count,n.News_Reading,n.News_ImageBool
                                    FROM ((R_News n LEFT OUTER JOIN
                                          R_NewsSort s ON n.Sort_ID = s.ID) INNER JOIN
                                          R_User u ON n.User_ID = u.ID) where n.ID=@ID ORDER BY n.ID DESC", id);
        }



        /// <summary>
        /// 获取文章分类列表
        /// </summary>
        /// <returns></returns>
        public DataSet getNews_Sort()
        {
            return getData("select * from R_NewsSort where Sort_Value not like'about'");
        }

        /// <summary>
        /// 查询用户名是否已存在
        /// </summary>
        /// <param name="name">用户名</param>
        /// <returns>1存在，0不存在</returns>
        public int searchNews(string name)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand("select * from  R_User where User_Name=@User_Name");
            db.AddInParameter(cmd, "@User_Name", DbType.String, name);
            return db.ExecuteDataSet(cmd).Tables[0].Rows.Count;
        }

        /// <summary>
        /// 添加新文章
        /// </summary>
        /// <param name="u">实例</param>
        /// <returns>受影响行数</returns>
        public int addNews(R_News u)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(@"insert into R_News 
                ( Sort_ID,News_Tital,News_Content,User_ID, News_AddTime, News_Images,News_Count, News_Reading, News_ImageBool) 
                                                    values 
             (@Sort_ID,@News_Tital,@News_Content,@User_ID, @News_AddTime, @News_Images,@News_Count, @News_Reading, @News_ImageBool)
");
            db.AddInParameter(cmd, "@Sort_ID", DbType.Int32, u.Sort_ID);
            db.AddInParameter(cmd, "@News_Tital", DbType.String, u.News_Tital);
            db.AddInParameter(cmd, "@News_Content", DbType.String, u.News_Content);
            db.AddInParameter(cmd, "@User_ID", DbType.Int32, u.User_ID);
            db.AddInParameter(cmd, "@News_AddTime", DbType.String, DateTime.Now.ToString());
            db.AddInParameter(cmd, "@News_Images", DbType.String, u.News_Images);
            db.AddInParameter(cmd, "@News_Count", DbType.Int32, 0);
            db.AddInParameter(cmd, "@News_Reading", DbType.String, u.News_Reading);
            db.AddInParameter(cmd, "@News_ImageBool", DbType.String, u.News_ImageBool);
            return db.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// 修改文章
        /// </summary>
        /// <param name="u">实例</param>
        /// <returns>受影响行数</returns>
        public int editNews(R_News u)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(@"UPDATE  R_News
                                                    SET 
            Sort_ID=@Sort_ID,News_Tital=@News_Tital,News_Content=@News_Content,User_ID=@User_ID, 
            News_EditTime=@News_EditTime,News_Images=@News_Images, 
            News_Reading=@News_Reading, News_ImageBool=@News_ImageBool
                                                    WHERE   (ID = @ID)");
            db.AddInParameter(cmd, "@Sort_ID", DbType.Int32, u.Sort_ID);
            db.AddInParameter(cmd, "@News_Tital", DbType.String, u.News_Tital);
            db.AddInParameter(cmd, "@News_Content", DbType.String, u.News_Content);
            db.AddInParameter(cmd, "@User_ID", DbType.Int32, u.User_ID);
            db.AddInParameter(cmd, "@News_EditTime", DbType.String, DateTime.Now.ToString());
            db.AddInParameter(cmd, "@News_Images", DbType.String, u.News_Images);
            db.AddInParameter(cmd, "@News_Reading", DbType.String, u.News_Reading);
            db.AddInParameter(cmd, "@News_ImageBool", DbType.String, u.News_ImageBool);
            db.AddInParameter(cmd, "@ID", DbType.Int32, u.ID);
            return db.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// 更改推荐阅读
        /// </summary>
        /// <param name="id"></param>
        /// <param name="read"></param>
        /// <returns></returns>
        public int CancelNewsReading(int id,int read)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(@"UPDATE  R_News
                                                    SET 
            News_Reading=@News_Reading
                                                    WHERE   (ID = @ID)");
            db.AddInParameter(cmd, "@News_Reading", DbType.String, read);
            db.AddInParameter(cmd, "@ID", DbType.Int32, id);
            return db.ExecuteNonQuery(cmd);
        }


        /// <summary>
        /// 根据ID删除用户数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns>受影响行数</returns>
        public int deleteByNewsID(int id)
        {
            return deleteData("delete from R_News where ID=@ID", id);
        }

        /// <summary>
        /// 获取推荐阅读
        /// </summary>
        /// <returns></returns>
        public DataSet getDataByReading()
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(@"SELECT n.ID, s.Sort_Name, s.Sort_Value, n.News_Tital, n.News_Content, u.User_Name, 
                                          n.News_AddTime, n.News_EditTime, n.News_Images, n.News_Count
                                    FROM ((R_News n LEFT OUTER JOIN
                                          R_NewsSort s ON n.Sort_ID = s.ID) INNER JOIN
                                          R_User u ON n.User_ID = u.ID)  where n.News_Reading=@News_Reading ORDER BY n.ID DESC");
            db.AddInParameter(cmd, "@News_Reading", DbType.Int32, 1);
            return db.ExecuteDataSet(cmd);
        }
    }
}
