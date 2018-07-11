<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/Student.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Qaelo.Web.Users.Student.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Home</title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../../Content/CustomCss/imagehover/imagehover.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="col-sm-10 col-sm-offset-1" style="margin-top:80px">
        <div class="card">
            <div class="panel panel-info">
                <div class="panel-heading" style="background-color:antiquewhite">
                 Recently Added Rooms   <a href="Accommodation.aspx" class="btn btn-primary btn-xs pull-right">See all</a>
                </div>

                <div class="panel-body">
                    <asp:Literal ID="lblAccommodations" runat="server"></asp:Literal>
                </div>
            </div>

                        
            <div class="panel panel-info">
                <div class="panel-heading" style="background-color:antiquewhite">
                 Recently Added Posts   <a href="Companies.aspx" class="btn btn-primary btn-xs pull-right">See all</a>
                </div>

                <div class="panel-body">
                    <asp:Literal ID="lblPosts" runat="server"></asp:Literal>
                </div>
            </div>

            <div class="panel panel-info">
                <div class="panel-heading" style="background-color:antiquewhite">
                 Recently Added Events  <a href="Events.aspx" class="btn btn-primary btn-xs pull-right">See all</a>
                </div>
                <div class="panel-body">
                    <asp:Literal ID="lblEvents" runat="server"></asp:Literal>
                </div>
            </div>

            <div class="panel panel-info">
                <div class="panel-heading" style="background-color:antiquewhite">
                 Recently Added Shops <a href="shops.aspx" class="btn btn-primary btn-xs pull-right">See all</a>
                </div>
                <div class="panel-body">
                    <asp:Literal ID="lblShops" runat="server"></asp:Literal>
                </div>
            </div>

            <div class="panel panel-info" >
                <div class="panel-heading" style="background-color:antiquewhite">
                 Recently Added Society <a href="Societies.aspx" class="btn btn-primary btn-xs pull-right">See all</a>
                </div>
                <div class="panel-body">
                    <asp:Literal ID="lblSocieties" runat="server"></asp:Literal>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
