using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RD.BAL;
using System.Data;
using RD.Model;

public partial class Admin_Site : System.Web.UI.Page
{
    static int userType = 3;
    static int id = 152;
    static string NewsTitle = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.Cookies["user"] != null)
            {
                if (Request.Cookies["user"]["UserName"] != null && Request.Cookies["user"]["ID"] != null && Request.Cookies["user"]["UserType"] != null)
                {
                    userType = Convert.ToInt32(Request.Cookies["user"]["UserType"]);
                    pageLode();
                }
            }
            else
            {
                Response.Write("<script>window.parent.location.href='Login.aspx';</script>");
            }
        }
    }

    private void pageLode()
    {
        B_News b = new B_News();
        DataTable dt = b.getNewsByID(id).Tables[0];
        NewsTitle = dt.Rows[0]["News_Tital"].ToString();
        SiteContent.Value = dt.Rows[0]["News_Content"].ToString();
    }
    protected void but_user_Click(object sender, EventArgs e)
    {
        if (userType == 0 || userType == 1)
        {
            if (SiteContent.Value.Length > 1)
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
        r.News_Tital = NewsTitle;
        r.Sort_ID = 8;
        r.News_Content = SiteContent.Value;
        r.User_ID = Convert.ToInt32(Request.Cookies["user"]["ID"]);
        r.ID = id;
        r.News_Reading = 0;
        r.News_ImageBool = 0;
        r.News_Images = "";
        B_News b = new B_News();
        if (b.editNews(r))
        {
            Response.Write("<script>alert('更新成功')</script>");
        }
        else
        {
            ll_ts.Text = "修改失败！";
        }
    }
}