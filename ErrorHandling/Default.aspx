<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ErrorHandling.Default" %>
<%@ Register TagName="Sum" TagPrefix="CC" Src="~/SumControl.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
       div{
           border:1px solid black;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="wrapper">
        <h3>Page</h3>
        <div><input type="checkbox" name="pageAction" value="error" />
            Generate Error
        </div>
    </div>
        <div><h3>Control</h3></div>
        <CC:Sum id="sumControl" runat="server"></CC:Sum>
    </div>
        <div class="panel"><button type="submit">submit</button></div>
    </form>
</body>
</html>
