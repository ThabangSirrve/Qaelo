<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="students-add-work.aspx.cs" Inherits="Qaelo.Web.Users.Student.students_add_work" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Previous Work</title>
    <link href="../../../Template/Wizard/style.css" rel="stylesheet" />
    <script src="../../../Template/Wizard/script.js"></script>
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
                     <a href="#home" data-toggle="tab">
                      <span class="round-tabs one">
                              <i class="glyphicon glyphicon-picture"></i>
                      </span> 
                  </a></li>

                  <li><a href="#profile" data-toggle="tab" >
                     <span class="round-tabs two">
                         <i class="glyphicon glyphicon-play"></i>
                     </span> 
           </a>
                 </li>
                 <li><a href="#messages" data-toggle="tab" >
                     <span class="round-tabs three">
                          <i class="glyphicon glyphicon-link"></i>
                     </span> </a>
                     </li>

                     <li><a class="disabled">
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
                              <h3 class="head text-center">UPLOAD FREELANCE PORTFOLIO PICTURES</h3>
                              <p class="narrow text-center">
                                 Please upload pictures of your work.
                              </p>

                                    <!-- Content here-->
                          <div class="row">
                                    <div class="col-sm-4 col-sm-offset-4">
                                <div class="form-group">                                                                     
                                     <asp:FileUpload ID="file1" runat="server" /><br />
                                    <asp:FileUpload ID="file2" runat="server" /><br />
                                    <asp:FileUpload ID="file3" runat="server" />
                                    </div>
                                           
                                    </div>
                                
                                    </div>
                              <p class="text-center">
                                  <a href="#profile" data-toggle="tab" class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                              </p>
                      </div>

                      <div class="tab-pane fade" id="profile">
                          <h3 class="head text-center">UPLOAD FREELANCE PORTFOLIO VIDEOS</h3>
                            <p class="narrow text-center">
                                 Please upload videos of your work.
                              </p>
                        <!-- Content here-->
                                                    <div class="row">
                                    <div class="col-sm-4 col-sm-offset-4">
                                    <div class="form-group">    
                                    <asp:FileUpload ID="file4" runat="server" /><br />
                                    <asp:FileUpload ID="file5" runat="server" /><br />
                                    <asp:FileUpload ID="file6" runat="server" />
                                    </div>
                                        </div></div>
                                   
                          <p class="text-center">
                           <a href="#home" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
                           <a href="#messages" data-toggle="tab"  class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                          </p>

                      </div>
                         
                      <div class="tab-pane fade" id="messages">
                              <h3 class="head text-center">Freelance CV: What I’ve done so far</h3>
                              <p class="narrow text-center">
                                 Please fill in description of your work.
                              </p>
                           <!-- Content here-->
                                    <div class="row">
                                    <div class="col-sm-4 col-sm-offset-4">
                           <div class="form-group">
                                    <asp:TextBox ID="txtLink" class="form-control" placeholder="" TextMode="multiline"  Rows="6"  runat="server"></asp:TextBox>            
                           </div>  
                                        </div>
                                    </div>
                          <p class="text-center">
                           <a href="#profile" data-toggle="tab"  class="btn btn-warning btn-outline-rounded orange"> Previous <span style="margin-left:10px;" class="glyphicon glyphicon-backward"></span></a>
                           <a href="#doner" data-toggle="tab"  class="btn btn-success btn-outline-rounded green"> Next <span style="margin-left:10px;" class="glyphicon glyphicon-forward"></span></a>
                          </p>
                      </div>
                         

                      <div class="tab-pane fade" id="doner">
                          <div class="text-center">
                            <i class="img-intro icon-checkmark-circle"></i>
                        </div>
                        <h3 class="head text-center">Save changes</h3>
                          <p class="text-center">
                          <asp:Button ID="btnFinish" class="btn btn-success btn-outline-rounded green" runat="server" Text="OK" OnClick="btnFinish_Click"  />
                          </p>
                        </div>
                        <div class="clearfix"></div>
                    </div>

            </div>
            </div>
            </div>
            </section>
                            
</asp:Content>
