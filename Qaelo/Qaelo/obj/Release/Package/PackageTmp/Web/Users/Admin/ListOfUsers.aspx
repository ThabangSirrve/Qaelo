<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListOfUsers.aspx.cs" Inherits="Qaelo.Web.Users.Admin.ListOfUsers" %>

<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
        <title>List of users</title>
        <link href="../../../Content/CustomCss/animate.min.css" rel="stylesheet" />
        <link href="../../../Content/CustomCss/bootstrap.min.css" rel="stylesheet" />
        <link href="../../../Content/CustomCss/demo.css" rel="stylesheet" />
        <link href="../../../Content/CustomCss/light-bootstrap-dashboard.css" rel="stylesheet" />
    <!--     Fonts and icons     -->
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css" rel="stylesheet" />
    <link href='https://fonts.googleapis.com/css?family=Roboto:400,700,300' rel='stylesheet' type='text/css' />
    <link href='https://fonts.googleapis.com/css?family=Kaushan+Script' rel='stylesheet' type='text/css' />
    </head>
    <body>
        <div class="navbar navbar-default navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a href="#" class="navbar-brand">Qaelo</a>
                </div>
                <div class="navbar-collapse collapse pull-right">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="ListOfUsers.aspx">Users</a></li>
                        <li ><a href="ConfirmAccount.aspx">Confirm </a></li>
                        <li ><a href="unConfirmAccount.aspx">Delete</a></li>
                        <li ><a href="../../Account/Login.aspx?logout=true">Logout</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="container body-content" style="margin-top:100px">

             <div class="col-md-11 col-lg-11">
                        <div class="card ">
                            <div class="header">
                                <h4 class="title">List of Students</h4>
                            </div>
                            <div class="content">
                                <div style="overflow-x:auto;">
                                    <table class="table table-responsive table-bordered table-striped">
                                        <thead>
                                        <th>FullName</th>
                                        <th>Email</th>
                                        <th>Number</th>
                                        <th>Registration Date</th>
                                        <th>Action</th>
                                    </thead>
                                        <tbody>
                                            <tr>
                                                <asp:Label ID="lblStudents" runat="server" Text=""></asp:Label>
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
                                <h4 class="title">List of Companies</h4>
                            </div>
                            <div class="content">
                                <div style="overflow-x:auto;">
                                    <table class="table table-responsive table-bordered table-striped">
                                        <thead>
                                        <th>FullName</th>
                                        <th>Email</th>
                                        <th>Number</th>
                                        <th>Registration Date</th>
                                        <th>Action</th>
                                    </thead>
                                        <tbody>
                                            <tr>
                                                <asp:Label ID="lblCompanies" runat="server" Text=""></asp:Label>
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
                                <h4 class="title">List of Event Posters</h4>
                            </div>
                            <div class="content">
                                <div style="overflow-x:auto;">
                                    <table class="table table-responsive table-bordered table-striped">
                                        <thead>
                                        <th>FullName</th>
                                        <th>Email</th>
                                        <th>Number</th>
                                        <th>Registration Date</th>
                                        <th>Action</th>
                                    </thead>
                                        <tbody>
                                            <tr>
                                              <asp:Label ID="lblEventPosters" runat="server" Text=""></asp:Label>
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
                                <h4 class="title">List of Property Owners</h4>
                            </div>
                            <div class="content">
                                <div style="overflow-x:auto;">
                                    <table class="table table-responsive table-bordered table-striped">
                                        <thead>
                                        <th>FullName</th>
                                        <th>Email</th>
                                        <th>Number</th>
                                        <th>Registration Date</th>
                                        <th>Action</th>
                                    </thead>
                                        <tbody>
                                            <tr>
                                               <asp:Label ID="lblAccommodations" runat="server" Text=""></asp:Label> 
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
                                <h4 class="title">List of Shop Owners</h4>
                            </div>
                            <div class="content">
                                <div style="overflow-x:auto;">
                                    <table class="table table-responsive table-bordered table-striped">
                                        <thead>
                                        <th>FullName</th>
                                        <th>Email</th>
                                        <th>Number</th>
                                        <th>Registration Date</th>
                                        <th>Action</th>
                                    </thead>
                                        <tbody>
                                            <tr>
                                             <asp:Label ID="lblShops" runat="server" Text=""></asp:Label>   
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
                                <h4 class="title">List of Student Society Profiles</h4>
                            </div>
                            <div class="content">
                                <div style="overflow-x:auto;">
                                    <table class="table table-responsive table-bordered table-striped">
                                        <thead>
                                        <th>FullName</th>
                                        <th>Email</th>
                                        <th>Number</th>
                                        <th>Registration Date</th>
                                        <th>Action</th>
                                    </thead>
                                        <tbody>
                                            <tr>
                                              <asp:Label ID="lblSocieties" runat="server" Text=""></asp:Label>  
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