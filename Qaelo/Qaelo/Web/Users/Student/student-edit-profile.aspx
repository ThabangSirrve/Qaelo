<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="student-edit-profile.aspx.cs" Inherits="Qaelo.Web.Users.Student.student_edit_profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Edit Profile</title>
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

                     <div class="tab-content" style="margin-top:-60px">
                      <div class="tab-pane fade in active" id="home">
                              <h3 class="head text-center">Update your profile</h3>
                                    <!-- Content here-->
                          <div class="row">
                                  <div class="col-sm-12">
                                      <div class="col-sm-4 col-sm-offset-1">
                                         <div class="picture-container">
                                              <div class="picture">
                                                  <img  src="../../../Images/Users/Accommodation/defaultProfilePic.jpg" style="width:150px;height:150px"  class="picture-src img-circle" runat="server" id="wizardPicturePreview" title=""/>
                                                  <asp:FileUpload ID="wizardPicture"  runat="server" />
                                              </div>
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
                <!-- second row-->
                              </div>
                              <p class="text-center">
                                  <a href="#profile" data-toggle="tab" class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                              </p>
                      </div>

                      <div class="tab-pane fade" id="profile">
                          <h3 class="head text-center">Tertiary information</h3>
                          <p class="narrow text-center">
                             Please tell us more about you tertiary education.
                          </p>
                        <!-- Content here-->
                                                            <div class="col-sm-12">
                                      <div class="col-sm-5">
                                          <div class="form-group">
                                              <label>Qaulification <small>(required)</small></label>
                                              <asp:TextBox ID="txtQualification"  name="text" type="text" class="form-control" placeholder="Course Enrolled" runat="server"></asp:TextBox>
                                          </div>
                                      </div>
                                      <div class="col-sm-6">
                                          <div class="form-group">
                                            <label>Year of study<small>(required)</small></label>
                                             <asp:DropDownList ID="ddlYear" Width="100%" CssClass="form-control" runat="server" >
                                                                      <asp:ListItem selected="" Value="NONE">- Select year of study -</asp:ListItem>
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

                                  <div class="col-sm-12">
                                                                            
                                      <div class="col-sm-5">
                                          <div class="form-group">
                                              <label>University <small>(required)</small></label>
                                               <asp:TextBox ID="txtText" placeholder="Type Tertiary Institution" runat="server" type="text" class="typeaheadPlaces tt-query form-control" autocomplete="on" spellcheck="false"></asp:TextBox>

                                          </div>
                                      </div>
                    
                                  </div>
                          <p class="text-center">
                           <a href="#home" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
                           <a href="#messages" data-toggle="tab"  class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                          </p>

                      </div>

                      <div class="tab-pane fade" id="messages">
                              <h3 class="head text-center">More about Freelancing</h3>
                                
                           <!-- Content here-->
                          <div class="row">
                                     <div class="col-sm-12">
                                     <div class="col-sm-6">
                                      <div class="form-group">
                                          <div class="col-sm-12">
                                                 <div class="form-group">
                                        <label>Your Specialty</label>
                                             <asp:TextBox ID="ddlWork1"  placeholder="Type to search by freelance work" runat="server" type="text" class="typeaheadFreelancers tt-query freelanceClass form-control " autocomplete="on" spellcheck="false"></asp:TextBox><br />
                                       </div>
                                              
                                            <div class="form-group">
                                                <label>Price</label>
                                                <asp:TextBox ID="txtPrice" type="Number" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                            </div>
                                       
                                            <div class="form-group">
                                                <label>Terms</label>
                                            <asp:DropDownList ID="ddlPriceTerms" runat="server" Width="100%" CssClass="form-control">
                                                <asp:ListItem Value="Once-off">Once-off</asp:ListItem>
                                                <asp:ListItem Value="Per/Hour">Per/Hour</asp:ListItem>
                                                <asp:ListItem Value="Negotiable">Negotiable</asp:ListItem>
                                            </asp:DropDownList>
                                               

                                        </div>
                                    
                                          
                                          </div>


                                         </div>
                                  </div>

                                     <div class="col-sm-6">
                                                                            
                                          <div class="col-sm-12">
                                         <div class="form-group">
                                           <label>Freelancing description</label>
                                             <asp:TextBox ID="txtDescription" class="form-control" placeholder="" TextMode="multiline"  Rows="6"  runat="server">
                                             </asp:TextBox>
                                          </div>
                                    </div>
                                     </div>
                                     </div>
                                </div>
                          <p class="text-center">
                           <a href="#profile" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
                           <a href="#settings" data-toggle="tab"  class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                          </p>
                      </div>

                      <div class="tab-pane fade" id="settings">
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
                                    
                                                                         
                                    <div class="col-sm-7 col-sm-offset-2">
                                         <div class="form-group">
                                             <asp:Button ID="btnUpdate" class="btn btn-info pull-right" runat="server" Text="update" OnClick="btnUpdate_Click" />
                                          </div>
                                    </div>
                                </div>
                          <p class="text-center">
                           <a href="#messages" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
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
