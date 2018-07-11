<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Society/Society.Master" AutoEventWireup="true" CodeBehind="ListEvent.aspx.cs" Inherits="Qaelo.Web.Users.Society.ListEvent1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Post Event</title>
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
	width: 270px;
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
	width: 270px;
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
     <!--   Big container   -->
    <div class="container">
        <div class="row">
        <div class="col-sm-8 col-sm-offset-2">
            <!--      Wizard container        -->  
                <div class="card wizard-card ct-wizard-orange" id="wizard">
                <form  name="roomForm">
                <!--        You can switch "ct-wizard-azzure"  with one of the next bright colors: "ct-wizard-blue", "ct-wizard-green", "ct-wizard-orange", "ct-wizard-red"             -->
                    	<div class="wizard-header">
                        	<h3>
                        	   <b>Create an Event </b> <br/>
                        	</h3>
                    	</div>
                    	<ul>
                            <li><a href="#location" data-toggle="tab">Step 1</a></li>
                            <li><a href="#type" data-toggle="tab">Step 2</a></li>
                            <li><a href="#facilities" data-toggle="tab">Step 3</a></li>
                            <li><a href="#description" data-toggle="tab">Finish</a></li>
                        </ul>
                        <div class="tab-content">
                            <div class="tab-pane" id="location">
                              <div class="row">
                                  <div class="col-sm-12">
                                    <h4 class="info-text"> Basic details</h4>
                                  </div>
                                  
                                  <div class="col-sm-5 col-sm-offset-1">
                                      <div class="form-group">
                                              <label>Address</label>
                                          <div class="input-group">
                                              <span class="input-group-addon"><i class="fa fa-address-card" aria-hidden="true"></i></span>
                                              <asp:TextBox ID="txtAddress" class="form-control"  placeholder="Address of the accommodation" runat="server"></asp:TextBox>
                                          </div>
                                      </div>
                                  </div>
                                                                    
                                  <div class="col-sm-5">
                                                                             
                                      <div class="col-sm-6 form-group">
                                              <label>Institution:</label>
                                           <br /> 
                                         <asp:TextBox ID="txtText"  placeholder="Type Tertiary Institution" runat="server" type="text" class="typeaheadPlaces tt-query form-control" autocomplete="on" spellcheck="false"></asp:TextBox>
                                  
                                             </div>
                                      </div>
                              </div>

                            </div>
                            <div class="tab-pane" id="type">
                                <h4 class="info-text">Please upload  image for the event</h4>
                                <div class="row">
                                    <div class="col-sm-10 col-sm-offset-1"> 
                                                  <!-- Image upload 1-->
                                                <div class="col-xs-12 col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">  
                                                    <!-- image-preview-filename input [CUT FROM HERE]-->
                                                    <div class="input-group image-preview">
                                                        <input type="text" class="form-control image-preview-filename" disabled="disabled"/> <!-- don't give a name === doesn't send on POST/GET -->
                                                        <span class="input-group-btn">
                                                            <!-- image-preview-clear button -->
                                                            <button type="button" class="btn btn-default image-preview-clear" style="        display: none;">
                                                                <span class="glyphicon glyphicon-remove"></span> Clear
                                                            </button>
                                                            <!-- image-preview-input -->
                                                            <div class="btn btn-default image-preview-input">
                                                                <span class="glyphicon glyphicon-folder-open"></span>
                                                                <span class="image-preview-input-title">Browse</span>
                                                                <%--<input type="file" accept="image/png, image/jpeg, image/gif" runat="server" name="input-file-preview"/>--%> <!-- rename it -->
                                                                <asp:FileUpload ID="fu1" accept="image/png, image/jpeg, image/gif" name="input-file-preview" runat="server" />
                                                            </div>
                                                        </span>
                                                    </div><!-- /input-group image-preview [TO HERE]--> 
                                                </div>
                                    </div>
                                </div>
                            </div>

                            <div class="tab-pane" id="facilities">
                                <h4 class="info-text">Tell us more about the event. </h4>
                                <div class="row">
                                  <div class="col-sm-5 col-sm-offset-1">
                                      <div class="form-group">
                                          <label>Name of the event</label>
                                              <asp:TextBox ID="txtName" class="form-control" Width="100%" placeholder="Event Name" runat="server"></asp:TextBox>
                                      </div>
                                  </div>

                                  <div class="col-sm-5" >
                                      <div class="form-group"> 
                                          <label>Date</label>                                  
                                          <asp:TextBox ID="txtDate" type="date" class="form-control" Width="100%" placeholder="Event Name" runat="server"></asp:TextBox>
                                      </div>
                                  </div>

                                  <div class="col-sm-5 col-sm-offset-1">
                                      <div class="form-group">
                                          <label>Entry Fee</label>
                                          <div class="input-group">
                                              <span class="input-group-addon">R</span>
                                              <asp:TextBox ID="txtPrice" class="form-control" type="number" placeholder="Entry Fee" runat="server"></asp:TextBox>
                                          </div>
                                      </div>
                                  </div>
                                </div>
                            </div>

                            <div class="tab-pane" id="description">
                                <div class="row">
                                    <h4 class="info-text">Small description about Event. </h4>
                                    <div class="col-sm-6 col-sm-offset-1">
                                         <div class="form-group">
                                            <label>Event description</label>
                                           <asp:TextBox ID="txtDescription" class="form-control" placeholder=""  runat="server" TextMode="multiline" Width="100%"  Rows="9" ></asp:TextBox>
                                          </div>
                                    </div>
                                                                       
                                     <div class="col-sm-4">
                                         <div class="form-group">
                                            <label>Do you sell tickets?</label>
                                             <asp:DropDownList CssClass="form-control" Width="100%" ID="ddlSellTickets" runat="server">
                                              <asp:ListItem Value="False">No</asp:ListItem>
                                              <asp:ListItem Value="True">Yes</asp:ListItem>
                                          </asp:DropDownList>
                                          </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="wizard-footer">
                            	<div class="pull-right">
                                    <input type='button' class='btn btn-next btn-fill btn-warning btn-wd btn-sm' name='next' value='Next' />
                                    <asp:Button ID="btnFinish" runat="server" Text="Finish" type='button' class='btn btn-finish btn-fill btn-success btn-wd btn-sm' OnClick="btnFinish_Click"/>
                                </div>
                                <div class="pull-left">
                                    <input type='button' class='btn btn-previous btn-fill btn-default btn-wd btn-sm' name='previous' value='Previous' />
                                </div>
                                <div class="clearfix"></div>
                        </div>	

                    </form>
                </div>
        </div>
                                                        
        </div> <!-- row -->
    </div>
     <!--  big container -->
                              
</asp:Content>