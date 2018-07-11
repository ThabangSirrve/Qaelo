<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testSearch.aspx.cs" Inherits="Qaelo.search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <!-- Bootstrap core CSS -->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
        <!-- Search -->
    <%--<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>--%>

    <script src="Scripts/jquery.min.js"></script>
    <script src="Scripts/Search/universities.js"></script>
    <script src="Scripts/Search/typeahead.bundle.js"></script>
    <style type="text/css">
.bs-example {
	font-family: sans-serif;
	position: relative;
	margin: 100px;
}
.typeahead, .tt-query, .tt-hint {

	font-size: 15px; /* Set input font size */
	height: 30px;
	line-height: 30px;
	outline: medium none;
	padding: 8px 12px;
	width: 396px;
}
.typeahead {
	background-color: #FFFFFF;
}
.typeahead:focus {
	
}
.tt-query {
	box-shadow: 0 1px 1px rgba(0, 0, 0, 0.075) inset;
}
.tt-hint {
	color: #999999;
}
.tt-menu {
	background-color: #FFFFFF;

	box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
	margin-top: 12px;
	padding: 8px 0;
	width: 322px;
}
.tt-suggestion {
	font-size: 15px;  /* Set suggestion dropdown font size */
	padding: 3px 20px;
}
.tt-suggestion:hover {
	cursor: pointer;
	background-color: #0097CF;
	color: #FFFFFF;
}
.tt-suggestion p {
	margin: 0;
}
</style>
    <!--/Search -->
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">

        <div class="row">
            <br />
            <br />
            <br />
                        
<%--            <div class="col-sm-3">
                <asp:TextBox ID="txtText" placeholder="Type Tertiary Institution" runat="server" type="text" class="typeaheadPlaces tt-query form-control" autocomplete="on" spellcheck="false"></asp:TextBox>
            </div>--%>

<%--                        <div class="col-sm-3">
                <asp:TextBox ID="freelancers" placeholder="Type to search by work" runat="server" type="text" class="typeaheadPlaces tt-query form-control" autocomplete="on" spellcheck="false"></asp:TextBox>
            </div>
        </div>--%>
            <asp:Label ID="lblUniversitites" runat="server" Text=""></asp:Label>
            <asp:DropDownList ID="ddlFreelacers" runat="server">
                
            </asp:DropDownList>
        </div>
    </form>

        <!-- SCRIPTS -->
     <script>
         $(document).ready(function () {
                    $('[data-toggle="tooltip"]').tooltip(); 
                });
         </script> 
    <!-- JQuery -->
    
    <!-- Bootstrap tooltips -->
    <script src="Scripts/Search/tether.min.js"></script>
    <!-- Bootstrap core JavaScript -->
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
