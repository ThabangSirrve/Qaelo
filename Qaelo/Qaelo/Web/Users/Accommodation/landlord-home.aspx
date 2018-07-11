<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Accommodation/Accommodation.Master" AutoEventWireup="true" CodeBehind="landlord-home.aspx.cs" Inherits="Qaelo.Web.Users.Accommodation.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Home</title>
    <link href="../../../Content/CustomCss/notify/animate.css" rel="stylesheet" />
    <link href="../../../Content/CustomCss/imagehover/imagehover.css" rel="stylesheet" />
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
