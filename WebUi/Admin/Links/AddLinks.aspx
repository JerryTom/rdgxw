<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddLinks.aspx.cs" Inherits="Admin_Links_AddLinks" %>

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
            <a class="float_right_top_sign">友情链接管理</a>
            <div id="forinput">
                <form id="form1" method="post" runat="server">
                <dl>
                    <dd class="title_menu"><asp:Label ID="_Links_Name" runat="server" Text="" ForeColor="Red"></asp:Label>
                        链接名称：<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="链接名称必须填写" 
                            ControlToValidate="Links_Name" ForeColor="Red"></asp:RequiredFieldValidator>
                    </dd>
                    <dd class="content_menu">
                        <asp:TextBox ID="Links_Name" CssClass="input_style" MaxLength="50" runat="server"></asp:TextBox>
                    </dd>
                    <dd class="title_menu">
                        链接地址：<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="链接名称必须填写" 
                            ControlToValidate="Links_Url" ForeColor="Red"></asp:RequiredFieldValidator>
                    </dd>
                    <dd class="content_menu">
                        <asp:TextBox ID="Links_Url" CssClass="input_style" MaxLength="50" runat="server"></asp:TextBox>
                    </dd>
                    <dd class="title_menu">
                        <asp:Button ID="but_Links" CssClass="but_style" runat="server" Text="提&nbsp;&nbsp;交" OnClick="but_Links_Click" />
                        <asp:Label ID="ll_ts" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </dd>
                </dl>
                </form>
            </div>
        </div>
    </div>
</body>
</html>