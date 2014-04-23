<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login_Out.aspx.cs" Inherits="Admin_Login_Out" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>后台管理系统|退出登录</title>
    <style type="text/css">
        body,p{margin:0;}
        html,body{width:100%; height:100%;}
        .loginOut{color:#0094ff; font-size:16px; font-family:'Microsoft YaHei'; margin:20px;}
        a{color:#0026ff;}
        a:hover{color:#ff6a00;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="loginOut">
        <p>您已安全退出，欢迎您的下次使用...</p>
        <p>如需返回登陆界面请<a href="Login.aspx" target="_self">点击这里</a></p>
    </div>
    </form>
</body>
</html>
