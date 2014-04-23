<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_News_Default" %>

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
                <h1>文章管理</h1> 
    <div id="searchMod">
        <p>
            <span>要显示的文章：</span>
            <asp:DropDownList ID="News_Sort" runat="server" AutoPostBack="True" OnSelectedIndexChanged="News_Sort_SelectedIndexChanged">
                <asp:ListItem Selected="True" Value="">全部文章</asp:ListItem>
            </asp:DropDownList>
        </p>
    </div>
        <asp:Repeater ID="R_News" runat="server">
            <HeaderTemplate>
                <table style="width:800px;" id="tb" border="1">
                    <tr>
                        <th style="width:60px;">文章类型</th>
                        <th style="max-width:300px;">文章标题</th>
                        <th style="min-width:40px;">添加人</th>
                        <th style="min-width:60px;">推荐阅读</th>
                        <th style="min-width:60px;">图片新闻</th>
                        <th style="min-width:40px;">点击率</th>
                        <th style="width:90px;">管理操作</th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#((DataRowView)Container.DataItem)["Sort_Name"]%></td>
                    <td style="padding:5px;"><a href="../../web/BindNewsByID.aspx?id=<%#((DataRowView)Container.DataItem)["ID"]%>" title="查看【<%#((DataRowView)Container.DataItem)["News_Tital"]%>】" target="_blank"><%#((DataRowView)Container.DataItem)["News_Tital"]%></a></td>
                    <td><%#((DataRowView)Container.DataItem)["User_Name"]%></td>
                    <td><%#Convert.ToInt32(((DataRowView)Container.DataItem)["News_Reading"])==1?"<span style='color:red'>是</span>":"<span style='color:orange'>否</span>"%></td>
                    <td><%#Convert.ToInt32(((DataRowView)Container.DataItem)["News_ImageBool"])==1?"<span style='color:red'>是</span>":"<span style='color:orange'>否</span>"%></td>
                    <td><%#((DataRowView)Container.DataItem)["NewsCount"]%></td>

                    <td>
                        [<a href="AddNews.aspx?action=edit&id=<%#((DataRowView)Container.DataItem)["ID"] %>" target="_self">编辑</a>]
                        [<a onclick="deleteByID(<%#((DataRowView)Container.DataItem)["ID"] %>)">删除</a>]
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <div class="pagerMod">
            <div><p class="rowsMod">每页显示<asp:DropDownList ID="page_rows" runat="server" AutoPostBack="True" OnSelectedIndexChanged="page_rows_SelectedIndexChanged">
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
