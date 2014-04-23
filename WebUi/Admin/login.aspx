<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="MX_Web_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>后台管理 | 登录</title>
    <link href="../include/css/loginStyle.css" rel="stylesheet" />
</head>
<body>
<div style="text-align:center;clear:both">
<script src="/gg_bd_ad_720x90.js" type="text/javascript"></script>
<script src="/follow.js" type="text/javascript"></script>
</div>
  <div id="form-main">
  <div id="form-div">
    <form class="form" id="form1" runat="server">
        <dl>
            <dd class="content_menu">
                <asp:TextBox ID="userid" runat="server" placeholder="用户名" required="required" TabIndex="1" MaxLength="30"></asp:TextBox>
            </dd>
            <dd class="content_menu">
                <asp:TextBox ID="pwd" runat="server" placeholder="密码" required="required" TextMode="Password" TabIndex="2" MaxLength="18"></asp:TextBox>
            </dd>
            <dd class="content_menu" style="position:relative;">
                <input class="register_nic" name="vdcode" id="vdcode" placeholder="验证码" required="required" style="width: 120px; text-transform: uppercase;" tabindex="3" maxlength="4" runat="server" />
                <img title="如果您无法识别验证码，请点图片更换" id="imgVerify" src="VerifyCode/VerifyCode.aspx?"
                    alt="如果您无法识别验证码，请点图片更换" onclick="this.src=this.src+'?'" style="cursor: pointer; display:inline-block; position:absolute; height:53px; width:140px; bottom:0px; left:150px;"
                     />
            </dd>
        </dl>
      <div class="submit">
          <asp:Button ID="button_blue" runat="server" Text="登   录" OnClick="but_login_Click" />
        <div class="ease"></div>
      </div>
    </form>
  </div>
</div>
</body>
</html>
