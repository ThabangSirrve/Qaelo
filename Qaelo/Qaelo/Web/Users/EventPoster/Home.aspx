<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/EventPoster/EventPoster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Qaelo.Web.Users.EventPoster.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Home</title>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <div class="container" style="margin-top:60px">
    <asp:Literal ID="lblVerified" runat="server"></asp:Literal>
        <asp:Literal ID="lblListOfUsers" runat="server"></asp:Literal>
  
</div>
</asp:Content>