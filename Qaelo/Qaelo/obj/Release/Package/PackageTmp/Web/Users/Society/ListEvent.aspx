<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListEvent.aspx.cs" Inherits="Qaelo.Web.Users.Society.ListEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
	<meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
    <meta name="viewport" content="width=device-width" />

    <title>Post Event</title>
    <link href="../../../Content/CustomCss/ListPlace/assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../../Content/CustomCss/ListPlace/imageUpload.css" rel="stylesheet" />

    <link href="../../../Content/Qaelo%20template/css/font-awesome.min.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/animate.min.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/lightbox.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/main.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/responsive.css" rel="stylesheet" />

    <link href="../../../Content/CustomCss/ListPlace/assets/css/gsdk-base.css" rel="stylesheet" />

    <script src="../../../Content/CustomCss/ListPlace/assets/js/jquery-1.10.2.js"></script>
<script src="../../../Content/CustomCss/ListPlace/assets/js/bootstrap.min.js"></script>
    <script src="../../../Content/Qaelo%20template/js/lightbox.min.js"></script>
    <script src="../../../Content/Qaelo%20template/js/wow.min.js"></script>
    <script src="../../../Content/Qaelo%20template/js/main.js"></script>


                <!--Notify -->
    <link href="../../../Content/CustomCss/notify/animate.css" rel="stylesheet" />
    <script src="../../../Content/Qaelo%20template/js/jquery.js"></script>
    <script src="../../../Content/Qaelo%20template/js/bootstrap.min.js"></script>
    <script src="../../../Content/CustomCss/notify/dist/bootstrap-notify.js"></script>
</head>
<body>
            <!--Nav bar-->
    <header id="header">      
        <div class="navbar navbar-inverse" role="banner">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>

                    <a class="navbar-brand" href="../../../index.html" style="margin-top:-15px">
                    	<h3 style="color:#d89b4e"><strong> Qaelo</strong></h3>
                    </a>
                </div>
                <div class="collapse navbar-collapse">
                    <ul class="nav navbar-nav navbar-right">
                        <li ><a href="Home.aspx">Home</a></li>
                             <li ><a href="PostProfile.aspx">Manage Your Profile</a></li>
                             <li ><a href="ListEvent.aspx">Post Event</a></li>
                             <li ><a href="ManageEvents.aspx">Manage Events</a></li>
                             <li ><a href="EditProfile.aspx">Edit Profile</a></li>
                        <li><a href="../../Account/Login.aspx?logout=true">Logout</a></li>    			
                    </ul>
                </div>
            </div>
        </div>
    </header>

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
                <form runAt="server" name="roomForm">
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
                                        <label>Nearest University</label>
                                          <asp:DropDownList ID="ddlUniversity" Width="100%" CssClass="form-control" AutoPostBack="true" runat="server" >
                                              <asp:ListItem disabled="" selected="" Value="NONE">- University -</asp:ListItem>
                                              <asp:ListItem Value="University of Johannesburg">University of Johannesburg</asp:ListItem>
                                              <asp:ListItem Value="University of Pretoria">University of Pretoria</asp:ListItem>
                                              <asp:ListItem Value="University of the Witwatersrand">University of the Witwatersrand</asp:ListItem>
                                              <asp:ListItem Value="Monash University">Monash University</asp:ListItem>
                                              <asp:ListItem Value="Walter Sisulu University">Walter Sisulu University</asp:ListItem>
                                              <asp:ListItem Value="Vaal University of Technology">Vaal University of Technology</asp:ListItem>
                                              <asp:ListItem Value="University of Zululand">University of Zululand</asp:ListItem>
                                              <asp:ListItem Value="University of Venda">University of Venda</asp:ListItem>
                                              <asp:ListItem Value="University of the Western Cape">University of the Western Cape</asp:ListItem>
                                              <asp:ListItem Value="University of South Africa (UNISA)">University of South Africa(UNISA)</asp:ListItem>
                                              <asp:ListItem Value="University of Limpopo">University of Limpopo</asp:ListItem>
                                              <asp:ListItem Value="University of Kwazulu-Natal">University of Kwazulu-Natal</asp:ListItem>
                                              <asp:ListItem Value="University of Cape Town">University of Cape Town</asp:ListItem>
                                              <asp:ListItem Value="University of Fort Hare">University of Fort Hare</asp:ListItem>
                                              <asp:ListItem Value="Cape Peninsula University of Technology">CPUT</asp:ListItem>
                                              <asp:ListItem Value="Central University of Technology">Central University of Technology</asp:ListItem>
                                              <asp:ListItem Value="Durban University of Technology">DUT</asp:ListItem>
                                              <asp:ListItem Value="Mangosuthu University of Technology">MUT</asp:ListItem>
                                              <asp:ListItem Value="Nelson Mandela Metropolitan University">NMMU</asp:ListItem>
                                              <asp:ListItem Value="North West University">North West University</asp:ListItem>
                                              <asp:ListItem Value="Rhodes University">Rhodes University</asp:ListItem>
                                              <asp:ListItem Value="Tshwane University of Technology">TUT</asp:ListItem>
                                              <asp:ListItem Value="University of the Free State">University of the Free State</asp:ListItem>
                                              <asp:ListItem Value="Stellenbosch University">Stellenbosch University</asp:ListItem>
                                              <asp:ListItem Value="University of Mpumalanga">University of Mpumalanga</asp:ListItem>
                                          </asp:DropDownList>
                                      </div>
                                  </div>
                                  <div class="col-sm-5">
                                      <div class="form-group">
                                                                             
                                      <div class="form-group"  id="DivDefault" visible="true" runat="server">
                                            <label>Campus</label><br/>
                                              <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value=" "  disabled=""  Selected="True" >  Please Select a campus</asp:ListItem>
                                              </asp:DropDownList>
                                          </div>

                                       <div class="form-group"  id="DivWitsCampuses" visible="false" runat="server">
                                            <label> Wits Campuses</label><br/>
                                              <asp:DropDownList ID="ddlWitsCampus" AutoPostBack="true" runat="server" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Braamfontein Campus">Braamfontein Campus</asp:ListItem>
                                              <asp:ListItem Value="Education Campus">Education Campus</asp:ListItem>
                                              <asp:ListItem Value="Medical School">Medical School</asp:ListItem>
                                                                                  
                                              </asp:DropDownList>
                                          </div>


                                       <div class="form-group"  id="DivNWUCampus" visible="false" runat="server">
                                            <label>NWU Campuses</label><br/>
                                              <asp:DropDownList ID="ddlNWUCampus" AutoPostBack="true" runat="server" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Vaal Triangle Campus">Vaal Triangle Campus</asp:ListItem>
                                              <asp:ListItem Value="Potchefstroom Campus">Potchefstroom Campus</asp:ListItem>
                                              <asp:ListItem Value="Mafikeng Campus">Mafikeng Campus</asp:ListItem>
                                                                                  </asp:DropDownList>
                                          </div>

                                       <div class="form-group"  id="DivUPCampuses" visible="false" runat="server">
                                            <label> UP Campuses</label><br/>
                                              <asp:DropDownList ID="ddlUPCampus" AutoPostBack="true" runat="server" Width="100%"  CssClass="form-control" >
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Hatfield (Main) Campus">Hatfield (Main) Campus</asp:ListItem>
                                              <asp:ListItem Value="Groenkloof Campus">Groenkloof Campus</asp:ListItem>
                                              <asp:ListItem Value="Prinshof Campus">Prinshof Campus</asp:ListItem>
                                              <asp:ListItem Value="Onderstepoort Campus">Onderstepoort Campus</asp:ListItem> 
                                                  <asp:ListItem Value="Mamelodi Campus">Mamelodi Campus</asp:ListItem> 
                                              </asp:DropDownList>
                                          </div>

                                       <div class="form-group" id="DivujCampuses" visible="false" runat="server">
                                            <label> UJ Campuses</label><br/>
                                              <asp:DropDownList ID="ddlUjcampus" AutoPostBack="true" runat="server" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Auckland Park (Main) Campus">Auckland Park (Main) Campus</asp:ListItem>
                                              <asp:ListItem Value="Bunting Road Campus">Bunting Road Campuss</asp:ListItem>
                                              <asp:ListItem Value="Doornfontein Campus">Doornfontein Campus</asp:ListItem>
                                              <asp:ListItem Value="Soweto Campus">Soweto Campus</asp:ListItem>                                          </asp:DropDownList>
                                          </div>

                                       <div class="form-group" id="DivMonashCampuses" visible="false" runat="server">
                                            <label> Monash Campuses</label><br/>
                                              <asp:DropDownList ID="ddlMonashCampuses" AutoPostBack="true" runat="server" Width="100%" CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Monash University">Monash University</asp:ListItem>
                                                                                    </asp:DropDownList>
                                          </div>

                                       <div class="form-group" id="DivwsuCampuses" visible="false" runat="server">
                                            <label> WSU Campuses</label><br/>
                                              <asp:DropDownList ID="ddlwsucampuses" AutoPostBack="true" runat="server" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="East London Campus">East London Campus</asp:ListItem>
                                              <asp:ListItem Value="Queenstown Campus">Queenstown Campus</asp:ListItem>
                                              <asp:ListItem Value="Mthatha Campus">Mthatha Campus</asp:ListItem>
                                              <asp:ListItem Value="Butterworth Campus">Butterworth Campus</asp:ListItem>                                          </asp:DropDownList>
                                          </div>

                                       <div class="form-group" id="DivuzCampuses" visible="false" runat="server">
                                            <label> UZ Campuses</label><br/>
                                              <asp:DropDownList ID="ddlUZCampuses" AutoPostBack="true" runat="server" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                        
                                              <asp:ListItem Value="Queenstown Campus">Queenstown Campus</asp:ListItem>
                                              <asp:ListItem Value="Richards Bay Campus">Richards Bay Campus</asp:ListItem>
                                              <asp:ListItem Value="Science Centre">Science Centre</asp:ListItem>                                          </asp:DropDownList>
                                          </div>

                                       <div class="form-group" id="DivUnivenCampuses" visible="false" runat="server">
                                            <label> Univen Campuses</label><br/>
                                              <asp:DropDownList ID="ddlUnivenCampuses" AutoPostBack="true" runat="server" Width="100%" CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                        
                                              <asp:ListItem Value="University of Venda">University of Venda</asp:ListItem>
                                                                                  </asp:DropDownList>
                                          </div>

                                       <div class="form-group" id="DivulCampuses" visible="false" runat="server">
                                            <label> UL</label><br/>
                                              <asp:DropDownList ID="DdlUl" runat="server" AutoPostBack="true" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                        
                                              <asp:ListItem Value="University of Limpopo">University of Limpopo</asp:ListItem>
                                                                                  </asp:DropDownList>
                                          </div>

                                       <div class="form-group" id="DivUKZNCampuses" visible="false" runat="server">
                                            <label> UKZN Campuses</label><br/>
                                              <asp:DropDownList ID="ddlUKZN" runat="server" AutoPostBack="true" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Edgewood Campus">Edgewood Campus</asp:ListItem>
                                              <asp:ListItem Value="Howard Colledge">Howard Colledge</asp:ListItem>
                                              <asp:ListItem Value="Medical School">Medical School</asp:ListItem>
                                              <asp:ListItem Value="Pietermaritzburg Campus">Pietermaritzburg Campus</asp:ListItem> 
                                                  <asp:ListItem Value="WestVille Campus">WestVille Campus</asp:ListItem> 
                                              </asp:DropDownList>
                                          </div>

                                       <div class="form-group" id="DivUCTCampuses" visible="false" runat="server">
                                            <label> UCT Campuses</label><br/>
                                              <asp:DropDownList ID="DDLUCTCampuses" runat="server" AutoPostBack="true" Width="100%" CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Groote Schuur Campus">Groote Schuur Campus</asp:ListItem>
                                              <asp:ListItem Value="Health Sciences Campus">Health Sciences Campus</asp:ListItem>
                                              <asp:ListItem Value="Hiddingh Campus">Hiddingh Campus</asp:ListItem>
                                              <asp:ListItem Value="Breakwater Campus">Breakwater Campus</asp:ListItem> 
                                                  <asp:ListItem Value="Upper, middle and lower Campuses">Upper, middle and lower Campuses</asp:ListItem> 
                                              </asp:DropDownList>
                                          </div>
           
                                       <div class="form-group"  id="DivUFHCampuses"  visible="false" runat="server">
                                            <label> UFH Campuses</label><br/>
                                              <asp:DropDownList ID="DdlUFHCampuses" runat="server" AutoPostBack="true" Width="100%" CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="East London Campus">East London Campus</asp:ListItem>
                                              <asp:ListItem Value="Bhisho Campus">Bhisho Campus</asp:ListItem>
                                              <asp:ListItem Value="Alice (Main) Campus">Alice (Main) Campus</asp:ListItem>
                                              <asp:ListItem Value="Breakwater Campus">Breakwater Campus</asp:ListItem> 
                                              </asp:DropDownList>
                                          </div>

                                       <div class="form-group"  id="DivCPUTCampuses" visible="false" runat="server">
                                            <label> CPUT Campuses</label><br/>
                                              <asp:DropDownList ID="DdlCPUTCampuses" runat="server" AutoPostBack="true" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Tygerberg Hospital">Tygerberg Hospital</asp:ListItem>
                                              <asp:ListItem Value="Roeland Street Building">Roeland Street Building</asp:ListItem>
                                              <asp:ListItem Value="Groot Schuur Hospital">Groot Schuur Hospital</asp:ListItem>
                                              <asp:ListItem Value="Wellington Campus">Wellington Campus</asp:ListItem> 
                                                  <asp:ListItem Value="Mowbray Campus">Mowbray Campus</asp:ListItem>
                                                  <asp:ListItem Value="Granger Bay Campus">Granger Bay Campus</asp:ListItem>
                                              <asp:ListItem Value="Granger Bay Campus">Granger Bay Campus</asp:ListItem>
                                              <asp:ListItem Value="Cape Town Campus">Cape Town Campus</asp:ListItem>
                                              <asp:ListItem Value="Bellville Campus">Bellville Campus</asp:ListItem> 
                        
                                              </asp:DropDownList>
                                          </div>

                                       <div class="form-group"  id="DivDUTCampuses" visible="false" runat="server">
                                            <label> DUT Campuses</label><br/>
                                              <asp:DropDownList ID="DdlDUTCampuses" runat="server" AutoPostBack="true" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Riverside Campus">Riverside Campus</asp:ListItem>
                                              <asp:ListItem Value="City Campus">City Campus</asp:ListItem>
                                              <asp:ListItem Value="Ritson Campus">Ritson Campus</asp:ListItem>
                                              <asp:ListItem Value="Brickfield Campus">Brickfield Campus</asp:ListItem> 
                                                  <asp:ListItem Value="Steve Biko Campus">Steve Biko Campus</asp:ListItem>
                                                  <asp:ListItem Value="ML Sultan Campus">ML Sultan Campus</asp:ListItem>
                                             
                        
                                              </asp:DropDownList>
                                          </div>

                                       <div class="form-group" id="DivCUTCampuses" visible="false" runat="server">
                                            <label> CUT Campuses</label><br/>
                                              <asp:DropDownList ID="DdlCUTCampuses" runat="server" AutoPostBack="true" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Bloemfontein Campus">Bloemfontein Campus</asp:ListItem>
                                              <asp:ListItem Value="Kimberley Campus">Kimberley Campus</asp:ListItem>
                                              <asp:ListItem Value="Welkom Campus">Welkom Campus</asp:ListItem>
                                            
                        
                                              </asp:DropDownList>
                                          </div>

                                       <div class="form-group" id="DivMUTCampuses" visible="false" runat="server">
                                            <label> MUT Campuses</label><br/>
                                              <asp:DropDownList ID="DdlMUTCampuses" runat="server" AutoPostBack="true" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Mangosuthu University of Technology">Mangosuthu University of Technology</asp:ListItem>
                                        
                                              </asp:DropDownList>
                                          </div>

                                       <div class="form-group" id="DivNMMUCampuses" visible="false" runat="server">
                                            <label> NMMU Campuses</label><br/>
                                              <asp:DropDownList ID="DdlNMMUCampuses" runat="server" AutoPostBack="true" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Missionvale Campus">Missionvale Campus</asp:ListItem>
                                              <asp:ListItem Value="George Campus">George Campus</asp:ListItem>
                                              <asp:ListItem Value="Bird Street Campus">Bird Street Campus</asp:ListItem>
                                              <asp:ListItem Value="Second Avenue Campus">Second Avenue Campus</asp:ListItem> 
                                                  <asp:ListItem Value="South Campus">South Campus</asp:ListItem>
                                                  <asp:ListItem Value="North Campus">North Campus</asp:ListItem>
                                             
                        
                                              </asp:DropDownList>
                                          </div>
                        
                                       <div class="form-group" id="DivMUCampuses" visible="false" runat="server">
                                            <label> Mafikeng University Campuses</label><br/>
                                              <asp:DropDownList ID="DdlMUCampuses" runat="server" AutoPostBack="true" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Vaal Triangle Campus">Vaal Triangle Campus</asp:ListItem>
                                              <asp:ListItem Value="Potchefstroom Campus">Potchefstroom Campus</asp:ListItem>
                                              <asp:ListItem Value="Mafikeng Campus">Mafikeng Campus</asp:ListItem>
                                         
                                             
                        
                                              </asp:DropDownList>
                                          </div>

                                       <div class="form-group" id="DivRhodesCampuses" visible="false" runat="server">
                                            <label> Rodes University Campuses</label><br/>
                                              <asp:DropDownList ID="DdlRodesCampuses" runat="server" AutoPostBack="true" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Rhodes University">Rhodes University</asp:ListItem>
                                    
                                             
                                              </asp:DropDownList>
                                          </div>

                                       <div class="form-group" id="DivTUTCampuses" visible="false" runat="server">
                                            <label> TUT Campuses</label><br/>
                                              <asp:DropDownList ID="DdlTUTCampuses" runat="server" AutoPostBack="true" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Mbombela Campus">Mbombela Campus</asp:ListItem>
                                              <asp:ListItem Value="eMalahleni Campus">eMalahleni Campus</asp:ListItem>
                                              <asp:ListItem Value="Soshanguve North 1">Soshanguve North 1</asp:ListItem>
                                           <asp:ListItem Value="Soshanguve North 2">Soshanguve North 2</asp:ListItem>
                                              <asp:ListItem Value="Soshanguve South 2">Soshanguve South 2</asp:ListItem>
                                              <asp:ListItem Value="Soshanguve South 1">Soshanguve South 1</asp:ListItem>
                                                    <asp:ListItem Value="Pretoria Campus">Pretoria Campus</asp:ListItem>
                                              <asp:ListItem Value="Ga-Rankuwa Campus">Ga-Rankuwa Campus</asp:ListItem>
                                              <asp:ListItem Value="Arcadia Campus">Arcadia Campus</asp:ListItem>
                                             
                                                <asp:ListItem Value="Arts Campus">Arts Campus</asp:ListItem>
                                              <asp:ListItem Value="Polokwane Campus">Polokwane Campus</asp:ListItem>
                                              </asp:DropDownList>
                                          </div>

                                       <div class="form-group" id="DivVUTCampuses" visible="false"  runat="server">
                                            <label> VUT Campuses</label><br/>
                                              <asp:DropDownList ID="DdlVUTCampuses" runat="server" AutoPostBack="true" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Vanderbijlpark Campus">Vanderbijlpark Campus</asp:ListItem>
                                              <asp:ListItem Value="Secunda Campus">Secunda Campus</asp:ListItem>
                                              <asp:ListItem Value="Upington Campus">Upington Campus</asp:ListItem>
                                         
                                             
                        
                                              </asp:DropDownList>
                                          </div>

                                       <div class="form-group" id="DivUFSCampuses" visible="false" runat="server">
                                            <label> UFS Campuses</label><br/>
                                              <asp:DropDownList ID="ddlUFSCampus" runat="server" AutoPostBack="true" Width="100%" CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Bloemfontein Campus">Bloemfontein Campus</asp:ListItem>
                                              <asp:ListItem Value="Qwaqwa Campus">Qwaqwa Campus</asp:ListItem>
                                              <asp:ListItem Value="South Campus">South Campus</asp:ListItem>
                                             
                                             
                        
                                              </asp:DropDownList>
                                          </div>
    
                                       <div class="form-group"  id="DivSTUCampuses" visible="false" runat="server">
                                            <label> STU Campuses</label><br/>
                                              <asp:DropDownList ID="DdlSTUCampuses" runat="server" AutoPostBack="true" Width="100%" CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Stellebosh Campus">Stellebosh Campus</asp:ListItem>
                                              <asp:ListItem Value="Tygerburg Campus">Tygerburg Campus</asp:ListItem>
                                              <asp:ListItem Value="US Business School">US Business School</asp:ListItem>
                                              <asp:ListItem Value="Worcester Campus">Worcester Campus</asp:ListItem> 
                                               
                                                  
                        
                                              </asp:DropDownList>
                                          </div>
                     
                                       <div class="form-group" id="DivUMCampuses"  visible="false" runat="server">
                                            <label> UM Campuses</label><br/>
                                              <asp:DropDownList ID="DdlUMCampuses" runat="server" AutoPostBack="true" Width="100%" CssClass="form-control">
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="Mbombela Campus">Mbombela Campus</asp:ListItem>
                                              <asp:ListItem Value="Siyabuswa Campus">Siyabuswa Campus</asp:ListItem>
                                           
                                             
                        
                                              </asp:DropDownList>
                                          </div>
                                       <div class="form-group"  id="DivUNISACampuses" visible="false" runat="server">
                                            <label> UNISA Campuses</label><br/>
                                              <asp:DropDownList ID="DdlUNISACampuses" runat="server" AutoPostBack="true" Width="100%"  CssClass="form-control" >
                                              <asp:ListItem Value=" ">Please Select a campus</asp:ListItem>
                                              <asp:ListItem Value="East London">East London</asp:ListItem>
                                              <asp:ListItem Value="Mthatha">Mthatha</asp:ListItem>
                                                      <asp:ListItem Value="Port Elizabeth">Port Elizabeth</asp:ListItem>
                                              <asp:ListItem Value="Muckleneuk Campus">Muckleneuk Campus</asp:ListItem>
                                                             <asp:ListItem Value="Sunnyside Campus">Sunnyside Campus</asp:ListItem>
                                              <asp:ListItem Value="Johannesburg">Johannesburg</asp:ListItem>
                                                             <asp:ListItem Value="Florida Science Campus">Florida Science Campus</asp:ListItem>
                                              <asp:ListItem Value="Ekurhuleni Campus">Ekurhuleni Campus</asp:ListItem>
                                                             <asp:ListItem Value="Vaal Triangle">Vaal Triangle</asp:ListItem>
                                              <asp:ListItem Value="Durban">Durban</asp:ListItem>
                                                             <asp:ListItem Value="Pietermaritzburg">Pietermaritzburg</asp:ListItem>
                                              <asp:ListItem Value="Newcastle">Newcastle</asp:ListItem>
                                                             <asp:ListItem Value="Richards Bay">Richards Bay</asp:ListItem>
                                              <asp:ListItem Value="Wild Coast">Wild Coast</asp:ListItem>
                                                             <asp:ListItem Value="Polokwane">Polokwane</asp:ListItem>
                                              <asp:ListItem Value="Makhado">Makhado</asp:ListItem>
                                                             <asp:ListItem Value="Rustenburg">Rustenburg</asp:ListItem>
                                              <asp:ListItem Value="Bloemfontein">Bloemfontein</asp:ListItem>
                                                             <asp:ListItem Value="Mahikeng">Mahikeng</asp:ListItem>
                                              <asp:ListItem Value="Potchefstroom">Potchefstroom</asp:ListItem>
                                                             <asp:ListItem Value="Kimberley">Kimberley</asp:ListItem>
                                              <asp:ListItem Value="Kroonstad">Kroonstad</asp:ListItem>
                                                     <asp:ListItem Value="Nelspruit">Nelspruit</asp:ListItem>
                                              <asp:ListItem Value="Middelburg">Middelburg</asp:ListItem>
                                                             <asp:ListItem Value="Cape Town">Cape Town</asp:ListItem>
                                              <asp:ListItem Value="George">George</asp:ListItem>
                                             
                        
                                              </asp:DropDownList>
                                          </div>
                                      </div>
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
                                    
</body>

	<!--   plugins 	 -->
<script src="../../../Content/CustomCss/ListPlace/assets/js/jquery.bootstrap.wizard.js"></script>
    <!--  More information about jquery.validate here: http://jqueryvalidation.org/	 -->
<script src="../../../Content/CustomCss/ListPlace/assets/js/jquery.validate.min.js"></script>
	<!--  methods for manipulating the wizard and the validation -->
        <script src="https://gitcdn.github.io/bootstrap-toggle/2.2.2/js/bootstrap-toggle.min.js"></script>
<script src="../../../Content/CustomCss/ListPlace/assets/js/wizard.js"></script>
<script src="../../../Scripts/imageUpload.js"></script>


</html>
