<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/Student.Master" AutoEventWireup="true" CodeBehind="Event.aspx.cs" Inherits="Qaelo.Web.Users.Student.Event" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Event</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-sm-12">
            
   <div class="panel panel-info">
                <div class="panel-heading" style="background-color:antiquewhite">
                    <asp:Literal ID="lblPanelTopic" runat="server"></asp:Literal>
                </div>

                <div class="panel-body">
                    <div class="col-sm-12">
                        <div class="col-sm-8">
                            <div id="myCarousel" class="carousel slide" data-ride="carousel">
                      <div class="carousel-inner" role="listbox">
                        <div class="item active">
                          <img src="../../../Images/Events/default_home.jpg" id="imgImage1" runat="server" class="img-rounded"  style="height:400px;width:100%"  alt="image1"/>
                        </div>
                      </div>
                    </div>
                        </div>
                         
                        <div class="col-sm-4">
                            <div class="col-sm-12"><h3><strong>
                                <asp:Literal ID="lblDate" runat="server"></asp:Literal> </strong></h3></div>
                            <div class="col-sm-12"><strong>For More info Contact:</strong>
                                <p>Name : <asp:Literal ID="lblName" runat="server"></asp:Literal></p>
                                <p>Call :<asp:Literal ID="lblNumber" runat="server"></asp:Literal></p>
                                <p>Email:<asp:Literal ID="lblEmail" runat="server"></asp:Literal></p>
                            </div>
                            <div class="col-sm-12"><strong>Event Description</strong>
                                    <p> <asp:Literal ID="lblDescription" runat="server"></asp:Literal></p>
                            </div>
                                                        
                            <div class="col-sm-12" id="divTickets" runat="server" visible="false"><strong>Ticket Price(s)</strong>
                                    <p> <asp:Literal ID="lblTicketSales" runat="server"></asp:Literal></p>
                                    <strong>How To Pay</strong>
                                    <p> <asp:Literal ID="lblTicketAccountdetails" runat="server"></asp:Literal></p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    </div>
</asp:Content>
