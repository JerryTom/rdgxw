using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ApplicationErroy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //显示程序中的错误码
        if (!IsPostBack)
        {
            //显示程序中的错误码
            if (Application["erroy"] != null)
            {
                Response.Write(Application["erroy"].ToString());
            }
            else
            {
                DealErroy();
            }
        }
    }

    private void DealErroy()
    {
        HttpException erroy = new HttpException();
        string strCode = erroy.ErrorCode.ToString();
        string strMsg = erroy.Message;
        erroy.HelpLink = "sss";
        Response.Write("ErrorCode:" + strCode + "<br />");
        Response.Write("Message:" + strMsg + "<br />");
        Response.Write("HelpLink:" + erroy.HelpLink + "<br />");
        Response.Write("Source:" + erroy.Source + "<br />");
        Response.Write("TargetSite:" + erroy.TargetSite + "<br />");
        Response.Write("InnerException:" + erroy.InnerException + "<br />");
        Response.Write("StackTrace:" + erroy.StackTrace + "<br />");
        Response.Write("GetHtmlErrorMessage:" + erroy.GetHtmlErrorMessage() + "<br />");
        Response.Write("erroy.GetHttpCode().ToString():" + erroy.GetHttpCode().ToString() + "<br />");
        Response.Write("erroy.Data.ToString()::" + erroy.Data.ToString() + "<br />");
    }  
}