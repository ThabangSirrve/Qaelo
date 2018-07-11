<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/EventPoster/EventPoster.Master" AutoEventWireup="true" CodeBehind="Sellticket.aspx.cs" Inherits="Qaelo.Web.Users.EventPoster.Sellticket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Sell Ticket</title>
    <link href="../../../Template/Wizard/style.css" rel="stylesheet" />
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
                         <i class="glyphicon glyphicon-briefcase"></i>
                     </span> 
           </a>
                 </li>
                 <li><a >
                     <span class="round-tabs three">
                          <i class="glyphicon glyphicon-book"></i>
                     </span> </a>
                     </li>

                     <li><a>
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
                              <h3 class="head text-center" style="margin-top:-30px">Ticket Information</h3>

                                    <!-- Content here-->
                          <div class="row">
                                  <div class="col-sm-5 col-sm-offset-1">
                                      <div class="form-group">
                                        <label>Bank <small>(required)</small></label>
                                          <asp:TextBox ID="txtFullBank" name="bankname" type="text" class="form-control"  runat="server"></asp:TextBox>
                                      </div>
                                          <div class="form-group">
                                              <label>Account Number <small>(required)</small></label>
                                              <asp:TextBox ID="txtAccNo" type="number"  name="acc Number" class="form-control"  runat="server"></asp:TextBox>
                                          </div>
                                              <div class="form-group">
                                              <label>Reference <small>(required)</small></label>
                                              <asp:TextBox ID="txtReference" name="email"  class="form-control" placeholder="reference to be used by attendees" runat="server"></asp:TextBox>
                                          </div>
                                  </div>

                                  <div class="col-sm-5">
                                        <div class="form-group">
                                        <label>Branch code <small></small></label>
                                          <asp:TextBox ID="txtBraCode" name="Code" type="number" class="form-control" runat="server"></asp:TextBox>
                                      </div>
                                       <div class="form-group">
                                              <label>Account Holder <small>(required)</small></label>
                                              <asp:TextBox ID="txtAccHolder" name="AccountHolder"  class="form-control"  runat="server"></asp:TextBox>
                                          </div>
                                      
                                  </div>
                              </div>
                              <p class="text-center">
                                  <a href="#profile" data-toggle="tab" class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                              </p>
                      </div>

                      <div class="tab-pane fade" id="profile" style="margin-top:-30px">
                          <h3 class="head text-center">Please describe your prices</h3>
<%--                          <p class="narrow text-center">
                             Please upload  image for the advertisment.
                          </p>--%>

                          <div class="row">
                                     <div class="col-sm-7 col-sm-offset-2">
                                         <div class="form-group">
                                          <label>Pricing Description</label>
                                            <asp:TextBox ID="txtDescription" class="form-control" placeholder="e.g VIP Rxxx, VVIP Rxxx"  runat="server" TextMode="multiline" Width="100%"  Rows="9" ></asp:TextBox>
                                         </div>
                                    </div>
                                </div>
                        <!-- Content here-->
                          <p class="text-center">
                           <a href="#home" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
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
