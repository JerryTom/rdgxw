using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using RD.BAL;
using RD.Model;
public partial class Admin_News_AddNews : System.Web.UI.Page
{
    static string action = string.Empty;
    static int id = 0;
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
        action = string.Empty;
        getSort();
        if (Request.QueryString["action"] != null)
        {
            action = Request.QueryString["action"];
            if (action.Equals("edit") && Request.QueryString["id"] != null)
            {
                but_News.Text = "修  改";
                // but_Sort.Visible = false;
                id = Convert.ToInt32(Request.QueryString["id"]);
                getDataByID(id);
            }
        }
    }

    /// <summary>
    ///  获取新闻分类
    /// </summary>
    private void getSort()
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

    /// <summary>
    /// 根据ID获取数据
    /// </summary>
    /// <param name="id"></param>
    private void getDataByID(int id)
    {
        B_News b = new B_News();
        DataTable dt = b.getNewsByID(id).Tables[0];
        NewsTitle.Text = dt.Rows[0]["News_Tital"].ToString();
        News_Sort.Enabled = false;
        reading.Checked = Convert.ToBoolean(Convert.IsDBNull(dt.Rows[0]["News_Reading"]) == false ? dt.Rows[0]["News_Reading"] : 0);
        imageCheck.Checked = Convert.ToBoolean(Convert.IsDBNull(dt.Rows[0]["News_ImageBool"]) == false ? dt.Rows[0]["News_ImageBool"] : 0);
        Img_Url.Value = dt.Rows[0]["News_Images"].ToString();
        News_Sort.SelectedValue = dt.Rows[0]["Sort_ID"].ToString();
        NewsContent.Value = dt.Rows[0]["News_Content"].ToString();
    }
    protected void but_News_Click(object sender, EventArgs e)
    {
        if (News_Sort.SelectedIndex != 0 && NewsContent.Value.Length>1)
        {
            _News_Sort.Visible = false;
            if (action.Equals("edit"))
            {
                editNews();
            }
            else
            {
                AddNews();
            }
        }
        else
        {
            _News_Sort.Visible = true;
        }
    }

    private void editNews()
    {
        R_News r = new R_News();
        r.News_Tital = NewsTitle.Text.Trim();
        r.Sort_ID = Convert.ToInt32(News_Sort.SelectedValue);
        r.News_Content = NewsContent.Value;
        r.User_ID = Convert.ToInt32(Request.Cookies["user"]["ID"]);
        r.ID = id;
        r.News_Reading = reading.Checked == true ? 1 : 0;
        r.News_ImageBool = imageCheck.Checked == true ? 1 : 0;
        r.News_Images = imageCheck.Checked == true ? Img_Url.Value.Trim() : "";
        B_News b = new B_News();
        if (b.editNews(r))
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            ll_ts.Text = "修改失败！";
        }
    }

    private void AddNews()
    {
        R_News r = new R_News();
        r.News_Tital = NewsTitle.Text.Trim();
        r.Sort_ID = Convert.ToInt32(News_Sort.SelectedValue);
        r.News_Content = NewsContent.Value;
        r.User_ID = Convert.ToInt32(Request.Cookies["user"]["ID"]);
        r.News_Reading = reading.Checked == true ? 1 : 0;
        r.News_ImageBool = imageCheck.Checked == true ? 1 : 0;
        r.News_Images = imageCheck.Checked == true ? Img_Url.Value.Trim() : "";
        B_News b = new B_News();
        if (b.addNews(r))
        {
            NewsTitle.Text = "";
            Img_Url.Value = "";
            News_Sort.SelectedIndex = 0;
            NewsContent.Value = "";
            ll_ts.Text = "添加成功！";
            //Response.Redirect("Default.aspx");
        }
        else
        {
            ll_ts.Text = "添加失败！";
        }
    }
}