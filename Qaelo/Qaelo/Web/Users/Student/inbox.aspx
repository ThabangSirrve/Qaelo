<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="inbox.aspx.cs" Inherits="Qaelo.Web.Users.Student.inbox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Inbox</title>
    <link href="../../../Content/CustomCss/chat.css" rel="stylesheet" />  
          <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.2.0/css/all.css">
  <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.2.0/css/v4-shims.css">


    <style>
@-moz-keyframes bounceDown {
  0%, 20%, 50%, 80%, 100% {
    -moz-transform: translateY(0);
    transform: translateY(0);
  }
  40% {
    -moz-transform: translateY(-30px);
    transform: translateY(-30px);
  }
  60% {
    -moz-transform: translateY(-15px);
    transform: translateY(-15px);
  }
}
@-webkit-keyframes bounceDown {
  0%, 20%, 50%, 80%, 100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
  40% {
    -webkit-transform: translateY(-30px);
    transform: translateY(-30px);
  }
  60% {
    -webkit-transform: translateY(-15px);
    transform: translateY(-15px);
  }
}
@keyframes bounceDown {
  0%, 20%, 50%, 80%, 100% {
    -moz-transform: translateY(0);
    -ms-transform: translateY(0);
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
  40% {
    -moz-transform: translateY(-30px);
    -ms-transform: translateY(-30px);
    -webkit-transform: translateY(-30px);
    transform: translateY(-30px);
  }
  60% {
    -moz-transform: translateY(-15px);
    -ms-transform: translateY(-15px);
    -webkit-transform: translateY(-15px);
    transform: translateY(-15px);
  }
}


/* assign bounce */
.fa-hand-point-down {
  -moz-animation: bounceDown 2s infinite;
  -webkit-animation: bounceDown 2s infinite;
  animation: bounceDown 2s infinite;
text-align:center;
  display:block;
}



/*** Credits: Liquid Web Design London for bouncing icons */
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
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

                <i visible="false" runat="server" id="handSignal" class="fas fa-hand-point-down fa-2x" style="color:#eac086"></i>
          <div class="type_msg">
              
            <div class="input_msg_write">
                <asp:TextBox ID="txtMessage" runat="server" class="write_msg form-control" placeholder="Type a message" autocomplete="off"></asp:TextBox>
                <asp:LinkButton ID="btnSendMessage" type="button" class="msg_send_btn" runat="server" Text="Button" OnClick="btnSendMessage_Click" ><i class="fa fa-paper-plane-o " aria-hidden="true"></i></asp:LinkButton>
            </div>
          </div>
                </fieldset>
            </ContentTemplate>
        </asp:UpdatePanel>
        </div>
      </div>
      
    </div></div>
</asp:Content>
