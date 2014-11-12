<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequestReporter.aspx.cs" Inherits="PathsAndURLs.Content.RequestReporter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <p>Original virtual path: <%:Request.FilePath %></p>
    <p>Original phisical path: <%:Request.PhysicalPath %></p>
    <p>Current virtual path: <%:Request.CurrentExecutionFilePath %></p>
    <p>Current phisical path: <%:Request.MapPath(Request.CurrentExecutionFilePath) %></p>
</body>
</html>
