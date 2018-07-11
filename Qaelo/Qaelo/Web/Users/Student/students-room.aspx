<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="students-room.aspx.cs" Inherits="Qaelo.Web.Users.Student.Room" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Room</title>

    <!--Rating -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.6.0/css/font-awesome.min.css"/>
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
    <div class="col-sm-9 col-sm-offset-1">
            
   <div class="panel panel-info">
                <div class="panel-heading" style="background-color:antiquewhite">
                    <asp:Literal ID="lblPanelTopic" runat="server"></asp:Literal>
                </div>

                <div class="panel-body">
                    <div class="col-sm-12">
                        <div class="col-sm-8">
                            <div id="myCarousel" class="carousel slide" data-ride="carousel">
  <!-- Indicators -->
  <ol class="carousel-indicators">
    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
    <li data-target="#myCarousel" data-slide-to="1"></li>
    <li data-target="#myCarousel" data-slide-to="2"></li>
    <li data-target="#myCarousel" data-slide-to="3"></li>
    <li data-target="#myCarousel" data-slide-to="4"></li>
  </ol>
                                
  <!-- Wrapper for slides -->
  <div class="carousel-inner" role="listbox">
    <div class="item active">
      <img src="../../../Images/Accommodation/default_home.jpg" id="imgImage1" runat="server" class="img-rounded"  style="height:400px;width:100%"  alt="image1"/>
    </div>

    <div class="item">
      <img src="../../../Images/Accommodation/default_home.jpg" id="imgImage2" runat="server" class="img-rounded" style="height:400px;width:100%"  alt="image1"/>
    </div>

    <div class="item">
      <img src="../../../Images/Accommodation/default_home.jpg" id="imgImage3" runat="server" class="img-rounded" style="height:400px;width:100%"  alt="image1"/>
    </div>

    <div class="item">
      <img src="../../../Images/Accommodation/default_home.jpg" id="imgImage4" runat="server" class="img-rounded" style="height:400px;width:100%"  alt="image1"/>
    </div>
          <div class="item">
      <img src="../../../Images/Accommodation/default_home.jpg" id="imgImage5" runat="server" class="img-rounded" style="height:400px;width:100%"  alt="image1"/>
    </div>

  </div>

  <!-- Left and right controls -->
  <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
                        </div>
                         
                        <div class="col-sm-4">
                            <div class="col-sm-12"><h3><strong>
                                <asp:Literal ID="lblRoomType" runat="server"></asp:Literal> </strong></h3></div>
                            <div class="col-sm-12">
                                <asp:Literal ID="lblLocation" runat="server"></asp:Literal> </div>
                            <div class="col-sm-12">
                                <br />
                                <strong>Contact</strong>
                                <p>Name : <asp:Literal ID="lblName" runat="server"></asp:Literal></p>
                                <p>Call :<asp:Literal ID="lblNumber" runat="server"></asp:Literal></p>
                                <p>Email:<asp:Literal ID="lblEmail" runat="server"></asp:Literal></p>
                            </div>
                            
                                <div class="col-sm-12"><a href="" runat="server" id="reserveRoom" type='button' style="margin-bottom:10px;width:100px" class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish'>Reserve Room</a></div>
                                <div class="col-sm-12">
                                   <%--<asp:Button ID="btnPayDeposit" runat="server"  style="margin-bottom:10px;width:100px" class='btn btn-finish btn-fill btn-warning btn-wd btn-sm'  Text="Pay Deposit" OnClick="btnPayDeposit_Click" />--%>
                                   <a  href="#comingSoon" style="margin-bottom:10px;width:100px" data-toggle='modal' class='btn btn-finish btn-fill btn-warning btn-wd btn-sm'>Pay Deposit</a>


                                    <%-- Modal --%>
                             <div class='modal fade' id='comingSoon' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{1}' aria-hidden='true'>
                <div class='modal-dialog'>
                    <div class='modal-content'>
                                <div class='modal-body'>
                                    <div class="container">
                                        <div class="col-sm-4">
                                            <h3>Functionality coming soon!</h3>
                                        </div>
                                    </div>
                                </div>
                
                                <div class='modal-footer'>
                                    <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                </div>
                            </div>
                        </div>
                    </div>
                                    <%-- /Modal --%>
                                </div>
                            <div class="col-sm-12">
                                   <a  href="#comingSoon" style="margin-bottom:10px;width:100px" data-toggle='modal' class='btn btn-finish btn-fill btn-warning btn-wd btn-sm'>Pay Rent</a>

                                <%--<asp:Button ID="btnPayRent" style="margin-bottom:10px;width:100px" class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' runat="server" Text="Pay Rent" OnClick="btnPayDeposit_Click" />--%>
                            </div>
                                
                                <div class="col-sm-12">
                                    <br />
<%--                                    <strong>Room Rating</strong><asp:DropDownList ID="example1" AutoPostBack="true" runat="server">
                            <asp:ListItem Value="1">1</asp:ListItem>
                            <asp:ListItem Value="2">2</asp:ListItem>
                            <asp:ListItem Value="3">3</asp:ListItem>
                            <asp:ListItem Value="4">4</asp:ListItem>
                            <asp:ListItem Value="5">5</asp:ListItem>
                        </asp:DropDownList>--%>
                        
                                </div>
                        </div>
                            <div class="col-sm-12">
                                <br />
                                <strong>Room Description</strong>
                                    <p> <asp:Literal ID="lblDescription" runat="server"></asp:Literal></p>
                            </div>
                    </div>

                </div>
            </div>

    </div>
                <!-- Rating --->    
        <script src="../../../Scripts/jquery-1.9.1.min.js"></script>

    <script src="../../../Scripts/jquery.barrating.min.js"></script>   
    <script type="text/javascript">

        //Do for 3 posts
       $(function() {
          $('#example1').barrating({
            theme: 'fontawesome-stars'
          });
          $('#example2').barrating({
              theme: 'fontawesome-stars'
          });
       });
    </script>
    <!-- End of Rating -->
</asp:Content>
