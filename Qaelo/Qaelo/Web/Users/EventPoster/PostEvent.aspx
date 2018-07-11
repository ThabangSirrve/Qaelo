<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/EventPoster/EventPoster.Master" AutoEventWireup="true" CodeBehind="PostEvent.aspx.cs" Inherits="Qaelo.Web.Users.EventPoster.PostEvent1" %>
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
        <link href="../../../Template/Wizard/style.css" rel="stylesheet" />
     <link href="../../../Content/CustomCss/ListPlace/imageUpload.css" rel="stylesheet" />
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
                     <li >
                     <a href="#home" data-toggle="tab" title="">
                      <span class="round-tabs one">
                              <i class="glyphicon glyphicon-home"></i>
                      </span> 
                  </a></li>

                  <li><a href="#profile" data-toggle="tab" title="">
                     <span class="round-tabs two">
                         <i class="glyphicon glyphicon-blackboard"></i>
                     </span> 
           </a>
                 </li>
                 <li><a href="#messages" data-toggle="tab" title="">
                     <span class="round-tabs three">
                          <i class="glyphicon glyphicon-book"></i>
                     </span> </a>
                     </li>

                     <li><a href="#settings" data-toggle="tab" title="">
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
                              <h3 class="head text-center">Create an event</h3>
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
                                              <asp:TextBox ID="txtAddress" class="form-control"  placeholder="Address of the event" runat="server"></asp:TextBox>
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
                              <p class="text-center">
                                  <a href="#profile" data-toggle="tab" class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                              </p>
                      </div>

                      <div class="tab-pane fade" id="profile">
                          <h3 class="head text-center">Event Image</h3>
                          <p class="narrow text-center">
                             Please upload  image for the event
                          </p>
                        <!-- Content here-->
                                <div class="row">
                                    <div class="col-sm-10 col-sm-offset-1"> 
                                                  <!-- Image upload 1-->
                                                <div class="col-xs-12 col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">  
                                                    <asp:FileUpload ID="fu1" CssClass="btn btn-default" accept="image/png, image/jpeg, image/gif" name="input-file-preview" runat="server" />
                                                </div>
                                    </div>
                                </div>
                          <p class="text-center">
                           <a href="#home" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
                           <a href="#messages" data-toggle="tab"  class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                          </p>

                      </div>

                      <div class="tab-pane fade" id="messages">
                              <h3 class="head text-center">Tell us more about the event.</h3>
                          
                           <!-- Content here-->
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
                                              <asp:TextBox ID="txtPrice" class="form-control" type="text" placeholder="Entry Fee" runat="server"></asp:TextBox>
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
                          <h3 class="head text-center">Event Description</h3>                                             
                          <!-- Content here-->
                          <div class="row">
                                    <div class="col-sm-6 col-sm-offset-1">
                                         <div class="form-group">
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
                          <p class="text-center" style="padding-top:-50px">
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
                            <asp:Button ID="btnFinish" class="btn btn-success btn-outline-rounded green" runat="server" Text="Ok" OnClick="btnFinish_Click" />
                          </p>
                        </div>
                        <div class="clearfix"></div>
                    </div>
            </div>
            </div>
            </div>
            </section>
                   



<script>
    $(function () {
        $('a[title]').tooltip();
    });

</script>
</asp:Content>
