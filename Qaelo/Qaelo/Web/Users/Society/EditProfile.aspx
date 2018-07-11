<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Society/Society.Master" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="Qaelo.Web.Users.Society.EditProfile1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title> Edit Profile</title>
    <style type="text/css">
.bs-example {
	font-family: sans-serif;
	position: relative;
	margin: 100px;
}
.typeahead, .tt-query, .tt-hint {

	font-size: 15px; /* Set input font size */
	height: 100%;
	line-height: 30px;
	outline: medium none;
	padding: 8px 12px;
	width: 300px;
}
.typeahead {
	background-color: #FFFFFF;
}
.typeahead:focus {
	
}
.tt-query {
	box-shadow: 0 1px 1px rgba(0, 0, 0, 0.075) inset;
}
.tt-hint {
	color: #999999;
}
.tt-menu {
	background-color: #FFFFFF;
	box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
	margin-top: 12px;
	padding: 8px 0;
	width: 300px;
}
.tt-suggestion {
	font-size: 15px;  /* Set suggestion dropdown font size */
	padding: 3px 20px;
    text-align:left;
}
.tt-suggestion:hover {
	cursor: pointer;
	background-color: #0097CF;
	color: #FFFFFF;
}
.tt-suggestion p {
	margin: 0;
}
</style>
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
        <!--   Big container   -->
    <div class="container">
        <div class="row">
        <div class="col-sm-8 col-sm-offset-2">
            <!--      Wizard container        -->   
                <div class="card wizard-card ct-wizard-orange" id="wizardProfile">
                    <form action="" method="">
                <!--        You can switch "ct-wizard-orange"  with one of the next bright colors: "ct-wizard-blue", "ct-wizard-green", "ct-wizard-orange", "ct-wizard-red"             -->
                
                    	<div class="wizard-header">
                        	<h3>
                        	   <b>Edit</b>YOUR PROFILE <br/>
                        	</h3>
                    	</div>
                    	<ul>
                            <li><a href="#about" data-toggle="tab">About</a></li>
                            <li><a href="#account" data-toggle="tab">Account</a></li>
                            <li><a href="#address" data-toggle="tab">Business</a></li>
                        </ul>
                        
                        <div class="tab-content">
                            <div class="tab-pane" id="about">
                              <div class="row">
                                  <h4 class="info-text"> Basic information</h4>
                                  <div class="col-sm-4 col-sm-offset-1">
                                     <div class="picture-container">
                                          <div class="picture">
                                              <img  src="" class="picture-src" runat="server" id="wizardPicturePreview" title=""/>
                                              <asp:FileUpload ID="wizardPicture" runat="server" />
                                          </div>
                                          <h6>Choose Picture</h6>
                                      </div>
                                  </div>
                                  <div class="col-sm-6">
                                      <div class="form-group">
                                          <div class="col-sm-12">
                                        <label>Society Name <small>(required)</small></label>
                                          <asp:TextBox ID="txtName" name="firstname" type="text" class="form-control" placeholder="My Society name is..." runat="server"></asp:TextBox>

                                          </div>
                                      </div>
                                      <div class="form-group">
                                          <div class="col-sm-6">
                                          <label>Email <small>(required)</small></label>
                                              <asp:TextBox ID="txtEmail" name="email" type="email" class="form-control" placeholder="me@gmail.com" runat="server"></asp:TextBox>
                                          </div>
                                          <div class="col-sm-6">
                                               <label>Number<small>(required)</small></label>
                                              <asp:TextBox ID="txtNumber" name="number" type="number" class="form-control" placeholder="0712345678" runat="server"></asp:TextBox>
                                          </div>
                                         </div>
                                  </div>

                                  <div class="col-sm-12">
                                      <div class="col-sm-5">
                                          
                                      </div>

                                      <div class="col-sm-7">
                                                                                
                                          <div class="form-group">
                                          <div class="col-sm-12">
                                        <label>Institution:</label>
                                           <br /> 
                                         <asp:TextBox ID="txtText"  placeholder="Type Tertiary Institution" runat="server" type="text" class="typeaheadPlaces tt-query form-control" autocomplete="on" spellcheck="false"></asp:TextBox>
                                      
                                          </div>
                                      </div>
                                     </div>
                                  </div>
                              </div>
                            </div>

                            <div class="tab-pane" id="account">
                                <h4 class="info-text"> Update your Password</h4>
                                <div class="row">
                                    <div class="col-sm-7 col-sm-offset-2">
                                         <div class="form-group">
                                             <asp:TextBox ID="txtCurrentPassword" type="password" class="form-control" placeholder="Cuurent password" runat="server"></asp:TextBox>
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
                                             <asp:Button ID="btnUpdate" class="btn btn-info pull-right" runat="server" Text="update" OnClick="btnUpdate_Click" />
                                          </div>
                                    </div>
                                </div>
                            </div>

                            <div class="tab-pane" id="address">
                                <div class="row">
                                    <div class="col-sm-12">
                                        <h4 class="info-text"> More About your Society</h4>
                                    </div>
                                    <div class="col-sm-6 col-sm-offset-1">
                                         <div class="form-group">
                                             <div class="col-sm-6">
                                            <label>Meeting Time</label>
                                             <asp:TextBox ID="txtMeetingTime" MaxLength="13" type="text" class="form-control" placeholder="16:00-19:00" runat="server"></asp:TextBox>

                                             </div>
                                             <div class="col-sm-6">
                                             <label>Meetings Day(s)</label>
                                             <asp:TextBox ID="txtMeetingDays" type="text" class="form-control" placeholder="Mondays..." runat="server"></asp:TextBox>

                                             </div>
                                          </div>
                                    </div>
                                    <div class="col-sm-4">
                                      <div class="form-group">
                                          <label>Enter Society Type</label>
                                             <asp:TextBox ID="txtSocityType" type="text" class="form-control" placeholder="Society Type" runat="server"></asp:TextBox>
                                      </div>
                                    </div>
                                    <div class="col-sm-6 col-sm-offset-1">
                                         <div class="form-group">
                                         <label>Small description about the Society. </label>
                                             <asp:TextBox ID="txtDescription" class="form-control" placeholder="" TextMode="multiline"  Rows="6"  runat="server">

                                             </asp:TextBox>
                                          </div>
                                    </div>
                                    <div class="col-sm-4">
                                         <div class="form-group">
                                            <label>Facebook Link</label>
                                            <asp:TextBox ID="txtFacebookLink" CssClass="form-control" placeholder="paste facebook link here" runat="server"></asp:TextBox>
                                          </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="wizard-footer">
                            <div class="pull-right">
                                <input type='button' class='btn btn-next btn-fill btn-warning btn-wd btn-sm' name='next' value='Next' />
                                <asp:Button ID="btnFinish" class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish' runat="server" Text="Finish" OnClick="btnFinish_Click" />
                            </div>
                            <div class="pull-left">
                                <input type='button' class='btn btn-previous btn-fill btn-default btn-wd btn-sm' name='previous' value='Previous' />
                            </div>
                            <div class="clearfix"></div>
                        </div>	
                    </form>
                </div>
        </div>
        </div><!-- end row -->
        
    </div>
     <!--  big container -->
    
</asp:Content>
