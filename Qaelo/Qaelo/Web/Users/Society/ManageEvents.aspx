<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Society/Society.Master" AutoEventWireup="true" CodeBehind="ManageEvents.aspx.cs" Inherits="Qaelo.Web.Users.Society.Managestudents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Manage Events</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            <div class="col-lg-12">
            <asp:Literal ID="listOfEvents" runat="server"></asp:Literal>
            
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

                        <script>
                $(document).ready(function(){
                    $('[data-toggle="tooltip"]').tooltip(); 
                });
            </script> 
    </div>
        </div>
</asp:Content>
