<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="change-password.aspx.cs" Inherits="Qaelo.Web.Users.Student.change_password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <title>Update Password</title>
    <link href="../../../Template/Wizard/style.css" rel="stylesheet" />
    <script src="../../../Template/Wizard/script.js"></script>
    <link href="../../../Content/CustomCss/Profile/assets/css/gsdk-base.css" rel="stylesheet" />
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
            <div class="row">
                <div class="board">
                    <!-- <h2>Welcome to IGHALO!<sup>™</sup></h2>-->
                    <div class="board-inner">
                    <ul class="nav nav-tabs" id="myTab">
                    <div class="liner"></div>

                     <li class="active"><a href="#settings" data-toggle="tab" >
                         <span class="round-tabs four">
                              <i class="glyphicon glyphicon-bookmark"></i>
                         </span> 
                     </a></li>
                     
                     </ul>

                    </div>

                     <div class="tab-content" style="margin-top:-60px">

                      <div class="tab-pane fade in active" id="settings">
                          <h3 class="head text-center">Update your Password</h3>
                          <!-- Content -->
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
                                    
                                                                         
                                   <%-- <div class="col-sm-7 col-sm-offset-2">
                                         <div class="form-group">
                                             <asp:Button ID="Button1" class="btn btn-success btn-outline-rounded green" runat="server" Text="OK" OnClick="Button1_Click"/>
                                          </div>
                                    </div>--%>
                                </div>
                          <p class="text-center">
                         
                              <asp:Button ID="Button2" class="btn btn-success btn-outline-rounded green" runat="server" Text="Update" OnClick="Button1_Click"/>
                          </p>
                          
                      </div>

                        <div class="clearfix"></div>
                    </div>
            </div>
            </div>
            </div>
            </section>

                            

</asp:Content>
