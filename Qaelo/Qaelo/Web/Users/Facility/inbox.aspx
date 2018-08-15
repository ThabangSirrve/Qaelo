<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Shop/Shop.Master" AutoEventWireup="true" CodeBehind="inbox.aspx.cs" Inherits="Qaelo.Web.Users.Facility.inbox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Inbox</title>
    <link href="../../../Content/CustomCss/chat.css" rel="stylesheet" />
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
          <div class="type_msg">
            <div class="input_msg_write">
                <asp:TextBox ID="txtMessage" runat="server" class="write_msg form-control" placeholder="Type a message"  autocomplete="off"></asp:TextBox>
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
