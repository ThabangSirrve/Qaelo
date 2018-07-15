<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Account/Account.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Qaelo.Web.Account.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Registration</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Notifier-->
         <asp:Label ID="lblErrorMessage" style="opacity:-20" runat="server" Text=""></asp:Label>
         <script type="text/javascript">
            (function ($)
            {
                var error = $('#<%=lblErrorMessage.ClientID%>').text();

                if (error.length > 5) {
                    $.notify(error, {
                        type: "danger", animate: {
                            enter: 'animated bounceIn',
                            exit: 'animated bounceOut'
                        }
                    });
            }
            })(jQuery);
             </script>
    <!--/Notifier-->
        <div class="login-page">
  <div class="form">
      <h3 class="text-center message" style="margin-top:-20px"><a href="#"><b style="font-size:xx-large">Create a Profile
</b></a> </h3>
      <h6 class="message">Please complete the form below</h6><br />
      <asp:DropDownList id="ddlUser" runat="server" AutoPostBack="true" CssClass="dropdownlist">
          <asp:ListItem Value="NONE" disabled="" Selected="">Please Select Profile</asp:ListItem>
          <asp:ListItem Value="Student">Freelancer</asp:ListItem>
          <asp:ListItem Value="Property">Property Manager</asp:ListItem>
          <asp:ListItem Value="Shop">Shop Manager</asp:ListItem>
          <asp:ListItem Value="Event">Events Manager</asp:ListItem>
          <%--<asp:ListItem Value="Company">Company HR</asp:ListItem>--%>
          <%--<asp:ListItem Value="Society">Group Manager</asp:ListItem>--%>
      </asp:DropDownList>
        <asp:TextBox ID="txtFirstName" runat="server" placeholder="Name"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" placeholder="Surname"></asp:TextBox>
        <asp:TextBox ID="txtEmail" type="email" runat="server" placeholder="Email adress"></asp:TextBox>
        <asp:TextBox ID="txtPassword" type="password" runat="server" placeholder="Password "></asp:TextBox>
      
      <br />
      <asp:Button ID="btnRegister" style="background:#d89b4e" class="button" runat="server" Text="Create Profile" OnClick="btnRegister_Click" />
      <p class="message">By clicking "Create Profile" I agree to Qaelo's <a href="TermsOfUse.aspx" target="_blank">Terms of Service</a> and <a href="PrivacyPolicy.aspx" target="_blank">Privacy Policy</a></p>
      <p class="message">Already registered? <a href="tempLogin.aspx">Sign In</a><a href="../../" class="pull-right">Home</a></p><br />

  </div>
</div>
</asp:Content>