<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPost.aspx.cs" Inherits="Qaelo.Web.Users.Student.ViewPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
	<meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
    <meta name="viewport" content="width=device-width" />
    <title>View Post</title>
    <link href="../../../Content/Qaelo%20template/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/font-awesome.min.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/animate.min.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/lightbox.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/main.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/responsive.css" rel="stylesheet" />
    
    <link href="http://netdna.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.css" rel="stylesheet"/>

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


        <div class="col-sm-8 col-sm-offset-2" >

        <!--Card content-->
        <div class="thumbnail">
            <!--Title-->
            <h3 ><asp:Literal ID="lblTitle" runat="server"></asp:Literal>
                <asp:Label ID="lblLike" runat="server" Text=""></asp:Label> </h3>

            <asp:Literal ID="lblContent" runat="server"></asp:Literal><br />
            <!--Text--><br />
        </div>
        <!--/.Card content-->

        </div>

</body>

        <!-- Css for Template -->
    <script src="../../../Content/Qaelo%20template/js/lightbox.min.js"></script>
    <script src="../../../Content/Qaelo%20template/js/wow.min.js"></script>
    <script src="../../../Content/Qaelo%20template/js/main.js"></script>
</html>
