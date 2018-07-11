<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="Qaelo.Web.Users.Student.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

   	<meta charset="utf-8" />
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
	<meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
    <meta name="viewport" content="width=device-width" />
	<title>Profile</title>
     <script type="application/x-javascript">
        addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
               function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- //for-mobile-apps -->
    <link href="../../../Template/css/bootstrap.css" rel="stylesheet" />
    <link href="../../../Template/css/popuo-box.css" rel="stylesheet" />
    <link href="../../../Template/css/style.css" rel="stylesheet" />
    <%--<script src="../../../Template/js/jquery-2.1.4.min.js"></script>--%>
     <script src="../../../Scripts/jquery.min.js"></script>
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" integrity="sha384-wvfXpqpZZVQGK6TAh5PVlGOfQNHSoD2xbE+QkPxCAFlNEevoEH3Sl0sibVcOQVnN" crossorigin="anonymous">
    <!-- //js -->
    <link href='//fonts.googleapis.com/css?family=Cabin:400,400italic,500,500italic,600,600italic,700,700italic' rel='stylesheet' type='text/css'>
    <link href='//fonts.googleapis.com/css?family=Open+Sans:400,300,300italic,400italic,600,600italic,700,700italic,800,800italic' rel='stylesheet' type='text/css'>
    <!-- start-smoth-scrolling -->
    <script src="../../../Template/js/move-top.js"></script>
    <script src="../../../Template/js/easing.js"></script>
    <script type="text/javascript">
	jQuery(document).ready(function($) {
		$(".scroll").click(function(event){
			event.preventDefault();
			$('html,body').animate({scrollTop:$(this.hash).offset().top},1000);
		});
	});
    </script>
    <!-- start-smooth-scrolling -->
    <link href="../../../Template/Wizard/style.css" rel="stylesheet" />

    <script src="../../../Template/js/jquery-2.1.4.min.js"></script>
    
   <script src="../../../Template/js/bootstrap.js"></script>
</head>
<body>
    <div class="banner2">
        <div class="container">
            <nav class="navbar navbar-default">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <div class="logo">
                        <h3 style="margin-top:10px"; ><a class="navbar-brand" href="../../../default.aspx">Qaelo</a></h3>
                    </div>
                </div>

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class="collapse navbar-collapse nav-wil" id="bs-example-navbar-collapse-1">
                    <nav class="link-effect-2" id="link-effect-2">
                        <ul class="nav navbar-nav">
                             <li ><a href="students-profile.aspx">My Profile</a></li>  			
                            <li><a href="students-freelancers.aspx">FIND A FREELANCER</a></li>
                            <li><a href="students-shops.aspx">SHOPS</a></li>
                            <li><a href="student-accommodation.aspx" >ROOMS</a></li>
                            <li><a href="students-events.aspx">Events & AUditions</a></li>
                            <li><a href="students-buy-textbooks.aspx">BUY BOOKS</a></li>
                        </ul>
                    </nav>
                </div>
                <!-- /.navbar-collapse -->
            </nav>
        </div>
    </div>

    <section style="background:#efefe9;">
        <div class="container">
            <div class="row">
                <div class="board">
                    <!-- <h2>Welcome to IGHALO!<sup>™</sup></h2>-->
                    <div class="board-inner">
                    <ul class="nav nav-tabs" id="myTab">
                    <div class="liner"></div>
                     <li class="active">
                     <a href="#home" data-toggle="tab" title="welcome">
                      <span class="round-tabs one">
                              <i class="glyphicon glyphicon-home"></i>
                      </span> 
                  </a></li>

                  <li><a href="#profile" data-toggle="tab" title="profile">
                     <span class="round-tabs two">
                         <i class="glyphicon glyphicon-blackboard"></i>
                     </span> 
           </a>
                 </li>
                 <li><a href="#messages" data-toggle="tab" title="">
                     <span class="round-tabs three">
                          <i class="glyphicon glyphicon-book"></i>
                     </span> </a>
                     </li>

                     <li><a href="#settings" data-toggle="tab" title="">
                         <span class="round-tabs four">
                              <i class="glyphicon glyphicon-bookmark"></i>
                         </span> 
                     </a></li>

                     <li><a href="#doner" data-toggle="tab" title="completed">
                         <span class="round-tabs five">
                              <i class="glyphicon glyphicon-ok"></i>
                         </span> </a>
                     </li>
                     
                     </ul>

                    </div>

                     <div class="tab-content">
                      <div class="tab-pane fade in active" id="home">
                              <h3 class="head text-center">Create an advertisement</h3>
                              <p class="narrow text-center">
                                 Please fill all the fields below.
                              </p>

                                    <!-- Content here-->

                              <p class="text-center">
                                  <a href="#profile" data-toggle="tab" class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                              </p>
                      </div>

                      <div class="tab-pane fade" id="profile">
                          <h3 class="head text-center">Advert Image</h3>
                          <p class="narrow text-center">
                             Please upload  image for the advertisment.
                          </p>
                        <!-- Content here-->
                          <p class="text-center">
                           <a href="#home" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
                           <a href="#messages" data-toggle="tab"  class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                          </p>

                      </div>

                      <div class="tab-pane fade" id="messages">
                              <h3 class="head text-center">Small description about the Shop.</h3>
                          
                           <!-- Content here-->
                          <p class="text-center">
                           <a href="#profile" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
                           <a href="#settings" data-toggle="tab"  class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                          </p>
                      </div>

                      <div class="tab-pane fade" id="settings">
                          <h3 class="head text-center">Choose the length of the advertisement</h3>
<%--                          <p class="narrow text-center">
                              Please choose the length and cost of the advertisement.
                          </p>--%>
                                             <!-- Content here-->
                          
                      </div>

                      <div class="tab-pane fade" id="doner">
                          <div class="text-center">
                            <i class="img-intro icon-checkmark-circle"></i>
                        </div>
                        <h3 class="head text-center">thanks for advertising</h3>
                          <p class="text-center">
                            <asp:Button ID="Button1" class="btn btn-success btn-outline-rounded green" runat="server" Text="Submit" OnClick="btnFinish_Click" />
                          </p>
                        </div>
                        <div class="clearfix"></div>
                    </div>

            </div>
            </div>
            </div>
            </section>
                   



<script>
    $(function () {
        $('a[title]').tooltip();
    });

</script>



</body>
    

</html>
