<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/Student.Master" AutoEventWireup="true" CodeBehind="Companies.aspx.cs" Inherits="Qaelo.Web.Users.Student.Companies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Companies</title>
    <link href="../../../Content/CustomCss/imagehover/imagehover.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
            
    <div class="container">
	    <div class="row">
	        <div class="col-md-12"> 
                 <br /><br />
	        <h3 class="text-center">Find your Job </h3>
              <hr/>
            </div>
	    </div>
        <asp:Literal ID="lblJobs" runat="server"></asp:Literal>
        
    </div>
</asp:Content>
