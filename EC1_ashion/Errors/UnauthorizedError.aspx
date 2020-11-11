<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UnauthorizedError.aspx.cs" Inherits="EC1_ashion.Errors.UnauthorizedError" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--Design 404 Unauthorized -->
    <asp:Label ID="Label1" runat="server" Text="Error" Style="color: black; font-weight: 700; font-size: 450%; padding-top: 20%">4 0 1 ERROR</asp:Label>
    <a href='javascript:history.go(-1)'>Go Back to Previous Page</a> - 
    <a href="../Default.aspx">Home</a>
</asp:Content>
