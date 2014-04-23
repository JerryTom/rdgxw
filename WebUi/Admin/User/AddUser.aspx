<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="Admin_User_Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../../include/css/addStyle.css" rel="stylesheet" />
</head>
<body>
<div id="registerarea">
        <div id="forManage" style="width:310px;">
            <div class="title-login"></div>
            <a class="float_right_top_sign">用户管理</a>
            <div id="forinput">
                <form id="NewsCategory_Add" method="post" runat="server">
                <dl>
                    <dd class="title_menu">
                        用户名：<asp:Label ID="_UserName" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </dd>
                    <dd class="content_menu">
                        <input id="UserName" name="UserName" class="input_style" type="text" placeholder="只能输入'A-Z','a-z','0-9','_'" tabindex="1" maxlength="30" runat="server" onblur="validate(this.id)" />
                    </dd>
                    <dd class="title_menu">
                        用户类型：
                    </dd>
                    <dd class="content_menu">
                        <asp:DropDownList ID="User_Type" CssClass="input_style" Width="310" runat="server"></asp:DropDownList>
                    </dd>
                    <dd class="title_menu">
                        密码：<asp:Label ID="_PassWord" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </dd>
                    <dd class="content_menu">
                       <input id="PassWord1" name="PassWord" type="password" class="input_style"  placeholder="输入您的密码6-18位" tabindex="2" maxlength="18" runat="server" />
                    </dd>
                    <dd class="title_menu">
                        重复密码：
                    </dd>
                    <dd class="content_menu">
                       <input id="PassWord2" name="PassWord2" type="password" class="input_style"  placeholder="重复输入您的密码，以便牢记" tabindex="2" maxlength="18" runat="server" />
                    </dd>
                    <dd class="title_menu">
                        <asp:Button ID="but_user" CssClass="but_style" runat="server" Text="提&nbsp;&nbsp;交" OnClick="but_user_Click" />
                        <asp:Label ID="ll_ts" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </dd>
                </dl>
                </form>
            </div>
        </div>
    </div>
</body>
</html>