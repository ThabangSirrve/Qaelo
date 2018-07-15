<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="testModal.aspx.cs" Inherits="Qaelo.Web.Users.Student.testModal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title></title>
        <style>
        @media (min-width: 992px) {
  .modal-lg {
    width: 1200px;
  }
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


        
    <a href="#myModal1" data-toggle="modal" >View Specials</a>

    <!-- Modal for specials-->
    <div class="modal fade" id="myModal1" tabindex="-1" role="dialog" aria-labelledby="myModal">
                        <div class="modal-dialog modal-lg" role="document">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <!--<h4>Notice </h4>-->
                                    <div class="col-lg-12">
                                    <h4 class="text-center">Shop Specials in your campus</h4>
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                    </div>
                                    <hr />
                                </div>
                                <div class='modal-body'>
                                <div class="container-fluid">
                                    <asp:Label ID="lblSpecialLinks" runat="server" Text=""></asp:Label>
                                </div>
                                </div>
                                <div class='modal-footer'>
                                    <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                </div>
                            </div>
                        </div>
                    </div>

   <!-- Single Specials popup-->
    <asp:Label ID="lblSpecials" runat="server" Text=""></asp:Label>



</asp:Content>
