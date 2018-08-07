<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="facility.aspx.cs" Inherits="Qaelo.Web.Users.Student.facility" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Facilities</title>
    <%--    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>--%>

    <style>
        .popover1{
    max-width: 100%; /* Max Width of the popover (depending on the container!) */
}
                
        .popover2{
    max-width: 100%; /* Max Width of the popover (depending on the container!) */
}
                        
        .popover3{
    max-width: 100%; /* Max Width of the popover (depending on the container!) */
}
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top:60px"></div>
        <div class="container">
	   
    <div class='col-md-12'>
	        <div class="col-md-12">
                  <h3 class="text-center">Find your facility</h3>
            </div>

  <div class="row">
      <br /><br />
          <div class="col-sm-4">
                                          <div class="form-group">
                                            <%--<label><small>(required)</small></label>--%>
                                             <asp:DropDownList ID="ddlYear" Width="100%" CssClass="form-control" runat="server" >
                                                                      <asp:ListItem selected="" Value="NONE">- Select Facility -</asp:ListItem>
                                                                      <asp:ListItem Value="Restaurant">Restaurant</asp:ListItem>
                                                                      <asp:ListItem Value="Clothing store">Clothing store</asp:ListItem>
                                                                      <asp:ListItem Value="Service business">Service business</asp:ListItem>
                                                                      <asp:ListItem Value="Community Organisation">Community Organisation</asp:ListItem>
                                                                      <asp:ListItem Value="Accommodation">Accommodation</asp:ListItem>
                                                                      <asp:ListItem Value="General store">General store</asp:ListItem>
                                                                  </asp:DropDownList>
                                          </div>
          </div>
                         
       <div class="col-sm-8"> 
           <asp:TextBox ID="txtText" placeholder="Type Location" runat="server" type="text" class="typeaheadPlaces tt-query form-control" autocomplete="on" spellcheck="false"></asp:TextBox>
           <asp:Button ID="btnSearch" CssClass="btn btn-default" style="color:sandybrown" runat="server" Text="Find" OnClick="btnSearch_Click"  />
                         
       </div> 
       
     </div>
        
                 <div class="row"> 
             <div class="col-md-12">
             <hr/>
             </div>
         </div>
	         
            <div class="col-md-12 card">
                <asp:Literal ID="lblFacilities" runat="server"></asp:Literal>         
            </div>
    </div>
        
    </div>

    <!-- All Freelancers -->

    <!--Single view of freelancer's work-->
    <div class='col-md-12'>
        <asp:Literal ID="lblSingleFacility" runat="server"></asp:Literal>   
    </div>


<script>
    //we have 3 images for each user so lets loop 3 times
    var image = '<img src="../../../Images/Freelancer/1email%20setup.JPG"">';

    $('#popover1').popover({ placement: 'bottom',trigger : 'hover', content: image, html: true });
    $('#popover2').popover({ placement: 'bottom', trigger: 'hover', content: image, html: true });
    $('#popover3').popover({ placement: 'bottom', trigger: 'hover', content: image, html: true });

</script>

</asp:Content>
