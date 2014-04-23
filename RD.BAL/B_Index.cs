using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RD.DAL;
using System.Data;
using System.Collections;
using RD.Model;

namespace RD.BAL
{
    public class B_Index : B_Main
    {
        D_Index di = new D_Index();

        #region 首页上的信息展示
        /// <summary>
        /// 获取友情链接信息
        /// </summary>
        /// <returns></returns>
        public string getLinks()
        {
            DataTable dt = di.getLinks();
            int n = dt.Rows.Count;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append("<a href='")
                .Append(dt.Rows[i]["Links_Url"])
                .Append("' title='")
                .Append(dt.Rows[i]["Links_Name"])
                .Append("' target='_blank'>")
                .Append(dt.Rows[i]["Links_Name"])
                .Append("</a><br />");
            }
            return sb.ToString();
        }


        /// <summary>
        /// 获取最新要闻信息
        /// </summary>
        /// <returns></returns>
        public string getLatestnews()
        {
            DataTable dt = di.getNews();
            return getInforNum(dt, "web/BindNewsByID.aspx");
        }

        /// <summary>
        /// 获取热门新闻
        /// </summary>
        /// <returns></returns>
        public string getHotNews()
        {
            DataTable dt = di.getHotNews();
            return getInforNum(dt, "web/BindNewsByID.aspx");
        }

        /// <summary>
        /// 获取政策法规
        /// </summary>
        /// <returns></returns>
        public string getPolicyLaws()
        {
            DataTable dt = di.getDataBySort_Value("PolicyLaws");
            return getInfor(dt, "web/BindNewsByID.aspx");
        }

        /// <summary>
        /// 获取市场动态
        /// </summary>
        /// <returns></returns>
        public string getMarknews()
        {
            DataTable dt = di.getDataBySort_Value("Marknews");
            return getInfor(dt, "web/BindNewsByID.aspx");
        }

        /// <summary>
        /// 获取特色产品
        /// </summary>
        /// <returns></returns>
        public string getAgricultTech()
        {
            DataTable dt = di.getDataBySort_Value("AgricultTech");
            return getInfor(dt, "web/BindNewsByID.aspx");
        }

        /// <summary>
        /// 获取供求信息
        /// </summary>
        /// <returns></returns>
        public string getSupply_demandInfor()
        {
            DataTable dt = di.getDataBySort_Value("Supply_demandInfor");
            return getInfor(dt, "web/BindNewsByID.aspx");
        }

        /// <summary>
        /// 获取农业科技
        /// </summary>
        /// <returns></returns>
        public string getNYKJ()
        {
            DataTable dt = di.getDataBySort_Value("NYKJ");
            return getInfor(dt, "web/BindNewsByID.aspx");
        }

        /// <summary>
        /// 获取企业简介
        /// </summary>
        /// <returns></returns>
        public string getEconomicnews()
        {
            DataTable dt = di.getDataBySort_Value("Economicnews");
            return getInfor(dt, "web/BindNewsByID.aspx");
        }

        /// <summary>
        /// 获取推荐阅读
        /// </summary>
        /// <returns></returns>
        public string getDataByReading()
        {
            DataTable dt = di.getDataByReading();
            StringBuilder sb = new StringBuilder();
            string url = "web/BindNewsByID.aspx";
            int max = dt.Rows.Count > 5 ? 5 : dt.Rows.Count;
            for (int i = 0; i < 5; i++)
            {
                if (i < max)
                {
                    sb.Append("<li>")
                        .Append("<a href='" + url + "?id=")
                        .Append(dt.Rows[i]["ID"])
                        .Append("' title='")
                        .Append(dt.Rows[i]["News_Tital"])
                        .Append("' target='_blank'>")
                        .Append(dt.Rows[i]["News_Tital"])
                        .Append("</a></li>");
                }
                else
                {
                    sb.Append("<li></li>");
                }
            }
            return sb.ToString();
        }



        /// <summary>
        /// 获取滚动图片
        /// </summary>
        /// <returns></returns>
        public string getDataByImg()
        {
            DataTable dt = di.getDataByImg();
            StringBuilder sb = new StringBuilder();
            int max = dt.Rows.Count >= 5 ? 5 : dt.Rows.Count;
            for (int i = 0; i < max; i++)
            {
                sb.Append("<a href='web/BindNewsByID.aspx?id=" + dt.Rows[i]["ID"] + "' title='")
                    .Append(dt.Rows[i]["News_Tital"])
                    .Append("' target='_blank' ><img src='")
                    .Append(dt.Rows[i]["News_Images"])
                    .Append("'></a>");
            }
            return sb.ToString();
        }

        /// <summary>
        /// 滚动图片按钮
        /// </summary>
        /// <returns></returns>
        public string getIcoBox()
        {
            DataTable dt = di.getDataByImg();
            StringBuilder sb = new StringBuilder();
            int max = dt.Rows.Count >= 5 ? 5 : dt.Rows.Count;
            sb.Append("<span class='active' rel='1'>1</span>");
            for (int i = 2; i <= max; i++)
            {
                sb.Append("<span rel='"+i+"'>"+i+"</span>");
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获取产品展示
        /// </summary>
        /// <returns></returns>
        public string getImgList()
        {
            DataTable dt = di.getDataByImg();
            StringBuilder sb = new StringBuilder();
            int max = dt.Rows.Count >= 5 ? 5 : dt.Rows.Count;
            sb.Append("<table style='float:left; border:0;'><tr><td>&nbsp;</td>");
            for (int i = 0; i < max; i++)
            {
                sb.Append("<td><table style='float:left; border:0;'><tr><td><img src='")
                    .Append(dt.Rows[i]["News_Images"])
                    .Append("' style='width:145px; height:110px;' /></td></tr> <tr> <td style='text-align:center;height:20px; vertical-align:bottom'> ")
                    .Append(dt.Rows[i]["News_Tital"])
                    .Append("</td></tr></table></td>");
            }
            sb.Append("</tr></table>");
            return sb.ToString();
        }
        #endregion

        /// <summary>
        /// 查询文章今天是否访问过
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public bool[] searchRead(R_Read r)
        {
            bool[] a = new bool[2];
            DataTable dt = di.searchRead(r).Tables[0];
            if (dt.Rows.Count == 0)
            {
              a[0] = addRead(r);
            }
            else
            {
                if(!dt.Rows[0]["Read_Time"].Equals(DateTime.Now.Date))
                {
                    r.Read_Count = (Convert.ToInt32(dt.Rows[0]["Read_Count"]) + 1).ToString();
                   a[1] = updateRead(r);
                }
            }
            return a;
        }

        /// <summary>
        /// 更新访问量
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public bool updateRead(R_Read r)
        {
            return di.updateRead(r) == 1 ? true : false;
        }

        /// <summary>
        /// 添加访问量
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public bool addRead(R_Read r)
        {
            return di.addRead(r) == 1 ? true : false;
        }

    }
}
