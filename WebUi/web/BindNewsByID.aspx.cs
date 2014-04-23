using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RD.BAL;
using RD.Model;

public partial class web_BindNewsByID : System.Web.UI.Page
{
    static int id = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                id = Convert.ToInt32(Request.QueryString["id"]);
                bindData();
            }
        }
    }

    private void bindData()
    {
        B_InforData bf=new B_InforData();
        thisCP.NavigateUrl = bf.getCpByID(id)["Sort_Value"].ToString() + ".aspx";
        thisCP.Text = bf.getCpByID(id)["Sort_Name"].ToString();
        dataTableByID.InnerHtml = bf.getInforByID(id);
        GetIP g = new GetIP();
        R_Read r = new R_Read();
        r.News_ID = id;
        r.Read_IP = g.GetRealIP();
        r.Read_Time = DateTime.Now.Date;
        B_News bn = new B_News();
        webInfor.InnerHtml = bn.getWebInfor().Tables[0].Rows[0]["News_Content"].ToString();
        B_Index bi=new B_Index();
        try
        {
            bi.searchRead(r);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}