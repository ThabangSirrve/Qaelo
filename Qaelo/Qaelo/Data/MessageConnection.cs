using MySql.Data.MySqlClient;
using Qaelo.Models.Inbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Data
{
    public class MessageConnection : Connection
    {

        //Insert
        public bool sendMessage(Message message)
        {
            bool success = false;
            //SenderID, ReceiverID, NameFrom, NameTo, Date, Read, Content
            query = @"INSERT INTO messages(SenderID, ReceiverID, NameFrom, NameTo, DateSent, Viewed, Content) values(@SenderID,@ReceiverID,@NameFrom, @NameTo,@Date,@Read,@Content)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@SenderID", message.SenderID);
                command.Parameters.AddWithValue("@ReceiverID", message.ReceiverID);
                command.Parameters.AddWithValue("@NameFrom", message.NameFrom);
                command.Parameters.AddWithValue("@NameTo", message.NameTo);
                command.Parameters.AddWithValue("@Date", message.Date);
                command.Parameters.AddWithValue("@Read", message.Read);
                command.Parameters.AddWithValue("@Content", message.Content);

                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;
               command.ExecuteNonQuery();
                command.Connection.Close();

                success = true;
            }

            return success;
        }


        //Read 
        public List<Message> getAllMessages(string id)
        {
            List<Message> messages = new List<Message>();
            //Get all messages that you received
            query = "SELECT * FROM messages where ReceiverID = @ReceiverID";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {

                command.Connection.Open();
                //command.Parameters.AddWithValue("@SenderID", id);
                command.Parameters.AddWithValue("@ReceiverID", id);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            messages.Add(new Message(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),reader.GetDateTime(5),reader.GetBoolean(6), reader.GetString(7)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return messages;
        }

        public List<Message> getConversation(string senderId, string receiverId)
        {
            List<Message> messages = new List<Message>();
            //Get all messages that you received
            query = "SELECT * FROM messages where (ReceiverID = @ReceiverID AND SenderID = @SenderID) OR (ReceiverID = @SenderID AND SenderID = @ReceiverID)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {

                command.Connection.Open();
                command.Parameters.AddWithValue("@SenderID", senderId);
                command.Parameters.AddWithValue("@ReceiverID", receiverId);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            messages.Add(new Message(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5), reader.GetBoolean(6), reader.GetString(7)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return messages;
        }


        //Delete 
        public void deleteMessage(int id)
        {
            string query = "DELETE FROM messages WHERE SenderID = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }


    }
}