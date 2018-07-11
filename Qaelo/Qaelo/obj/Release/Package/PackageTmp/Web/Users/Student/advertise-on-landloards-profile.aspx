<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="advertise-on-landloards-profile.aspx.cs" Inherits="Qaelo.Web.Users.Student.advertise_on_landloards_profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
	<meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
    <meta name="viewport" content="width=device-width" />

    <title>Advertise</title>
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

    <!--checkboxes -->
    <link href="../../../Content/CustomCss/checkboxes.css" rel="stylesheet" />

</head>
<body>
            <!--Nav bar-->
    <header id="header">      
        <div class="navbar navbar-inverse" role="banner" style="margin-top:-20px">
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
                             freelancer
                             <li ><a href="Accommodation.aspx"><b>Rooms</b></a></li>
                        <li><a href="Shops.aspx "><b>Shops </b></a></li>  
						<li><a href="Societies.aspx "><b>Societies </b> </a></li>  			
                           <li><a href="Companies.aspx"><b>Companies</b></a></li>  
                           <li><a href="Events.aspx "><b>Events</b> </a></li>  			
                             <li ><a href="Profile.aspx"><b>Edit Profile</b></a></li>
                        <li><a href="PostProfile.aspx"><b>Post Profile</b></a></li>
                           <li><a href="../../Account/Login.aspx?logout=true">
                               <b><asp:Literal ID="lblLogInOrOut" runat="server"></asp:Literal></b>
                               </a></li>  			
                    </ul>
                </div>
            </div>
        </div>
    </header>

        <!--Notifier-->
        <%--     <asp:Label ID="lblSuccess" style="opacity:-20" runat="server" Text=""></asp:Label>
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
                     </script>--%>
        <!--/Notifier-->
    <form runat="server" action="" method="">
         <a href='#' data-toggle='modal' data-target='#share' type='button' class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish'>Advertise</a>
    
        <!--Modal-->
                             
        <div class='modal fade' id='share' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{1}' aria-hidden='true'>
                    
            <div class='modal-dialog'>
                        
                <div class='modal-content'>
                        <div class="modal-header"><strong>Advertise</strong></div>
                            <div class='modal-body'>
                                <div class="container">
                                    <div class="col-sm-4">
                                      
                                    </div>
                                </div>
                            </div>
                
                            <div class='modal-footer'>
                                <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                <asp:Button ID="btnFinish" class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish' runat="server" Text="Publish" />
                            </div>
                        </div>
                    </div>
                </div>

        <a href='#' data-toggle='modal' data-target='#viewAdd' type='button' class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish'>Advertise</a>
        <div class='modal fade' id='viewAdd' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{2}' aria-hidden='true'>
                    
            <div class='modal-dialog'>
                        
                <div class='modal-content'>
                        <div class="modal-header"><strong>Your Ads</strong></div>
                            <div class='modal-body'>
                                <div class="container">
                                    <div class="col-sm-8">
                                         <div class="form-group">
                                          <div class="col-sm-2"><strong> Date</strong></div>
                                          <div class="col-sm-2"><strong>Type</strong></div>
                                          <div class="col-sm-2"><strong>Gender</strong></div>
                                          <div class="col-sm-2"><strong>Payment</strong></div>
                                          <div class="col-sm-2"><strong>Rant</strong></div>
                                </div>
                                    </div>
                                                                        
                                    <div class="col-sm-8">
                                          <div class="col-sm-2">25-May-2017</div>
                                          <div class="col-sm-2">Sharing</div>
                                          <div class="col-sm-2">Male</div>
                                          <div class="col-sm-2">Cash</div>
                                          <div class="col-sm-4">R1250</div>
                                    </div>
                                </div>
                            </div>
                
                            <div class='modal-footer'>
                                <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                     <a href='#' data-toggle='modal' data-target='#share' type='button' class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish'>Add New</a>
                            </div>
                        </div>
                    </div>
                </div>
            
    </form>
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
</html>