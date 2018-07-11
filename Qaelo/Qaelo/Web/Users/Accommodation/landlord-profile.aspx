<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Accommodation/Accommodation.Master" AutoEventWireup="true" CodeBehind="landlord-profile.aspx.cs" Inherits="Qaelo.Web.Users.Accommodation.landlord_profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Profile </title>
        <script src="../../../Template/Wizard/script.js"></script>
    <link href="../../../Template/Wizard/style.css" rel="stylesheet" />
    <link href="../../../Content/CustomCss/ListPlace/imageUpload.css" rel="stylesheet" />
    <link href="../../../Content/CustomCss/ListPlace/assets/css/gsdk-base.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <!--/Notifier-->
    <section style="background:#efefe9;">
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

                     <li><a >
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
                              <h3 class="head text-center" style="margin-top:-50px">Update profile</h3>
                                    <!-- Content here-->
                          <div class="col-sm-12">

                                  <div class="col-sm-offset-4">
                                      <div class="row">
                                        <div class="col-sm-6">
                                         <div class="form-group">
                                        <label>First Name <small>(required)</small></label>
                                          <asp:TextBox ID="txtName" name="firstname" type="text" class="form-control" placeholder="My name is..." runat="server"></asp:TextBox>
                                      </div>

                                         </div>

                                      </div>

                                      <div class="row">
                                      <div class="col-sm-6">
                                      <div class="form-group">
                                        <label>Last Name <small>(required)</small></label>
                                          <asp:TextBox ID="txtLastName" name="lastname" type="text" class="form-control" placeholder="My surname is..." runat="server"></asp:TextBox>
                                      </div>
                                  </div>
                                          
                                      </div>
                                      
                                      <div class="row">
                                      <div class="col-sm-6">
                                      <div class="form-group">
                                        <label>Contact number <small>(required)</small></label>
                                          <asp:TextBox ID="txtNumber" name="number" type="number" class="form-control" placeholder="072.." runat="server"></asp:TextBox>
                                      </div>
                                          
                                      </div>
                                          
                                      </div>
                                      
                                      <div class="row">
                                      <div class="col-sm-6">
                                          <div class="form-group">
                                              <label>Email <small></small></label>
                                              <asp:TextBox ID="txtEmail" disabled="" name="email" type="email" class="form-control" placeholder="me@gmail.com" runat="server"></asp:TextBox>
                                          </div>
                                      </div>
                                          
                                      </div>

                                  </div>
                              </div>
                              <p class="text-center">
                                  <a href="#profile" style="margin-top:-5px" data-toggle="tab" class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                              </p>
                      </div>

                      <div class="tab-pane fade" id="profile">
                          <h3 class="head text-center">Update your Password</h3>
                        <!-- Content here-->
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
                                             <asp:Button ID="btnUpdate" class="btn btn-info pull-right" runat="server" Text="update" OnClick="btnUpdate_Click"/>
                                          </div>
                                    </div>
                                </div>
                          <p class="text-center">
                           <a href="#home" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
                           <a href="#messages" data-toggle="tab"  class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                          </p>

                      </div>

                    <div class="tab-pane fade" id="messages">
                              <h3 class="head text-center">Small description about the property.</h3>
                           <!-- Content here-->
                        <div class="row">
                                    <div class="col-sm-6 col-sm-offset-1">
                                         <div class="form-group">
                                            <label>Name of accommodation property</label>
                                             <asp:TextBox ID="txtAccommodationName" type="text" class="form-control" placeholder="Name of your property" runat="server"></asp:TextBox>
                                          </div>
                                    </div>
                                    <div class="col-sm-4">
                                      <div class="form-group">
                                          <label>Is it Student Loan accredited?</label>
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
                                             <asp:TextBox ID="txtDescription" class="form-control" placeholder="" TextMode="multiline"  Rows="4"  runat="server">

                                             </asp:TextBox>
                                          </div>
                                    </div>
                                    <div class="col-sm-4">
                                      <%--   <div class="form-group">
                                            <label>Facebook Link</label>
                                            <asp:TextBox ID="txtFacebookLink" CssClass="form-control" placeholder="paste facebook link here" runat="server"></asp:TextBox>
                                          </div>--%>
                                    </div>
                                </div>
                          <p class="text-center">
                           <a href="#profile" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
                           <a href="#doner" data-toggle="tab"  class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                          </p>
                      </div>

                      <div class="tab-pane fade" id="doner">
                          <div class="text-center">
                            <i class="img-intro icon-checkmark-circle"></i>
                        </div>
                        <h3 class="head text-center">Save changes</h3>
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
    <script src="../../../Scripts/imageUpload.js"></script>
</asp:Content>
