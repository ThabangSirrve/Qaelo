<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="students-book-a-room.aspx.cs" Inherits="Qaelo.Web.Users.Student.students_book_a_room" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Book a room</title>
        <link href="http://netdna.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.css" rel="stylesheet"/>

    <link href="../../../Content/CustomCss/Profile/assets/css/gsdk-base.css" rel="stylesheet" />
    <link href="../../../Template/Wizard/style.css" rel="stylesheet" />
    <script src="../../../Template/Wizard/script.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <section style="background:#efefe9;">
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
            <div class="col-sm-12">
                <div class="board">
                    <!-- <h2>Welcome to IGHALO!<sup>™</sup></h2>-->
                    <div class="board-inner">
                    <ul class="nav nav-tabs" id="myTab">
                    <div class="liner"></div>
                     <li class="active">
                     <a href="#home" data-toggle="tab" >
                      <span class="round-tabs one">
                              <i class="glyphicon glyphicon-home"></i>
                      </span> 
                  </a></li>

                  <li><a href="#profile" data-toggle="tab" >
                     <span class="round-tabs two">
                         <i class="glyphicon glyphicon-file"></i>
                     </span> 
           </a>
                 </li>

                 <li><a href="#messages" data-toggle="tab" >
                     <span class="round-tabs three">
                          <i class="glyphicon glyphicon-book"></i>
                     </span> </a>
                     </li>
                               
                                      
                        <li>
                     <a>
                      <span class="round-tabs one">
                              <i class="glyphicon glyphicon-picture"></i>
                      </span> 
                  </a></li>

                     <li><a href="#doner" data-toggle="tab" title="completed">
                         <span class="round-tabs five">
                              <i class="glyphicon glyphicon-ok"></i>
                         </span> </a>
                     </li>
                     
                     </ul></div>

                     <div class="tab-content">
                      <div class="tab-pane fade in active" id="home">
                              <h3 class="head text-center" style="margin-top:-30px">Book a room</h3>
                                    <!-- Content here-->
                          <div class="container-fluid">
                                    <div class="col-sm-12">
                                        <label>Please note that you are only allowed to reserve a room that you have viewed or a trusted person has viewed on your behalf unles the room in question is internal resiidence of a university</label>
                                    </div>
                                    <div class="col-sm-12">
                                        <div class="col-sm-6">
                                        <br />
                                                  
                                            <label>I'm Sponsored by:</label>      
                                            <asp:DropDownList ID="ddlSponsor" Width="100%" CssClass="form-control" runat="server" >
                                              <asp:ListItem disabled="" selected="" Value="NONE">- Select -</asp:ListItem>
                                              <asp:ListItem Value="Family">Family</asp:ListItem>
                                              <asp:ListItem Value="Friend">Friend</asp:ListItem>
                                              <asp:ListItem Value="Student Loan">Student Loan</asp:ListItem>
                                              <asp:ListItem Value="Eduloan">Eduloan</asp:ListItem>
                                              <asp:ListItem Value="Bursary">Bursary</asp:ListItem>
                                          </asp:DropDownList>                     


                                            <label>Please enter room number if available</label>
                                             <asp:TextBox ID="txtRoomNo" class="form-control" placeholder="Room number"  runat="server">
                                             </asp:TextBox>


                                        </div>

                                        <div class="col-sm-6">
                                            <div class="row"><br /><strong></strong>
                                            <label>Have you seen the room?</label>      
                                            <asp:DropDownList ID="ddlSeenRoom" Width="100%" CssClass="form-control" runat="server" >
                                              <asp:ListItem disabled="" selected="" Value="NONE">- Select -</asp:ListItem>
                                              <asp:ListItem Value="true">Yes</asp:ListItem>
                                              <asp:ListItem Value="false">No</asp:ListItem>
                                          </asp:DropDownList>

                                            <label>Is the room available?</label>      
                                                <asp:DropDownList ID="ddlRoomAvailable" Width="100%" CssClass="form-control" runat="server" >
                                              <asp:ListItem disabled="" selected="" Value="NONE">- Select -</asp:ListItem>
                                              <asp:ListItem Value="true">Yes</asp:ListItem>
                                              <asp:ListItem Value="false">No</asp:ListItem>
                                          </asp:DropDownList>


                                           <label>Home Address</label>
                                             <asp:TextBox ID="txtPostalAddress" class="form-control" placeholder="Postal Address"  runat="server">
                                             </asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                <//div>
                              <p class="text-center">
                                  <a href="#profile" data-toggle="tab" class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                              </p>

                      </div>
                        </div>
                      <div class="tab-pane fade" id="profile">
                          <h3 class="head text-center" style="margin-top:-30px">Upload supporting documents</h3>
                        <!-- Content here-->
                          <div class="row">
                                    <div class="col-sm-6 col-sm-offset-3">
                                        <strong> Salary Advice</strong>
                                        <asp:FileUpload ID="fuSalary" CssClass="form-control" runat="server" />
                                                                                <strong>3 Months bank statement</strong>
                                        <asp:FileUpload ID="fuBankStatement" CssClass="form-control" runat="server" />

                                                                                <strong>Guardian's Certified Id</strong>
                                        <asp:FileUpload ID="fuGuardianId" CssClass="form-control" runat="server" />
                                                                                <strong>Your ID</strong>
                                        <asp:FileUpload ID="fuID" CssClass="form-control" runat="server" />
                                    </div>
                                </div>
                          <p class="text-center">
                           <a href="#home" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
                           <a href="#messages" data-toggle="tab"  class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                          </p>

                      </div>

                      <div class="tab-pane fade" id="messages">
                              <h3 class="head text-center">Terms and conditions</h3>
                           <!-- Content here-->
                          <div class="row">
                                  <div class="col-sm-4 col-sm-offset-4">
                                       <label>Please pick a move in date</label><br />
                                       <asp:TextBox ID="txtMoveInDate" type="date" CssClass="form-control" runat="server"></asp:TextBox>
                                  <br />
                                   
                                  <label>Please read our terms and condition</label><br />
                                  <a href='#' data-toggle='modal' data-target='#share' type='button' class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish'>Terms of Stay</a>
                                                              <!--Modal-->
                             <div class='modal fade' id='share' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{1}' aria-hidden='true'>
                    <div class='modal-dialog'>
                        <div class='modal-content'>
                        <div class="modal-header">Terms Of Stay(Example)</div>
                            <div class='modal-body'>
                                <div class="form-group">
                                  <p>Insurance:To avoid any misunderstanding, a booking constitutes a binding 
                                    contract. All guests confirming a booking are advised to take out insurance
                                    to cover the cost of their accommodation in the event of a cancellation. Centre 
                                    Court bed and breakfast will seek full payment for any cancelled accommodation
                                    that cannot be re-let, including premature curtailment of stay. 

                                    A 50% deposit is required to secure a booking. The balance is payable on arrival. 

                                    Deposits are not refundable in the event of non arrival. 

                                    Our policy in terms of cancellations is as follows: 

                                    No persons other than those quoted for and booked are permitted to share the accommodation. In the event that it is possible to accommodate any extra person/s in the same room, an additional charge will become payable. The final decision regarding the accommodation of additional persons in the same room rests entirely with the proprietors or agents of Centre Court Bed and Breakfast. 

                                    Payment methods: Visa or Mastercard credit cards are acceptable. Cash payments or Internet Transfer. 

                                Confirmation of Booking: The Terms and Conditions of a booking are deemed as being accepted on receipt by Centre Court of the deposit. Centre Court reserves the right to change any prices quoted without incurring obligations unless the correct deposit has been received.</p>

                                </div>
                            </div>
                
                            <div class='modal-footer'>
                                <button  class='btn btn-default pull-left' data-dismiss='modal'>Decline</button>
                                
                                <asp:Button ID="Button1" class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish' runat="server" Text="Accept" OnClick="Button1_Click" />
                            </div>
                        </div>
                         </div>
                    </div>
                </div>
                                  
                              </div>
                          <p class="text-center">
                           <a href="#profile" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
                           <%--<a href="#doner" data-toggle="tab"  class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>--%>
                          </p>
                      </div>

                      

                      <div class="tab-pane fade" id="doner">
                          <div class="text-center">
                            <i class="img-intro icon-checkmark-circle"></i>
                        </div>
                        <h3 class="head text-center">Save your booking</h3>
                          <p class="text-center">
                            <asp:Button ID="Button2" class="btn btn-success btn-outline-rounded green" runat="server" Text="OK" OnClick="Button1_Click" />
                          </p>
                        </div>
                        <div class="clearfix"></div>
                    </div>

            </div>
            
        </div>
            
            </section>
</asp:Content>
