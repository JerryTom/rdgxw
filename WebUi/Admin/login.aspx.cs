using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RD.BAL;
using System.Data;
using MX_Encrypt.web;

public partial class MX_Web_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Request.Cookies["user"] != null)
            {
                if (Request.Cookies["user"]["UserName"] != null && Request.Cookies["user"]["ID"] != null && Request.Cookies["user"]["UserType"] != null)
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }
    }
    protected void but_login_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["CheckCode"] != null)
        {
            if (vdcode.Value.ToUpper().Equals(Request.Cookies["CheckCode"].Value.ToUpper()))
            {
                string user = userid.Text.Trim();
                string password = new Encrypt().Get_MD5_Method32(pwd.Text.Trim());
                B_User b = new B_User();
                DataTable dt = b.selUser(user);
                if (dt.Rows.Count == 1)
                {
                    DataRow dr = dt.Rows[0];
                    if (dr["Password"].Equals(password))
                    {
                        int id = Convert.ToInt32(dr["ID"].ToString());
                        if (b.updatalogin(id))
                        {
                            string usertype = dr["User_Type"].ToString();
                            Response.Cookies["user"]["ID"] = id.ToString();
                            Response.Cookies["user"]["UserName"] = System.Web.HttpContext.Current.Server.UrlEncode(user);
                            Response.Cookies["user"]["UserType"] = usertype;
                            Response.Redirect("Default.aspx");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('密码不正确!')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('用户名不正确!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('验证码输入不正确!')</script>");
            }
        }
    }
}