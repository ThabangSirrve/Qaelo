<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="students-events.aspx.cs" Inherits="Qaelo.Web.Users.Student.Events" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Events</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top:60px"></div>
    <div class="container thumbnail">
	    <div class="row">
	        <div class="col-md-12"> 
	          <h3 class="text-center">Find your event or audition!</h3>
              <hr/>
            </div>
                    <div class="col-md-9 col-md-offset-3"> 
                         <asp:TextBox ID="txtText" placeholder="Type Tertiary Institution" runat="server" type="text" class="typeaheadPlaces tt-query form-control" autocomplete="on" spellcheck="false"></asp:TextBox>
                        <asp:Button ID="btnSearch" CssClass="btn btn-default" style="color:sandybrown" runat="server" Text="Find" OnClick="btnSearch_Click"/>
                    </div>
	    </div>
      
        <div class="col-md-12"><br /><br />
            <asp:Literal ID="listOfEvents" runat="server"></asp:Literal>
            <asp:Label ID="lblEvent" runat="server" Text=""></asp:Label>
        </div>
                     <script>
                $(document).ready(function(){
                    $('[data-toggle="tooltip"]').tooltip(); 
                });
            </script> 
    </div>

<%--    <a href="#event" data-toggle="modal">click </a>
    <div class='modal fade' id='event' tabindex='-1' role='dialog' aria-labelledby='myModalLabel' aria-hidden='true'>
                        <div class='modal-dialog modal-lg'>
                        <div class='modal-content'>
                            <div class="modal-header" style="background-color:mediumvioletred">
                                <div class="container-fluid">
                                    <div class="col-sm-12">
                                        <p style="color:white"> Nickelodeon Block Party  - 15 December 2017

                                        <a href="#" class="pull-right" style="color:white">Get Directions <img src="../../../getDirections.png"  style='height:32px;width:32px;color:dodgerblue'  /></a> 
                                        </p>
                                    </div>
                                </div>
                            </div>
                                   
                            <div class='modal-body'>
                                <div class="row">
                                        
                                    <div class='col-lg-12' style='margin:20px'>
                                        <div class='col-lg-6'>
                                            <img src="../../../Images/Events/3ms_20127.jpg" class='img-thumbnail' style='height:250px;width:100%'  />
                                        </div>

                                        <div class='col-lg-6'>
                                            <h4>Event Name</h4>
                                            <p>Nickelodeon Block Party 3</p>
                                            <br />
                                            <h4>Date</h4>
                                            <p>15 December 2017</p>
                                            <br />
                                            <h4>For More info, Contact:</h4>
                                            <p> 
                                             <strong>Name :</strong> event poster<br />
                                             <strong>Call :</strong>012345678<br />
                                             <strong>Email:</strong>events@gmail.com<br />
                                            </p>
                                            <br/><strong>Price:</strong>Free
                                        </div>
                                    
                                        </div>

                                    <div class='col-lg-12'>
                                         <br/><h4>Description</h4>
                                            <p>Roll the dice to find out how many spaces you move forward. Make your way across the board, and compete against the other players in a variety of fun online mini games to win coins. The player with the most coins at the end of the game wins! Play Block Party 3 and other free online strategy games on Nick.com.</p>
                                    </div>

                                     <br />

                                </div>
                                    </div>
                                   
                            <div class='modal-footer'>
                                        <button  class='btn btn-danger pull-right' data-dismiss='modal'>Back</button>
                                    </div>
                                </div>
                            
                        </div>
                            
    </div>--%>
</asp:Content>
