
<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Shop/Shop.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Qaelo.Web.Users.Shop.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Home</title>
                    <!--Notify -->
    <link href="../../../Content/CustomCss/notify/animate.css" rel="stylesheet" />
    <script src="../../../Content/Qaelo%20template/js/jquery.js"></script>
    <script src="../../../Content/Qaelo%20template/js/bootstrap.min.js"></script>
    <script src="../../../Content/CustomCss/notify/dist/bootstrap-notify.js"></script>
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
    <div class="container">
         <asp:Literal ID="lblVerified" runat="server"></asp:Literal>
            <asp:Literal ID="lblListOfUsers" runat="server"></asp:Literal>
       
         </div>
</asp:Content>
