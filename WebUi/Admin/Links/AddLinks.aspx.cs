using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RD.BAL;
using System.Data;
using RD.Model;

public partial class Admin_Links_AddLinks : System.Web.UI.Page
{
    static string action = string.Empty;
    static int id = 0;
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
            action = Request.QueryString["action"];
            if (action.Equals("edit") && Request.QueryString["id"] != null)
            {
                but_Links.Text = "修  改";
                // but_Sort.Visible = false;
                id = Convert.ToInt32(Request.QueryString["id"]);
                getDataByID(id);
            }
        }
    }


    private void getDataByID(int id)
    {
        B_Links b = new B_Links();
        DataTable dt = b.selLinksByID(id);
        Links_Name.Text = dt.Rows[0]["Links_Name"].ToString() ;
        Links_Url.Text = dt.Rows[0]["Links_Url"].ToString();
    }
    protected void but_Links_Click(object sender, EventArgs e)
    {
        R_Links r = new R_Links();
        r.User_ID = Convert.ToInt32(Request.Cookies["user"]["ID"]);
        r.Links_Name = Links_Name.Text.Trim();
        r.Links_Url = Links_Url.Text.Trim();
        if (action.Equals("edit"))
        {
            editLinks(r);
        }
        else
        {
            AddLinks(r);
        }
    }

    private void editLinks(R_Links r)
    {
        B_Links b = new B_Links();
        r.ID = id;
        _Links_Name.Text = "";
        if (b.editLinks(r))
        {
            Response.Redirect("Links.aspx");
        }
        else
        {
            ll_ts.Text = "修改失败";
        }
        
    }

    private void AddLinks(R_Links r)
    {
        B_Links b = new B_Links();
        _Links_Name.Text = "";
        if (b.addLinks(r))
        {
            Response.Redirect("Links.aspx");
        }
        else
        {
            ll_ts.Text = "添加失败！";
        }
    }
}