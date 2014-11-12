<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlOvveride.aspx.cs" Inherits="Caching.ControlOvveride" %>

<%@ Register TagPrefix="CC" TagName="Outer" Src="~/OuterControl.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        div.panel {
            margin: 10px 0;
        }
    </style>
</head>
<body>
    <form id="asdsad" runat="server">
        <CC:Outer runat="server"></CC:Outer>
        <div class="panel">
            <button type="submit">Submit</button>
        </div>
    </form>
</body>
</html>
