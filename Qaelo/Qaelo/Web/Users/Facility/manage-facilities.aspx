<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Shop/Shop.Master" AutoEventWireup="true" CodeBehind="manage-facilities.aspx.cs" Inherits="Qaelo.Web.Users.Facility.manage_facilities" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Manage My Facilities</title>
            <style>
        a.btn-default:hover{
     background:#5cb85c;
}
    </style>
    <link href="../../../Content/CustomCss/imagehover/imagehover.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
    <div class="container" style="margin-top:10px">
     <div class="col-lg-12"><h4 class="text-uppercase">List of facilities <asp:Label ID="lblFacilityCount" runat="server" Text="0"></asp:Label></h4>
         <hr style="color:dodgerblue; border-bottom:solid"/>
     </div>
    <div class="col-lg-12 card" style="background-color:whitesmoke">
        <asp:Literal ID="lblShops" runat="server"></asp:Literal>
     </div>
    </div>

        
    <div class="container" style="margin-top:50px">
    <div class="col-lg-12"><h4 class="text-uppercase">List of discounts <asp:Label ID="lblDiscountCount" runat="server" Text="0"></asp:Label></h4>
        <hr style="color:dodgerblue; border-bottom:solid"/>
    </div>

    <div class="col-lg-12 card" style="background-color:whitesmoke">
        <asp:Literal ID="lblSpecials" runat="server"></asp:Literal>
     </div>
    </div>

</asp:Content>
