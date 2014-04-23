<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BindNewsByID.aspx.cs" Inherits="web_BindNewsByID" %>
<%@ OutputCache Duration="60" VaryByParam="*" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>如东县农副产品信息网</title>
    <link href="../include/css/inforStyle.css" rel="stylesheet" />
    <script type="text/javascript">
        window.onscroll = function () {
            var t = document.documentElement.scrollTop || document.body.scrollTop;
            var guide = document.getElementById("guide").style;
            if (t >= 45) {
                guide.position = "fixed";
            } else {
                guide.position = "absolute";
            }
        }
    </script>
</head>
<body>
<form runat="server" id="from1">
    <div id="guide">
        <div class="guide_menu">
            <ul class="guide_ul">
                <li><a href="../Default.aspx" target="_self">首页</a></li>
                <li><a href="Latestnews.aspx" target="_self">最新要闻</a></li>
                <li><a href="PolicyLaws.aspx" target="_self">政策法规</a></li>
                <li><a href="Marknews.aspx" target="_self">市场动态</a></li>
                <li><a href="AgricultTech.aspx" target="_self">特色产品</a></li>
                <li><a href="Supply_demandInfor.aspx" target="_self">供求信息</a></li>
                <li><a href="NYKJ.aspx" target="_self">农业科技</a></li>
                <li><a href="Economicnews.aspx" target="_self">企业简介</a></li>
                <li><a href="About.aspx" target="_self" style="border-right-width:0;">关于本站</a></li>
            </ul>
        </div>
    </div>
    <div id="top_menu">
        <div class="menu_div">
            <embed name="wmode" value="opaque" wmode=opaque src="../include/images/banner.swf" type="application/x-shockwave-flash" width="960" height="144" />

            <div class="mainNews">
                <p class="cp">当前位置：
                    <a href="../Default.aspx" target="_self">如东县农副产品信息网</a>
                    &nbsp;&gt;&gt;&nbsp;
                    <asp:HyperLink ID="thisCP" runat="server" NavigateUrl="~/web/Latestnews.aspx">最新要闻</asp:HyperLink>
                </p>
                <div runat="server" style="width:780px;" id="dataTableByID">
                    <table id="dgNews" runat="server">
                        <tr><th></th></tr>
                        <tr><td style="padding-bottom:30px;">&nbsp;&nbsp;更新时间：<span id="Timelbl">2013-11-14 0:00:00</span>
                &nbsp;&nbsp;发布人：<span id="UserName">admin</span></td></tr>
                        <tr><td class="td_text">
                            
                            </td></tr>
                    </table>
                </div>
                <div class="bottomMenu">
                    【<a href="javascript:window.print();">打印本页</a>】
                    【<a href="javascript:window.close();">关闭窗口</a>】
                </div>
            </div>


            <div id="webInfor" runat="server">
                        如东县供销合作社主办 地址：如东县掘港镇江海东路17号<br />
                        版权所有 如东县供销社信息服务中心<br />
                        Tel:0513-84512258 0513-84512541 Fax:0513-84512128
            </div>
        </div>
    </div>
</form>
</body>
</html>
