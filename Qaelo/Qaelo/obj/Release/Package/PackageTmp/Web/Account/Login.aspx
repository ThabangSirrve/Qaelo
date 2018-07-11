<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Account/Account.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Qaelo.Web.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Login</title>
    <style>
         /*Base for label styling */
[type="checkbox"]:not(:checked),
[type="checkbox"]:checked {
  position: absolute;
  left: -9999px;
}
[type="checkbox"]:not(:checked) + label,
[type="checkbox"]:checked + label {
  position: relative;
  padding-left: 1.95em;
  cursor: pointer;
}

/* checkbox aspect */
[type="checkbox"]:not(:checked) + label:before,
[type="checkbox"]:checked + label:before {
  content: '';
  position: absolute;
  left: 0; top: 0;
  width: 1.25em; height: 1.25em;
  border: 2px solid #ccc;
  background: #fff;
  border-radius: 4px;
  box-shadow: inset 0 1px 3px rgba(0,0,0,.1);
}
/* checked mark aspect */
[type="checkbox"]:not(:checked) + label:after,
[type="checkbox"]:checked + label:after {
  content: '✔';
  position: absolute;
  top: .1em; left: .3em;
  font-size: 1.3em;
  line-height: 0.8;
  color: #09ad7e;
  transition: all .2s;
}
/* checked mark aspect changes */
[type="checkbox"]:not(:checked) + label:after {
  opacity: 0;
  transform: scale(0);
}
[type="checkbox"]:checked + label:after {
  opacity: 1;
  transform: scale(1);
}

/* accessibility */
[type="checkbox"]:checked:focus + label:before,
[type="checkbox"]:not(:checked):focus + label:before {

}
</style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


            <!--Notifier-->
     <asp:Label ID="lblSuccess" style="opacity:-20" runat="server" Text=""></asp:Label>
             <script type="text/javascript">
            (function ($)
            {
                var success = $('#<%=lblSuccess.ClientID%>').text();

                if (success.length) {
                    $.notify(success, { type: "success" });
            }
            })(jQuery);
             </script>
    
     <asp:Label ID="lblErrorMessage" style="opacity:-20" runat="server" Text=""></asp:Label>

        <div class="login-page">
  <div class="form">
        <h1 class="text-center message" style="margin-top:-20px"><a href="#"><b style="font-size:xx-large"> Qaelo Sign in</b></a> </h1>
        <h6 class="message">Please enter your credentials</h6><br />
        <asp:TextBox ID="txtEmail" runat="server" placeholder="Email"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" type="password" placeholder="Password "></asp:TextBox>
    <%--<input type="checkbox" id="rememberMe"/>--%>
    <%--<label for="rememberMe" class="pull-left">Remember Me</label>--%>

      <asp:Button ID="btnLogin" style="background:#d89b4e" class="button" runat="server" Text="Sign In" OnClick="btnLogin_Click" />
      <p class="message">Forgot password? click <a href="SendPasswordRecovery.aspx">here</a></p>
      <p class="message"> <a href="Registration.aspx" class="pull-left">Create Account</a> <a href="../../index.html" class="pull-right">Home</a></p>
       
  </div>
</div>

       <br /><br /><br /><br />
    
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
</asp:Content>