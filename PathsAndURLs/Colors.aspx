<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Colors.aspx.cs" Inherits="PathsAndURLs.Colors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    The colors are:
    <ol>
        <asp:Repeater ItemType="System.String" SelectMethod="GetColors" runat="server">
            <ItemTemplate>
                <li><%#Item %></li>
            </ItemTemplate>
        </asp:Repeater>
    </ol>
</body>
</html>
