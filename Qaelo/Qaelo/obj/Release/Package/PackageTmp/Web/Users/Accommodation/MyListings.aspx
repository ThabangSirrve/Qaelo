<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Accommodation/Accommodation.Master" AutoEventWireup="true" CodeBehind="MyListings.aspx.cs" Inherits="Qaelo.Web.Users.Accommodation.MyListings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>My Rooms</title>

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
	        <div class="col-md-12"> 
	        <h3 class="text-center">List Of My Rooms.</h3>
              <h4 class="text-center"> <small>The following are list of the rooms listed by you</small></h4>
              <hr/>
            </div>
    </div>
        <div class="container">
    <div class="row">
        <asp:Literal ID="lblListOfRooms" runat="server"></asp:Literal>
    </div>
</div>
</asp:Content>
