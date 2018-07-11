<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Accommodation/Accommodation.Master" AutoEventWireup="true" CodeBehind="landlord-list-a-room.aspx.cs" Inherits="Qaelo.Web.Users.Accommodation.landlord_list_a_room" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>List a room</title>
    <script src="../../../Template/Wizard/script.js"></script>
    <link href="../../../Template/Wizard/style.css" rel="stylesheet" />
    <link href="../../../Content/CustomCss/ListPlace/imageUpload.css" rel="stylesheet" />
    <link href="../../../Content/CustomCss/ListPlace/assets/css/gsdk-base.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!--Notifier-->
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
    <!--/Notifier-->

 <!--   Big container   -->
    <%--<div class="container">
        <div class="row">
        <div class="col-sm-8 col-sm-offset-2">
            <!--      Wizard container        -->  
                <div class="card wizard-card ct-wizard-orange" id="wizard">
                <form  name="roomForm">
                <!--        You can switch "ct-wizard-azzure"  with one of the next bright colors: "ct-wizard-blue", "ct-wizard-green", "ct-wizard-orange", "ct-wizard-red"             -->
                    	<div class="wizard-header">
                        	<h3>
                        	   <b>LIST YOUR ROOM </b> <br/>
                        	</h3>
                    	</div>
                    	<ul>
                            <li><a href="#location" data-toggle="tab">Step 1</a></li>
                            <li><a href="#type" data-toggle="tab">Step 2</a></li>
                            <li><a href="#facilities" data-toggle="tab">Step 3</a></li>
                            <li><a href="#description" data-toggle="tab">Finish</a></li>
                        </ul>
                        <div class="tab-content">

                            

                            <div class="tab-pane" id="description">

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
    </div>--%>



    <section style="background:#efefe9;">
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
                     
                     </ul></div>

                     <div class="tab-content">
                      <div class="tab-pane fade in active" id="home">
                              <h3 class="head text-center">List a Room</h3>
                              <p class="narrow text-center">
                                 Please fill all the fields below.
                              </p>

                                    <!-- Content here-->
                          <div class="row">
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
                                      <div class="form-group">
                                              <label>Distance from campus</label>
                                          <div class="input-group">
                                              <asp:TextBox ID="txtDistance" type="number" class="form-control" placeholder="Distance" runat="server"></asp:TextBox>
                                              <span class="input-group-addon">KM</span>
                                          </div>
                                      </div>
                                  </div>

                                  <div class="col-md-5 col-sm-offset-1"> 
                                        <label>Institution</label>
                                      <br />
                                         <asp:TextBox ID="txtText" placeholder="Type Tertiary Institution" runat="server" type="text" class="typeaheadPlaces tt-query form-control" autocomplete="on" spellcheck="false"></asp:TextBox>
                                     </div>         

                              </div>
                              <p class="text-center">
                                  <a href="#profile" data-toggle="tab" class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                              </p>
                      </div>

                      <div class="tab-pane fade" id="profile">
                          <h3 class="head text-center">Please upload 5 images of the available room</h3>
                        <!-- Content here-->
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

                                                <!-- Image upload 2-->

                                                <div class="col-xs-12 col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">  
                                                    <!-- image-preview-filename input [CUT FROM HERE]-->
                                                    <div class="input-group image-preview2">
                                                        <input type="text" class="form-control image-preview2-filename" disabled="disabled"/> <!-- don't give a name === doesn't send on POST/GET -->
                                                        <span class="input-group-btn">
                                                            <!-- image-preview-clear button -->
                                                            <button type="button" class="btn btn-default image-preview2-clear" style="display:none;">
                                                                <span class="glyphicon glyphicon-remove"></span> Clear
                                                            </button>
                                                            <!-- image-preview-input -->
                                                            <div class="btn btn-default image-preview2-input">
                                                                <span class="glyphicon glyphicon-folder-open"></span>
                                                                <span class="image-preview2-input-title">Browse</span>
                                                                <asp:FileUpload ID="fu2" accept="image/png, image/jpeg, image/gif" name="input-file-preview2" runat="server" />
                                                            </div>
                                                        </span>
                                                    </div><!-- /input-group image-preview [TO HERE]--> 
                                                </div>

                                                <!-- Image upload 3-->
                                                <div class="col-xs-12 col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">  
                                                    <!-- image-preview-filename input [CUT FROM HERE]-->
                                                    <div class="input-group image-preview3">
                                                        <input type="text" class="form-control image-preview3-filename" disabled="disabled"/> <!-- don't give a name === doesn't send on POST/GET -->
                                                        <span class="input-group-btn">
                                                            <!-- image-preview-clear button -->
                                                            <button type="button" class="btn btn-default image-preview3-clear" style="        display: none;">
                                                                <span class="glyphicon glyphicon-remove"></span> Clear
                                                            </button>
                                                            <!-- image-preview-input -->
                                                            <div class="btn btn-default image-preview3-input">
                                                                <span class="glyphicon glyphicon-folder-open"></span>
                                                                <span class="image-preview3-input-title">Browse</span>
                                                                <asp:FileUpload ID="fu3" accept="image/png, image/jpeg, image/gif" name="input-file-preview3" runat="server" />
                                                            </div>
                                                        </span>
                                                    </div><!-- /input-group image-preview [TO HERE]--> 
                                                </div>

                                                <!-- Image upload 4-->
                                                <div class="col-xs-12 col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">  
                                                    <!-- image-preview-filename input [CUT FROM HERE]-->
                                                    <div class="input-group image-preview4">
                                                        <input type="text" class="form-control image-preview4-filename" disabled="disabled"/> <!-- don't give a name === doesn't send on POST/GET -->
                                                        <span class="input-group-btn">
                                                            <!-- image-preview-clear button -->
                                                            <button type="button" class="btn btn-default image-preview4-clear" style="        display: none;">
                                                                <span class="glyphicon glyphicon-remove"></span> Clear
                                                            </button>
                                                            <!-- image-preview-input -->
                                                            <div class="btn btn-default image-preview4-input">
                                                                <span class="glyphicon glyphicon-folder-open"></span>
                                                                <span class="image-preview4-input-title">Browse</span>
                                                                <asp:FileUpload ID="fu4" accept="image/png, image/jpeg, image/gif" name="input-file-preview4" runat="server" />
                                                            </div>
                                                        </span>
                                                    </div><!-- /input-group image-preview [TO HERE]--> 
                                                </div>

                                                <!-- Image upload 5-->
                                                <div class="col-xs-12 col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">  
                                                    <!-- image-preview-filename input [CUT FROM HERE]-->
                                                    <div class="input-group image-preview5">
                                                        <input type="text" class="form-control image-preview5-filename" disabled="disabled"/> <!-- don't give a name === doesn't send on POST/GET -->
                                                        <span class="input-group-btn">
                                                            <!-- image-preview-clear button -->
                                                            <button type="button" class="btn btn-default image-preview5-clear" style="        display: none;">
                                                                <span class="glyphicon glyphicon-remove"></span> Clear
                                                            </button>
                                                            <!-- image-preview-input -->
                                                            <div class="btn btn-default image-preview5-input">
                                                                <span class="glyphicon glyphicon-folder-open"></span>
                                                                <span class="image-preview5-input-title">Browse</span>
                                                                <asp:FileUpload ID="fu5"  accept="image/png, image/jpeg, image/gif" name="input-file-preview5" runat="server" />
                                                            </div>
                                                        </span>
                                                    </div><!-- /input-group image-preview [TO HERE]--> 
                                                </div>
                                    </div>
                                </div>
                          <p class="text-center">
                           <a href="#home" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
                           <a href="#messages" data-toggle="tab"  class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                          </p>

                      </div>

                      <div class="tab-pane fade" id="messages">
                              <h3 class="head text-center">Tell us more about the accommodation.</h3>
                          
                           <!-- Content here-->
                                <div class="row">
                                  <div class="col-sm-5 col-sm-offset-1">
                                      <div class="form-group">
                                          <label>Is the accomodation Student Loan Accredited?</label>
                                          <asp:DropDownList CssClass="form-control" Width="100%" ID="ddlAccreditation" runat="server">
                                              <asp:ListItem disabled="" selected="">- response -</asp:ListItem>
                                              <asp:ListItem Value="True">Yes</asp:ListItem>
                                              <asp:ListItem Value="False">No</asp:ListItem>
                                          </asp:DropDownList>
                                      </div>
                                     </div>
                                  <div class="col-sm-5 col-sm-offset-">
                                      <div class="col-sm-6">
                                          <div class="form-group" style="margin-left:-15px">
                                              <label>Accommodates</label>
                                              <asp:DropDownList CssClass="form-control" Width="100%" ID="ddlArrangement" runat="server">
                                                  <asp:ListItem disabled="" selected="">- persons -</asp:ListItem>
                                                  <asp:ListItem Value="Single">Single</asp:ListItem>
                                                  <asp:ListItem Value="Sharing">Sharing</asp:ListItem>
                                              </asp:DropDownList>
                                          </div>
                                      </div>
                                                                            
                                      <div class="col-sm-6">
                                          <div class="form-group">
                                              <label>Gender</label>
                                              <asp:DropDownList CssClass="form-control" Width="100%" ID="ddlGender" runat="server">
                                                  <asp:ListItem disabled="" selected="">- Gender -</asp:ListItem>
                                                  <asp:ListItem Value="All">All</asp:ListItem>
                                                  <asp:ListItem Value="Male">Male</asp:ListItem>
                                                  <asp:ListItem Value="Female">Female</asp:ListItem>
                                              </asp:DropDownList>
                                          </div>

                                      </div>
                                  </div>

                                  <div class="col-sm-5 col-sm-offset-1">
                                      <div class="form-group"> 
                                          <label>Property Type</label>                                  
                                          <asp:DropDownList CssClass="form-control" Width="100%" ID="ddlAccommodationType" runat="server">
                                              <asp:ListItem disabled="" selected="">- Select One -</asp:ListItem>
                                              <asp:ListItem Value="Bachelor Flat">Bachelor Flat</asp:ListItem>
                                              <asp:ListItem Value="Commune/House">Commune/House</asp:ListItem>
                                              <asp:ListItem Value="Flat/Apartment">Flat/Apartment</asp:ListItem>
                                          </asp:DropDownList>
                                      </div>
                                  </div>

                                  <div class="col-sm-5 ">
                                      <div class="form-group">
                                          <label>Rent price</label>
                                          <div class="input-group">
                                              <%--<span class="input-group-addon">R</span>--%>
                                              <asp:TextBox ID="txtPrice" class="form-control" type="number" placeholder="Rent per month" runat="server"></asp:TextBox>
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
                          <h3 class="head text-center">Small description about the property. </h3>
<%--                          <p class="narrow text-center">
                              Please choose the length and cost of the advertisement.
                          </p>--%>
                                             <!-- Content here-->
                               <div class="row">
                                    <div class="col-sm-6 col-sm-offset-1">
                                         <div class="form-group">
                                            <label>Place description</label>
                                           <asp:TextBox ID="txtDescription" class="form-control" placeholder=""  runat="server" TextMode="multiline" Width="100%"  Rows="7" ></asp:TextBox>
                                          </div>
                                    </div>
                                    <div class="col-sm-4 ">
                                         <div class="form-group">
                                            <label>Example</label>
                                            <p class="description">"The 8 roomed commune has wifi, dstv etc.Please include features about the property"</p>
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
                        <h3 class="head text-center">Save your room</h3>
                          <p class="text-center">
                            <asp:Button ID="Button1" class="btn btn-success btn-outline-rounded green" runat="server" Text="Ok" OnClick="btnFinish_Click" />
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
