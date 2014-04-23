<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="AdminManage_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>后台信息管理</title>
<%--	<meta content="width=device-width, initial-scale=1.0" name="viewport" />

	<meta content="" name="description" />

	<meta content="" name="author" />--%>

	<!-- BEGIN GLOBAL MANDATORY STYLES -->

	<link href="media/css/bootstrap.min.css" rel="stylesheet" type="text/css"/>

	<link href="media/css/bootstrap-responsive.min.css" rel="stylesheet" type="text/css"/>

	<link href="media/css/font-awesome.min.css" rel="stylesheet" type="text/css"/>

	<link href="media/css/style-metro.css" rel="stylesheet" type="text/css"/>

	<link href="media/css/style.css" rel="stylesheet" type="text/css"/>

	<link href="media/css/style-responsive.css" rel="stylesheet" type="text/css"/>

	<link href="media/css/default.css" rel="stylesheet" type="text/css" id="style_color"/>

	<link href="media/css/uniform.default.css" rel="stylesheet" type="text/css"/>

	<!-- END GLOBAL MANDATORY STYLES -->

	<%--<link rel="shortcut icon" href="media/image/favicon.ico" />--%>
</head>
<body class="page-header-fixed" onload="setMain()">

	<div class="header navbar navbar-inverse navbar-fixed-top">

		<!-- BEGIN TOP NAVIGATION BAR -->

		<div class="navbar-inner">

			<div class="container-fluid">

				<!-- BEGIN LOGO 定义logo -->

				<a class="brand" style="display:inline-block; margin-left:20px;" href="Default.aspx" target="_self">

				<%--<img src="media/image/logo.png" alt="logo"/>--%>
                后台信息管理

				</a>

				<!-- END LOGO -->

				<!-- BEGIN RESPONSIVE MENU TOGGLER -->

				<a href="javascript:;" class="btn-navbar collapsed" data-toggle="collapse" data-target=".nav-collapse">

				<img src="media/image/menu-toggler.png" alt=""/>

				</a>          

				<!-- END RESPONSIVE MENU TOGGLER -->            

				<!-- BEGIN TOP NAVIGATION MENU -->              

				<ul class="nav pull-right">
					<!-- BEGIN USER LOGIN DROPDOWN -->

					<li class="dropdown user">

						<a href="#" class="dropdown-toggle" data-toggle="dropdown">

                        <img alt="" style="display:inline-block;height:29px; width:29px;" src="../include/images/images.jpg" />

						<span class="username" id="username" runat="server"></span>

						<i class="icon-angle-down"></i>

						</a>

						<ul class="dropdown-menu">

<%--							<li><a href="extra_profile.html"><i class="icon-user"></i> My Profile</a></li>

							<li><a href="page_calendar.html"><i class="icon-calendar"></i> My Calendar</a></li>

							<li><a href="inbox.html"><i class="icon-envelope"></i> My Inbox(3)</a></li>

							<li><a href="#"><i class="icon-tasks"></i> My Tasks</a></li>

							<li class="divider"></li>

							<li><a href="extra_lock.html"><i class="icon-lock"></i> Lock Screen</a></li>
    --%>
							<li><a href="Login_Out.aspx"><i class="icon-key"></i>  安全退出</a></li>

						</ul>

					</li>

					<!-- END USER LOGIN DROPDOWN -->

				</ul>

				<!-- END TOP NAVIGATION MENU --> 

			</div>

		</div>

		<!-- END TOP NAVIGATION BAR -->

	</div>

<!-- 顶部菜单结束 -->
<!-- 导航菜单+主体 -->
<div class="page-container">

		<!-- BEGIN SIDEBAR -->

		<div id="menuMod" class="page-sidebar nav-collapse collapse">

			<!-- BEGIN SIDEBAR MENU -->        

			<ul class="page-sidebar-menu">

				<li>

					<!-- BEGIN SIDEBAR TOGGLER BUTTON -->

					<div class="sidebar-toggler hidden-phone" title="点击显示/隐藏"></div>

					<!-- BEGIN SIDEBAR TOGGLER BUTTON -->

				</li>

				<li style="height:13px;">

					<!-- BEGIN  SEARCH 开始搜索模块 -->

<%--					<form class="sidebar-search" id="form1" runat="server">

						<div class="input-box">

							<a href="javascript:;" class="remove"></a>

							<input type="text" placeholder="Search..."/>
                            <asp:Button ID="but_Search" runat="server" CssClass="submit" Text="  " />
							<input type="button" class="submit" value=" "/>

						</div>

					</form>--%>

					<!-- END  SEARCH 结束搜索模块 -->

				</li>  

				<li class="" style="border-top-width:0;"> <%-- 原来样式start active--%>

					<a href="index.aspx" target="main">

					<i class="icon-home"></i> 

					<span class="title">主界面</span>

					<span class="selected"></span>

					</a>

				</li>

				<li class="">
					<a href="javascript:;">
					<i class="icon-file-text"></i> 
					<span class="title">文章管理</span>
					<span class="arrow "></span>
					</a>
					<ul class="sub-menu">
						<li><a href="News/Default.aspx" target="main">所有文章</a></li>
                        <li><a href="News/AddNews.aspx" target="main">写文章</a></li>
					</ul>
				</li>

                <li class="">
					<a href="javascript:;">
					<i class="icon-user"></i> 
					<span class="title">用户管理</span>
					<span class="arrow "></span>
					</a>
					<ul class="sub-menu">
						<li><a href="User/User.aspx" target="main">所有用户</a></li>
                        <li><a href="User/AddUser.aspx" target="main">添加用户</a></li>
					</ul>
				</li>

                <li class="">
					<a href="javascript:;">
					<i class="icon-link"></i> 
					<span class="title">友情链接管理</span>
					<span class="arrow "></span>
					</a>
					<ul class="sub-menu">
						<li><a href="Links/Links.aspx" target="main">所有友情链接</a></li>
                        <li><a href="Links/AddLinks.aspx" target="main">添加友情链接</a></li>
					</ul>
				</li>

				<li class="last ">

					<a href="Site.aspx" target="main">

					<i class="icon-columns"></i> 

					<span class="title">网站设置</span>

					</a>

				</li>

			</ul>

			<!-- END SIDEBAR MENU -->

		</div>

		<!-- END SIDEBAR -->

		<!-- BEGIN PAGE -->

		<div class="page-content">

			<!-- BEGIN SAMPLE PORTLET CONFIGURATION MODAL FORM-->


			<!-- END SAMPLE PORTLET CONFIGURATION MODAL FORM-->

			<!-- BEGIN PAGE CONTAINER-->
<!-- 主体模块 -->
			<div id="mainMod" style="position:relative;">
                <iframe style="position:absolute; left:0px; top:0px; height:100%; width:100%; border:0;" id="main" name="main" src="Index.aspx"></iframe>
			</div>

			<!-- END PAGE CONTAINER-->    
<!-- 主体模块结束 -->
		</div>

		<!-- END PAGE -->

	</div>
<!-- 左侧导航结束，底部模块开始 -->
    <div class="footer" style="max-height:70px;">

	    <div class="footer-inner">
<%-- 版本信息 --%>
		    <%--2013 © Metronic by keenthemes.--%>
<%-- 版本信息结束 --%>
	    </div>

	    <div class="footer-tools">

		    <span class="go-top">

		    <i class="icon-angle-up"></i>

		    </span>

	    </div>

    </div>
<!-- 底部模块结束 -->
	<!-- BEGIN JAVASCRIPTS(Load javascripts at bottom, this will reduce page load time) -->

	<!-- BEGIN CORE PLUGINS -->

	<script src="media/js/jquery-1.10.1.min.js" type="text/javascript"></script>

	<script src="media/js/jquery-migrate-1.2.1.min.js" type="text/javascript"></script>

	<!-- IMPORTANT! Load jquery-ui-1.10.1.custom.min.js before bootstrap.min.js to fix bootstrap tooltip conflict with jquery ui tooltip -->

	<script src="media/js/jquery-ui-1.10.1.custom.min.js" type="text/javascript"></script>      

	<script src="media/js/bootstrap.min.js" type="text/javascript"></script>

<%--	[if lt IE 9]>--%>

	<script src="media/js/excanvas.min.js"></script>

	<script src="media/js/respond.min.js"></script>  

<%--	<![endif]   --%>

	<script src="media/js/jquery.slimscroll.min.js" type="text/javascript"></script>

	<script src="media/js/jquery.blockui.min.js" type="text/javascript"></script>  

	<script src="media/js/jquery.cookie.min.js" type="text/javascript"></script>

	<script src="media/js/jquery.uniform.min.js" type="text/javascript" ></script>

	<!-- END CORE PLUGINS -->

	<!-- BEGIN PAGE LEVEL SCRIPTS -->

	<script src="media/js/app.js" type="text/javascript"></script>
   

	<!-- END PAGE LEVEL SCRIPTS -->  

	<script>

	    jQuery(document).ready(function () {

	        App.init(); // initlayout and core plugins

	        Index.init();

	        Index.initJQVMAP(); // init index page's custom scripts

	        Index.initCalendar(); // init index page's custom scripts

	        Index.initCharts(); // init index page's custom scripts

	        Index.initChat();

	        Index.initMiniCharts();

	        Index.initDashboardDaterange();

	        Index.initIntro();

	    });

	</script>

	<!-- END JAVASCRIPTS -->

<script type="text/javascript">  var _gaq = _gaq || []; _gaq.push(['_setAccount', 'UA-37564768-1']); _gaq.push(['_setDomainName', 'keenthemes.com']); _gaq.push(['_setAllowLinker', true]); _gaq.push(['_trackPageview']); (function () { var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true; ga.src = ('https:' == document.location.protocol ? 'https://' : 'http://') + 'stats.g.doubleclick.net/dc.js'; var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s); })();</script>

    <script type="text/javascript">
        $(function () {
            setMain();
        });

        function setMain() {
            var h = parseInt(document.body.clientHeight);
            var main = document.getElementById("mainMod").style;
            main.height = h + 'px';
        }
        window.onresize = main;
    </script>
<!-- END BODY -->
</body>
</html>
