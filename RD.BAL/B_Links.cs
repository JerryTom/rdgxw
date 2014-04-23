using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RD.DAL;
using RD.Model;

namespace RD.BAL
{
    public class B_Links
    {
        D_Links d = new D_Links();
        /// <summary>
        /// 获取所有友情链接数据
        /// </summary>
        /// <returns></returns>
        public DataSet getLinks()
        {
            return d.getLinks();
        }

        /// <summary>
        /// 根据ID删除友情链接
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool deleteByLinksID(int id)
        {
            return d.deleteByLinksID(id) == 1 ? true : false;
        }

        /// <summary>
        /// 根据ID获取数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable selLinksByID(int id)
        {
            return d.selLinksByID(id);
        }

        /// <summary>
        /// 查询友情链接是否存在
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int searchLinksNews(string name)
        {
            return d.searchLinksNews(name);
        }

        /// <summary>
        /// 添加新链接
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public bool addLinks(R_Links r)
        {
            return d.addLinks(r) == 1 ? true : false;
        }

        /// <summary>
        /// 修改链接
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public bool editLinks(R_Links r)
        {
            return d.editLinks(r) == 1 ? true : false;
        }
    }
}
