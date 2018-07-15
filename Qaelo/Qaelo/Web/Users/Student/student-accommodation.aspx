<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="student-accommodation.aspx.cs" Inherits="Qaelo.Web.Users.Student.student_accommodation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Student Accommodation</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="margin-top:60px">
        <div class="container col-md-6 col-md-offset-1">
            <div class="container">
	            <div class="row">
	                <div class="col-md-12"> 
	                  <h3 class="text-center">Find a room to rent!</h3>
                      <hr/>
                    </div>

                    <div class="col-md-12 text-center"> 
                         <asp:TextBox ID="txtText" placeholder="Type Tertiary Institution" runat="server" type="text" class="typeaheadPlaces tt-query form-control" autocomplete="on" spellcheck="false"></asp:TextBox>
                        <asp:Button ID="btnSearch" CssClass="btn btn-default" style="color:sandybrown" runat="server" Text="Find" OnClick="btnSearch_Click" />
                    </div>
	            </div>

                <div class="container col-md-9 col-md-offset-1" style="margin-top:75px">
                    <asp:Label ID="lblListOfRooms" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>

        </div>

        <!-- SCRIPTS -->
     <script>
         $(document).ready(function () {
                    $('[data-toggle="tooltip"]').tooltip(); 
                });
         </script> 
    <!-- JQuery -->
    
    <!-- Bootstrap tooltips -->
    <script src="../../../Scripts/Search/tether.min.js"></script>
    <!-- Bootstrap core JavaScript -->
    <script src="../../../Scripts/bootstrap.min.js"></script>


</asp:Content>
