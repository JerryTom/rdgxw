using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using RD.BAL;

public partial class Admin_News_Default : System.Web.UI.Page
{
    static int userType = 2;
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
        if (Request.QueryString["action"] != null )
        {
            if (userType == 0 || userType == 1)
            {
                if (Request.QueryString["id"] != null)
                {
                    B_News b = new B_News();
                    if (b.deleteByNewsID(Convert.ToInt32(Request.QueryString["id"])))
                    {
                        Response.Redirect("Default.aspx");
                    }
                    else
                    {
                        Response.Write("<sciput>alert('删除失败')</sciput>");
                    }
                }

                //if (Request.QueryString["action"].Equals("deleteIDs") && Request.QueryString["ids"] != null)
                //{
                //    B_News b = new B_News();
                //    string[] ids=Request.QueryString["ids"].Split(',');
                //    int count = 0;
                //    foreach (string id in ids)
                //    {
                //        if (b.deleteByNewsID(Convert.ToInt32(id)))
                //        {
                //            count++;
                //        }
                //        else
                //        {

                //        }
                //    }
                //    Response.Write(count);
                //}
            }
            else
            {
                Response.Write("<script>alert('用户权限不足，不能删除！')</script>");
            }
        }
        bindNews_Sort();
        bindNewsData();
    }


    private void bindNews_Sort()
    {
        B_News b = new B_News();

        //绑定文章分类列表数据
        DataSet ds = b.getNews_Sort();

        foreach (DataRow r in ds.Tables[0].Rows)
        {
            string t = r["Sort_Name"].ToString();
            string v = r["ID"].ToString();
            ListItem l = new ListItem(t, v);//初始化ListItem的值
            News_Sort.Items.Add(l);
        }
    }

    private void bindNewsData()
    {
        AspNetPager1.PageSize = Convert.ToInt32(page_rows.SelectedValue);
        B_News b = new B_News();
        //绑定文章表格数据
        DataSet ds = b.getNewsData();
        PagedDataSource ps = new PagedDataSource();
        ps.DataSource = ds.Tables[0].DefaultView;
        AspNetPager1.RecordCount = ps.Count;
        ps.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
        ps.AllowPaging = true;
        ps.PageSize = AspNetPager1.PageSize;
        R_News.DataSource = ps;
        R_News.DataBind();
    }

    private void bindNewsDataBySortID()
    {
        int sid = Convert.ToInt32(News_Sort.SelectedValue);
        B_News b = new B_News();
        //绑定文章表格数据
        DataSet ds = b.getDataBySort_ID(sid);
        PagedDataSource ps = new PagedDataSource();
        ps.DataSource = ds.Tables[0].DefaultView;
        AspNetPager1.RecordCount = ps.Count;
        ps.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
        ps.AllowPaging = true;
        ps.PageSize = AspNetPager1.PageSize;
        R_News.DataSource = ps;
        R_News.DataBind();
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        if (News_Sort.SelectedValue.Equals(""))
        {
            bindNewsData();
        }
        else
        {
            bindNewsDataBySortID();
        }
    }
    protected void News_Sort_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (News_Sort.SelectedValue.Equals("")) 
        {
            bindNewsData();
        }
        else
        {
            bindNewsDataBySortID();
        }
    }
    protected void page_rows_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (News_Sort.SelectedValue.Equals(""))
        {
            bindNewsData();
        }
        else
        {
            AspNetPager1.PageSize = Convert.ToInt32(page_rows.SelectedValue);
            bindNewsDataBySortID();
        }
    }
}