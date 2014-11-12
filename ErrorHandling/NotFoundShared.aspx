<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NotFoundShared.aspx.cs" Inherits="ErrorHandling.NotFoundShared" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    You asked <span id="errorSrc" runat="server"></span>
        for: <span id="requestURL" runat="server"></span>
    </div>
    </form>
</body>
</html>
