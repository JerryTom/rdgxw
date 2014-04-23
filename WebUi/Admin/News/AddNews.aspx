<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNews.aspx.cs" Inherits="Admin_News_AddNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="\../../include/css/addStyle.css" rel="stylesheet" />
    <link href="\../../include/kindeditor/themes/default/default.css" rel="stylesheet" />
    <link href="\../../include/kindeditor/plugins/code/prettify.css" rel="stylesheet" />
    <script src="\../../include/kindeditor/kindeditor.js" type="text/javascript"></script>
    <script src="\../../include/kindeditor/lang/zh_CN.js" type="text/javascript"></script>
    <script src="\../../include/kindeditor/plugins/code/prettify.js" type="text/javascript"></script>
    <script src="\../../include/js/jquery-2.1.0.min.js"></script>
    <script type="text/javascript">
        KindEditor.ready(function (K) {
            var editor = K.editor({
                uploadJson: '\../../include/kindeditor/asp.net/upload_json.ashx',
                fileManagerJson: '\../../include/kindeditor/asp.net/file_manager_json.ashx',
                allowFileManager: true
            });
            K('#image1').click(function () {
                editor.loadPlugin('image', function () {
                    editor.plugin.imageDialog({
                        imageUrl: K('#Img_Url').val(),
                        clickFn: function (url, title, width, height, border, align) {
                            K('#Img_Url').val(url);
                            editor.hideDialog();
                        }
                    });
                });
            });
        });
		</script>
    <script type="text/javascript">
        $(function () {
            showImg();
        });
        KindEditor.ready(function (K) {
            var editor1 = K.create('#NewsContent', {
                cssPath: '../../include/kindeditor/plugins/code/prettify.css',
                uploadJson: '../../include/kindeditor/asp.net/upload_json.ashx',
                fileManagerJson: '../../include/kindeditor/asp.net/file_manager_json.ashx',
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

        function showImg() {
            if ($("#imageCheck").prop('checked') == true) {
                $("#img1").show(500);
                $("#img2").show(500);
            } else {
                $("#img1").hide(500);
                $("#img2").hide(500);
            }
        }
    </script>
</head>
<body>
<div id="registerarea">
    <div id="forManage">
        <div class="title-login"></div>
        <a class="float_right_top_sign">文章管理</a>
        <div id="forinput">
            <form id="NewsCategory_Add" method="post" runat="server">
            <dl>
                <dd class="title_menu">
                    文章标题：<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="文章标题必须填写" ControlToValidate="NewsTitle" ForeColor="Red"></asp:RequiredFieldValidator>
                </dd>
                <dd class="content_menu"> 
                    <asp:TextBox ID="NewsTitle" CssClass="input_style" MaxLength="30" runat="server"></asp:TextBox>
                </dd>
                <dd class="title_menu">
                    文章分类：<asp:Label ID="_News_Sort" runat="server" Text="请选择文章分类" ForeColor="Red" Visible="False"></asp:Label>
                </dd>
                <dd class="content_menu" style="width:600px;">
                    <asp:DropDownList CssClass="input_style" Width="220" ID="News_Sort" runat="server">
                        <asp:ListItem Value="0" Selected="True">请选择文章分类</asp:ListItem>
                    </asp:DropDownList>
                    <input id="imageCheck" onchange="showImg()" style="margin-left:30px;" type="checkbox" runat="server" /><label for="imageCheck">图片新闻？</label>
                    <input id="reading" style="margin-left:30px;" type="checkbox" runat="server" /><label for="reading">推荐阅读？</label>
                </dd>
                <dd class="title_menu" id="img1">
                    封面图片：
                </dd>
                <dd class="content_menu" id="img2" style="width:500px;">
                   <input class="input_style" style="width:200px;" type="text" id="Img_Url" value="" runat="server" /> 
                    <input class="but_style" style="width:100px; height:34px;" type="button" id="image1" value="选择图片" />
                </dd>
                <dd class="title_menu">
                    文章内容：
                </dd>
                <dd class="content_menu">
                    <textarea id="NewsContent" cols="100" rows="8" style="width:670px;height:200px;visibility:hidden;" runat="server"  onblur="validate(this.id)"></textarea>
                </dd>
                <dd class="title_menu">
                    <asp:Button ID="but_News" CssClass="but_style" runat="server" 
                        Text="添&nbsp;&nbsp;加" OnClick="but_News_Click" />
                    <asp:Label ID="ll_ts" runat="server" Text="" ForeColor="Red"></asp:Label>
                </dd>
            </dl>
            </form>
        </div>
    </div>
</div>
</div>
</body>
</html>

