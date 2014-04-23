using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using RD.BAL;
using RD.Model;
public partial class Admin_News_editAbout : System.Web.UI.Page
{
    static int id = 149;
    static int userType = 3;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.Cookies["user"] != null)
            {
                if (Request.Cookies["user"]["UserName"] != null && Request.Cookies["user"]["ID"] != null && Request.Cookies["user"]["UserType"] != null)
                {
                    userType = Convert.ToInt32(Request.Cookies["user"]["UserType"]);
                    getDataByID(id);
                }
            }
            else
            {
                Response.Write("<script>window.parent.location.href='../Login.aspx';</script>");
            }
        }
    }


    /// <summary>
    /// 根据ID获取数据
    /// </summary>
    /// <param name="id"></param>
    private void getDataByID(int id)
    {
        B_News b = new B_News();
        DataTable dt = b.getNewsByID(id).Tables[0];
        NewsTitle.Text = dt.Rows[0]["News_Tital"].ToString();
        NewsContent.Value = dt.Rows[0]["News_Content"].ToString();
    }
    protected void but_News_Click(object sender, EventArgs e)
    {
        if (userType == 0||userType==1)
        {
            if (NewsContent.Value.Length > 1)
            {
                editNews();
            }
        }
        else
        {
            Response.Write("<script>alert('用户权限不足，不能编辑！')</script>");
        }
    }

    private void editNews()
    {
        R_News r = new R_News();
        r.News_Tital = NewsTitle.Text.Trim();
        r.Sort_ID = 8;
        r.News_Content = NewsContent.Value;
        r.User_ID = Convert.ToInt32(Request.Cookies["user"]["ID"]);
        r.ID = id;
        r.News_Reading = 0;
        r.News_ImageBool = 0;
        r.News_Images = "";
        B_News b = new B_News();
        if (b.editNews(r))
        {
            Response.Redirect("../index.aspx");
        }
        else
        {
            ll_ts.Text = "修改失败！";
        }
    }
}