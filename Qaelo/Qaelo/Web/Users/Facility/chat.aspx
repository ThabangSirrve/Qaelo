<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chat.aspx.cs" Inherits="Qaelo.Web.Users.Facility.chat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chat</title>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.css" type="text/css" rel="stylesheet" />
    <%-- <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
        --%>

      <link href="../../../Content/CustomCss/chat.css" rel="stylesheet" />   
      <script type="application/x-javascript">
        addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
               function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- //for-mobile-apps -->
    <link href="../../../Template/css/bootstrap.css" rel="stylesheet" />
    <link href="../../../Template/css/style.css" rel="stylesheet" />
     <script src="../../../Scripts/jquery.min.js"></script>

    <style>
        .center {
    display: block;
    margin-left: auto;
    margin-right: auto;
    width: 50%;
    margin-top:150px;
}
    </style>
</head>
<body style="background:#efefe9;">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

            <!-- banner -->
    <div class="accommodation">
            <nav class="navbar navbar-default">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <div class="logo pull-right">
                        <h3 style="margin-top:10px;"; ><a class="navbar-brand" href="../../../">Qaelo</a></h3>
                    </div>
                </div>

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class="collapse navbar-collapse nav-wil" id="bs-example-navbar-collapse-1">
                    <nav class="link-effect-2" id="link-effect-2">            
                        <ul class="nav navbar-nav navbar-right">
                        <li ><a href="Home.aspx">Clients</a></li>
                             <li ><a href="list-facility.aspx">List a facility</a></li>
                             <li ><a href="discount.aspx">Create discount</a></li>
                             <li ><a href="manage-facilities.aspx">Manage Listings</a></li>
                             <li ><a href="edit-profile.aspx">Edit Profile</a></li>
                             <li ><a href="chat.aspx">Inbox</a></li>
                        <li><a href="../../Account/tempLogin.aspx?logout=true">Logout</a></li>    			
                    </ul>
                    </nav>
                </div>
                <!-- /.navbar-collapse -->
            </nav>
    </div>
    <!-- //banner -->

    
    <div class="container">
<div class="messaging" style="margin-top:30px;background-color:whitesmoke">
      <div class="inbox_msg">
        <div class="inbox_people">
          <div class="headind_srch">
            <div class="recent_heading">
              <h4>Chats</h4>
            </div>
          </div>
          <div class="inbox_chat">
              <asp:Label ID="lblChatList" runat="server" Text="No messages yet."></asp:Label>
          </div>
        </div>
        <div class="mesgs">
         <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <fieldset>
                   <div class="msg_history">
                     <asp:Label ID="lblConversation" runat="server" Text=""></asp:Label>
                   </div>


          <div class="type_msg">
            <div class="input_msg_write">
                <asp:TextBox ID="txtMessage" runat="server" class="write_msg form-control" placeholder="Type a message" OnTextChanged="txtMessage_TextChanged" autocomplete="off"></asp:TextBox>
                <asp:LinkButton ID="btnSendMessage" type="button" class="msg_send_btn" runat="server" Text="Button" OnClick="btnSendMessage_Click" ><i class="fa fa-paper-plane-o " aria-hidden="true"></i></asp:LinkButton>
            </div>
          </div>
                           
                </fieldset>
            </ContentTemplate>
        </asp:UpdatePanel>
        </div>
      </div>
      
    </div></div>
    </form>
</body>
</html>
