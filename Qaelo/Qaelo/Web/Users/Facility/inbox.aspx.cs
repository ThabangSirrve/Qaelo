using Qaelo.Data;
using Qaelo.Data.Accounts;
using Qaelo.Data.ShopData;
using Qaelo.Models.Inbox;
using Qaelo.Models.ShopOwnerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Facility
{
    public partial class inbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["SHOPOWNER"] != null)
                {
                    //Get User loggedin ID
                    string loggedInUserId = ((ShopOwner)Session["SHOPOWNER"]).Id + "F";

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


                    //Chat list on the left 
                    foreach (var chat in chats)
                    {
                        //Get all messages between the two people

                        if (Request.QueryString["id"] != null)
                        {
                            if (Request.QueryString["id"].ToString().Equals(chat.SenderID))
                                activeChat = "active_chat";
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

                    lblChatList.Text = chatList;


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
                    else
                    {
                        //Chat conversations
                        lblConversation.Text = "<img class='center' style='width:50%;height:50%' src='../../../Images/Inbox/defualt%20image.png'/>";
                    }
                }
                else
                {
                    //Chat conversations
                    Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Facility/inbox.aspx");
                }
            }
        }

        protected void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text.Count() <= 0)
            {
                return;
            }
            string toId = "";
            string text = txtMessage.Text;
            ShopOwner facility = ((ShopOwner)Session["SHOPOWNER"]);
            string loggedInUserId = facility.Id + "F";

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

                Message message = new Message(loggedInUserId, Request.QueryString["id"].ToString(), facility.FullName, receiverName, DateTime.Now, false, text);
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