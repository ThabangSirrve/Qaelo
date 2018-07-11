<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Shop/Shop.Master" AutoEventWireup="true" CodeBehind="EditSpecial.aspx.cs" Inherits="Qaelo.Web.Users.Shop.EditSpecials" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Edit Special</title>
    <!-- checkboxes-->
    <link href="../../../Content/CustomCss/checkboxes.css" rel="stylesheet" />
    <link href="../../../Template/Wizard/style.css" rel="stylesheet" />
    <script src="../../../Template/Wizard/script.js"></script>
    <script src="../../../Template/js/jquery-2.1.4.min.js"></script>
    <script src="../../../Template/js/bootstrap.js"></script>

    <link href="../../../Content/CustomCss/ListPlace/imageUpload.css" rel="stylesheet" />
    
     <!-- Search -->
           
    <script src="../../../Scripts/Search/typeahead.bundle.js"></script>
    <script src="../../../Scripts/Search/universities.js"></script>

    <!-- Search-->
        <style type="text/css">
.bs-example {
	font-family: sans-serif;
	position: relative;
	margin: 100px;
}
.typeahead, .tt-query, .tt-hint {

	font-size: 15px; /* Set input font size */
	height: 35px;
	line-height: 30px;
	outline: medium none;
	padding: 8px 12px;
	width: 500px;
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
	width: 500px;
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
    <!--/Search -->

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section style="background:#efefe9;">
        <div class="container">
            <div class="row">
                    <div class="container">
                      <div class="alert alert-danger" id="divError" runat="server" visible="false">
                    <strong>Error</strong> All fields are required.
                  </div>
                </div>
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
                              <h3 class="head text-center">Update Special</h3>
                              <p class="narrow text-center">
                                 Please fill all the fields below.
                              </p>
                                    <div class="col-md-12 text-center">
                                       <div class="form-group">
                                          <label>Institution:</label>
                                           <br /> 
                                         <asp:TextBox ID="txtText" placeholder="Type Tertiary Institution" runat="server" type="text" class="typeaheadPlaces tt-query form-control" autocomplete="on" spellcheck="false"></asp:TextBox>
                                  
                                             </div>
                                        </div>                          
                                     <div class="col-sm-5 col-sm-offset-1">
                                      <div class="form-group">
                                              <label>Shop No:</label>
                                          <div class="input-group">
                                              <span class="input-group-addon"><i class="fa fa-address-card" aria-hidden="true"></i></span>
                                              <asp:TextBox ID="txtShoNo" type="number" class="form-control"  placeholder="Shop number" runat="server"></asp:TextBox>
                                          </div>
                                      </div>
                                  </div>

                                     <div class="col-sm-5">
                                      <div class="form-group">
                                              <label>Shop Name:</label>
                                          <div class="input-group">
                                              <span class="input-group-addon"><i class="fa fa-address-card" aria-hidden="true"></i></span>
                                              <asp:TextBox ID="txtShopName" class="form-control"  placeholder="Name of the shop" runat="server"></asp:TextBox>
                                          </div>
                                      </div>
                                  </div>
                              <p class="text-center">
                                  <a href="#profile" data-toggle="tab" class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                              </p>
                      </div>

                      <div class="tab-pane fade" id="profile">
                          <h3 class="head text-center">Special Image</h3>
                          <p class="narrow text-center">
                             Please upload  image for the advertisment.
                          </p>
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
                          <p class="text-center">
                           <a href="#home" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
                           <a href="#messages" data-toggle="tab"  class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                          </p>
                          
                      </div>

                      <div class="tab-pane fade" id="messages">
                              <h3 class="head text-center" style="margin-top:-20px">Small description about the Special.</h3>
                          <div class="row">
                                    
                                    <div class="col-sm-6 col-sm-offset-3">
                                         <div class="form-group">
                                            <label>Trading Hours</label>
                                           <asp:TextBox ID="txtOpenHours" class="form-control" placeholder="08:00 - 16:30"  runat="server" Width="100%" ></asp:TextBox>
                                         </div>
                                    </div>

                                    <div class="col-sm-6 col-sm-offset-3">
                                         <div class="form-group">
                                            <label>Special's description</label>
                                           <asp:TextBox ID="txtDescription" class="form-control" placeholder=""  runat="server" TextMode="multiline" Width="100%"  Rows="3" ></asp:TextBox>
                                          </div>
                                    </div>
                                </div>
                          <p class="text-center">
                           <a href="#profile" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
                           <a href="#settings" data-toggle="tab"  class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                          </p>
                      </div>

                      <div class="tab-pane fade" id="settings">
                          <h3 class="head text-center">Cost of the Special</h3>
                            <%--                          <p class="narrow text-center">
                              Please choose the length and cost of the advertisement.
                          </p>--%>
                           <%--<div class="col-sm-6 col-sm-offset-3" style="margin-top:-20px">
                                            <div class="funkyradio">
                                                <div class="funkyradio-default">
                                                    <input type="radio" runat="server" name="radio" id="adR70" checked/>
                                                    <label for="adR70"><b class="divider-short">R70 1 Week</b></label>
                                                </div>

                                                <div class="funkyradio-primary">
                                                    <input type="radio" runat="server" name="radio" id="adR100" />
                                                    <label for="adR100"><b class="divider-short">R100 For 2 weeks</b></label>
                                                </div>
                                                <div class="funkyradio-success">
                                                    <input type="radio" runat="server" name="radio" id="adR300" />
                                                    <label for="adR300"><b class="divider-short">R300 For a month</b></label>
                                                </div>
                                            </div>
                          <p class="text-center">
                           <a href="#messages" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
                           <a href="#doner" data-toggle="tab"  class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                          </p>
                                        </div>--%>
                          <div class="row">
                              <div class="col-sm-6 col-sm-offset-3">
                                <div class="form-group">
                              <label>Special's Name</label>             
                              <asp:TextBox ID="txtName" class="form-control" placeholder="Name of special your are offering"  runat="server" Width="100%" ></asp:TextBox>     
                                       </div>
                                  </div>
                                 
                               <div class="col-sm-6 col-sm-offset-3"> 
                                   <div class="form-group">                  
                               <label>Special's Price</label>             
                              <asp:TextBox ID="txtPrice" class="form-control" placeholder="Please include currency"  runat="server" Width="100%" ></asp:TextBox>                          
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
                        <h3 class="head text-center">Save your updates</h3>
                          <p class="text-center">
                            <asp:Button ID="btnFinish" class="btn btn-success btn-outline-rounded green" runat="server" Text="OK" OnClick="btnFinish_Click" />
                          </p>
                        </div>
                        <div class="clearfix"></div>
                    </div>
            </div>
            </div>
            </div>
            </section>
    
    <!-- file upload -->
    <script src="../../../Scripts/imageUpload.js"></script>
</asp:Content>
