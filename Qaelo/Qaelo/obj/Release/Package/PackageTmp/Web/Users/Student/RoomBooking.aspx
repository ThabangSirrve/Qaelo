<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoomBooking.aspx.cs" Inherits="Qaelo.Web.Users.Student.RoomBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
	<meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
    <meta name="viewport" content="width=device-width" />

    <title>Profile</title>
    <!-- Css for Profile page-->
    <link href="../../../Content/CustomCss/Profile/assets/css/bootstrap.min.css" rel="stylesheet" />

            <link href="../../../Content/Qaelo%20template/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/font-awesome.min.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/animate.min.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/lightbox.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/main.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/responsive.css" rel="stylesheet" />

    <link href="http://netdna.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.css" rel="stylesheet"/>

    <link href="../../../Content/CustomCss/Profile/assets/css/gsdk-base.css" rel="stylesheet" />
        <!--Notify -->
    <link href="../../../Content/CustomCss/notify/animate.css" rel="stylesheet" />
    <script src="../../../Content/Qaelo%20template/js/jquery.js"></script>
    <script src="../../../Content/Qaelo%20template/js/bootstrap.min.js"></script>
    <script src="../../../Content/CustomCss/notify/dist/bootstrap-notify.js"></script>
    <!--/Notify -->
</head>
<body>
            <!--Nav bar-->
    <header id="header">      
        <div class="navbar navbar-inverse" role="banner" >
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="../../../index.html">
                    	<h2 style="color:#d89b4e"><strong> Qaelo</strong></h2>
                    </a>
                </div>
                <div class="collapse navbar-collapse">
                    <ul class="nav navbar-nav navbar-right">
                             <li ><a href="StudentProfile.aspx"><b>My Profile</b></a></li>  			
                             <li ><a href="freelancers.aspx"><b>Freelancers</b></a></li>  			
                             <li ><a href="usedtextbooks.aspx"><b>Used books</b></a></li>  			
                        <li><a href="Shops.aspx "><b>Shops </b></a></li>  
                        <li ><a href="Accommodation.aspx"><b>Rooms</b></a></li>
                           <li><a href="Events.aspx "><b>Events</b> </a></li>  			
                           <!--<li><a href="Companies.aspx"><b>Jobs</b></a></li>-->  
						<li><a href="Societies.aspx "><b>Societies </b> </a></li>  		
                    </ul>
                </div>
            </div>
        </div>
    </header>

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
        <!--   Big container   -->
    <div class="container">
        <div class="row">
        <div class="col-sm-8 col-sm-offset-2">
            <!--      Wizard container        -->   
             <br />
                <div class="card wizard-card ct-wizard-orange" id="wizardProfile">
                    <form runat="server" action="" method="">
                <!--        You can switch "ct-wizard-orange"  with one of the next bright colors: "ct-wizard-blue", "ct-wizard-green", "ct-wizard-orange", "ct-wizard-red"             -->
                
                    	<div class="wizard-header">
                        	<h3>
                        	   <b>RESERVE</b> A ROOM<br/>
                        	</h3>
                    	</div>
                    	<ul>
                            <li><a href="#address" data-toggle="tab">Personal Details</a></li>
                            <li><a href="#account" data-toggle="tab">Documents</a></li>
                            <li><a href="#about" data-toggle="tab">Agreement</a></li>
                        </ul>
                        
                        <div class="tab-content">
                            <div class="tab-pane" id="address">
                                <div class="row">
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
                                              <asp:ListItem Value="NSFAS">NSFAS</asp:ListItem>
                                              <asp:ListItem Value="Eduloan">Eduloan</asp:ListItem>
                                              <asp:ListItem Value="Bursary">Bursary</asp:ListItem>
                                          </asp:DropDownList>                     
                                            <label>FullName</label>
                                             <asp:TextBox ID="txtFullName" class="form-control" placeholder="Name and Surname"  runat="server">
                                             </asp:TextBox>

                                            <label>Contact Number</label>
                                             <asp:TextBox ID="txtNumber" type="number" class="form-control" placeholder="Contact Number"  runat="server">
                                             </asp:TextBox>
                                                                                        
                                            <label>Email Address</label>
                                             <asp:TextBox ID="txtEmail" type="email" class="form-control" placeholder="Email Address"  runat="server">
                                             </asp:TextBox>
                                                                                        
                                            <label>Home Address</label>
                                             <asp:TextBox ID="txtPostalAddress" class="form-control" placeholder="Postal Address"  runat="server">
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

                                                                                           
                                                 <label>Please enter room number if available</label>
                                             <asp:TextBox ID="txtRoomNo" class="form-control" placeholder="Room number"  runat="server">
                                             </asp:TextBox>

                                            </div>
                                        </div>
                                    </div>
                                <//div>
                                </div>
                            </div>

                            <div class="tab-pane" id="account">
                                <h4 class="info-text"> Please upload the following </h4>
                                                                
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
                            </div>
                        
                            <div class="tab-pane" id="about">
                              <div class="row">
                                  <h4 class="info-text"> Terms</h4>
                                  <div class="col-sm-4 col-sm-offset-3">
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
                                <asp:Button ID="Button1" class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish' runat="server" Text="Accept" OnClick="btnFinish_Click" />
                            </div>
                        </div>
                         </div>
                    </div>
                </div>
                                  
                              </div>
                            </div>
                        </div>
                        <div class="wizard-footer">
                            <div class="pull-right">
                                <input type='button' class='btn btn-next btn-fill btn-warning btn-wd btn-sm' name='next' value='Next' />
                            </div>
                            <div class="pull-left">
                                <input type='button' class='btn btn-previous btn-fill btn-default btn-wd btn-sm' name='previous' value='Previous' />
                            </div>
                            <div class="clearfix"></div>
                        </div>
            </form>
                </div>
        </div>
        </div><!-- end row -->
                    
                                                 
     <!--  big container -->
</body>

<script src="../../../Content/CustomCss/Profile/assets/js/jquery-1.10.2.js"></script>
<script src="../../../Content/CustomCss/Profile/assets/js/bootstrap.min.js"></script>
		
	<!--   plugins 	 -->
<script src="../../../Content/CustomCss/Profile/assets/js/jquery.bootstrap.wizard.js"></script>
	
    <!--  More information about jquery.validate here: http://jqueryvalidation.org/	 -->
<script src="../../../Content/CustomCss/Profile/assets/js/jquery.validate.min.js"></script>
	
    <!--  methods for manipulating the wizard and the validation -->
<script src="../../../Content/CustomCss/Profile/assets/js/wizard.js"></script>
        <!-- Css for Template -->
    <script src="../../../Content/Qaelo%20template/js/lightbox.min.js"></script>
    <script src="../../../Content/Qaelo%20template/js/wow.min.js"></script>
    <script src="../../../Content/Qaelo%20template/js/main.js"></script>
        <!-- /Css for Template -->


</html>
