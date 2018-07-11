<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/Student.Master" AutoEventWireup="true" CodeBehind="usedtextbooks.aspx.cs" Inherits="Qaelo.Web.Users.Student.usedtextbooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Content/CustomCss/imagehover/imagehover.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container col-sm-8 col-sm-offset-2 thumbnail">
        <div class="col-sm-12"><h4 class="text-center">Find your books!</h4><br />
       <%--<div class="row" id="divContent" runat="server">
            
          <div class="col-sm-6">
                                                           
              <asp:DropDownList ID="ddlField" Width="100%" CssClass="form-control" AutoPostBack="true" runat="server" >
                                              <asp:ListItem selected="" Value="N/A">- Select Field of study -</asp:ListItem>
                                              <asp:ListItem Value="ART Design and architecture">ART Design and architecture</asp:ListItem>
                                              <asp:ListItem Value="Education">Education</asp:ListItem>
                                              <asp:ListItem Value="Engineering And Build Environment">Engineering And Build Environment</asp:ListItem>
                                              <asp:ListItem Value="Finacial Sciences">Finacial Sciences</asp:ListItem>
                                              <asp:ListItem Value="Health">Health</asp:ListItem>
                                              <asp:ListItem Value="Humanities">Humanities</asp:ListItem>
                                              <asp:ListItem Value="Management">Management</asp:ListItem>
                                              <asp:ListItem Value="Law">Law</asp:ListItem>
                                              <asp:ListItem Value="Science">Science</asp:ListItem>
                                          </asp:DropDownList>
                                  
          </div>

          <div class="col-sm-6">
                                                        <asp:DropDownList ID="ddlYear" Width="100%" CssClass="form-control" AutoPostBack="true" runat="server" >
                                              <asp:ListItem selected="" Value="N/A">- Select year of study -</asp:ListItem>
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
          </div>--%>
            <div class="row" id="divContent" runat="server">
            
          <div class="col-sm-6">
                 <div class="form-group col-sm-offset-1">
                                        <label>Please select University</label>
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

                <!-- second row-->
                          
                <div class="col-sm-6">
                              <div class="form-group col-sm-offset-1">
                                        <label>Field of study</label>
                                        <asp:DropDownList ID="ddlField" Width="100%" CssClass="form-control" AutoPostBack="true" runat="server" >
                                              <asp:ListItem selected="" Value="N/A">- Select Field of study -</asp:ListItem>
                                              <asp:ListItem Value="ART Design and architecture">ART Design and architecture</asp:ListItem>
                                              <asp:ListItem Value="Education">Education</asp:ListItem>
                                              <asp:ListItem Value="Engineering And Build Environment">Engineering And Build Environment</asp:ListItem>
                                              <asp:ListItem Value="Finacial Sciences">Finacial Sciences</asp:ListItem>
                                              <asp:ListItem Value="Health">Health</asp:ListItem>
                                              <asp:ListItem Value="Humanities">Humanities</asp:ListItem>
                                              <asp:ListItem Value="Management">Management</asp:ListItem>
                                              <asp:ListItem Value="Law">Law</asp:ListItem>
                                              <asp:ListItem Value="Science">Science</asp:ListItem>
                                          </asp:DropDownList>
                               </div>                             
                                  
          </div>

          <div class="col-sm-6">
                                   <div class="form-group">
                                        <label>Year</label>
                                      <asp:DropDownList ID="ddlYear" Width="100%" CssClass="form-control" AutoPostBack="true" runat="server" >
                                                                      <asp:ListItem selected="" Value="N/A">- Select year of study -</asp:ListItem>
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
            <hr /></div>
        <div class="col-sm-12">
            <asp:Literal ID="lblBooks" runat="server"></asp:Literal>
        </div>
    </div>

</asp:Content>