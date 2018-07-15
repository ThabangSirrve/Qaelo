<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="member-profile.aspx.cs" Inherits="Qaelo.Web.Users.CommunityMember.member_profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <title>Profile</title>
        <link href="../../../Content/CustomCss/imagehover/imagehover.css" rel="stylesheet" />
    <style>
        @media (min-width: 992px) {
  .modal-lg {
    width: 1200px;
  }


}
                @media (min-width: 992px) {
  .modal-lg2 {
    width: 920px;
  }


}


         </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top:60px"></div>
    
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
            <h4 class="col-md-3" ><b>My Qaelo Community Platform</b></h4>
        </div>

        <div class="container" style="margin-top:50px">
        
        <div class='col-md-3'>
            <asp:Literal ID="lblProfileView" runat="server"></asp:Literal>        
       </div>
        <div class="col-md-6">

        <div class="col-md-6">
            <a href="student-edit-profile.aspx" class="btn btn-block btn-default" >Edit my profile</a>
            <%--<asp:Button ID="btnConstruction"  class="btn btn-submit" runat="server" Text="Edit my profile" OnClick="btnConstruction_Click" />--%>
            <br />
        </div>


        <div class="col-md-6">
            <a href="#CONVENIENCE" runat="server" data-toggle='modal'  class="btn btn-block btn-default">My LifeStyle</a>
            <br />
        </div>


        <div class="col-md-6">
            <a href="students-add-work.aspx" runat="server" class="btn btn-block btn-default" >My Portfolio</a>
            <br />
        </div>

<%--        <div class="col-md-6" hidden="hidden">
            <a href="#share" runat="server" id="setView" data-toggle='modal'  class="btn btn-block btn-default" >Advertise to Landlords</a>
            <br />
        </div>

        <div class="col-md-6">
            <asp:Label ID="lblsellbooks" class="btn btn-block btn-default" runat="server" Text=""></asp:Label>
            <br />
        </div>--%>

        <div class="col-md-6">
            <a href="#myModal1" data-toggle='modal'  class="btn btn-block btn-default" >View Specials</a>
            <br />
        </div>

        <div class="col-md-6">
            <a href="../../Account/tempLogin.aspx?logout=true" class="btn btn-block btn-default" >Sign Out</a>
        </div>
        
        </div>

    </div>

        <!-- Modal for convinience -->
        <div class='modal fade' id='CONVENIENCE' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{2}' aria-hidden='true'>                   
            <div class='modal-dialog modal-lg'>            
                <div class='modal-content'>
                            <div class="modal-header" style="background-color:palevioletred;"><h4 class="text-center" style="color:white;">My Life Style</h4></div>
                            <div class='modal-body' style="margin-top:-80px">
                                        <div class="portfolio" id="portfolio">
                                           <div class="col-sm-12">
            <%--<p class="aut">Great services designed for you!</p>--%>
            <div class="portfolio_grid_w3lss">
                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel="" href="#" title="Wayfaring">
                            <img src="../../../Images/Convinience/uber.jpg" class="img-responsive"/>
                            <div class="mask">
                                <p><a style="color:white" href="https://play.google.com/store/apps/details?id=com.ubercab&hl=en" target="_blank">Transport</a></p>
                            </div>
                        </a>
                    </div>
                </div>

                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel=" " href="#" title="Wayfaring">
                            <img src="../../../Images/Convinience/EToro_logo_facebook_profile.jpg" class="img-responsive"  />
                            <div class="mask">
                                <p><a style="color:white" href="http://www.etoro.com/" target="_blank">Forex Trading</a></p>
                            </div>
                        </a>
                    </div>
                </div>

                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel=" " href="#" title="Wayfaring">
                            <img src="../../../Images/Convinience/getor.jpg" class="img-responsive" />
                            <div class="mask">
                                <p><a style="color:white" href="http://www.hostgator.com/" target="_blank">Web Hosting</a></p>
                            </div>
                        </a>
                    </div>
                </div>

                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel=" " href="#" title="Life Style">
                            <img src="../../../Images/Convinience/getSmarter.png" class="img-responsive" />
                            <div class="mask">
                                <p><a style="color:white" href="https://www.getsmarter.com" target="_blank">Online courses</a></p>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel=" " href="#" title="Life Style">
                            <img src="../../../Images/Convinience/Huawei.png" class="img-responsive" />
                            <div class="mask">
                                <p><a style="color:white" href="http://consumer.huawei.com" target="_blank">Gadgets</a></p>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel=" " href="#" title="Life Style">
                            <img src="../../../Images/Convinience/Netflix.png"  class="img-responsive" />
                            <div class="mask">
                                <p><a style="color:white" href="https://www.netflix.com" target="_blank">Online streaming</a></p>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel=" " href="#" title="Life Style">
                            <img src="../../../Images/Convinience/STATravel.jpg" class="img-responsive" />
                            <div class="mask">
                                <p><a style="color:white" href="http://www.statravel.com" target="_blank">Travel</a></p>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel=" " href="#" title="Life Style">
                            <img src="../../../Images/Convinience/ups.png" style="margin-top:-20px" class="img-responsive" />
                            <div class="mask">
                                <p><a style="color:white" href="http://ups.com" target="_blank">Parcel Services</a></p>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel=" " href="#" title="Life Style">
                            <img src="../../../Images/Convinience/nike.jpg"  class="img-responsive"/>
                            <div class="mask">
                                <p><a style="color:white" href="http://nike.com" target="_blank">Sports Apparel</a></p>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="clearfix"> </div>
            </div>
            <script src="../../../Template/js/jquery.zbox.min.js"></script>
            <script type="text/javascript">
				  //<![CDATA[
				  jQuery(document).ready(function(){
					jQuery(".zb").zbox( { margin:40 } );
				  });
				  //]]>
            </script>
        </div>
                                        </div>
                            </div>
                
                            <div class='modal-footer'>  
                                <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                            </div>
                        </div>
                    </div>
                </div>
    
        <!--Modal for viewing ads -->
        <%--<div class='modal fade' id='viewAdd' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{2}' aria-hidden='true'>                   
            <div class='modal-dialog modal-lg2'>            
                <div class='modal-content'>
                        <div class="modal-header" style="background-color:palevioletred;"><h4 class="text-center" style="color:white;">Your Ads(<asp:Label ID="lblNumAdds" runat="server" Text="1"></asp:Label>)</h4></div>
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
                </div>--%>
        <div class='modal fade' id='viewAdd' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{2}' aria-hidden='true'>                   
            <div class='modal-dialog modal-lg2'>            
                <div class='modal-content'>
                        <div class="modal-header" style="background-color:palevioletred;"><h4 class="text-center" style="color:white;">Your Ads(<asp:Label ID="lblNumAdds" runat="server" Text="1"></asp:Label>)</h4></div>
                            <div class='modal-body'>
                                <div class="container">
                                    <div class="col-sm-8">
                                        <div style="overflow-x:auto;">
                                        <table class='table responsive table-striped table-bordered' cellspacing='0' width='100%'>
                                         <thead>
                                          <tr>
                                            <th>Date</th>
                                            <th>Type</th>
                                            <th>Gender</th>
                                            <th>Payment</th>
                                            <th>Rent</th>
                                            <th>Action</th>
                                          </tr>
                                        </thead>
                                        <tbody>
                                         <asp:Label ID="lblRoomAds" runat="server" Text=""></asp:Label>
                                        </tbody>
                                </table>
                                            </div>
                                </div>
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
                        <div class="modal-header" style="background-color:palevioletred;"><h4 class="text-center" style="color:white">I’m looking for a room</h4></div>
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
                                              <asp:ListItem Value="Student Loan">Student Loan</asp:ListItem>
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

        <!-- Specials advertisement -->
           <!-- Modal for specials-->
        <div class="modal fade" id="myModal1" tabindex="-1" role="dialog" aria-labelledby="myModal">
                        <div class="modal-dialog modal-lg" role="document">
                            <div class="modal-content">
                                <div class="modal-header" style="background-color:palevioletred;">
                                    <!--<h4>Notice </h4>-->
                                        <h4 style="color:white"  class="text-center ">Specials in your campus</h4>
                                </div>
                                <div class='modal-body'>
                                <div class="container-fluid">
                                    <asp:Label ID="lblSpecialLinks" runat="server" Text=""></asp:Label>
                                </div>
                                </div>
                                <div class='modal-footer'>
                                    <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                </div>
                            </div>
                        </div>
                    </div>

        <!-- Single Specials popup-->
        <asp:Label ID="lblSpecials" runat="server" Text=""></asp:Label>

        <!-- Selling textbooks-->
        <div class='modal fade' id='sellbooks' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{1}' aria-hidden='true'>
                <div class='modal-dialog modal-lg2 '>
                    <div class='modal-content'>
                            <div class="modal-header" style="background-color:palevioletred;"><h4 class="text-center" style="color:white;">Maximum of 8 books are allowed</h4></div>
                                <div class='modal-body'>
                                    <div class="container">
                                            <asp:Literal ID="lblPublished" runat="server"></asp:Literal>
                                    </div>
                                     </div>
                
                                <div class='modal-footer'>
                                    <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                    <a href="students-sell-textbooks.aspx" id="addNew" runat="server"  type='button' class='btn btn-finish btn-fill btn-warning btn-wd btn-sm'>Add new book</a>
                                </div>
                            </div>
                        </div>

        </div>

        <div class='modal fade' id='cannotsellbooks' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{1}' aria-hidden='true'>
                <div class='modal-dialog'>
                    <div class='modal-content'>
                            <div class="modal-header"><h3 class="text-center">Not Allowed to sell textbooks</h3></div>
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
                        <div class="modal-header"><h3 class="text-center">Not Allowed to register as freelancer </h3></div>
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
