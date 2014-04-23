<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AgricultTech.aspx.cs" Inherits="web_AgricultTech" %>
<%@ OutputCache Duration="60" VaryByParam="*" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>如东县农副产品信息网|特色产品</title>
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

            <div class="main">
                <div class="main_dg" runat="server" id="dataTable">
                    <table id="dg" runat="server">
                        <tr><th colspan="2">特色产品</th></tr>
                    </table>
                </div>
                    <webdiyer:AspNetPager ID="dgPager" runat="server" AlwaysShow="True" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" ShowMoreButtons="False" OnPageChanged="dgPager_PageChanged"></webdiyer:AspNetPager>
            </div>

                <div class="hotMod" style="right:-5px; top:160px;">
                    <p class="tital">热门信息</p>
                    <ul id="hotNews" runat="server">
                    </ul>
                </div>

                <div class="InforMod" style="right:-5px; top:460px;">
                    <p class="tital">信息检索</p>
                    <div>
                        <script>
                            (function () {
                                var cx = '007967169358405356312:cerpvuel_ua';
                                var gcse = document.createElement('script');
                                gcse.type = 'text/javascript';
                                gcse.async = true;
                                gcse.src = (document.location.protocol == 'https:' ? 'https:' : 'http:') +
                                    '//www.google.com/cse/cse.js?cx=' + cx;
                                var s = document.getElementsByTagName('script')[0];
                                s.parentNode.insertBefore(gcse, s);
                            })();
                        </script>
                        <gcse:search></gcse:search>
                    </div>
                </div>

                <div class="LinksMod" style="right:-5px; top:570px;">
                    <p class="tital">友情链接</p>
                    <div id="Links" runat="server">
                    </div>
                </div>

            <div id="webInfor" runat="server" style="top:750px; left:5px;">
                        如东县供销合作社主办 地址：如东县掘港镇江海东路17号<br />
                        版权所有 如东县供销社信息服务中心<br />
                        Tel:0513-84512258 0513-84512541 Fax:0513-84512128
            </div>
        </div>
    </div>
</form>
</body>
</html>

