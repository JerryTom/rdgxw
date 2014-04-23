using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RD.DAL;
using RD.Model;

namespace RD.BAL
{
    public class B_News
    {
        D_News d = new D_News();
        /// <summary>
        /// 获取文章,无参数
        /// </summary>
        /// <returns></returns>
        public DataSet getNewsData()
        {
            return d.getNewsData();
        }

        /// <summary>
        /// 根据Sort_ID获取文章
        /// </summary>
        /// <param name="sid">Sort_ID</param>
        /// <returns></returns>
        public DataSet getDataBySort_ID(int sid)
        {
            return d.getDataBySort_ID(sid);
        }

        /// <summary>
        /// 获取文章分类列表
        /// </summary>
        /// <returns></returns>
        public DataSet getNews_Sort()
        {
            return d.getNews_Sort();
        }

        /// <summary>
        /// 根据ID获取文章数据
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public DataSet getNewsByID(int id)
        {
            return d.getNewsByID(id);
        }

        /// <summary>
        /// 添加新文章
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool addNews(R_News u)
        {
            return d.addNews(u) == 1 ? true : false;
        }

        /// <summary>
        /// 修改文章
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool editNews(R_News u)
        {
            return d.editNews(u) == 1 ? true : false;
        }

        /// <summary>
        /// 根据ID删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool deleteByNewsID(int id)
        {
            return d.deleteByNewsID(id) == 1 ? true : false;
        }


        /// <summary>
        /// 获取推荐阅读
        /// </summary>
        /// <returns></returns>
        public DataSet getDataByReading()
        {
            return d.getDataByReading();
        }

        /// <summary>
        /// 获取关于本站
        /// </summary>
        /// <returns></returns>
        public DataSet getAbout()
        {
            return d.getNewsByID(149);
        }

        /// <summary>
        /// 获取网站底部信息
        /// </summary>
        /// <returns></returns>
        public DataSet getWebInfor()
        {
            return d.getNewsByID(152);
        }

        /// <summary>
        /// 修改推荐阅读
        /// </summary>
        /// <param name="id"></param>
        /// <param name="read"></param>
        /// <returns></returns>
        public bool CancelNewsReading(int id,int read)
        {
            return d.CancelNewsReading(id, read) == 1 ? true : false;
        }

    }
}
