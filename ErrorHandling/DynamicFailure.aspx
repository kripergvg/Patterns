<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DynamicFailure.aspx.cs" Inherits="ErrorHandling.DynamicFailure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <a href="<%:Request["aspxerrorpath"] %>">Ololo</a>
    </div>
    </form>
</body>
</html>
