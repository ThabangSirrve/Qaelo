<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="students-societies.aspx.cs" Inherits="Qaelo.Web.Users.Student.Societies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Societies</title>
        <style>
        a.btn-default:hover{
     background:#5cb85c;
}
    </style>
    <link href="../../../Content/CustomCss/imagehover/imagehover.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top:60px"></div>
        <div class="container thumbnail">
	    <div class="row">
	        <div class="col-md-12"> 
	          <h3 class="text-center">Find your group!</h3>
              <hr/>
            </div>
            <div class="col-md-12">
                                    <div class="col-md-9 col-md-offset-3"> 
                         <asp:TextBox ID="txtText" placeholder="Type Tertiary Institution" runat="server" type="text" class="typeaheadPlaces tt-query form-control" autocomplete="on" spellcheck="false"></asp:TextBox>
                        <asp:Button ID="btnSearch" CssClass="btn btn-default" style="color:sandybrown" runat="server" Text="Find" OnClick="btnSearch_Click" />
                    </div>
                <%--<asp:Button ID="Button1" CssClass="btn btn-default col-lg-offset-5" style="color:sandybrown;margin-top:10px" runat="server" Text="Find" OnClick="btnSearch_Click" />--%>
            </div>
	    </div>
      
        <div class="col-md-12" style="margin-top:20px">
            <asp:Literal ID="lblListOfSocieties" runat="server"></asp:Literal>
        </div>
    </div>

</asp:Content>