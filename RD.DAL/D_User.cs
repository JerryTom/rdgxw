using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using RD.Model;

namespace RD.DAL
{
    public class D_User : D_Main
    {
        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <returns></returns>
        public DataSet getUserData()
        {
            return getData(@"SELECT   u.ID, u.User_Name, t.UserType_Name, u.LostLoginTime, u.LoginCount
                            FROM      (R_User u LEFT OUTER JOIN
                             R_UserType t ON u.User_Type = t.UserType_Value) order by LostLoginTime desc");
        }

        /// <summary>
        /// 获取用户分类信息
        /// </summary>
        /// <returns></returns>
        public DataSet getUserType()
        {
            return getData("SELECT * FROM R_UserType");
        }


        /// <summary>
        /// 根据ID获取用户数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable getUserByID(int id)
        {
            return getDataByID("select * from R_User where ID=@ID", id).Tables[0];
        }

        /// <summary>
        /// 查询用户名
        /// </summary>
        /// <param name="name">用户名</param>
        /// <returns></returns>
        public DataTable searchUser(string name)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand("select * from  R_User where User_Name=@User_Name");
            db.AddInParameter(cmd, "@User_Name", DbType.String, name);
            return db.ExecuteDataSet(cmd).Tables[0];
        }
        /// <summary>
        /// 用户登录后的操作
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int updatalogin(int id)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(@"UPDATE  R_User
                                                    SET  LostLoginTime=@LT,LoginCount=@LC
                                                    WHERE   (ID = @ID)");
            db.AddInParameter(cmd, "@LT", DbType.String, DateTime.Now.ToString());
            db.AddInParameter(cmd, "@LC", DbType.Int32, (searchLoginCount(id) + 1));
            db.AddInParameter(cmd, "@ID", DbType.Int32, id);
            return db.ExecuteNonQuery(cmd);
        }

        public int searchLoginCount(int id)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand("select LoginCount from  R_User where ID=@ID");
            db.AddInParameter(cmd, "@ID", DbType.Int32, id);
            return Convert.ToInt32(db.ExecuteDataSet(cmd).Tables[0].Rows[0]["LoginCount"]);
        }
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="u">R_User的实例</param>
        /// <returns>受影响行数</returns>
        public int addUser(R_User u)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(@"insert into R_User 
                                                    (User_Name,[Password],User_Type,LoginCount) 
                                                    values 
                                                    (@User_Name,@Password,@User_Type,@LoginCount)");
            db.AddInParameter(cmd, "@User_Name", DbType.String, u.User_Name);
            db.AddInParameter(cmd, "@Password", DbType.String, u.Password);
            db.AddInParameter(cmd, "@User_Type", DbType.Int32, u.User_Type);
            db.AddInParameter(cmd, "@LoginCount", DbType.Int32, u.LoginCount);
            return db.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// 修改用户信息（用户类型，密码）
        /// </summary>
        /// <param name="u">R_User的实例</param>
        /// <returns>受影响行数</returns>
        public int editUser(R_User u)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand cmd = db.GetSqlStringCommand(@"UPDATE  R_User
                                                    SET         [Password] = @Password
                                                    WHERE   (ID = @ID)");
            db.AddInParameter(cmd, "@Password", DbType.String, u.Password);
            db.AddInParameter(cmd, "@ID", DbType.Int32, u.ID);
            return db.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// 根据ID删除用户数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns>受影响行数</returns>
        public int deleteByUserID(int id)
        {
            return deleteData("delete from R_User where ID=@ID", id);
        }
    }
}
