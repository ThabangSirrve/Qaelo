<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SellBooks.aspx.cs" Inherits="Qaelo.Web.Users.Student.SellBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
	<meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
    <meta name="viewport" content="width=device-width" />

    <title>Post</title>
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
        <div class="navbar navbar-inverse"  role="banner">
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
    --%>
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
                        	   <b>Sell </b>Your Books<br/>
                        	</h3>
                    	</div>
                    	<ul>
                            <li><a href="#about" data-toggle="tab">Basic </a></li>
                            <li><a href="#account" data-toggle="tab">Description</a></li>
                        </ul>
                        
                        <div class="tab-content">
                            <div class="tab-pane" id="about">
                              <div class="row">
                                  <h4 class="info-text"> Basic information</h4>
                                  <div class="col-sm-6 col-sm-offset-3">
                                      <div class="form-group">
                                          <div class="col-sm-12">
                                                 <div class="form-group">
                                        <label>Select study field</label>
                                          <asp:DropDownList ID="ddlField" Width="100%" CssClass="form-control" runat="server" >
                                              <asp:ListItem disabled="" selected="" Value="N/A">- Select -</asp:ListItem>
                                              <asp:ListItem Value="ART Design and architecture">ART Design and architecture</asp:ListItem>
                                              <asp:ListItem Value="Education">Education</asp:ListItem>
                                              <asp:ListItem Value="Engineering And Build Environment">Engineering And Build Environment</asp:ListItem>
                                              <asp:ListItem Value="Finacial Sciences">Finacial Sciences</asp:ListItem>
                                              <asp:ListItem Value="Health">Health</asp:ListItem>
                                              <asp:ListItem Value="Humanities">Humanities</asp:ListItem>
                                              <asp:ListItem Value="Management">Management</asp:ListItem>
                                              <asp:ListItem Value="Law">Law</asp:ListItem>
                                              <asp:ListItem Value="Science">Science</asp:ListItem>
                                          </asp:DropDownList>
                                     </div>
                                          </div>
                                         </div>
                                  </div>

                                  <div class="col-sm-6 col-sm-offset-3">
                                      <div class="form-group">
                                          <div class="col-sm-12">
                                                 <div class="form-group">
                                        <label>Select year of study</label>
                                          <asp:DropDownList ID="ddlYear" Width="100%" CssClass="form-control" runat="server" >
                                              <asp:ListItem disabled="" selected="" Value="N/A">- Select -</asp:ListItem>
                                              <asp:ListItem Value="Bridging">Bridging</asp:ListItem>
                                              <asp:ListItem Value="1st">1st</asp:ListItem>
                                              <asp:ListItem Value="2nd">2nd</asp:ListItem>
                                              <asp:ListItem Value="3rd">3rd</asp:ListItem>
                                              <asp:ListItem Value="4th">4th</asp:ListItem>
                                              <asp:ListItem Value="Honours">Honours</asp:ListItem>
                                              <asp:ListItem Value="Masters">Masters</asp:ListItem>
                                              <asp:ListItem Value="Doctorate">Doctorate</asp:ListItem>
                                          </asp:DropDownList>
                                     </div>
                                          </div>
                                         </div>
                                  </div>
                              </div>
                            </div>

                            <div class="tab-pane" id="account">
                                       <div class="row">
                                    <div class="col-sm-12">
                                        <h4 class="info-text"> Description the book</h4>
                                    </div>
                                    <div class="col-sm-4 col-sm-offset-1">
                                       
                                            <div class="form-group">
                               
                                      <h6 class="">Book Image</h6>
                                       <img src="" class="img-thumbnail" style="height:230px;width:80%" id="image1"/>
                                       <asp:FileUpload ID="file1" CssClass="btn-blue-grey btn-sm" runat="server" />
                          
                                            </div>

                                    </div>
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                                <label>Title</label>
                                                <asp:TextBox ID="txtTitle" MaxLength="50" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                                <label>Price</label>
                                                <asp:TextBox ID="txtPrice" type="Number" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                            </div>
                                        </div>

                                        <div class="col-sm-6">
                                         <div class="form-group">
                                           <label>Book description</label>
                                             <asp:TextBox ID="txtDescription" class="form-control" placeholder="" TextMode="multiline"  Rows="6"  runat="server">
                                             </asp:TextBox>
                                          </div>
                                    </div>
                                    </div>
                            </div>
                                                                             
                            <!--Modal-->
                             <div class='modal fade' id='share' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{1}' aria-hidden='true'>
                    <div class='modal-dialog'>
                        <div class='modal-content'>
                        <div class="modal-header">Tell friend</div>
                            <div class='modal-body'>
                                <p>Please Tell 3 a friend that that you are publishing a your used textbook with us, Who knows? They may just buy or tell other friends about you</p>
                                <div class="form-group">
                                    <label>Friend's email</label>
                                    <asp:TextBox ID="txtshare1" CssClass="form-control" placeholder="Email" runat="server"></asp:TextBox><br />
                                </div>
                            </div>
                
                            <div class='modal-footer'>
                                <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
        <asp:Button ID="btnFinish" class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish' runat="server" Text="Publish" OnClick="btnFinish_Click" />
                            </div>
                        </div>
                    </div>
                </div>
                            </div>
                        <div class="wizard-footer">
                            <div class="pull-right">
                                <input type='button' class='btn btn-next btn-fill btn-warning btn-wd btn-sm' name='next' value='Next' />
                                <a href='#' data-toggle='modal' data-target='#share' type='button' class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish'>Finish</a>

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
                            
        <!-- Live Image Loader--> 
     <script>
                document.getElementById("file1").onchange = function () {
                    var reader = new FileReader();
                    reader.onload = function (e) {
                        // get loaded data and render thumbnail. 
                        document.getElementById("image1").src = e.target.result;
                        document.getElementById("imageDefault").src = e.target.result;
                    };
                    // read the image file as a data URL.
                    reader.readAsDataURL(this.files[0]);
                };

                //Image 2
                document.getElementById("file2").onchange = function () {
                    var reader = new FileReader();
                    reader.onload = function (e) {
                        // get loaded data and render thumbnail.
                        document.getElementById("image2").src = e.target.result;
                    };
                    // read the image file as a data URL.
                    reader.readAsDataURL(this.files[0]);
                };

                //Image 3
                document.getElementById("file3").onchange = function () {
                    var reader = new FileReader();
                    reader.onload = function (e) {
                        // get loaded data and render thumbnail.
                        document.getElementById("image3").src = e.target.result;
                    };
                    // read the image file as a data URL.
                    reader.readAsDataURL(this.files[0]);
                };
                </script>
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