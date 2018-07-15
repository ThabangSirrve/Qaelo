<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Qaelo.Web.Users.Accommodation.Profile" %>

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
        <div class="navbar navbar-inverse" role="banner">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>

                    <a class="navbar-brand" href="../../../index.html" style="margin-top:-20px">
                    	<h4 style="color:#d89b4e"><strong> Qaelo</strong></h4>
                    </a>
                </div>
                <div class="collapse navbar-collapse">
                    <ul class="nav navbar-nav navbar-right">
                             <li ><a href="Home.aspx">Home</a></li>
                             <li ><a href="roomAds.aspx">Ads <span style="margin-left:3px"class="badge pull-right"><asp:Label ID="lblNoOfAds" runat="server" Text="0"></asp:Label></span></a></li>
                             <li ><a href="reservations.aspx">Reservations <span style="margin-left:3px" class="badge pull-right"><asp:Label ID="lblNoOfReservations" runat="server" Text="0"></asp:Label></span></a></li>
                             <li ><a href="ListRoom.aspx">List Room</a></li>
                             <li ><a href="MyListings.aspx">Manage Rooms</a></li>
                             <li ><a href="Profile.aspx">Edit Profile</a></li>
                        <li><a href="../../Account/Login.aspx?logout=true">Logout</a></li> 						
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
                <div class="card wizard-card ct-wizard-orange" id="wizardProfile">
                    <form runat="server" action="" method="">
                <!--        You can switch "ct-wizard-orange"  with one of the next bright colors: "ct-wizard-blue", "ct-wizard-green", "ct-wizard-orange", "ct-wizard-red"             -->
                
                    	<div class="wizard-header">
                        	<h3>
                        	   <b>CREATE</b> YOUR PROFILE <br/>
                        	</h3>
                    	</div>
                    	<ul>
                            <li><a href="#about" data-toggle="tab">About</a></li>
                            <li><a href="#account" data-toggle="tab">Account</a></li>
                            <li><a href="#address" data-toggle="tab">Business</a></li>
                        </ul>
                        
                        <div class="tab-content">
                            <div class="tab-pane" id="about">
                              <div class="row">
                                  <h4 class="info-text"> Basic information</h4>
                                  <div class="col-sm-4 col-sm-offset-1">
                                     <div class="picture-container">
                                          <div class="picture">
                                              <img  src="../../../Images/Users/Accommodation/defaultProfilePic.jpg" class="picture-src" runat="server" id="wizardPicturePreview" title=""/>
                                              <asp:FileUpload ID="wizardPicture" runat="server" />
                                          </div>
                                          <h6>Choose Picture</h6>
                                      </div>
                                  </div>
                                  <div class="col-sm-6">
                                      <div class="form-group">
                                        <label>First Name <small>(required)</small></label>
                                          <asp:TextBox ID="txtName" name="firstname" type="text" class="form-control" placeholder="My name is..." runat="server"></asp:TextBox>
                                      </div>
                                      <div class="form-group">
                                        <label>Last Name <small>(required)</small></label>
                                          <asp:TextBox ID="txtLastName" name="lastname" type="text" class="form-control" placeholder="My surname is..." runat="server"></asp:TextBox>
                                      </div>
                                  </div>

                                  <div class="col-sm-12">
                                      <div class="col-sm-5">
                                          <div class="form-group">
                                              <label>Email <small></small></label>
                                              <asp:TextBox ID="txtEmail" disabled="" name="email" type="email" class="form-control" placeholder="me@gmail.com" runat="server"></asp:TextBox>
                                          </div>
                                      </div>
                                      <div class="col-sm-6">
                                      <div class="form-group">
                                        <label>Contact number <small>(required)</small></label>
                                          <asp:TextBox ID="txtNumber" name="number" type="number" class="form-control" placeholder="072.." runat="server"></asp:TextBox>
                                      </div>
                                          
                                      </div>

                                  </div>
                              </div>
                            </div>

                            <div class="tab-pane" id="account">
                                <h4 class="info-text"> Update your Password</h4>
                                <div class="row">
                                    <div class="col-sm-7 col-sm-offset-2">
                                         <div class="form-group">
                                            <%--<label>Current Password</label>--%>
                                             <asp:TextBox ID="txtCurrentPassword" type="password" class="form-control" placeholder="Cuurent password" runat="server"></asp:TextBox>
                                          </div>
                                    </div>
                                    <div class="col-sm-7 col-sm-offset-2">
                                         <div class="form-group">
                                            <%--<label>New Password</label>--%>
                                             <asp:TextBox ID="txtNewPassword" type="password" class="form-control" placeholder="New password" runat="server"></asp:TextBox>
                                          </div>
                                    </div>
                                     <div class="col-sm-7 col-sm-offset-2">
                                         <div class="form-group">
                                            <%--<label>Confirm Password</label>--%>
                                             <asp:TextBox ID="txtConfirmPassword" type="password" class="form-control" placeholder="Confirm Password" runat="server"></asp:TextBox>
                                          </div>
                                    </div>
                                    
                                                                         
                                    <div class="col-sm-7 col-sm-offset-2">
                                         <div class="form-group">
                                            <%--<label>Confirm Password</label>--%>
                                             <asp:Button ID="btnUpdate" class="btn btn-info pull-right" runat="server" Text="update" OnClick="btnUpdate_Click" />
                                          </div>
                                    </div>
                                </div>
                            </div>

                            <div class="tab-pane" id="address">
                                <div class="row">
                                    <div class="col-sm-12">
                                        <h4 class="info-text"> About your accommodation </h4>
                                    </div>
                                    <div class="col-sm-6 col-sm-offset-1">
                                         <div class="form-group">
                                            <label>Name of accommodation property</label>
                                             <asp:TextBox ID="txtAccommodationName" type="text" class="form-control" placeholder="Name of your property" runat="server"></asp:TextBox>
                                          </div>
                                    </div>
                                    <div class="col-sm-4">
                                      <div class="form-group">
                                          <label>Is it NSFAS accredited?</label>
                                          <asp:DropDownList class="form-control" ID="ddlAccredited" runat="server">
                                              <asp:ListItem disabled="" selected="">- response -</asp:ListItem>
                                              <asp:ListItem Value="true">Yes</asp:ListItem>
                                              <asp:ListItem Value="false">No</asp:ListItem>
                                          </asp:DropDownList>
                                      </div>
                                    </div>
                                    <div class="col-sm-6 col-sm-offset-1">
                                         <div class="form-group">
                                         <label>Small description about the property. </label>
                                             <asp:TextBox ID="txtDescription" class="form-control" placeholder="" TextMode="multiline"  Rows="6"  runat="server">

                                             </asp:TextBox>
                                          </div>
                                    </div>
                                    <div class="col-sm-4">
                                         <div class="form-group">
                                            <label>Facebook Link</label>
                                            <asp:TextBox ID="txtFacebookLink" CssClass="form-control" placeholder="paste facebook link here" runat="server"></asp:TextBox>
                                          </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="wizard-footer">
                            <div class="pull-right">
                                <input type='button' class='btn btn-next btn-fill btn-warning btn-wd btn-sm' name='next' value='Next' />
                                <asp:Button ID="btnFinish" class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish' runat="server" Text="Finish" OnClick="btnFinish_Click" />
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
        
    </div>

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
