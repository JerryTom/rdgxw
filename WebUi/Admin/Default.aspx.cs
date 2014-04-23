using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminManage_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Request.Cookies["user"] != null)
            {
                if (Request.Cookies["user"]["UserName"] != null && Request.Cookies["user"]["ID"] != null && Request.Cookies["user"]["UserType"] != null)
                {
                    this.username.InnerText = System.Web.HttpContext.Current.Server.UrlDecode(Request.Cookies["user"]["UserName"]);
                }
            }
            else
            {
                Response.Write("<script>window.parent.location.href='Login.aspx';</script>");
            }
        }
    }
    protected void Login_Out_Click(object sender, EventArgs e)
    {
        Response.Cookies["user"].Expires = DateTime.Now;
        Response.Write("<script>window.parent.location.href='Login_out.aspx';</script>");
    }
}