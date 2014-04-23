using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RD.BAL;

public partial class web_About : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindData();
        }
    }

    private void bindData()
    {
        B_News bn = new B_News();
        about.InnerHtml = bn.getAbout().Tables[0].Rows[0]["News_Content"].ToString();
        webInfor.InnerHtml = bn.getWebInfor().Tables[0].Rows[0]["News_Content"].ToString();
    }
}