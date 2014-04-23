using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RD.DAL;
using System.Data;

namespace RD.BAL
{
    public class B_Main
    {
        #region 获取信息字符串
        /// <summary>
        /// 获取信息有左边编号
        /// </summary>
        /// <param name="dt">数据表</param>
        /// <returns>字符串</returns>
        public string getInforNum(DataTable dt,string url)
        {
            StringBuilder sb = new StringBuilder();
            int max = dt.Rows.Count > 10 ? 10 : dt.Rows.Count;
            for (int i = 0; i < 10; i++)
            {
                if (i < max)
                {
                    sb.Append("<li>")
                        .Append("<span>" + (i + 1) + ".</span>")
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
                    sb.Append("<li><span>" + (i + 1) + ".</span></li>");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获取信息无编号
        /// </summary>
        /// <param name="dt">数据表</param>
        /// <returns>字符串</returns>
        public string getInfor(DataTable dt, string url)
        {
            StringBuilder sb = new StringBuilder();
            int max = dt.Rows.Count > 7 ? 7 : dt.Rows.Count;
            for (int i = 0; i < max; i++)
            {
                if (i < max)
                {
                    sb.Append("<li>")
                        .Append("<a href='"+url+"?id=")
                        .Append(dt.Rows[i]["ID"])
                        .Append("' title='")
                        .Append(dt.Rows[i]["News_Tital"])
                        .Append("' target='_blank'>")
                        .Append(dt.Rows[i]["News_Tital"])
                        .Append("</a><span>" + Convert.ToDateTime(dt.Rows[i]["News_AddTime"]).ToShortDateString() + "</span></li>");
                }
                else
                {
                    sb.Append("<li></li>");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获取文章列表展示数据
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public string getInforTable(DataTable dt,int begin, int end)
        {
            StringBuilder sb = new StringBuilder();
            int max = dt.Rows.Count;
            sb.Append("<table id='dg'><tr><th colspan='2'>" + dt.Rows[0]["Sort_Name"] + "</th></tr>");
            for (int i = (begin-1); i < end; i++)
            {
                if (i < max)
                {
                    sb.Append("<tr><td class='leftStyle'>")
                        .Append("<a href='BindNewsByID.aspx?id=")
                        .Append(dt.Rows[i]["ID"])
                        .Append("' title='")
                        .Append(dt.Rows[i]["News_Tital"])
                        .Append("' target='_blank'>")
                        .Append(dt.Rows[i]["News_Tital"])
                        .Append("</a></td> <td class='rightStyle'>")
                        .Append(Convert.ToDateTime(dt.Rows[i]["News_AddTime"]).ToShortDateString())
                        .Append("</td></tr>");
                }
                else
                {
                    sb.Append("<tr><td class='leftStyle'><td class='rightStyle'></td></tr>");
                }
            }
            sb.Append("</table>");
            return sb.ToString();
        }

        public string getInforTable(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            int max = dt.Rows.Count;
            sb.Append(" <table id='dgNews' style='max-width:780px'><tr><th>" + dt.Rows[0]["News_Tital"] + "</th></tr>")
            .Append("<tr><td style='padding-bottom:30px;'>&nbsp;&nbsp;更新时间：" + dt.Rows[0]["News_AddTime"])
            .Append("&nbsp;&nbsp;发布人："+dt.Rows[0]["User_Name"])
            .Append("</span></td></tr><tr><td class='td_text'>")
            .Append(dt.Rows[0]["News_Content"])
            .Append("</td></tr>")
            .Append("</table>");
            return sb.ToString();
        }
        #endregion


    }
}
