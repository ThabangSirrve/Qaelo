﻿using Qaelo.Data;
using Qaelo.Data.Accounts;
using Qaelo.Data.ShopData;
using Qaelo.Models.Inbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Student
{
    public partial class inbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["STUDENT"] != null)
                {
                    //Get User loggedin ID
                    string loggedInUserId = ((Qaelo.Models.StudentModel.Student)Session["STUDENT"]).Id + "C";

                    //Load all messages 
                    List<Message> messages = new MessageConnection().getAllMessages(loggedInUserId);

                    //Group chats into conversations 
                    List<Message> chats = new List<Message>();
                    messages.Reverse();

                    foreach (var item in messages)
                    {
                        if (!chats.Any(d => d.SenderID.Equals(item.SenderID)))
                        {
                            //Add the Last message 
                            chats.Add(messages.Where(m => m.SenderID == item.SenderID).First());
                        }
                    }

                    string chatList = "";
                    string activeChat = "";
                    string conversation = "";

                    //reverse chats 
                    chats.Reverse();
                    messages.Reverse();

                    //Chat list on the left 
                    foreach (var chat in chats)
                    {
                        //Get all messages between the two people

                        if (Request.QueryString["id"] != null)
                        {
                            if (Request.QueryString["id"].ToString().Equals(chat.SenderID))
                                activeChat = "active_chat";
                        }
                        else if (Request.QueryString["chatTo"] != null)
                        {
                            if (chat.SenderID.Equals(Request.QueryString["chatTo"].ToString()))
                            {
                                //Select active chat if user have previous chats with the client
                                activeChat = "active_chat";
                            }
                        }

                        chatList += string.Format(@"<div class='chat_list {4}'><a href='inbox.aspx?id={3}'>
                          <div class='chat_people'>
                            <div class='chat_img'> <img src='../../../Images/Profile/defaultProfilePic.jpg'/> </div>
                            <div class='chat_ib'>
                              <h5>{0}<span class='chat_date'>{1}</span></h5>
                              <p>{2}</p>
                            </div>
                          </div></a>
                        </div>", chat.NameFrom, chat.Date.ToShortDateString(), chat.Content, chat.SenderID, activeChat);

                        activeChat = "";
                    }


                    if (Request.QueryString["id"] != null)
                    {
                        //load all chats of this client 
                        List<Message> myConversation = new MessageConnection().getConversation(Request.QueryString["id"].ToString(), loggedInUserId);

                        foreach (var item in myConversation)
                        {
                            if (item.SenderID.Equals(loggedInUserId))
                            {
                                //sent 
                                conversation += string.Format(@"
                                <div class='outgoing_msg'>
                                  <div class='sent_msg'>
                                    <p> {0}</p>
                                    <span class='time_date'> {1}    |    {2}</span> </div>
                                </div>", item.Content, item.Date.ToShortTimeString(), item.Date.ToShortDateString());
                            }
                            else
                            {
                                //Received
                                conversation += string.Format(@"<div class='incoming_msg'>
                                  <div class='incoming_msg_img'> <img src='../../../Images/Profile/defaultProfilePic.jpg'/> </div>
                                  <div class='received_msg'>
                                    <div class='received_withd_msg'>
                                      <p>{0}</p>
                                      <span class='time_date'> {1}    |    {2}</span></div>
                                  </div>
                                </div>", item.Content, item.Date.ToShortTimeString(), item.Date.ToShortDateString());
                            }
                        }

                        //Chat conversations
                        lblConversation.Text = conversation;
                    }
                    else if (Request.QueryString["chatTo"] != null)
                    {
                        string query = Request.QueryString["chatTo"].ToString();
                        string letter = query[0].ToString();
                        int userId = Convert.ToInt32(letter);

                        //Check if there's existing chat with requested chat 
                        if (chats.Any(v => v.SenderID.Equals(query)))
                        {
                            //load all chats of this client 
                            List<Message> myConversation = new MessageConnection().getConversation(query, loggedInUserId);

                            foreach (var item in myConversation)
                            {
                                if (item.SenderID.Equals(loggedInUserId))
                                {
                                    //sent 
                                    conversation += string.Format(@"
                                <div class='outgoing_msg'>
                                  <div class='sent_msg'>
                                    <p> {0}</p>
                                    <span class='time_date'> {1}    |    {2}</span> </div>
                                </div>", item.Content, item.Date.ToShortTimeString(), item.Date.ToShortDateString());
                                }
                                else
                                {
                                    //Received
                                    conversation += string.Format(@"<div class='incoming_msg'>
                                  <div class='incoming_msg_img'> <img src='../../../Images/Profile/defaultProfilePic.jpg'/> </div>
                                  <div class='received_msg'>
                                    <div class='received_withd_msg'>
                                      <p>{0}</p>
                                      <span class='time_date'> {1}    |    {2}</span></div>
                                  </div>
                                </div>", item.Content, item.Date.ToShortTimeString(), item.Date.ToShortDateString());
                                }
                            }

                            //Chat conversations
                            lblConversation.Text = conversation;
                        }
                        else
                        {
                            //Else just display a new chat 
                            string NameFrom = new ShopConnection().getShopOwner(userId).FullName;

                            //chat from find a facility 
                            chatList += string.Format(@"<div class='chat_list active_chat'><a href='inbox.aspx?id={3}'>
                              <div class='chat_people'>
                                <div class='chat_img'> <img src='../../../Images/Profile/defaultProfilePic.jpg'/> </div>
                                <div class='chat_ib'>
                                  <h5>{0}<span class='chat_date'>{1}</span></h5>
                                  <p>{2}</p>
                                </div>
                              </div></a>
                            </div>", NameFrom, "", "", "");

                            //Set hand Signal 
                            handSignal.Visible = true;
                        }
                    }
                    else
                    {
                        //Chat conversations
                        lblConversation.Text = "<img class='center' style='width:50%;height:50%;' src='../../../Images/Inbox/defualt%20image.png'/>";
                    }

                    lblChatList.Text = chatList;

                }
                else
                {
                    Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Student/inbox.aspx");
                }
            }
        }

        protected void btnSendMessage_Click(object sender, EventArgs e)
        {
            handSignal.Visible = false;

            if (txtMessage.Text.Count() <= 0)
            {
                return;
            }

            string toId = "";
            string text = txtMessage.Text;
            Qaelo.Models.StudentModel.Student communityMember = ((Qaelo.Models.StudentModel.Student)Session["STUDENT"]);
            string loggedInUserId = communityMember.Id + "C";

            //Load all messages
            List<Message> messages = new MessageConnection().getAllMessages(loggedInUserId);


            if (Request.QueryString["id"] != null)
            {
                toId = Request.QueryString["id"].ToString();
                char letter = Request.QueryString["id"].ToString()[1];
                string receiverName = "";

                switch (letter)
                {
                    case 'F':
                        string cf = Request.QueryString["id"][0].ToString();
                        int fId = Convert.ToInt32(cf);
                        receiverName = new ShopConnection().getShopOwner(fId).FullName;
                        break;

                    case 'C':
                        string cc = Request.QueryString["id"][0].ToString();
                        int cId = Convert.ToInt32(cc);
                        receiverName = new AccountConnection().getStudent(cId).FirstName;
                        break;
                }

                Message message = new Message(loggedInUserId, Request.QueryString["id"].ToString(), communityMember.FirstName, receiverName, DateTime.Now, false, text);
                new MessageConnection().sendMessage(message);
            }
            else if (Request.QueryString["chatTo"] != null)
            {
                toId = Request.QueryString["chatTo"].ToString();
                string userId = toId.ToString().Remove(toId.Length - 1);
                string receiverName = new ShopConnection().getShopOwner(Convert.ToInt32(userId)).FullName;

                Message message = new Message(loggedInUserId, toId, communityMember.FirstName, receiverName, DateTime.Now, false, text);
                new MessageConnection().sendMessage(message);
            }
            else
            {
                return;
            }

            txtMessage.Text = "";


            //reload section 
            string conversation = "";

            List<Message> myConversation = new MessageConnection().getConversation(toId, loggedInUserId);

            foreach (var item in myConversation)
            {
                if (item.SenderID.Equals(loggedInUserId))
                {
                    //sent 
                    conversation += string.Format(@"
                                <div class='outgoing_msg'>
                                  <div class='sent_msg'>
                                    <p> {0}</p>
                                    <span class='time_date'> {1}    |    {2}</span> </div>
                                </div>", item.Content, item.Date.ToShortTimeString(), item.Date.ToShortDateString());
                }
                else
                {
                    //Received
                    conversation += string.Format(@"<div class='incoming_msg'>
                                  <div class='incoming_msg_img'> <img src='../../../Images/Profile/defaultProfilePic.jpg'/> </div>
                                  <div class='received_msg'>
                                    <div class='received_withd_msg'>
                                      <p>{0}</p>
                                      <span class='time_date'> {1}    |    {2}</span></div>
                                  </div>
                                </div>", item.Content, item.Date.ToShortTimeString(), item.Date.ToShortDateString());
                }
            }

            //Chat conversations
            lblConversation.Text = conversation;
        }
    }
}