<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Shop/Shop.Master" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="Qaelo.Web.Users.Shop.EditProfile1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Edit Profile</title>

   <link href="../../../Template/Wizard/style.css" rel="stylesheet" />
    <script src="../../../Template/Wizard/script.js"></script>
    <script src="../../../Template/js/jquery-2.1.4.min.js"></script>
    <script src="../../../Template/js/bootstrap.js"></script>

    <link href="../../../Content/CustomCss/ListPlace/imageUpload.css" rel="stylesheet" />
    <link href="../../../Content/CustomCss/Profile/assets/css/gsdk-base.css" rel="stylesheet" />


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Wizard-->
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
                     <li class="active">
                     <a href="#home" data-toggle="tab" >
                      <span class="round-tabs one">
                              <i class="glyphicon glyphicon-home"></i>
                      </span> 
                  </a></li>

                  <li><a href="#profile" data-toggle="tab" >
                     <span class="round-tabs two">
                         <i class="glyphicon glyphicon-blackboard"></i>
                     </span> 
           </a>
                 </li>
                 <li><a href="#messages" data-toggle="tab" >
                     <span class="round-tabs three">
                          <i class="glyphicon glyphicon-book"></i>
                     </span> </a>
                     </li>

                     <li><a href="#settings" data-toggle="tab" >
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
                                  <h3 class="head text-center">Update your profile</h3>
                                        <!-- Content here-->
                                  <div class="row col-sm-offset-3">
                                  <div class="col-sm-6">
                                      <div class="form-group">
                                        <label>FullName <small>(required)</small></label>
                                          <asp:TextBox ID="txtFullname" name="firstname" type="text" class="form-control" placeholder="Full Name" runat="server"></asp:TextBox>
                                      </div>

                                  </div>
                                  </div>
                                                                  
                                  <div class="row col-sm-offset-3">
                                  <div class="col-sm-6">
                                      <div class="form-group">
                                              <label>Email <small>(required)</small></label>
                                              <asp:TextBox ID="txtEmail" name="email" type="email" disabled class="form-control" placeholder="me@gmail.com" runat="server"></asp:TextBox>
                                          </div>
                                      
                                  </div>
                                  </div>
                                  <div class="row col-sm-offset-3">
                                      <div class="col-sm-6">
                                      <div class="form-group">
                                        <label>Contact number <small>(required)</small></label>
                                          <asp:TextBox ID="txtNumber" name="number" type="number" disbled="true" class="form-control" placeholder="072.." runat="server"></asp:TextBox>
                                      </div>
                                      </div>
                                  </div>
                             
                                  <p class="text-center">
                                      <a href="#profile" data-toggle="tab" style="margin-top:-5px" class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                                  </p>
                          </div>

                          <div class="tab-pane fade" id="profile">
                              <h3 class="head text-center">Update your password</h3>
                                <div class="row">
                                    <div class="col-sm-7 col-sm-offset-2">
                                         <div class="form-group">
                                             <asp:TextBox ID="txtCurrentPassword" type="password" class="form-control" placeholder="Current password" runat="server"></asp:TextBox>
                                          </div>
                                    </div>
                                    <div class="col-sm-7 col-sm-offset-2">
                                         <div class="form-group">
                                             <asp:TextBox ID="txtNewPassword" type="password" class="form-control" placeholder="New password" runat="server"></asp:TextBox>
                                          </div>
                                    </div>
                                     <div class="col-sm-7 col-sm-offset-2">
                                         <div class="form-group">
                                             <asp:TextBox ID="txtConfirmPassword" type="password" class="form-control" placeholder="Confirm Password" runat="server"></asp:TextBox>
                                          </div>
                                    </div>
                                    
                                                                         
                                    <div class="col-sm-7 col-sm-offset-2">
                                         <div class="form-group">
                                            <%--<label>Confirm Password</label>--%>
                                             <asp:Button ID="Button2" class="btn btn-info pull-right" runat="server" Text="update" OnClick="btnPasswordUpdate_Click" />
                                          </div>
                                    </div>
                                </div>
                            <!-- Content here-->
                              <p class="text-center">
                               <a href="#home" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
                               <a href="#doner" data-toggle="tab"  class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                              </p>

                          </div>

                          <div class="tab-pane fade" id="doner">
                              <div class="text-center">
                                <i class="img-intro icon-checkmark-circle"></i>
                            </div>
                            <h3 class="head text-center">Save changes</h3>
                              <p class="text-center">
                                <asp:Button ID="Button1" class="btn btn-success btn-outline-rounded green" runat="server" Text="OK" OnClick="btnFinish_Click" />
                              </p>
                            </div>
                            <div class="clearfix"></div>
                        </div>

                </div>
                </div>
                </div>
                </section>


</asp:Content>
