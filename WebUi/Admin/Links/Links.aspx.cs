using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using RD.BAL;
using RD.Model;

public partial class Admin_Links_Links : System.Web.UI.Page
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
                Response.Write("<script>window.parent.location.href='../Login.aspx';</script>");
            }
        }
    }

    private void pageLode()
    {
        if (Request.QueryString["action"] != null)
        {
            if ((userType == 0 || userType == 1))
            {
                if (Request.QueryString["action"].Equals("delete") && Request.QueryString["id"] != null)
                {
                    B_Links b = new B_Links();
                    if (b.deleteByLinksID(Convert.ToInt32(Request.QueryString["id"])))
                    {
                        Response.Redirect("Links.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('删除失败')</script>");
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('权限不足不能删除！')</script>");
            }
        }
        bindUserData();
    }

    private void bindUserData()
    {
        AspNetPager1.PageSize = Convert.ToInt32(page_rows.SelectedValue);
        B_Links b = new B_Links();
        DataSet ds = b.getLinks();
        PagedDataSource ps = new PagedDataSource();
        ps.DataSource = ds.Tables[0].DefaultView;
        AspNetPager1.RecordCount = ps.Count;
        ps.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
        ps.AllowPaging = true;
        ps.PageSize = AspNetPager1.PageSize;
        R_User.DataSource = ps;
        R_User.DataBind();
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        bindUserData();
    }
    protected void page_rows_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindUserData();
    }
}