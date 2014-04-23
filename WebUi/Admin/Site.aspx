<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Site.aspx.cs" Inherits="Admin_Site" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="\../include/css/addStyle.css" rel="stylesheet" />
    <link href="\../include/kindeditor/themes/default/default.css" rel="stylesheet" />
    <link href="\../include/kindeditor/plugins/code/prettify.css" rel="stylesheet" />
    <script src="\../include/kindeditor/kindeditor.js" type="text/javascript"></script>
    <script src="\../include/kindeditor/lang/zh_CN.js" type="text/javascript"></script>
    <script src="\../include/kindeditor/plugins/code/prettify.js" type="text/javascript"></script>
    <script src="\../include/js/jquery-2.1.0.min.js"></script>
    <script type="text/javascript">
        KindEditor.ready(function (K) {
            var editor1 = K.create('#SiteContent', {
                cssPath: '\../include/kindeditor/plugins/code/prettify.css',
                uploadJson: '\../include/kindeditor/asp.net/upload_json.ashx',
                fileManagerJson: '\../include/kindeditor/asp.net/file_manager_json.ashx',
                allowFileManager: true,
                afterCreate: function () {
                    var self = this;
                    K.ctrl(document, 13, function () {
                        self.sync();
                        K('form[name=NewsCategory_Add]')[0].submit();
                    });
                    K.ctrl(self.edit.doc, 13, function () {
                        self.sync();
                        K('form[name=NewsCategory_Add]')[0].submit();
                    });
                }
            });
            prettyPrint();
        });
    </script>
</head>
<body>
<div id="registerarea">
        <div id="forManage" style="width:700px;">
            <div class="title-login"></div>
            <a class="float_right_top_sign">网站设置</a>
            <div id="forinput">
                <form id="NewsCategory_Add" method="post" runat="server">
                <dl>
                    <dd class="title_menu">
                        网站底部信息：
                    </dd>
                    <dd class="content_menu">
                        <textarea id="SiteContent" cols="100" rows="8" style="width:670px;height:200px;visibility:hidden;" runat="server"  onblur="validate(this.id)"></textarea>
                    </dd>
                    <dd class="title_menu">
                        <asp:Button ID="but_user" CssClass="but_style" runat="server" Text="更  新" OnClick="but_user_Click" />
                        <asp:Label ID="ll_ts" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </dd>
                </dl>
                </form>
            </div>
        </div>
    </div>
</body>
</html>