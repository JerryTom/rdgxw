<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>如东县农副产品信息网</title>
    <link href="\include/css/index.css" rel="stylesheet" />
    <link href="\include/css/imageStyle.css" rel="stylesheet" />
    <script src="\include/js/jquery-2.1.0.min.js"></script>
    <script src="\include/js/imageChange.js"></script>
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
    <div id="guide">
        <div class="guide_menu">
            <ul class="guide_ul">
                <li><a href="\Default.aspx" target="_self">首页</a></li>
                <li><a href="\web/Latestnews.aspx" target="_self">最新要闻</a></li>
                <li><a href="\web/PolicyLaws.aspx" target="_self">政策法规</a></li>
                <li><a href="\web/Marknews.aspx" target="_self">市场动态</a></li>
                <li><a href="\web/AgricultTech.aspx" target="_self">特色产品</a></li>
                <li><a href="\web/Supply_demandInfor.aspx" target="_self">供求信息</a></li>
                <li><a href="\web/NYKJ.aspx" target="_self">农业科技</a></li>
                <li><a href="\web/Economicnews.aspx" target="_self">企业简介</a></li>
                <li><a href="\web/About.aspx" target="_self" style="border-right-width:0;">关于本站</a></li>
            </ul>
        </div>
    </div>
    <div id="top_menu">
        <div class="menu_div">
            <embed wmode="opaque" src="include/images/banner.swf" type="application/x-shockwave-flash" name="mymovie" align="middle" allowScriptAccess="sameDomain"  width="960" height="144" pluginspage="http://www.macromedia.com/go/getflashplayer" />

            <div class="mainMod">

                    <div id="scrollobj" onmouseover="_stop()" onmouseout="_start()" >
                        <a href="javaScript:void[0]" target="_self" style="color:#0026ff" title="如东县农副产品信息网">欢迎来到如东县农副产品信息网</a>
                    </div>
                <script type="text/javascript">
                    function scroll(obj) {
                        var tmp = (obj.scrollLeft)++;
                        //当滚动条到达右边顶端时
                        if (obj.scrollLeft == tmp) obj.innerHTML += obj.innerHTML;
                        //当滚动条滚动了初始内容的宽度时滚动条回到最左端
                        if (obj.scrollLeft >= obj.firstChild.offsetWidth) obj.scrollLeft = 0;
                    }
                    var a = setInterval("scroll(document.getElementById('scrollobj'))", 20);
                    function _stop(id) {
                        clearInterval(a);
                    }
                    function _start() {
                        a = setInterval("scroll(document.getElementById('scrollobj'))", 20);
                    }
                </script>

            <div class="imageRotation">
                <div id="imageBox" runat="server" class="imageBox">
                </div>
                <div class="icoBox" id="icoBox" runat="server">
                </div>
            </div>

                <div id="tjNews" style="left:325px; top:28px;">
                    <span class="tjTital">推荐阅读</span>
                    <ul id="Reading" runat="server">
                        
                    </ul>
                </div>

                <div class="hotMod" style="right:5px; top:30px;">
                    <p class="tital">最新信息</p>
                    <ul id="Latestnews" runat="server">
                    </ul>
                </div>
                <div class="hotMod" style="right:5px; top:345px;">
                    <p class="tital">热门信息</p>
                    <ul id="hotNews" runat="server">
                    </ul>
                </div>

                <div class="LinksMod" style="height:100px; z-index:30; right:5px; top:650px;">
                    <p class="tital">友情链接</p>
                    <div id="Links" runat="server">
                        <a>中国农业网</a>
                    </div>
                </div>

<div style=" position:absolute; left:5px; top:270px;"><span class="demoTital">产品展示</span></div>
<div id="demo" style="overflow:hidden;width:680px;padding:0px; position:absolute; left:5px; top:300px;">
<div id="indemo">
	<div id="demo1" runat="server">
	</div>
     <div id="demo2"></div>
     </div>
</div>
<script type="text/javascript">
    var speed = 20; //数字越大速度越慢
    var tab = document.getElementById("demo");
    var tab1 = document.getElementById("demo1");
    var tab2 = document.getElementById("demo2");
    tab2.innerHTML = tab1.innerHTML;

    function Marquee() {
        if (tab2.offsetWidth - tab.scrollLeft <= 0)
            tab.scrollLeft -= tab1.offsetWidth
        else {
            tab.scrollLeft++;
        }
    }
    var MyMar = setInterval(Marquee, speed);
    tab.onmouseover = function () { clearInterval(MyMar) };
    tab.onmouseout = function () { MyMar = setInterval(Marquee, speed) };
</script> 

                <div class="Infor" style=" left:5px; top:475px; ">
                    <ul class="inforMenu">
                        <li><a id="Marknews" class="moverOver" href="web/Marknews.aspx" target="_blank" onmouseover="change1(this.id)">市场动态</a>
                            <ul id="_Marknews" runat="server"  style="display:inline-block">
                                
                            </ul>
                        </li>
                        <li><a id="AgricultTech" href="web/AgricultTech.aspx" target="_blank" class="moverOut" onmouseover="change1(this.id)">特色产品</a>
                            <ul id="_AgricultTech" runat="server">
                               
                            </ul>
                        </li>
                        <li><a id="Supply_Infor" href="web/Supply_demandInfor.aspx" target="_blank" class="moverOut" onmouseover="change1(this.id)">供求信息</a>
                            <ul id="_Supply_Infor" runat="server">
                                
                            </ul>
                        </li>
                    </ul>
                </div>

                <div class="Infor" style="left:330px; top:475px; ">
                    <ul class="inforMenu">
                        <li><a id="PolicyLaws" href="web/PolicyLaws.aspx" target="_blank" class="moverOver" onmouseover="change2(this.id)">政策法规</a>
                            <ul id="_PolicyLaws" runat="server" style="display:inline-block">
                                
                            </ul>
                        </li>
                        <li><a id="NYKJ" href="web/NYKJ.aspx" target="_blank" class="moverOut" onmouseover="change2(this.id)">农业科技</a>
                            <ul id="_NYKJ" runat="server">
                               
                            </ul>
                        </li>
                        <li><a id="Economicnews" href="web/Economicnews.aspx" target="_blank" class="moverOut" onmouseover="change2(this.id)">企业简介</a>
                            <ul id="_Economicnews" runat="server">
                              
                            </ul>
                        </li>
                    </ul>
                </div>
                <script type="text/javascript">
                    var arr1 = new Array('Marknews', 'AgricultTech', 'Supply_Infor');
                    var arr2 = new Array('PolicyLaws', 'NYKJ', 'Economicnews');
                    function change1(id) {
                        for (var i = 0; i < arr1.length; i++) {
                            if (arr1[i] == id) {
                                document.getElementById(id).className = "moverOver";
                                document.getElementById("_" + id).style.display = "inline-block";
                            } else {
                                document.getElementById(arr1[i]).className = "moverOut";
                                document.getElementById("_" + arr1[i]).style.display = "none";
                            }
                        }
                    }

                    function change2(id) {
                        for (var i = 0; i < arr2.length; i++) {
                            if (arr2[i] == id) {
                                document.getElementById(id).className = "moverOver";
                                document.getElementById("_" + id).style.display = "inline-block";
                            } else {
                                document.getElementById(arr2[i]).className = "moverOut";
                                document.getElementById("_" + arr2[i]).style.display = "none";
                            }
                        }
                    }
                </script>

                <div id="webInfor" runat="server" style="top:750px; left:5px;">
                        如东县供销合作社主办 地址：如东县掘港镇江海东路17号<br />
                        版权所有 如东县供销社信息服务中心<br />
                        Tel:0513-84512258 0513-84512541 Fax:0513-84512128
                </div>
        </div>
        </div>
    </div>
</body>
</html>
