using RD.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RD.Model;
using MX_Encrypt.web;

public partial class Admin_User_Add : System.Web.UI.Page
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
                    bindUserType();
                }
            }
            else
            {
                Response.Write("<script>window.parent.location.href='../Login.aspx';</script>");
            }
        }
    }

    /// <summary>
    /// 绑定用户类型下拉框
    /// </summary>
    private void bindUserType()
    {
        B_User b = new B_User();
        DataSet ds = b.getUserType();

        foreach (DataRow r in ds.Tables[0].Rows)
        {
            string t = r["UserType_Name"].ToString();
            string v = r["UserType_Value"].ToString();
            ListItem l = new ListItem(t, v);
            User_Type.Items.Add(l);
        }
    }
    protected void but_user_Click(object sender, EventArgs e)
    {
        string name = UserName.Value.Trim();
        string ut = User_Type.SelectedValue;
        string pwd1 = PassWord1.Value;
        string pwd2 = PassWord2.Value;
        if (Convert.ToInt32(ut) > userType||userType==0)
        {
            if (!name.Equals(string.Empty) && pwd1.Equals(pwd2))
            {
                B_User b = new B_User();
                _PassWord.Text = string.Empty;
                R_User r = new R_User();
                r.User_Name = name;
                r.User_Type = Convert.ToInt32(ut);
                r.Password = new Encrypt().Get_MD5_Method32(pwd1); ;
                r.LoginCount = 0;
                if (b.searchUser(name))
                {
                    _UserName.Text = string.Empty;
                    if (b.addUser(r))
                    {
                        Response.Redirect("User.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('添加失败')</script>");
                    }
                }
                else
                {
                    _UserName.Text = "用户名已存在";
                }
            }
            else if (!pwd1.Equals(pwd2))
            {
                _PassWord.Text = "两次输入密码不一致";
            }
        }
        else
        {
            Response.Write("<script>alert('用户权限不足不能添加！')</script>");
        }
    }
}