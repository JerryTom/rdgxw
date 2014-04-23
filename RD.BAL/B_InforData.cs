using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RD.DAL;
using System.Data;

namespace RD.BAL
{
    public class B_InforData : B_Main
    {
        D_Index d = new D_Index();
        #region 获取数据
                /// <summary>
        /// 获取最新要问总条数
        /// </summary>
        /// <returns></returns>
        public int getLatestnewsCount()
        {
            return d.getDataBySort_Value("Latestnews").Rows.Count;
        }

        /// <summary>
        /// 获取最新要闻
        /// </summary>
        /// <returns></returns>
        public string getLatestnews(int begin,int end)
        {
            DataTable dt = d.getDataBySort_Value("Latestnews");
            return getInforTable(dt,begin,end);
        }

        /// <summary>
        /// 获取政策法规总条数
        /// </summary>
        /// <returns></returns>
        public int getPolicyLawsCount()
        {
            return d.getDataBySort_Value("PolicyLaws").Rows.Count;
        }

        /// <summary>
        /// 获取政策法规
        /// </summary>
        /// <returns></returns>
        public string getPolicyLaws(int begin,int end)
        {
            DataTable dt = d.getDataBySort_Value("PolicyLaws");
            return getInforTable(dt,begin,end);
        }

        /// <summary>
        /// 获取市场动态总条数
        /// </summary>
        /// <returns></returns>
        public int getMarknewsCount()
        {
            return d.getDataBySort_Value("Marknews").Rows.Count;
        }

        /// <summary>
        /// 获取市场动态
        /// </summary>
        /// <returns></returns>
        public string getMarknews(int begin,int end)
        {
            DataTable dt = d.getDataBySort_Value("Marknews");
            return getInforTable(dt,begin,end);
        }

        /// <summary>
        /// 获取特色产品总条数
        /// </summary>
        /// <returns></returns>
        public int getAgricultTechCount()
        {
            return d.getDataBySort_Value("AgricultTech").Rows.Count;
        }

        /// <summary>
        /// 获取特色产品
        /// </summary>
        /// <returns></returns>
        public string getAgricultTech(int begin,int end)
        {
            DataTable dt = d.getDataBySort_Value("AgricultTech");
            return getInforTable(dt,begin,end);
        }

        /// <summary>
        /// 获取供求信息总条数
        /// </summary>
        /// <returns></returns>
        public int getSupply_demandInforCount()
        {
            return d.getDataBySort_Value("Supply_demandInfor").Rows.Count;
        }

        /// <summary>
        /// 获取供求信息
        /// </summary>
        /// <returns></returns>
        public string getSupply_demandInfor(int begin,int end)
        {
            DataTable dt = d.getDataBySort_Value("Supply_demandInfor");
            return getInforTable(dt,begin,end);
        }

        /// <summary>
        /// 获取农业科技总条数
        /// </summary>
        /// <returns></returns>
        public int getNYKJCount()
        {
            return d.getDataBySort_Value("NYKJ").Rows.Count;
        }

        /// <summary>
        /// 获取农业科技
        /// </summary>
        /// <returns></returns>
        public string getNYKJ(int begin,int end)
        {
            DataTable dt = d.getDataBySort_Value("NYKJ");
            return getInforTable(dt,begin,end);
        }

        /// <summary>
        /// 获取企业简介总条数
        /// </summary>
        /// <returns></returns>
        public int getEconomicnewsCount()
        {
            return d.getDataBySort_Value("Economicnews").Rows.Count;
        }

        /// <summary>
        /// 获取企业简介
        /// </summary>
        /// <returns></returns>
        public string getEconomicnews(int begin,int end)
        {
            DataTable dt = d.getDataBySort_Value("Economicnews");
            return getInforTable(dt,begin,end);
        }
        #endregion

        /// <summary>
        /// 获取热门新闻
        /// </summary>
        /// <returns></returns>
        public string getHotNews()
        {
            DataTable dt = d.getHotNews();
            return getInforNum(dt, "BindNewsByID.aspx");
        }

        /// <summary>
        /// 根据ID获取当前位置
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataRow getCpByID(int id)
        {
            DataTable dt = d.getNewsByID(id);
            return dt.Rows[0];
        }

        /// <summary>
        /// 根据ID获取文章信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string getInforByID(int id)
        {
            DataTable dt=d.getNewsByID(id);
            return getInforTable(dt);
        }
    }
}
