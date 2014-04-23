<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="Admin_index" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<%@Import Namespace="System.Data" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../include/css/adminIndex.css" rel="stylesheet" />
    <script type="text/javascript">
        function Cancel(id) {
            var t = confirm("确定要取消推荐？");
            if (t == true) {
                window.open((location.href + '?action=cancel&id=' + id), "_self");
            } else {

            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="div1"><span>如东县农副产品供销网后台信息管理</span></div>
     <div class="main">
        <div class="registerarea" style="left:30px; top:0;">
        <div class="forManage" style="width:310px;">
            <div class="title-login"></div>
            <span class="float_right_top_sign">推荐阅读文章</span>
            <div id="forinput">
                
        <asp:Repeater ID="R_Reading" runat="server">
            <HeaderTemplate>
                <table id="tb" border="1" style="border-collapse:collapse;">
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td style="padding:5px;"><a href="../web/BindNewsByID.aspx?id=<%#((DataRowView)Container.DataItem)["ID"]%>" target="_blank"><%#((DataRowView)Container.DataItem)["News_Tital"]%></a></td>
                    <td style="width:30px; padding:5px; text-align:center;"><a onclick="Cancel('<%#((DataRowView)Container.DataItem)["ID"]%>')">取消推荐</a></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <div style="margin:5px auto 0 auto; text-align:center;">
            <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" 
                FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" NumericButtonCount="5" 
                PrevPageText="上一页" 
                ShowMoreButtons="False">
            </webdiyer:AspNetPager>
        </div>


            </div>
        </div>
        </div>

        <div class="registerarea" style="left:490px; top:0;">
        <div class="forManage" style="width:310px;">
            <div class="title-login"></div>
            <span class="float_right_top_sign">关于本站</span>
            <div id="about" runat="server">
                
            </div>
            <div style="text-align:right; padding-right:30px;">
                <a href="News/editAbout.aspx" target="_self" title="编辑 关于本站" class="butSty">编辑</a>
            </div>
        </div>
        </div>
     </div>
    </form>
</body>
</html>
