using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class GetIP
{
    /// <summary>
    /// 获取真实IP
    /// </summary>
    /// <remarks>获取真实IP</remarks>
    public string GetRealIP()
    {
        string ip;
        try
        {
            HttpRequest request = HttpContext.Current.Request;

            if (request.ServerVariables["HTTP_VIA"] != null)
            {
                ip = request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString().Split(',')[0].Trim();
            }
            else
            {
                ip = request.UserHostAddress;
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        return ip;
    }
}