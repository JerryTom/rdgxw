using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RD.DAL;
using RD.Model;
using System.Data;

namespace RD.BAL
{
    public class B_User
    {
        D_User d = new D_User();

        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <returns></returns>
        public DataSet getUserData()
        {
            return d.getUserData();
        }

        /// <summary>
        /// 获取用户分类信息
        /// </summary>
        /// <returns></returns>
        public DataSet getUserType()
        {
            return d.getUserType();
        }

        /// <summary>
        /// 查询用户信息是否存在
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public DataTable selUser(string name)
        {
            return d.searchUser(name);
        }

        /// <summary>
        /// 登陆后的修改操作
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool updatalogin(int id)
        {
            bool v = false;
            if (d.updatalogin(id) == 1)
            {
                v = true;
            }
            return v;
        }

        /// <summary>
        /// 根据ID获取用户数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable getUserByID(int id)
        {
            return d.getUserByID(id);
        }

        /// <summary>
        /// 查询用户名是否已存在
        /// </summary>
        /// <param name="name">用户名</param>
        /// <returns>是否存在</returns>
        public bool searchUser(string name)
        {
            bool bl = false;
            if (d.searchUser(name).Rows.Count == 0)
            {
                bl = true;
            }
            return bl;
        }

        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="u">R_User的实例</param>
        /// <returns>是否添加成功</returns>
        public bool addUser(R_User u)
        {
            bool bl = false;
            if (d.addUser(u) == 1)
            {
                bl = true;
            }
            return bl;
        }

         /// <summary>
         /// 修改用户信息（用户类型，密码）
         /// </summary>
         /// <param name="u">R_User的实例</param>
        /// <returns>是否修改成功</returns>
        public bool editUser(R_User u)
        {
            bool bl = false;
            if (d.editUser(u) == 1)
            {
                bl = true;
            }
            return bl;
        }

        /// <summary>
        /// 根据ID删除用户数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns>是否删除成功</returns>
        public bool deleteByUserID(int id)
        {
            bool bl = false;
            if (d.deleteByUserID(id) == 1)
            {
                bl = true;
            }
            return bl;
        }
    }
}
