<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CietiesControl.ascx.cs" Inherits="Caching.CietiesControl" %>
Here are some cities
<%=GetCities() %>
(Render at <%= GetTimeStamp() %>)