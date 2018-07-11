<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/Student.Master" AutoEventWireup="true" CodeBehind="StudentProfile.aspx.cs" Inherits="Qaelo.Web.Users.Student.StudentProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Profile</title>
        <link href="../../../Content/CustomCss/imagehover/imagehover.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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

    <div class="row">
        <div class="container">
            <h3 style="margin-right:20px"><b> Your Current Profile Preview</b></h3>
        </div>
    </div>
    <div class="row">
        <div class='col-md-3'>
            <asp:Literal ID="lblProfileView" runat="server"></asp:Literal>        
       </div>

    <div class="col-md-6">
<%--        <div class="col-md-12">
            <asp:Label ID="lblFreelance" runat="server" Text=""></asp:Label>
        </div>--%>

        <div class="col-md-12">
            <asp:Label ID="lblsellbooks" runat="server" Text=""></asp:Label>
        </div>

                
        <div class="col-md-12">
            <a href="#CONVENIENCE" runat="server" data-toggle='modal'  class="btn btn-submit" >CONVENIENCE</a>
        </div>

        <div class="col-md-12">
            <a href="Profile.aspx" class="btn btn-submit" >Edit my profile</a>
            <%--<asp:Button ID="btnConstruction"  class="btn btn-submit" runat="server" Text="Edit my profile" OnClick="btnConstruction_Click" />--%>
        </div>

        <div class="col-md-12">
            <a href="#share" runat="server" id="setView" data-toggle='modal'  class="btn btn-submit" >Advertise on Landlord's profiles</a>
            
        </div>

        <div class="col-md-12">
            <a href="../../Account/Login.aspx?logout=true" class="btn btn-submit" >Sign Out</a>
        </div>
    </div>

    </div>

        <!-- Modal for convinience -->
        <div class='modal fade' id='CONVENIENCE' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{2}' aria-hidden='true'>                   
            <div class='modal-dialog'>            
                <div class='modal-content'>
                        <%--<div class="modal-header"><strong>Your Ads(<asp:Label ID="Label1" runat="server" Text="1"></asp:Label>)</strong></div>--%>
                            <div class='modal-body'>
                                <div class="container">
                                    <div class="col-sm-8">
                                        <h2 style="margin-left:20px">Transport</h2>
                                         <div class="col-sm-3">
                                             <a style="color:white" href="https://play.google.com/store/apps/details?id=com.ubercab&hl=en" target="_blank"><img src="../../../Images/Convinience/uber.jpeg" alt=""  class="img-thumbnail" /></a>
                                         </div>
                                         <div class="col-sm-3">
                                             <a style="color:white" href="http://www.flymango.com/" target="_blank"><img src="../../../Images/Convinience/Mango.png" alt=""  class="img-thumbnail" /></a>
                                         </div>
                                         <div class="col-sm-3">
                                             <a style="color:white" href="https://www.greyhound.co.za/" target="_blank"><img src="../../../Images/Convinience/Greyhound.jpeg" alt=""  class="img-thumbnail" /></a>
                                         </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <hr />
                                </div>
                                <div class="container">
                                    <div class="col-sm-8">
                                        <h2 style="margin-left:20px">Life Style</h2>
                                         <div class="col-sm-3">
                                             <a style="color:white" href="https://play.google.com/store/apps/details?id=mobi.debonairspizza.iosapp&hl=en" target="_blank"><img src="../../../Images/Convinience/Debonairs.png" alt=""  class="img-thumbnail" /></a>
                                         </div>
                                         <div class="col-sm-3">
                                             <a style="color:white" href="https://movies.sterkinekor.co.za/browsing/" target="_blank"><img src="../../../Images/Convinience/SK.jpeg" alt=""  class="img-thumbnail" /></a>
                                         </div>
                                         <div class="col-sm-3">
                                             <a style="color:white" href="https://www.mrp.com/en_za/" target="_blank"><img src="../../../Images/Convinience/mrp.png" alt=""  class="img-thumbnail" /></a>
                                         </div>
                                    </div>
                                </div>
                                                                
                                <div class="row">
                                    <hr />
                                </div>
                                                               
                                 <div class="container">
                                    <div class="col-sm-8">
                                         <div class="col-sm-3">
                                             <a style="color:white" href="http://shop.pnp.co.za/b2c_pnp/b2c/display/(layout=5.1-6_2_4_90_89_8_3&carea=%24ROOT)/.do?rf=y" target="_blank"><img src="../../../Images/Convinience/picknpay.png" alt=""  class="img-thumbnail" /></a>
                                         </div>
                                         <div class="col-sm-3">
                                             <a style="color:white" href="https://www.incredible.co.za/?gclid=Cj0KEQjwxbDIBRCL99Wls-nLicoBEiQAWroh6tMJQvpgofMkDCuA_eDS2ZhhF7nIrsO01epDKfOMH_oaApP88P8HAQ" target="_blank"><img src="../../../Images/Convinience/incredible connection.jpeg" alt=""  class="img-thumbnail" /></a>
                                         </div>
                                         <div class="col-sm-3">
                                             <a style="color:white" href="https://www.absa.co.za/personal/bank/youth-student-banking/student-account/" target="_blank"><img src="../../../Images/Convinience/Absa.png" alt=""  class="img-thumbnail" /></a>
                                         </div>
                                    </div>
                                </div>
                            </div>
                
                            <div class='modal-footer'>  
                                <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                            </div>
                        </div>
                    </div>
                </div>
    
        <!--Modal for viewing adds -->
        <div class='modal fade' id='viewAdd' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{2}' aria-hidden='true'>                   
            <div class='modal-dialog modal-lg'>            
                <div class='modal-content'>
                        <div class="modal-header"><strong>Your Ads(<asp:Label ID="lblNumAdds" runat="server" Text="1"></asp:Label>)</strong></div>
                            <div class='modal-body'>
                                <div class="container">
                                    <div class="col-sm-8">
                                         <div class="form-group">
                                          <div class="col-sm-2"><strong> Date</strong></div>
                                          <div class="col-sm-2"><strong>Type</strong></div>
                                          <div class="col-sm-2"><strong>Gender</strong></div>
                                          <div class="col-sm-2"><strong>Payment</strong></div>
                                          <div class="col-sm-2"><strong>Rent</strong></div>
                                          <div class="col-sm-2"><strong>Action</strong></div><br />
                                </div>
                                    </div>
                                    <asp:Label ID="lblRoomAds" runat="server" Text=""></asp:Label>
                                </div>
                            </div>
                
                            <div class='modal-footer'>  
                                <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                     <a href='#' data-toggle='modal' data-target='#share' type='button' class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish'>Add New</a>
                            </div>
                        </div>
                    </div>
                </div>

        <!--Modal for advertising to landlords-->
        <div class='modal fade' id='share' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{1}' aria-hidden='true'>
            <div class='modal-dialog'>
                <div class='modal-content'>
                        <div class="modal-header"><strong>Advertise</strong></div>
                            <div class='modal-body'>
                                <div class="container">
                                    <div class="col-sm-4 col-sm-offset-1">
                                <p>Please Fill in the following form</p>
                                <div class="form-group">
                                    <label>Monthly Rent </label>
                                    <asp:TextBox ID="txtPrice" type="Number" CssClass="form-control" placeholder="Price" runat="server"></asp:TextBox><br />
                                    <label>Phone Number</label>
                                    <asp:TextBox ID="txtPhone" type="Number" CssClass="form-control" placeholder="Phone number" runat="server"></asp:TextBox><br />
                                                  
                                    <label>Single/Sharing</label>                        
                                    <asp:DropDownList ID="ddlArragement" Width="100%" CssClass="form-control" runat="server" >
                                              <asp:ListItem disabled="" selected="" Value="NONE">- Select -</asp:ListItem>
                                              <asp:ListItem Value="Single">Single</asp:ListItem>
                                              <asp:ListItem Value="Sharing">Sharing</asp:ListItem>
                                          </asp:DropDownList>
                                                               
                                    <label>Gender</label>         
                                    <asp:DropDownList ID="ddlGender" Width="100%" CssClass="form-control" runat="server" >
                                              <asp:ListItem disabled="" selected="" Value="NONE">- Select -</asp:ListItem>
                                              <asp:ListItem Value="Male">Male</asp:ListItem>
                                              <asp:ListItem Value="Female">Female</asp:ListItem>
                                          </asp:DropDownList>
                                    <label>Payment Method</label>
                                    <asp:DropDownList ID="ddlPaymentType" Width="100%" CssClass="form-control" runat="server" >
                                              <asp:ListItem disabled="" selected="" Value="NONE">- Select -</asp:ListItem>
                                              <asp:ListItem Value="Cash">Cash</asp:ListItem>
                                              <asp:ListItem Value="NSFAS">NSFAS</asp:ListItem>
                                              <asp:ListItem Value="Bursary">Bursary</asp:ListItem>
                                          </asp:DropDownList>
                                </div>
                                    </div>
                                </div>
                            </div>
                
                            <div class='modal-footer'>
                                <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                <asp:Button ID="btnFinish" class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish' runat="server" Text="Publish" OnClick="btnFinish_Click" />
                            </div>
                        </div>
                    </div>
                </div>

        <!-- Selling textbooks-->

        <div class='modal fade' id='sellbooks' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{1}' aria-hidden='true'>
                <div class='modal-dialog'>
                    <div class='modal-content'>
                            <div class="modal-header"><strong>Maximum of 8 books are allowed</strong></div>
                                <div class='modal-body'>
                                    <div class="container">
                                        <div class="col-sm-4">
                                            <asp:Literal ID="lblPublished" runat="server"></asp:Literal>
                                        </div>
                                    </div>
                                </div>
                
                                <div class='modal-footer'>
                                    <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                    <a href="SellBooks.aspx" id="addNew" runat="server"  type='button' class='btn btn-finish btn-fill btn-warning btn-wd btn-sm'>Add new book</a>
                                </div>
                            </div>
                        </div>
                    </div>

        <div class='modal fade' id='cannotsellbooks' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{1}' aria-hidden='true'>
                <div class='modal-dialog'>
                    <div class='modal-content'>
                            <div class="modal-header"><strong>Not Allowed to sell textbooks</strong></div>
                                <div class='modal-body'>
                                    <div class="container">
                                        <div class="col-sm-4">
                                            <h2>You cannot sell texbooks if your profile is not complete</h2>
                                            <b>Possible errors</b>
                                             <p>- Invalid Cell Number <br />
                                                - Invalid University/Campus<br />
                                                - Invalid Fist Name or last Name
                                             </p>
                                        </div>
                                    </div>
                                </div>
                
                                <div class='modal-footer'>
                                    <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                    <a href="Profile.aspx" id="a1" runat="server"  type='button' class='btn btn-finish btn-fill btn-warning btn-wd btn-sm'>Edit Profile</a>
                                </div>
                            </div>
                        </div>
                    </div>

        <div class='modal fade' id='cannotBecomeFreelancer' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{1}' aria-hidden='true'>
            <div class='modal-dialog'>
                <div class='modal-content'>
                        <div class="modal-header"><strong>Not Allowed to register as freelancer </strong></div>
                            <div class='modal-body'>
                                <div class="container">
                                    <div class="col-sm-4">
                                        <h2>You cannot register as freelancer if your profile is not complete</h2>
                                        <b>Possible errors</b><br />
                                         - Invalid Cell Number <br />
                                            - Invalid University/Campus<br />
                                            - Invalid Fist Name or last Name<br />
                                    </div>
                                </div>
                            </div>
                
                            <div class='modal-footer'>
                                <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                <a href="Profile.aspx" id="a2" runat="server"  type='button' class='btn btn-finish btn-fill btn-warning btn-wd btn-sm'>Edit Profile</a>
                            </div>
                        </div>
                    </div>
                </div>

</asp:Content>