<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="students-sell-textbooks.aspx.cs" Inherits="Qaelo.Web.Users.Student.students_sell_textbooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Sell Textbook</title>
        <link href="http://netdna.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.css" rel="stylesheet"/>

    <link href="../../../Content/CustomCss/Profile/assets/css/gsdk-base.css" rel="stylesheet" />
    <script src="../../../Template/Wizard/script.js"></script>
    <link href="../../../Template/Wizard/style.css" rel="stylesheet" />
    <link href="../../../Template/css/popuo-box.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section style="background:#efefe9;">
        
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

    <script>
                document.getElementById("file1").onchange = function () {
                    var reader = new FileReader();
                    reader.onload = function (e) {
                        // get loaded data and render thumbnail. 
                        document.getElementById("image1").src = e.target.result;
                        document.getElementById("imageDefault").src = e.target.result;
                    };
                    // read the image file as a data URL.
                    reader.readAsDataURL(this.files[0]);
                };

                //Image 2
                document.getElementById("file2").onchange = function () {
                    var reader = new FileReader();
                    reader.onload = function (e) {
                        // get loaded data and render thumbnail.
                        document.getElementById("image2").src = e.target.result;
                    };
                    // read the image file as a data URL.
                    reader.readAsDataURL(this.files[0]);
                };

                //Image 3
                document.getElementById("file3").onchange = function () {
                    var reader = new FileReader();
                    reader.onload = function (e) {
                        // get loaded data and render thumbnail.
                        document.getElementById("image3").src = e.target.result;
                    };
                    // read the image file as a data URL.
                    reader.readAsDataURL(this.files[0]);
                };
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
                 <li><a >
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
                     
                     </ul></div>

                     <div class="tab-content">
                      <div class="tab-pane fade in active" id="home">
                              <h3 class="head text-center">Sell your textbook</h3>
                              <p class="narrow text-center">
                                 Please fill all the fields below.
                              </p>

                                    <!-- Content here-->
                          <div class="row">
                                  <div class="col-sm-6 col-sm-offset-3">
                                      <div class="form-group">
                                          <div class="col-sm-12">
                                                 <div class="form-group">
                                        <label>Select study field</label>
                                          <asp:DropDownList ID="ddlField" Width="100%" CssClass="form-control" runat="server" >
                                              <asp:ListItem disabled="" selected="" Value="N/A">- Select -</asp:ListItem>
                                              <asp:ListItem Value="ART Design and architecture">ART Design and architecture</asp:ListItem>
                                              <asp:ListItem Value="Education">Education</asp:ListItem>
                                              <asp:ListItem Value="Engineering And Build Environment">Engineering And Build Environment</asp:ListItem>
                                              <asp:ListItem Value="Finacial Sciences">Finacial Sciences</asp:ListItem>
                                              <asp:ListItem Value="Health">Health</asp:ListItem>
                                              <asp:ListItem Value="Humanities">Humanities</asp:ListItem>
                                              <asp:ListItem Value="Management">Management</asp:ListItem>
                                              <asp:ListItem Value="Law">Law</asp:ListItem>
                                              <asp:ListItem Value="Science">Science</asp:ListItem>
                                          </asp:DropDownList>
                                     </div>
                                          </div>
                                         </div>
                                  </div>

                                  <div class="col-sm-6 col-sm-offset-3">
                                      <div class="form-group">
                                          <div class="col-sm-12">
                                                 <div class="form-group">
                                        <label>Select year of study</label>
                                          <asp:DropDownList ID="ddlYear" Width="100%" CssClass="form-control" runat="server" >
                                              <asp:ListItem disabled="" selected="" Value="N/A">- Select -</asp:ListItem>
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
                                  </div>
                              </div>
                              <p class="text-center">
                                  <a href="#profile" data-toggle="tab" class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                              </p>
                      </div>

                      <div class="tab-pane fade" id="profile">
                          <h3 class="head text-center" style="margin-top:-50px">Book description</h3>
                        <!-- Content here-->
                                                                 <div class="row">
                                    <div class="col-sm-4 col-sm-offset-1">
                                       
                                            <div class="form-group">
                               
                                      <h6 class="">Book Image</h6>
                                       <img src="../../../Images/Book/default.jpg" class="img-thumbnail" style="height:230px;width:80%" id="image1"/>
                                       <asp:FileUpload ID="file1" CssClass="btn-blue-grey btn-sm" runat="server" />
                          
                                            </div>

                                    </div>
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                                <label>Title</label>
                                                <asp:TextBox ID="txtTitle" MaxLength="50" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                                <label>Price</label>
                                                <asp:TextBox ID="txtPrice" type="Number" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                            </div>
                                        </div>

                                        <div class="col-sm-6">
                                         <div class="form-group">
                                           <label>Book description</label>
                                             <asp:TextBox ID="txtDescription" class="form-control" placeholder="" TextMode="multiline"  Rows="3"  runat="server">
                                             </asp:TextBox>
                                          </div>
                                    </div>
                                    </div>
                            <!--Modal-->
                             
                    <%--<div class='modal fade' id='share' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{1}' aria-hidden='true'>
                    <div class='modal-dialog'>
                        <div class='modal-content'>
                        <div class="modal-header">Invite a Friend</div>
                            <div class='modal-body'>
                                <p>Please Tell 3 a friend that that you are publishing a your used textbook with us, Who knows? They may just buy or tell other friends about you</p>
                                <div class="form-group">
                                    <label>Friend's email</label>
                                    <asp:TextBox ID="txtshare1" CssClass="form-control" placeholder="Email" runat="server"></asp:TextBox><br />
                                </div>
                            </div>
                
                            <div class='modal-footer'>
                                <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
        
                                <asp:Button ID="btnFinish" class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish' runat="server" Text="Publish" OnClick="btnFinish_Click" />
                           </div>
                        </div>
                    </div>
                </div>--%>

                    				<div class="modal video-modal fade" id="share" tabindex="-1" role="dialog" aria-labelledby="myModal">
					<div class="modal-dialog" role="document">
						<div class="modal-content">
							<div class="modal-header">
                                <div class="container-fluid"> 
								<h4 style="margin-right:50px">Invite a Friend</h4>
								<button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>						
									<p>Invite a friend to create a freelance profile with us and also tell them that you are selling your textbook today by entering their email address below...Thanks!  </p>
                                </div>
							</div>
							<section>
								<div class="modal-body"><br />
                                <div class="form-group">
                                    <label>Friend's email</label>
                                    <asp:TextBox ID="txtshare1" CssClass="form-control" placeholder="Email" runat="server"></asp:TextBox><br />
                                </div>
								</div>
                                                            <div class='modal-footer'>
                                <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
        
                                <asp:Button ID="btnFinish" class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish' runat="server" Text="Publish" OnClick="btnFinish_Click" />
                           </div>
							</section>
						</div>
					</div>
				</div>
                          <p class="text-center" >
                           <a href="#home" data-toggle="tab" style="margin-top:-15px"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
                           <a href="#share" data-toggle="modal" style="margin-top:-15px"  class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                          </p>

                      </div>

                      <div class="tab-pane fade" id="doner">
                          <div class="text-center">
                            <i class="img-intro icon-checkmark-circle"></i>
                        </div>
                        <h3 class="head text-center">Save your book</h3>
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
