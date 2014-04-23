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

public partial class Admin_User_editPwd : System.Web.UI.Page
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
                id = Convert.ToInt32(Request.QueryString["id"]);
                bindUserByID(id);
            }
        }
        bindUserType();
    }

    /// <summary>
    /// 根据ID绑定要修改的数据
    /// </summary>
    /// <param name="id"></param>
    private void bindUserByID(int id)
    {
        B_User b = new B_User();
        DataTable dt = b.getUserByID(id);
        UserName.Value = dt.Rows[0]["User_Name"].ToString();
        UserName.Disabled = true;
        User_Type.SelectedValue = dt.Rows[0]["User_Type"].ToString();
        User_Type.Enabled = false;
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
        string pwd = new Encrypt().Get_MD5_Method32(PassWord.Value);
        string pwd1 = PassWord1.Value;
        string pwd2 = PassWord2.Value;
        if (Convert.ToInt32(ut) > userType || userType == 0|| name.Equals(Request.Cookies["user"]["UserName"]))
        {
            if (!name.Equals(string.Empty) && pwd1.Equals(pwd2))
            {
                _PassWord.Visible = true;
                B_User b = new B_User();
                DataTable dt = b.getUserByID(id);

                if (pwd.Equals(dt.Rows[0]["Password"]))
                {
                    _oldPwd.Visible = true;
                    if (action.Equals("edit"))
                    {
                        R_User r = new R_User();
                        r.ID = id;
                        r.Password = new Encrypt().Get_MD5_Method32(pwd1);
                        if (b.editUser(r))
                        {
                            Response.Redirect("User.aspx");
                        }
                        else
                        {
                            Response.Write("<script>alert('修改失败')</script>");
                        }
                    }
                }
                else
                {
                    _oldPwd.Visible = false;
                }
            }
            else if (!pwd1.Equals(pwd2))
            {
                _PassWord.Visible = false;
            }
        }
        else
        {
            Response.Write("<script>alert('用户权限不足，不能修改！')</script>");
        }
    }
}