<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnCachedForm.aspx.cs" Inherits="Caching.UnCachedForm" %>

<%@ Register TagPrefix="CC" TagName="Time" Src="~/CurrentTime.ascx" %>
<%@ Register TagPrefix="CX" Namespace="Caching" Assembly="Caching" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        div.panel {
            margin: 5px;
            padding:5px;
            border:thick solid black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="panel"><CC:Time ID="timeControl" runat="server" /></div>
        <div class="panel"><CX:TimeServerControl runat="server"></CX:TimeServerControl> </div>
        <div class="panel">Requested at:<%:DateTime.Now.ToLongTimeString() %></div>
    </form>
</body>
</html>
