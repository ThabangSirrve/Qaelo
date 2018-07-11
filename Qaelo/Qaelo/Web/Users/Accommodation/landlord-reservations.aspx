<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Accommodation/Accommodation.Master" AutoEventWireup="true" CodeBehind="landlord-reservations.aspx.cs" Inherits="Qaelo.Web.Users.Accommodation.reservations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Room Reservations</title>

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
            <h3 class="text-center">List of rooom reservations.</h3>
            <asp:Literal ID="lblVerified" runat="server"></asp:Literal>

            <div class="row thumbnail">
                                            
                                    <div class='col-sm-12'>
                                         <div class='form-group'>
                                          <div class='col-sm-2'><strong>Student</strong></div>
                                          <div class='col-sm-2'><strong>Move In Date</strong></div>
                                          <div class='col-sm-2'><strong>RoomNo</strong></div>
                                          <div class='col-sm-2'><strong>Documents</strong></div>
                                          <div class='col-sm-4'><strong>Action</strong></div>
                                          </div>
                                   </div> 
                                    <div class='col-sm-12'><hr /> </div>  
            <asp:Literal ID="lblListOfUsers" runat="server"></asp:Literal>
            </div>
        </div>


            <div class='modal fade' id='share' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{1}' aria-hidden='true'>
                    
            <div class='modal-dialog modal-lg'>
                <div class='modal-content'>
                        <div class="modal-header"><strong>Advertise</strong></div>
                            <div class='modal-body'>
                                <div class="container">
                                    <div class="col-sm-4">
                                        <asp:Literal ID="lblDocuments" runat="server"></asp:Literal>
                                    </div>
                                </div>
                            </div>
                
                            <div class='modal-footer'>
                                <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                            </div>
                        </div>
                    </div>
                </div>
</asp:Content>
