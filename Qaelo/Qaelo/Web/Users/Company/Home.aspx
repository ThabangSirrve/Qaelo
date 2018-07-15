<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Company/Company.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Qaelo.Web.Users.Company.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Home</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div class="container">
            <asp:Literal ID="lblListOfUsers" runat="server"></asp:Literal>
         </div>

</asp:Content>
