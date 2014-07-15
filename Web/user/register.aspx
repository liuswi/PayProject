<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Web.user.register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>用户注册</title>
    <script type="text/javascript" src="scripts/jquery/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="scripts/jquery/jquery.form.min.js"></script>
<script type="text/javascript" src="scripts/jquery/Validform_v5.3.2_min.js"></script>
<script type="text/javascript" src="scripts/lhgdialog/lhgdialog.js?skin=idialog"></script>
<script type="text/javascript" src="scripts/datepicker/WdatePicker.js"></script>
<script type="text/javascript" src="scripts/swfupload/swfupload.js"></script>
<script type="text/javascript" src="scripts/swfupload/swfupload.queue.js"></script>
<script type="text/javascript" src="scripts/swfupload/swfupload.handlers.js"></script>
<script type="text/javascript" src="../js/layout.js"></script>
<script type="text/javascript" src="../js/base.js"></script>
<script type="text/javascript" src="../js/register_validate.js"></script>
<link href="../skin/default/style.css" rel="stylesheet" type="text/css" />
<link href="css/style.css" rel="stylesheet" type="text/css" />
<script type="text/javascript">
    $(function () {
        //初始化表单验证
        $("#form1").initValidform();
    });
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="tab-content register">
        <dl>
            <dt>
                <dd class="regTitle">用户注册</dd>
            </dt>
        </dl>
        <dl>
            <dt>用户名：</dt>
            <dd>
                <asp:TextBox ID="txtUserName" runat="server" CssClass="input normal" datatype="*2-100" ajaxurl="submit_ajax.ashx?action=validate_username" sucmsg=" "></asp:TextBox> <span class="Validform_checktip">*登录的用户名，支持中文</span>
            </dd>
        </dl>
        <dl>
            <dt>密码：</dt>
            <dd><asp:TextBox ID="txtPassword" runat="server" CssClass="input normal" TextMode="Password" datatype="*6-20" nullmsg="请设置密码" errormsg="密码范围在6-20位之间" sucmsg=" "></asp:TextBox> <span class="Validform_checktip">*登录的密码，至少6位</span></dd>
        </dl>
        <dl>
            <dt>确认密码：</dt>
            <dd><asp:TextBox ID="txtPassword1" runat="server" CssClass="input normal" TextMode="Password" datatype="*" recheck="txtPassword" nullmsg="请再输入一次密码" errormsg="两次输入的密码不一致" sucmsg=" "></asp:TextBox> <span class="Validform_checktip">*再次输入密码</span></dd>
        </dl>
        <dl>
            <dt>真实姓名：</dt>
            <dd><asp:TextBox ID="txtRealName" runat="server" CssClass="input normal" sucmsg=" "></asp:TextBox></dd>
        </dl>
        <dl>
            <dt>性别：</dt>
            <dd>
            <div class="rule-multi-radio">
        <asp:RadioButtonList ID="rblSex" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
        <asp:ListItem Value="保密" Selected="True">保密</asp:ListItem>
        <asp:ListItem Value="男">男</asp:ListItem>
        <asp:ListItem Value="女">女</asp:ListItem>
        </asp:RadioButtonList>
      </div>
            </dd>
        </dl>
        <dl>
            <dt>身份证号：</dt>
            <dd><asp:TextBox ID="txtCard" runat="server" CssClass="input normal" datatype="/^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$/" nullmsg="请输入身份证号码" sucmsg=" "></asp:TextBox></dd>
        </dl>
        <dl>
            <dt>家庭地址：</dt>
            <dd><asp:TextBox ID="txtAddress" runat="server" CssClass="input normal"></asp:TextBox></dd>
        </dl>
        <dl>
            <dt>手机号码：</dt>
            <dd><asp:TextBox ID="txtMobile" runat="server" datatype="m" nullmsg="请输入手机号码" CssClass="input normal"></asp:TextBox></dd>
        </dl>
        <dl>
            <dt>邮箱帐号：</dt>
            <dd><asp:TextBox ID="txtEmail" runat="server" CssClass="input normal" nullmsg="请输入邮箱帐号" datatype="e" sucmsg=" "></asp:TextBox> <span class="Validform_checktip">*取回密码时用到</span></dd>
        </dl>
        <dl>
            <dt>密保问题：</dt>
            <dd>
                <div class="rule-single-select">
                    <asp:DropDownList id="ddlQuestion" runat="server"  sucmsg=" ">
                        <asp:ListItem Value="我喜欢的书籍">我喜欢的书籍</asp:ListItem>
                        <asp:ListItem Value="我喜欢的宠物">我喜欢的宠物</asp:ListItem>
                        <asp:ListItem Value="我就读的小学名字">我就读的小学名字</asp:ListItem>
                        <asp:ListItem Value="我就读的中学名字">我就读的中学名字</asp:ListItem>
                        <asp:ListItem Value="我就读的中学名字">我就读的高中名字</asp:ListItem>
                        <asp:ListItem Value="我就读的大学名字">我就读的大学名字</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </dd>
        </dl>
        <dl>
            <dt>密保答案：</dt>
            <dd><asp:TextBox ID="txtAnswer" runat="server" CssClass="input normal"></asp:TextBox></dd>
        </dl>
        <dl>
            <dt>验证码：</dt>
            <dd>
                <asp:TextBox ID="txtCode" runat="server"  CssClass="input small"></asp:TextBox>
                <a id="verifyCode" style="display:none;" href="javascript:;" onclick="ToggleCode(this, 'verify_code.ashx');return false;"><img src="verify_code.ashx" width="80" height="22" /> 看不清楚？</a>
                <span class="Validform_checktip"></span>
            </dd>
        </dl>
        <dl>
            <dt></dt>
            <dd>
                <asp:Button ID="btnSubmit" CssClass="btn" runat="server" Text="注册" 
                    onclick="btnSubmit_Click" />&nbsp;&nbsp;<asp:Button ID="reset" CssClass="btn" runat="server" Text="重置" />
            </dd>
        </dl>
        
    </div>
    </form>
</body>
</html>