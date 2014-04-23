using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using RD.BAL;

public partial class Admin_index : System.Web.UI.Page
{
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
        if (Request.QueryString["action"] != null)
        {
            if(userType == 1||userType == 0)
            {
                if ((Request.QueryString["action"].Equals("cancel") && Request.QueryString["id"] != null))
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    B_News b = new B_News();
                    if (b.CancelNewsReading(id, 0))
                    {
                        Response.Redirect("index.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('取消失败！')</script>");
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('用户权限不足！')</script>");
            }
        }
        bindData();
    }
    private void bindData()
    {
        AspNetPager1.PageSize = 10;
        B_News b = new B_News();
        DataSet ds = b.getDataByReading();
        PagedDataSource ps = new PagedDataSource();
        ps.DataSource = ds.Tables[0].DefaultView;
        AspNetPager1.RecordCount = ps.Count;
        ps.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
        ps.AllowPaging = true;
        ps.PageSize = AspNetPager1.PageSize;
        R_Reading.DataSource = ps;
        R_Reading.DataBind();

        about.InnerHtml = b.getAbout().Tables[0].Rows[0]["News_Content"].ToString() ;
    }
}