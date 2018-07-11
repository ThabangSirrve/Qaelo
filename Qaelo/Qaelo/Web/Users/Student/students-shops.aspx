<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="students-shops.aspx.cs" Inherits="Qaelo.Web.Users.Student.students_shops" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Shops</title>
    <style>
        a.btn-default:hover{
     background:#5cb85c;
}
    </style>
        <link href="../../../Content/CustomCss/imagehover/imagehover.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="margin-top:60px"></div>


    <!-- For Ads -->
    <div class="container">
	    <div class="col-sm-9 thumbnail">
	        <div class="col-md-12"> 
	          <h3 class="text-center">Find your shop!</h3>
              <hr/>
            </div>
            <div class="col-md-9 col-md-offset-3"> 
                         <asp:TextBox ID="txtText" placeholder="Type Tertiary Institution" runat="server" type="text" class="typeaheadPlaces tt-query form-control" autocomplete="on" spellcheck="false"></asp:TextBox>
                        <asp:Button ID="btnSearch" CssClass="btn btn-default" style="color:sandybrown" runat="server" Text="Find" OnClick="btnSearch_Click" />
                    </div>
            <div class='col-md-12'>
                    <br />
            <asp:Literal ID="lblSingleShops" runat="server"></asp:Literal>   
               </div>
   
            <div class="col-md-12">
            <asp:Literal ID="lblShops" runat="server"></asp:Literal>
        </div>
	    </div>
       <div class="col-sm-3">
           <h4 class="text-muted text-center">Sponsored Ads</h4>
           <a href="https://www.instagram.com/dv_design22/" target ="_blank" class="thumbnail">
                <img src="../../../Images/Advertisers/IMG-20171031-WA0008.jpg" class="img-responsive" />
               <%--width="350px"--%>
           </a>
           <div class="container-fluid">
           </div>
       </div>
    </div>


    <!-- no ads -->
    <%--<div class="container thumbnail">
	    <div class="row">
	        <div class="col-md-12"> 
	          <h3 class="text-center">Find your shop!</h3>
              <hr/>
            </div>
                    <div class="col-md-9 col-md-offset-3"> 
                         <asp:TextBox ID="txtText" placeholder="Type Tertiary Institution" runat="server" type="text" class="typeaheadPlaces tt-query form-control" autocomplete="on" spellcheck="false"></asp:TextBox>
                        <asp:Button ID="btnSearch" CssClass="btn btn-default" style="color:sandybrown" runat="server" Text="Find" OnClick="btnSearch_Click" />
                    </div>
	    </div>
      

            <div class='col-md-12'>
                <br />
        <asp:Literal ID="lblSingleShops" runat="server"></asp:Literal>   
    </div>
   

        <div class="col-md-12">
            <asp:Literal ID="lblShops" runat="server"></asp:Literal>
        </div>
    </div>--%>

</asp:Content>
