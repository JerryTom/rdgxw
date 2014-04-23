using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RD.Model;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace RD.DAL
{
    public class D_Links : D_Main
    {
        /// <summary>
        /// 获取所有友情链接数据
        /// </summary>
        /// <returns></returns>
        public DataSet getLinks()
        {
            return getData("select l.ID,l.Links_Name, l.Links_Url,u.User_Name from R_Links l left join R_User u on l.User_ID=u.ID");
        }

        /// <summary>
        /// 根据ID删除友情链接
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int deleteByLinksID(int id)
        {
            return deleteData("delete from R_Links where ID=@ID", id);
        }

        /// <summary>
        /// 根据ID获取数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable selLinksByID(int id)
        {
            return getDataByID("select * from R_Links where ID=@ID", id).Tables[0];
        }

        /// <summary>
        /// 查询友情链接是否存在
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int searchLinksNews(string name)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand("select * from  R_Links where Links_Name=@Links_Name");
            db.AddInParameter(cmd, "@Links_Name", DbType.String, name);
            return db.ExecuteDataSet(cmd).Tables[0].Rows.Count;
        }

        /// <summary>
        /// 添加新链接
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int addLinks(R_Links r)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(@"insert into R_Links 
                                                    (Links_Name, Links_Url,User_ID) 
                                                    values 
                                                    (@Links_Name, @Links_Url,@User_ID)");
            db.AddInParameter(cmd, "@Links_Name", DbType.String, r.Links_Name);
            db.AddInParameter(cmd, "@Links_Url", DbType.String, r.Links_Url);
            db.AddInParameter(cmd, "@User_ID", DbType.Int32, r.User_ID);
            return db.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// 修改链接
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int editLinks(R_Links r)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(@"UPDATE  R_Links
                                                    SET  Links_Name=@Links_Name, Links_Url=@Links_Url,User_ID=@User_ID
                                                    WHERE   (ID = @ID)");
            db.AddInParameter(cmd, "@Links_Name", DbType.String, r.Links_Name);
            db.AddInParameter(cmd, "@Links_Url", DbType.String, r.Links_Url);
            db.AddInParameter(cmd, "@User_ID", DbType.Int32, r.User_ID);
            db.AddInParameter(cmd, "@ID", DbType.Int32, r.ID);
            return db.ExecuteNonQuery(cmd);
        }
    }
}
