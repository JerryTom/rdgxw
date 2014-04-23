<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="Admin_User_User" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<%@Import Namespace="System.Data" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../../include/css/ManageStyle.css" rel="stylesheet" />
    <script src="../../include/js/jquery-2.1.0.min.js"></script>
    <script src="../../include/js/deleteData.js"></script>
</head>
<body>
    <form id="form1" runat="server">
   <div class="mainDiv">
               <h1>用户管理</h1>
        <asp:Repeater ID="R_User" runat="server">
            <HeaderTemplate>
                <table id="tb" border="1">
                    <tr>
                        <th>用户名</th>
                        <th>用户类型</th>
                        <th>最后登陆时间</th>
                        <th>登陆次数</th>
                        <th>管理操作</th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#((DataRowView)Container.DataItem)["User_Name"]%></td>
                    <td><%#((DataRowView)Container.DataItem)["UserType_Name"]%></td>
                    <td><%#((DataRowView)Container.DataItem)["LostLoginTime"]%></td>
                    <td><%#((DataRowView)Container.DataItem)["LoginCount"]%></td>
                    <td>
                        <a href="editPwd.aspx?action=edit&id=<%#((DataRowView)Container.DataItem)["ID"] %>" target="_self">修改密码</a>
                        <a onclick="deleteByID(<%#((DataRowView)Container.DataItem)["ID"] %>)">删除</a>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <div class="pagerMod">
            <div><p class="rowsMod">每页显示<asp:DropDownList ID="page_rows" runat="server" AutoPostBack="True" OnSelectedIndexChanged="page_rows_SelectedIndexChanged">
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>50</asp:ListItem>
                <asp:ListItem>100</asp:ListItem>
                </asp:DropDownList>
                条</p>
            <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" 
                FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" NumericButtonCount="5" 
                onpagechanged="AspNetPager1_PageChanged" PrevPageText="上一页" 
                ShowMoreButtons="False">
            </webdiyer:AspNetPager>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
