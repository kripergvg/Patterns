<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CitiesForm.aspx.cs" Inherits="Caching.CitiesForm" %>
<%@ OutputCache Duration="60" VaryByParam="none" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   HERE are some cities
   <%=GetCities() %>
    (Render at <%:DateTime.Now.ToLongTimeString() %>)
</body>
</html>
