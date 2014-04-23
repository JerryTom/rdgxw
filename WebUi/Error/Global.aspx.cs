using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Global : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //这是添加了一个全局应用程序类 在Application_Error事件中处理错误页面 和web.config没有关系 即使没有web.config 也是可以定位到错误页面
    void Application_Error(object sender, EventArgs e)
    {
        //在出现未处理的错误时运行的代码
        Exception erroy = Server.GetLastError();
        string err = "出错页面是：" + Request.Url.ToString() + "</br>";
        err += "异常信息：" + erroy.Message + "</br>";
        err += "Source:" + erroy.Source + "</br>";
        err += "StackTrace:" + erroy.StackTrace + "</br>";
        //清除前一个异常
        Server.ClearError();

        //此处理用Session["ProError"]出错。所以用 Application["ProError"]
        Application["erroy"] = err;
        //此处不是page中，不能用Response.Redirect("../frmSysError.aspx");
        System.Web.HttpContext.Current.Response.Redirect(HttpContext.Current.Request.ApplicationPath + "/ApplicationErroy.aspx");

    }
}