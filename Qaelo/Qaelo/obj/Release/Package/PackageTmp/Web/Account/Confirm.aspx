<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Account/Account.Master" AutoEventWireup="true" CodeBehind="Confirm.aspx.cs" Inherits="Qaelo.Web.Account.Confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Confirm Email</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div class="login-page">
  <div class="form">
        <h3>Email Confirmation</h3>
        <div class="container">
            <asp:Label ID="lblConfirmMessage" runat="server" Text=""></asp:Label>
          
             </div>
  </div>
</div>
</asp:Content>
