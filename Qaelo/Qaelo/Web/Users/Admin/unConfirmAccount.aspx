<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="unConfirmAccount.aspx.cs" Inherits="Qaelo.Web.Users.Admin.unConfirmAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
        <title>UnConfirm Accounts</title>
        
                <link href="../../../Content/CustomCss/animate.min.css" rel="stylesheet" />
        <link href="../../../Content/CustomCss/bootstrap.min.css" rel="stylesheet" />
        <link href="../../../Content/CustomCss/demo.css" rel="stylesheet" />
        <link href="../../../Content/CustomCss/light-bootstrap-dashboard.css" rel="stylesheet" />
    <!--     Fonts and icons     -->
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css" rel="stylesheet" />
    <link href='https://fonts.googleapis.com/css?family=Roboto:400,700,300' rel='stylesheet' type='text/css' />
    <link href='https://fonts.googleapis.com/css?family=Kaushan+Script' rel='stylesheet' type='text/css' />

            <link href="../../../Content/CustomCss/Profile/assets/css/gsdk-base.css" rel="stylesheet" />
        <!--Notify -->
    <link href="../../../Content/CustomCss/notify/animate.css" rel="stylesheet" />
    <script src="../../../Content/Qaelo%20template/js/jquery.js"></script>
    <script src="../../../Content/Qaelo%20template/js/bootstrap.min.js"></script>
    <script src="../../../Content/CustomCss/notify/dist/bootstrap-notify.js"></script>
    <!--/Notify -->

    </head>
    <body>
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
        <div class="navbar navbar-default navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a href="ListOfUsers.aspx" class="navbar-brand">Qaelo</a>
                </div>
                <div class="navbar-collapse collapse pull-right">
                    <ul class="nav navbar-nav">
                        <li ><a href="ListOfUsers.aspx">Users</a></li>
                        <li><a href="ConfirmAccount.aspx">Confirm </a></li>
                        <li class="active"><a href="unConfirmAccount.aspx">Delete</a></li>
                         <li ><a href="../../Account/tempLogin.aspx?logout=true">Logout</a></li>

                    </ul>
                </div>
            </div>
        </div>

        <div class="container body-content" style="margin-top:100px">
            <div class="col-md-11 col-lg-11">
                        <div class="card ">
                            <div class="header">
                                <h4 class="title">Confirm Shop Owner Profile</h4>
                            </div>
                            <div class="content">
                                <div style="overflow-x:auto;">
                                    <table class="table table-responsive table-bordered table-striped">
                                        <thead>
                                        <th>FullName</th>
                                        <th>Email</th>
                                        <th>Number</th>
                                        <th>Registration Date</th>
                                        <th>Verify Account</th>
                                    </thead>
                                        <tbody>
                                            <tr>
                                                <asp:Literal ID="lblShopOwner" runat="server"></asp:Literal>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>

            <div class="col-md-11 col-lg-11">
                        <div class="card ">
                            <div class="header">
                                <h4 class="title">Confirm Events Poster Profile</h4>
                            </div>
                            <div class="content">
                                <div style="overflow-x:auto;">
                                    <table class="table table-responsive table-bordered table-striped">
                                        <thead>
                                        <th>FullName</th>
                                        <th>Email</th>
                                        <th>Number</th>
                                        <th>Registration Date</th>
                                        <th>Confirm</th>
                                    </thead>
                                        <tbody>
                                            <tr>
                                                <asp:Literal ID="lblEventPoster" runat="server"></asp:Literal>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>

            <div class="col-md-11 col-lg-11">
                        <div class="card ">
                            <div class="header">
                                <h4 class="title">Confirm Property Owner Profile</h4>
                            </div>
                            <div class="content">
                                <div style="overflow-x:auto;">
                                    <table class="table table-responsive table-bordered table-striped">
                                        <thead>
                                        <th>FullName</th>
                                        <th>Email</th>
                                        <th>Number</th>
                                        <th>Registration Date</th>
                                        <th>Confirm</th>
                                    </thead>
                                        <tbody>
                                            <tr>
                                                <asp:Literal ID="lblManagers" runat="server"></asp:Literal>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>

            <div class="col-md-11 col-lg-11">
                        <div class="card ">
                            <div class="header">
                                <h4 class="title">Confirm Student Society Profile</h4>
                            </div>
                            <div class="content">
                                <div style="overflow-x:auto;">
                                    <table class="table table-responsive table-bordered table-striped">
                                        <thead>
                                        <th>FullName</th>
                                        <th>Email</th>
                                        <th>Number</th>
                                        <th>Registration Date</th>
                                        <th>Confirm</th>
                                    </thead>
                                        <tbody>
                                            <tr>
                                                <asp:Literal ID="lblSocieties" runat="server"></asp:Literal>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>

        </div>
        <script src="../../../Scripts/jquery-1.9.1.min.js"></script>
        <script src="../../../Content/Qaelo%20template/js/bootstrap.min.js"></script>
    </body>
</html>
