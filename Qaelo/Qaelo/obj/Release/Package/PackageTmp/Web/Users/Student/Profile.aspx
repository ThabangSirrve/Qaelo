<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Qaelo.Web.Users.Student.Profile" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
	<meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
    <meta name="viewport" content="width=device-width" />

    <title>Profile</title>
    <!-- Css for Profile page-->
    <link href="../../../Content/CustomCss/Profile/assets/css/bootstrap.min.css" rel="stylesheet" />

    <link href="../../../Content/Qaelo%20template/css/font-awesome.min.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/animate.min.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/lightbox.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/main.css" rel="stylesheet" />
    <link href="../../../Content/Qaelo%20template/css/responsive.css" rel="stylesheet" />

    <link href="http://netdna.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.css" rel="stylesheet"/>

    <link href="../../../Content/CustomCss/Profile/assets/css/gsdk-base.css" rel="stylesheet" />
        <!--Notify -->
    <link href="../../../Content/CustomCss/notify/animate.css" rel="stylesheet" />
    <script src="../../../Content/Qaelo%20template/js/jquery.js"></script>
    <script src="../../../Content/Qaelo%20template/js/bootstrap.min.js"></script>
    <script src="../../../Content/CustomCss/notify/dist/bootstrap-notify.js"></script>
    <!--/Notify -->
</head>
<body>
            <!--Nav bar-->
    <header id="header">
        <div class="navbar navbar-inverse"  role="banner">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>

                    <a class="navbar-brand" href="../../../index.html" style="margin-top:-20px">
                    	<h4 style="color:#d89b4e"><strong> Qaelo</strong></h4>
                    </a>
                  
                </div>
                <div class="collapse navbar-collapse">
                    <ul class="nav navbar-nav navbar-right">     
                             <li ><a href="StudentProfile.aspx"><b>My Profile</b></a></li>  			
                             <li ><a href="freelancers.aspx"><b>Freelancers</b></a></li>  			
                             <li ><a href="usedtextbooks.aspx"><b>Used books</b></a></li>  			
                        <li><a href="Shops.aspx "><b>Shops </b></a></li>  
                        <li ><a href="Accommodation.aspx"><b>Rooms</b></a></li>
                           <li><a href="Events.aspx "><b>Events</b> </a></li>  			
                           <!--<li><a href="Companies.aspx"><b>Jobs</b></a></li>-->  
						<li><a href="Societies.aspx "><b>Societies </b> </a></li>  			
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
    <div class="container">
        <div class="row">
        <div class="col-sm-8 col-sm-offset-2">
            <!--      Wizard container        -->   
             <br />
                <div class="card wizard-card ct-wizard-orange" id="wizardProfile">
                    <form runat="server" action="" method="">
                <!--        You can switch "ct-wizard-orange"  with one of the next bright colors: "ct-wizard-blue", "ct-wizard-green", "ct-wizard-orange", "ct-wizard-red"             -->
                    	<div class="wizard-header">
                        	<h3>
                        	   <b>UPDATE</b> YOUR PROFILE <br/>
                        	</h3>
                    	</div>
                    	<ul>
                            <li><a href="#about" data-toggle="tab"> About</a></li>
                            <li><a href="#address" data-toggle="tab">Freelancing</a></li>
                            <li><a href="#account" data-toggle="tab">Account</a></li>
                        </ul>
                        
                        <div class="tab-content">
                            <div class="tab-pane" id="about">
                              <div class="row">
                                  <h4 class="info-text"> Basic information</h4>
                                  <div class="col-sm-12">
                                      <div class="col-sm-4 col-sm-offset-1">
                                         <div class="picture-container">
                                              <div class="picture">
                                                  <img  src="../../../Images/Users/Accommodation/defaultProfilePic.jpg" class="picture-src" runat="server" id="wizardPicturePreview" title=""/>
                                                  <asp:FileUpload ID="wizardPicture" runat="server" />
                                              </div>
                                              <h6>Choose Picture</h6>
                                          </div>
                                      </div>
                                      <div class="col-sm-6">
                                      <div class="form-group">
                                        <label>First Name <small>(required)</small></label>
                                          <asp:TextBox ID="txtName" name="firstname" type="text" class="form-control" placeholder="My name is..." runat="server"></asp:TextBox>
                                      </div>
                                      <div class="form-group">
                                        <label>Last Name <small>(required)</small></label>
                                          <asp:TextBox ID="txtLastName" name="lastname" type="text" class="form-control" placeholder="My surname is..." runat="server"></asp:TextBox>
                                      </div>
                                  </div>
                                  </div>
                                  <div class="col-sm-12">
                                      <div class="col-sm-5">
                                          <div class="form-group">
                                              <label>Email <small></small></label>
                                              <asp:TextBox ID="txtEmail" disabled="" name="email" type="email" class="form-control" placeholder="me@gmail.com" runat="server"></asp:TextBox>
                                          </div>
                                      </div>
                                      <div class="col-sm-6">
                                      <div class="form-group">
                                        <label>Contact number <small>(required)</small></label>
                                          <asp:TextBox ID="txtNumber" name="number" type="number" class="form-control" placeholder="072.." runat="server"></asp:TextBox>
                                      </div>
                                          
                                      </div>

                                  </div>

                                  <div class="col-sm-12">
                                      <!--Universities -->
                                      <div class="col-sm-5">
                                       <div class="form-group">
                                        <label>Please Select University</label>
                                          <asp:DropDownList ID="ddlUniversity" Width="100%" CssClass="form-control" AutoPostBack="true" runat="server" >
                                              <asp:ListItem Value="NONE"  selected="true">Please Selelct a University</asp:ListItem>
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

                                      <!-- Campuses-->
          <div class="col-sm-6">                                  
                                      <div class="form-group"  id="DivDefault" visible="true" runat="server">
                                            <label>Campus</label><br/>
                                              <asp:DropDownList ID="ddlCampuses" AutoPostBack="true" runat="server" Width="100%"  CssClass="form-control">
                                              <asp:ListItem Value="NONE"  disabled=""  Selected="True" >  Please Select a campus</asp:ListItem>
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
                <!-- second row-->
                                  <div class="col-sm-12">
                                      <div class="col-sm-5">
                                          <div class="form-group">
                                              <label>Qaulification <small>(required)</small></label>
                                              <asp:TextBox ID="txtQualification"  name="text" type="text" class="form-control" placeholder="Course Enrolled" runat="server"></asp:TextBox>
                                          </div>
                                      </div>
                                      <div class="col-sm-6">
                                          <div class="form-group">
                                            <label>Year of study<small>(required)</small></label>
                                             <asp:DropDownList ID="ddlYear" Width="100%" CssClass="form-control" runat="server" >
                                                                      <asp:ListItem selected="" Value="NONE">- Select year of study -</asp:ListItem>
                                                                      <asp:ListItem Value="Bridging">Bridging</asp:ListItem>
                                                                      <asp:ListItem Value="1st">1st</asp:ListItem>
                                                                      <asp:ListItem Value="2nd">2nd</asp:ListItem>
                                                                      <asp:ListItem Value="3rd">3rd</asp:ListItem>
                                                                      <asp:ListItem Value="4th">4th</asp:ListItem>
                                                                      <asp:ListItem Value="Honours">Honours</asp:ListItem>
                                                                      <asp:ListItem Value="Masters">Masters</asp:ListItem>
                                                                      <asp:ListItem Value="Doctorate">Doctorate</asp:ListItem>
                                                                  </asp:DropDownList>
                                          </div>
                                      </div>
                                  </div>
                              </div>
                            </div>

                            <div class="tab-pane" id="address">
                                <div class="row">
                                    <div class="col-sm-12">
                                        <h4 class="info-text">Be a freelancer </h4>
                                    </div>
                                     <div class="col-sm-12">
                                     <div class="col-sm-6">
                                      <div class="form-group">
                                          <div class="col-sm-12">
                                                 <div class="form-group">
                                        <label>Your Specialty</label>
                                          <asp:DropDownList ID="ddlWork1" Width="100%" CssClass="form-control" runat="server" >
                                              <asp:ListItem Value="NONE">- Select type -</asp:ListItem>
                                              <asp:ListItem Value="Acting Extra">Acting Extra</asp:ListItem>
                                              <asp:ListItem Value="Admin Assitant">Admin Assitant</asp:ListItem>
                                              <asp:ListItem Value="Animator">Animator</asp:ListItem>
                                              <asp:ListItem Value="Bookkeeper">Bookkeeper</asp:ListItem>
                                              <asp:ListItem Value="Business Incubator">Business Incubator</asp:ListItem>
                                              <asp:ListItem Value="Call Centre Agent">Call Centre Agent</asp:ListItem>
                                              <asp:ListItem Value="Chauffer">Chauffer</asp:ListItem>
                                              <asp:ListItem Value="Chef">Chef</asp:ListItem>
                                              <asp:ListItem Value="Choreographer">Choreographer</asp:ListItem>
                                              <asp:ListItem Value="Comedian">Comedian</asp:ListItem>
                                              <asp:ListItem Value="Data Analyst">Data Analyst</asp:ListItem>
                                              <asp:ListItem Value="Developer">Developer</asp:ListItem>
                                              <asp:ListItem Value="Dog Walker">Dog Walker</asp:ListItem>
                                              <asp:ListItem Value="Editor/Proof Reader">Editor/Proof Reader</asp:ListItem>
                                              <asp:ListItem Value="Event Dj">Event Dj</asp:ListItem>
                                              <asp:ListItem Value="Event host">Event host</asp:ListItem>
                                              <asp:ListItem Value="Fashion Designer">Fashion Designer</asp:ListItem>
                                              <asp:ListItem Value="Film Assistant Director">Film Assistant Director</asp:ListItem>
                                              <asp:ListItem Value="Forex Trader">Forex Trader</asp:ListItem>
                                              <asp:ListItem Value="Google adwords expert">Google adwords expert</asp:ListItem>
                                              <asp:ListItem Value="Google analytics consultant">Google analytics consultant</asp:ListItem>
                                              <asp:ListItem Value="Graphic Designer">Graphic Designer</asp:ListItem>
                                              <asp:ListItem Value="Hairdresser">Hairdresser</asp:ListItem>
                                              <asp:ListItem Value="High School sports coach">High School sports coach</asp:ListItem>
                                              <asp:ListItem Value="High School tutor">High School tutor</asp:ListItem>
                                              <asp:ListItem Value="Legal Assistance">Legal Assistance</asp:ListItem>
                                              <asp:ListItem Value="Logistics Assistant">Logistics Assistant</asp:ListItem>
                                              <asp:ListItem Value="Makeup artist">Makeup artist</asp:ListItem>
                                              <asp:ListItem Value="Market researcher">Market researcher</asp:ListItem>
                                              <asp:ListItem Value="Marketing Assistant">Marketing Assistant</asp:ListItem>
                                              <asp:ListItem Value="Medical Assistant">Medical Assistant</asp:ListItem>
                                              <asp:ListItem Value="Model">Model</asp:ListItem>
                                              <asp:ListItem Value="Motivational Speaker">Motivational Speaker</asp:ListItem>
                                              <asp:ListItem Value="Night child care nanny">Night child care nanny</asp:ListItem>
                                              <asp:ListItem Value="Personal Assistant">Personal Assistant</asp:ListItem>
                                              <asp:ListItem Value="Personal Fitness trainer">Personal Fitness trainer</asp:ListItem>
                                              <asp:ListItem Value="Photographer">Photographer</asp:ListItem>
                                              <asp:ListItem Value="Pre-school tutor">Pre-school tutor</asp:ListItem>
                                              <asp:ListItem Value="Product Promoter">Product Promoter</asp:ListItem>
                                              <asp:ListItem Value="Singer/Band">Singer/Band</asp:ListItem>
                                              <asp:ListItem Value="Sketch and portrait artist">Sketch and portrait artist</asp:ListItem>
                                              <asp:ListItem Value="Social network marketer">Social network marketer</asp:ListItem>
                                              <asp:ListItem Value="Tax Administrator">Tax Administrator</asp:ListItem>
                                              <asp:ListItem Value="Translator">Translator</asp:ListItem>
                                              <asp:ListItem Value="University Tutor">University Tutor</asp:ListItem>
                                              <asp:ListItem Value="Voice over">Voice over</asp:ListItem>
                                              <asp:ListItem Value="Volunteer">Volunteer</asp:ListItem>
                                              <asp:ListItem Value="Web Designer">Web Designer</asp:ListItem>
                                              <asp:ListItem Value="Writer">Writer</asp:ListItem>

                                          </asp:DropDownList>
                                           <br />  
                                        <label>Second Specialty(optional)</label>

                                          <asp:DropDownList ID="ddlWork2" Width="100%" CssClass="form-control" runat="server" >
                                              <asp:ListItem Value="NONE">- Select type -</asp:ListItem>
                                              <asp:ListItem Value="Acting Extra">Acting Extra</asp:ListItem>
                                              <asp:ListItem Value="Admin Assitant">Admin Assitant</asp:ListItem>
                                              <asp:ListItem Value="Animator">Animator</asp:ListItem>
                                              <asp:ListItem Value="Bookkeeper">Bookkeeper</asp:ListItem>
                                              <asp:ListItem Value="Business Incubator">Business Incubator</asp:ListItem>
                                              <asp:ListItem Value="Call Centre Agent">Call Centre Agent</asp:ListItem>
                                              <asp:ListItem Value="Chauffer">Chauffer</asp:ListItem>
                                              <asp:ListItem Value="Chef">Chef</asp:ListItem>
                                              <asp:ListItem Value="Choreographer">Choreographer</asp:ListItem>
                                              <asp:ListItem Value="Comedian">Comedian</asp:ListItem>
                                              <asp:ListItem Value="Data Analyst">Data Analyst</asp:ListItem>
                                              <asp:ListItem Value="Developer">Developer</asp:ListItem>
                                              <asp:ListItem Value="Dog Walker">Dog Walker</asp:ListItem>
                                              <asp:ListItem Value="Editor/Proof Reader">Editor/Proof Reader</asp:ListItem>
                                              <asp:ListItem Value="Event Dj">Event Dj</asp:ListItem>
                                              <asp:ListItem Value="Event host">Event host</asp:ListItem>
                                              <asp:ListItem Value="Fashion Designer">Fashion Designer</asp:ListItem>
                                              <asp:ListItem Value="Film Assistant Director">Film Assistant Director</asp:ListItem>
                                              <asp:ListItem Value="Forex Trader">Forex Trader</asp:ListItem>
                                              <asp:ListItem Value="Google adwords expert">Google adwords expert</asp:ListItem>
                                              <asp:ListItem Value="Google analytics consultant">Google analytics consultant</asp:ListItem>
                                              <asp:ListItem Value="Graphic Designer">Graphic Designer</asp:ListItem>
                                              <asp:ListItem Value="Hairdresser">Hairdresser</asp:ListItem>
                                              <asp:ListItem Value="High School sports coach">High School sports coach</asp:ListItem>
                                              <asp:ListItem Value="High School tutor">High School tutor</asp:ListItem>
                                              <asp:ListItem Value="Legal Assistance">Legal Assistance</asp:ListItem>
                                              <asp:ListItem Value="Logistics Assistant">Logistics Assistant</asp:ListItem>
                                              <asp:ListItem Value="Makeup artist">Makeup artist</asp:ListItem>
                                              <asp:ListItem Value="Market researcher">Market researcher</asp:ListItem>
                                              <asp:ListItem Value="Marketing Assistant">Marketing Assistant</asp:ListItem>
                                              <asp:ListItem Value="Medical Assistant">Medical Assistant</asp:ListItem>
                                              <asp:ListItem Value="Model">Model</asp:ListItem>
                                              <asp:ListItem Value="Motivational Speaker">Motivational Speaker</asp:ListItem>
                                              <asp:ListItem Value="Night child care nanny">Night child care nanny</asp:ListItem>
                                              <asp:ListItem Value="Personal Assistant">Personal Assistant</asp:ListItem>
                                              <asp:ListItem Value="Personal Fitness trainer">Personal Fitness trainer</asp:ListItem>
                                              <asp:ListItem Value="Photographer">Photographer</asp:ListItem>
                                              <asp:ListItem Value="Pre-school tutor">Pre-school tutor</asp:ListItem>
                                              <asp:ListItem Value="Product Promoter">Product Promoter</asp:ListItem>
                                              <asp:ListItem Value="Singer/Band">Singer/Band</asp:ListItem>
                                              <asp:ListItem Value="Sketch and portrait artist">Sketch and portrait artist</asp:ListItem>
                                              <asp:ListItem Value="Social network marketer">Social network marketer</asp:ListItem>
                                              <asp:ListItem Value="Tax Administrator">Tax Administrator</asp:ListItem>
                                              <asp:ListItem Value="Translator">Translator</asp:ListItem>
                                              <asp:ListItem Value="University Tutor">University Tutor</asp:ListItem>
                                              <asp:ListItem Value="Voice over">Voice over</asp:ListItem>
                                              <asp:ListItem Value="Volunteer">Volunteer</asp:ListItem>
                                              <asp:ListItem Value="Web Designer">Web Designer</asp:ListItem>
                                              <asp:ListItem Value="Writer">Writer</asp:ListItem>

                                          </asp:DropDownList>
                                           <br />    
                                        <label>Third Specialty(optional)</label>                                                           
                                          <asp:DropDownList ID="ddlWork3" Width="100%" CssClass="form-control" runat="server" >
                                              <asp:ListItem Value="NONE">- Select type -</asp:ListItem>
                                              <asp:ListItem Value="Acting Extra">Acting Extra</asp:ListItem>
                                              <asp:ListItem Value="Admin Assitant">Admin Assitant</asp:ListItem>
                                              <asp:ListItem Value="Animator">Animator</asp:ListItem>
                                              <asp:ListItem Value="Bookkeeper">Bookkeeper</asp:ListItem>
                                              <asp:ListItem Value="Business Incubator">Business Incubator</asp:ListItem>
                                              <asp:ListItem Value="Call Centre Agent">Call Centre Agent</asp:ListItem>
                                              <asp:ListItem Value="Chauffer">Chauffer</asp:ListItem>
                                              <asp:ListItem Value="Chef">Chef</asp:ListItem>
                                              <asp:ListItem Value="Choreographer">Choreographer</asp:ListItem>
                                              <asp:ListItem Value="Comedian">Comedian</asp:ListItem>
                                              <asp:ListItem Value="Data Analyst">Data Analyst</asp:ListItem>
                                              <asp:ListItem Value="Developer">Developer</asp:ListItem>
                                              <asp:ListItem Value="Dog Walker">Dog Walker</asp:ListItem>
                                              <asp:ListItem Value="Editor/Proof Reader">Editor/Proof Reader</asp:ListItem>
                                              <asp:ListItem Value="Event Dj">Event Dj</asp:ListItem>
                                              <asp:ListItem Value="Event host">Event host</asp:ListItem>
                                              <asp:ListItem Value="Fashion Designer">Fashion Designer</asp:ListItem>
                                              <asp:ListItem Value="Film Assistant Director">Film Assistant Director</asp:ListItem>
                                              <asp:ListItem Value="Forex Trader">Forex Trader</asp:ListItem>
                                              <asp:ListItem Value="Google adwords expert">Google adwords expert</asp:ListItem>
                                              <asp:ListItem Value="Google analytics consultant">Google analytics consultant</asp:ListItem>
                                              <asp:ListItem Value="Graphic Designer">Graphic Designer</asp:ListItem>
                                              <asp:ListItem Value="Hairdresser">Hair dresser</asp:ListItem>
                                              <asp:ListItem Value="High School sports coach">High School sports coach</asp:ListItem>
                                              <asp:ListItem Value="High School tutor">High School tutor</asp:ListItem>
                                              <asp:ListItem Value="Legal Assistance">Legal Assistance</asp:ListItem>
                                              <asp:ListItem Value="Logistics Assistant">Logistics Assistant</asp:ListItem>
                                              <asp:ListItem Value="Makeup artist">Makeup artist</asp:ListItem>
                                              <asp:ListItem Value="Market researcher">Market researcher</asp:ListItem>
                                              <asp:ListItem Value="Marketing Assistant">Marketing Assistant</asp:ListItem>
                                              <asp:ListItem Value="Medical Assistant">Medical Assistant</asp:ListItem>
                                              <asp:ListItem Value="Model">Model</asp:ListItem>
                                              <asp:ListItem Value="Motivational Speaker">Motivational Speaker</asp:ListItem>
                                              <asp:ListItem Value="Night child care nanny">Night child care nanny</asp:ListItem>
                                              <asp:ListItem Value="Personal Assistant">Personal Assistant</asp:ListItem>
                                              <asp:ListItem Value="Personal Fitness trainer">Personal Fitness trainer</asp:ListItem>
                                              <asp:ListItem Value="Photographer">Photographer</asp:ListItem>
                                              <asp:ListItem Value="Pre-school tutor">Pre-school tutor</asp:ListItem>
                                              <asp:ListItem Value="Product Promoter">Product Promoter</asp:ListItem>
                                              <asp:ListItem Value="Singer/Band">Singer/Band</asp:ListItem>
                                              <asp:ListItem Value="Sketch and portrait artist">Sketch and portrait artist</asp:ListItem>
                                              <asp:ListItem Value="Social network marketer">Social network marketer</asp:ListItem>
                                              <asp:ListItem Value="Tax Administrator">Tax Administrator</asp:ListItem>
                                              <asp:ListItem Value="Translator">Translator</asp:ListItem>
                                              <asp:ListItem Value="University Tutor">University Tutor</asp:ListItem>
                                              <asp:ListItem Value="Voice over">Voice over</asp:ListItem>
                                              <asp:ListItem Value="Volunteer">Volunteer</asp:ListItem>
                                              <asp:ListItem Value="Web Designer">Web Designer</asp:ListItem>
                                              <asp:ListItem Value="Writer">Writer</asp:ListItem>
                                          </asp:DropDownList>
                                     </div>

                                          </div>
                                         </div>
                                  </div>

                                     <div class="col-sm-6">
                                                                            
                                          <div class="col-sm-12">
                                         <div class="form-group">
                                           <label>Freelancing description</label>
                                             <asp:TextBox ID="txtDescription" class="form-control" placeholder="" TextMode="multiline"  Rows="6"  runat="server">
                                             </asp:TextBox>
                                          </div>
                                    </div>

                                    <div class="col-sm-12">
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                                <label>Price</label>
                                                <asp:TextBox ID="txtPrice" type="Number" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                                <label>Terms</label>
                                            <asp:DropDownList ID="ddlPriceTerms" runat="server" Width="100%" CssClass="form-control">
                                                <asp:ListItem Value="Once-off">Once-off</asp:ListItem>
                                                <asp:ListItem Value="Per/Hour">Per/Hour</asp:ListItem>
                                                <asp:ListItem Value="Negotiable">Negotiable</asp:ListItem>
                                            </asp:DropDownList>
                                                </div>
                                        </div>
                                    </div>
                                     </div>
                                     </div>
                                </div>
                            </div>

                            <div class="tab-pane" id="account">
                                <h4 class="info-text"> Update your Password</h4>
                                <div class="row">
                                    <div class="col-sm-7 col-sm-offset-2">
                                         <div class="form-group">
                                            <%--<label>Current Password</label>--%>
                                             <asp:TextBox ID="txtCurrentPassword" type="password" class="form-control" placeholder="Cuurent password" runat="server"></asp:TextBox>
                                          </div>
                                    </div>
                                    <div class="col-sm-7 col-sm-offset-2">
                                         <div class="form-group">
                                            <%--<label>New Password</label>--%>
                                             <asp:TextBox ID="txtNewPassword" type="password" class="form-control" placeholder="New password" runat="server"></asp:TextBox>
                                          </div>
                                    </div>
                                     <div class="col-sm-7 col-sm-offset-2">
                                         <div class="form-group">
                                            <%--<label>Confirm Password</label>--%>
                                             <asp:TextBox ID="txtConfirmPassword" type="password" class="form-control" placeholder="Confirm Password" runat="server"></asp:TextBox>
                                          </div>
                                    </div>
                                    
                                                                         
                                    <div class="col-sm-7 col-sm-offset-2">
                                         <div class="form-group">
                                            <%--<label>Confirm Password</label>--%>
                                             <asp:Button ID="btnUpdate" class="btn btn-info pull-right" runat="server" Text="update" OnClick="btnUpdate_Click" />
                                          </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="wizard-footer">
                            <div class="pull-right">
                                <input type='button' class='btn btn-next btn-fill btn-warning btn-wd btn-sm' name='next' value='Next' />
                            <asp:Button ID="btnFinish" class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish' runat="server" Text="Finish" OnClick="btnFinish_Click" />
                            </div>
                            <div class="pull-left">
                                <input type='button' class='btn btn-previous btn-fill btn-default btn-wd btn-sm' name='previous' value='Previous' />
                            </div>
                            <div class="clearfix"></div>
                        </div>	
                    </form>
                </div>
        </div>
        </div><!-- end row -->
        
    </div>
                                
                                                 
     <!--  big container -->
</body>

<script src="../../../Content/CustomCss/Profile/assets/js/jquery-1.10.2.js"></script>
<script src="../../../Content/CustomCss/Profile/assets/js/bootstrap.min.js"></script>
		
	<!--   plugins 	 -->
<script src="../../../Content/CustomCss/Profile/assets/js/jquery.bootstrap.wizard.js"></script>
	
    <!--  More information about jquery.validate here: http://jqueryvalidation.org/	 -->
<script src="../../../Content/CustomCss/Profile/assets/js/jquery.validate.min.js"></script>
	
    <!--  methods for manipulating the wizard and the validation -->
<script src="../../../Content/CustomCss/Profile/assets/js/wizard.js"></script>
        <!-- Css for Template -->
    <script src="../../../Content/Qaelo%20template/js/lightbox.min.js"></script>
    <script src="../../../Content/Qaelo%20template/js/wow.min.js"></script>
    <script src="../../../Content/Qaelo%20template/js/main.js"></script>
        <!-- /Css for Template -->


</html>
