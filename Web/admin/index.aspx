<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Web.admin.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后台管理</title>
    <link href="../skin/default/style.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="scripts/jquery/jquery-1.10.2.min.js"></script>
<script type="text/javascript" src="scripts/jquery/jquery.nicescroll.js"></script>
<script type="text/javascript" src="scripts/lhgdialog/lhgdialog.js?skin=idialog"></script>
<script type="text/javascript" src="../js/layout.js"></script>
</head>
<body class="indexbody">
<form id="form1" runat="server">
<!--全局菜单-->
<a class="btn-paograms" onclick="triggerMenu(true);"></a>
<div id="pop-menu" class="pop-menu">
  <div class="pop-box">
    <h1 class="title"><i></i>导航菜单</h1>
    <i class="close" onclick="triggerMenu(false);">关闭</i>
    <div class="list-box"></div>
  </div>
  <i class="arrow">箭头</i>
</div>
<!--/全局菜单-->

<div class="header">
  <div class="header-box">
    <h1 class="logo"></h1>
    <ul id="nav" class="nav"></ul>
    <div class="nav-right">
      <div class="icon-info">
        <span>
          <%--您好，<%=admin_info.user_name %><br />
          <%=new DTcms.BLL.manager_role().GetTitle(admin_info.role_id) %>--%>
        </span>
      </div>
      <div class="icon-option">
      	<i></i>
        <div class="drop-box">
          <div class="arrow"></div>
          <ul class="drop-item">
            <li><a  target="_blank" href="../">预览网站</a></li>
            <li><a href="center.aspx" target="mainframe">管理中心</a></li>
            <li><a onclick="linkMenuTree(false, '');" href="manager/manager_pwd.aspx" target="mainframe">修改密码</a></li>
            <li><asp:LinkButton ID="lbtnExit" runat="server">注销登录</asp:LinkButton></li>
          </ul>
        </div>
      </div>
    </div>
  </div>
</div>

<div class="main-sidebar">
    <div id="sidebar-nav" class="sidebar-nav">
      <div class="list-box"></div>
    </div>
</div>

<div class="main-container">
  <iframe id="mainframe" name="mainframe" frameborder="0" src="center.aspx"></iframe>
</div>
</form>
</body>
</html>
