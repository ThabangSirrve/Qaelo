<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Accommodation/Accommodation.Master" AutoEventWireup="true" CodeBehind="landlord-room-ads.aspx.cs" Inherits="Qaelo.Web.Users.Accommodation.roomAds" %>
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
        <h3 class="text-center">Room Ads</h3>
        </div>

        <div class="container">
            <asp:Literal ID="lblVerified" runat="server"></asp:Literal>

                <div style="overflow-x:auto;">
            <div class="col-sm-12">
                <table class="table table-responsive table-bordered table-striped">
                                        <thead>
                                            <tr class="success">
                                                <th>Student</th>
                                                <th>Number</th>
                                                <th>Type</th>
                                                <th>Gender </th>
                                                <th>Payment</th>
                                                <th>Rent</th>  
                                            </tr>
                                    </thead>
                                        <tbody>
                                                <asp:Literal ID="lblAds" runat="server"></asp:Literal>
                                        </tbody>
                                    </table>
            </div>
                    </div>
        </div>
</asp:Content>