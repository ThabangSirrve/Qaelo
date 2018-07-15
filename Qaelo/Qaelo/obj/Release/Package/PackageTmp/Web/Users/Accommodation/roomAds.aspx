<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Accommodation/Accommodation.Master" AutoEventWireup="true" CodeBehind="roomAds.aspx.cs" Inherits="Qaelo.Web.Users.Accommodation.roomAds" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Student Room Ads</title>
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

            <div class="row thumbnail">
                                            
                                    <div class='col-sm-12'>
                                         <div class='form-group'>
                                          <div class='col-sm-2'><strong>Student</strong></div>
                                          <div class='col-sm-2'><strong>Number</strong></div>
                                          <div class='col-sm-2'><strong>Type</strong></div>
                                          <div class='col-sm-2'><strong>Gender</strong></div>
                                          <div class='col-sm-2'><strong>Payment</strong></div>
                                          <div class='col-sm-2'><strong>Rent</strong></div>
                                          </div>
                                   </div> 
                                    <div class='col-sm-12'><hr /> </div>  
            <asp:Literal ID="lblListOfUsers" runat="server"></asp:Literal>
                
            </div>
        </div>
</asp:Content>